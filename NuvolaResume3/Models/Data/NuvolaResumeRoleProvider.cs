using NuvolaResume3.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebMatrix.WebData;

namespace NuvolaResume3.Models.Security
{
    public enum Roles
    {
        Administrator = 1,
        User,
        ResumeManager,
        Recruiter,
        HumanResourcesManager,
        EnterprizeHumanResourcesManager,
        SoftwareDevelopmentPartner,
        AffiliatePartner,
        Tester,
        Company
    }

    public class NuvolaResumeRoleProvider : RoleProvider
    {
        public NuvolaResumeRepository repository = new NuvolaResumeRepository();

        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            base.Initialize(name, config);
            if (config["applicationName"] != null)
                ApplicationName = config["applicationName"];
        }

        public override void CreateRole(string roleName)
        {
            repository.Roles_CreateRole(roleName);
        }

        public override string[] GetRolesForUser(string username)
        {
            using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<webpages_UsersInRoles> items = repository.Roles_GetRolesForUser(username);

                var lroles = from role in items
                             join webRole in context.webpages_Roles on
                                    role.RoleId equals webRole.RoleId
                             select new
                             {
                                 webRole.RoleName
                             };

                string[] roles = lroles.Select(x => x.RoleName).ToArray<string>();

                return (roles);
            }

        }

        public string[] GetRolesForUserByUserId(int UserId)
        {
            using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile user = repository.UserProfile_GetUserProfile(UserId);

                if (user != null)
                {
                    IEnumerable<webpages_UsersInRoles> items = repository.Roles_GetRolesForUserId(UserId);
                    var lroles = from role in items
                                 join webRole in context.webpages_Roles on
                                     role.RoleId equals webRole.RoleId
                                 select new
                                 {
                                     webRole.RoleName
                                 };

                    string[] roles = lroles.Select(x => x.RoleName).ToArray<string>();

                    return (roles);
                }
            }

            return (null);
        }

        public bool IsManagedBy(int ManagedById, int UserId)
        {
            //Owner can access everything that they own
            if (UserId == ManagedById)
                return (true);

            //Administrators can access everything
            if (IsAdministrator(ManagedById))
                return (true);

            //Managers can access evberything that they manage
            bool ret = repository.ManagedBy_IsManagedBy(ManagedById, UserId);

            return (ret);
        }

        public void AddUserToRole(string username, string roleName)
        {
            AddUsersToRoles(new string[] { username }, new string[] { roleName });
        }

        public void AddToUserToRoleByID(string username, int roleId)
        {
            AddUsersToRoles(new string[] { username }, new string[] { GetRoleName(roleId) });
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                foreach (string user in usernames)
                {
                    int userId = WebSecurity.GetUserId(user);
                    foreach (string role in roleNames)
                    {
                        int roleId = GetRoleId(role);
                        context.webpages_UsersInRoles.Add(
                            new webpages_UsersInRoles()
                            {
                                RoleId = roleId,
                                UserId = userId
                            }
                        );
                        context.SaveChanges();
                    }
                }
            }
        }

        public override string[] GetAllRoles()
        {
            string[] roles = repository.Roles_GetAllRoles().ToArray<string>();

            return (roles);
        }

        public IEnumerable<webpages_Roles> GetPublicRoles()
        {
            List<webpages_Roles> roles = repository.Roles_GetPublicRoles().ToList();

            return (roles);
        }

        public override string[] GetUsersInRole(string roleName)
        {
            using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                var items = from urole in context.webpages_UsersInRoles
                            join role in context.webpages_Roles on urole.RoleId equals role.RoleId
                            join user in context.UserProfiles on urole.UserId equals user.ID
                            where role.RoleName == roleName
                            select new
                            {
                                ID = urole.ID,
                                RoleId = urole.RoleId,
                                UserId = urole.UserId,
                                UserName = user.UserName
                            };

                string[] users = items.Select(x => x.UserName).ToArray<string>();

                return (users);
            }
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            bool ret = repository.Roles_RoleExists(roleName);

            return (ret);
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            bool ret = repository.Roles_IsUserInRole(username, roleName);

            return (ret);
        }

        public bool IsUserInRole(int userId, int roleId)
        {
            bool ret = repository.Roles_IsUserInRole(userId, roleId);

            return (ret);
        }

        public bool IsAdministrator(string userName)
        {
            return (IsUserInRole(userName, "Administrator"));
        }

        public bool IsAdministrator(int userId)
        {
            return (IsUserInRole(userId, (int)Roles.Administrator));
        }

        private string _ApplicationName;

        public override string ApplicationName
        {
            get
            {
                return (_ApplicationName);
            }
            set
            {
                _ApplicationName = value;
            }
        }

        public int GetRoleId(string roleName)
        {
            int ret = 0;

            webpages_Roles role = repository.Roles_GetByRoleName(roleName);//.webpages_Roles.Where(m => m.RoleName == roleName).FirstOrDefault();
            if (role != null)
            {
                ret = role.RoleId;
            }
            else
            {
                throw new Exception("Invalid Role name provided");
            }

            return (ret);
        }

        public string GetRoleName(int roleId)
        {
            string ret = "";

            webpages_Roles role = repository.Roles_GetByRoleId(roleId);
            if (role != null)
            {
                ret = role.RoleName;
            }
            else
            {
                throw new Exception("Invalid Role Id provided");
            }

            return (ret);
        }

    }
}