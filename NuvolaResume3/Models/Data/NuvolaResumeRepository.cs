using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using NuvolaResume.Models.Data.Views;

namespace NuvolaResume3.Models.Data
{
    public partial class NuvolaResumeRepository : IDisposable
    {
        public NuvolaResumeContext _context { get; set; }

        public NuvolaResumeRepository()
        {
            _context = new NuvolaResumeContext();
        }

        public NuvolaResumeRepository(NuvolaResumeContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        //~NuvolaResumeRepository()
        //{
        //    if(_context != null)
        //        _context.Dispose();
        //}

        //public virtual IQueryable<fnSplit_Result> fnSplit(string sInputList, string sDelimiter)
        //{
        //    var sInputListParameter = sInputList != null ?
        //        new SqlParameter("sInputList", sInputList) :
        //        new SqlParameter("sInputList", typeof(string));

        //    var sDelimiterParameter = sDelimiter != null ?
        //        new SqlParameter("sDelimiter", sDelimiter) :
        //        new SqlParameter("sDelimiter", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<fnSplit_Result>("[NuvolaResumeContext].[fnSplit](@sInputList, @sDelimiter)", sInputListParameter, sDelimiterParameter);
        //}

        //public virtual ObjectResult<Achievement_GetAllForUser_Result> Achievement_GetAllForUser(Nullable<int> userID)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Achievement_GetAllForUser_Result>("Achievement_GetAllForUser", userIDParameter);
        //}

        public virtual List<Achievement> Achievement_GetAllForUser(Nullable<int> userID)
        {
            if (!userID.HasValue)
                return (new List<Achievement>()); //No items

            List<Achievement> items = _context.Achievements.Include(x => x.UserProfile).Where(x => x.UserID == userID.Value).ToList();

            return (items);
        }

        public virtual Achievement Achievement_Get(int id)
        {
            if (id < 1)
                return (new Achievement()); //No items

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Achievement item = _context.Achievements.SingleOrDefault(x => x.ID == id);
                return (item);
            }
        }

        //public virtual ObjectResult<int> Achievement_Save(Nullable<int> iD, string name, Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, Nullable<int> userID)
        //{
        //    var iDParameter = iD.HasValue ?
        //        new SqlParameter("ID", iD) :
        //        new SqlParameter("ID", typeof(int));

        //    var nameParameter = name != null ?
        //        new SqlParameter("Name", name) :
        //        new SqlParameter("Name", typeof(string));

        //    var dateStartParameter = dateStart.HasValue ?
        //        new SqlParameter("DateStart", dateStart) :
        //        new SqlParameter("DateStart", typeof(System.DateTime));

        //    var dateEndParameter = dateEnd.HasValue ?
        //        new SqlParameter("DateEnd", dateEnd) :
        //        new SqlParameter("DateEnd", typeof(System.DateTime));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));



        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Achievement_Save", iDParameter, nameParameter, dateStartParameter, dateEndParameter, userIDParameter);
        //}

        public virtual Achievement Achievement_Save(int iD, string name,
            Nullable<System.DateTime> dateStart,
            Nullable<System.DateTime> dateEnd,
            int userID)
        {

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Achievement item = new Achievement();

                if (iD > 0)
                {
                    //Find the item
                    item = _context.Achievements.SingleOrDefault(x => x.ID == iD);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new Achievement();
                }

                //Update / Set properties
                item.UserID = userID;
                item.Name = name;
                item.DateStart = dateStart;
                item.DateEnd = dateEnd;

                if (iD < 1)
                {
                    //Add the new item to the database
                    _context.Achievements.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }

        }

        //public virtual ObjectResult<int> Achievements_DeleteAllByUserId(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Achievements_DeleteAllByUserId", userIdParameter);
        //}

        public virtual bool Achievements_DeleteAllByUserId(int userId)
        {
            if (userId < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Achievement item = _context.Achievements.SingleOrDefault(x => x.UserID == userId);
                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }

            return (true);
        }

        public virtual bool Achievements_Delete(int id)
        {
            if (id < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Achievement item = Achievement_Get(id);
                _context.Achievements.Remove(item);
                _context.SaveChanges();
            }

            return (true);
        }

        public virtual Category Category_Get(int id)
        {
            if (id < 1)
                return (new Category()); //No items

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Category item = _context.Categories.SingleOrDefault(x => x.ID == id);
                return (item);
            }
        }

        public virtual bool Categories_Delete(int id)
        {
            if (id < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Category item = Category_Get(id);
                _context.Categories.Remove(item);
                _context.SaveChanges();
            }

            return (true);
        }

        public virtual List<Category> Categories_GetAll()
        {
            List<Category> items = _context.Categories
                                    .Include(x => x.CategoryItems)
                                    .OrderBy(x => x.Name).ToList();
            return (items);
        }

        public virtual Category Categories_Save(int iD, string name)
        {

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Category item = new Category();

                if (iD > 0)
                {
                    //Find the item
                    item = _context.Categories.Include(x => x.CategoryItems).SingleOrDefault(x => x.ID == iD);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new Category();
                }

                //Update / Set properties
                item.Name = name;

                if (iD < 1)
                {
                    //Add the new item to the database
                    _context.Categories.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }

        }

        public virtual CategoryItem CategoryItems_Get(int id)
        {
            if (id < 1)
                return (new CategoryItem()); //No items

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                CategoryItem item = _context.CategoryItems.SingleOrDefault(x => x.ID == id);
                return (item);
            }
        }

        public virtual List<CategoryItem> CategoryItems_GetAll()
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                List<CategoryItem> items = _context.CategoryItems
                    .Include(x => x.Category)
                    .Include(x => x.ResumeCategories).ToList();
                return (items);
            }
        }

        public virtual CategoryItem CategoryItems_Save(int iD, Nullable<int> categoryID, string name)
        {

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                CategoryItem item = new CategoryItem();

                if (iD > 0)
                {
                    //Find the item
                    item = _context.CategoryItems.SingleOrDefault(x => x.ID == iD);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new CategoryItem();
                }

                //Update / Set properties
                item.CategoryID = categoryID.Value;
                item.Name = name;

                if (iD < 1)
                {
                    //Add the new item to the database
                    _context.CategoryItems.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }

        }

        public virtual bool CategoryItems_Delete(int id)
        {
            if (id < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                CategoryItem item = CategoryItems_Get(id);
                _context.CategoryItems.Remove(item);
                _context.SaveChanges();
            }

            return (true);
        }

        //public virtual ObjectResult<int> Companies_DeleteAllByUserId(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Companies_DeleteAllByUserId", userIdParameter);
        //}

        public virtual bool Companies_DeleteAllByUserId(int userId)
        {
            if (userId < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Company item = _context.Companies.SingleOrDefault(x => x.UserID == userId);
                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }

            return (true);
        }

        public virtual Company Companies_Get(int id)
        {
            if (id < 1)
                return (new Company()); //No items

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Company item = _context.Companies.SingleOrDefault(x => x.ID == id);
                return (item);
            }
        }

        //public virtual ObjectResult<Companies_GetAllForUser_Result> Companies_GetAllForUser(Nullable<int> userID)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Companies_GetAllForUser_Result>("Companies_GetAllForUser", userIDParameter);
        //}

        public virtual IEnumerable<Company> Companies_GetAllForUser(Nullable<int> userID)
        {
            if (!userID.HasValue)
                return (new List<Company>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<Company> items = new List<Company>();

                if (userID.HasValue)
                {
                    //Find the item
                    items = _context.Companies.Where(x => x.UserID == userID.Value);
                }

                return (items.ToList());
            }
        }

        public virtual Company Companies_Save(Nullable<int> iD,
            string name, string jobTitle, string uRL,
            Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd,
            Nullable<int> userID)
        {

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Company item = new Company();

                if (iD > 0)
                {
                    //Find the item
                    item = Companies_Get(iD.Value);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new Company();
                }

                //Update / Set properties
                item.JobTitle = jobTitle;
                item.URL = uRL;
                item.UserID = userID.Value;
                item.DateStart = dateStart;
                item.DateEnd = dateEnd;
                item.Name = name;

                if (iD.HasValue)
                {
                    //Add the new item to the database
                    _context.Companies.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }

        }

        //public virtual ObjectResult<int> Company_Delete(Nullable<int> companyID)
        //{
        //    var companyIDParameter = companyID.HasValue ?
        //        new SqlParameter("CompanyID", companyID) :
        //        new SqlParameter("CompanyID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Company_Delete", companyIDParameter);
        //}

        public virtual bool Company_Delete(int companyID)
        {
            if (companyID < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Company item = _context.Companies.SingleOrDefault(x => x.ID == companyID);
                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }

            return (true);
        }

        public virtual ObjectResult<int> CreateFullTextSearch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("CreateFullTextSearch");
        }

        public virtual Education Education_Save(Nullable<int> iD, string institutionName, string courseName, string courseDescription, Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, Nullable<int> userID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Education item = new Education();

                if (iD.HasValue)
                {
                    //Find the item
                    item = _context.Educations.SingleOrDefault(x => x.ID == iD.Value);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new Education();
                }

                //Update / Set properties
                item.UserID = userID.Value;
                item.DateStart = dateStart;
                item.DateEnd = dateEnd;
                item.CourseName = courseName;
                item.CourseDescription = courseDescription;

                if (iD.HasValue)
                {
                    //Add the new item to the database
                    _context.Educations.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }

        }

        //public virtual ObjectResult<int> Educations_DeleteAllByUserId(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Educations_DeleteAllByUserId", userIdParameter);
        //}

        public virtual bool Educations_DeleteAllByUserId(int userId)
        {
            if (userId < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Company item = _context.Companies.SingleOrDefault(x => x.UserID == userId);
                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }

            return (true);
        }

        public virtual Education Educations_Get(int id)
        {
            if (id < 1)
                return (new Education()); //No items

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Education item = _context.Educations.SingleOrDefault(x => x.ID == id);
                return (item);
            }
        }

        //public virtual ObjectResult<Educations_GetAllForUser_Result> Educations_GetAllForUser(Nullable<int> userID)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Educations_GetAllForUser_Result>("Educations_GetAllForUser", userIDParameter);
        //}

        public virtual List<Education> Educations_GetAllForUser(int UserId)
        {
            IEnumerable<Education> items = new List<Education>();

            if (UserId < 1)
                return (items.ToList());

            //Find the item
            items = _context.Educations.Where(x => x.UserID == UserId);

            return (items.ToList());
        }

        public virtual FeaturesList FeaturesList_Save(Nullable<int> iD, Nullable<int> userID,
            string description, string problemToFix, Nullable<int> reportedByUserID,
            Nullable<bool> highlightAsComingSoon, Nullable<System.DateTime> fixDate,
            Nullable<System.DateTime> releaseDate)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                FeaturesList item = new FeaturesList();

                if (iD.HasValue)
                {
                    //Find the item
                    item = _context.FeaturesLists.SingleOrDefault(x => x.ID == iD.Value);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new FeaturesList();
                }

                //Update / Set properties
                item.UserID = userID.Value;
                item.Description = description;
                item.ProblemToFix = problemToFix;
                item.ReportedByUserID = reportedByUserID.Value;
                item.HighlightAsComingSoon = highlightAsComingSoon.Value;
                item.FixedDate = fixDate;
                item.ReleaseDate = releaseDate;

                if (iD.HasValue)
                {
                    //Add the new item to the database
                    _context.FeaturesLists.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> Friends_ConfirmManager(Nullable<System.Guid> activationID, SqlParameter confirmationID)
        {
            var activationIDParameter = activationID.HasValue ?
                new SqlParameter("ActivationID", activationID) :
                new SqlParameter("ActivationID", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Friends_ConfirmManager", activationIDParameter, confirmationID);
        }

        //public virtual ObjectResult<int> Friends_DeleteAllByUserId(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Friends_DeleteAllByUserId", userIdParameter);
        //}

        public virtual bool Friends_DeleteAllByUserId(int userId)
        {
            if (userId < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Friend item = _context.Friends.SingleOrDefault(x => x.UserID == userId);
                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }

            return (true);
        }

        public virtual ObjectResult<Nullable<int>> Friends_GetFriendIdByRequestConfirmationId(Nullable<System.Guid> requestConfirmationId)
        {
            var requestConfirmationIdParameter = requestConfirmationId.HasValue ?
                new SqlParameter("RequestConfirmationId", requestConfirmationId) :
                new SqlParameter("RequestConfirmationId", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("Friends_GetFriendIdByRequestConfirmationId", requestConfirmationIdParameter);
        }

        //public virtual ObjectResult<Friends_GetFriendsCreatedBy_Result> Friends_GetFriendsCreatedBy(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Friends_GetFriendsCreatedBy_Result>("Friends_GetFriendsCreatedBy", userIdParameter);
        //}

        //public virtual ObjectResult<Friends_GetManagerByRequestConfirmationId_Result> Friends_GetManagerByRequestConfirmationId(Nullable<System.Guid> requestConfirmationId)
        //{
        //    var requestConfirmationIdParameter = requestConfirmationId.HasValue ?
        //        new SqlParameter("RequestConfirmationId", requestConfirmationId) :
        //        new SqlParameter("RequestConfirmationId", typeof(System.Guid));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Friends_GetManagerByRequestConfirmationId_Result>("Friends_GetManagerByRequestConfirmationId", requestConfirmationIdParameter);
        //}

        public virtual ObjectResult<Nullable<int>> Friends_GetUserIdByRequestConfirmationId(Nullable<System.Guid> requestConfirmationId)
        {
            var requestConfirmationIdParameter = requestConfirmationId.HasValue ?
                new SqlParameter("RequestConfirmationId", requestConfirmationId) :
                new SqlParameter("RequestConfirmationId", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("Friends_GetUserIdByRequestConfirmationId", requestConfirmationIdParameter);
        }

        //public virtual ObjectResult<Friends_GetUsersFriends_Result> Friends_GetUsersFriends(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Friends_GetUsersFriends_Result>("Friends_GetUsersFriends", userIdParameter);
        //}

        public virtual ObjectResult<int> Friends_Save(Nullable<int> userId, Nullable<int> friendId, SqlParameter requesterConfirmationId, SqlParameter newId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            var friendIdParameter = friendId.HasValue ?
                new SqlParameter("FriendId", friendId) :
                new SqlParameter("FriendId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Friends_Save", userIdParameter, friendIdParameter, requesterConfirmationId, newId);
        }

        //public virtual Friend Friends_Save(Nullable<int> userId, Nullable<int> friendId, SqlParameter requesterConfirmationId, SqlParameter newId)
        //{
        //    ////using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    //{
        //    //    ResumeAchievement item = new ResumeAchievement();

        //    //    if (resumeID > 0 && achievementID > 0)
        //    //    {
        //    //        //Find the item
        //    //        item = _context.ResumeAchievements.SingleOrDefault(x => x.ResumeID == resumeID && x.AchievementID == achievementID);
        //    //    }

        //    //    if (item == null)
        //    //    {
        //    //        //Create a new item, we don't have an ID
        //    //        item = new ResumeAchievement();

        //    //        //Update / Set properties
        //    //        item.ResumeID = resumeID;
        //    //        item.AchievementID = achievementID;

        //    //        //Add the new item to the database
        //    //        _context.ResumeAchievements.Add(item);
        //    //    }

        //    //    _context.SaveChanges();

        //    //    return (item);
        //    //}
        //}

        //public virtual ObjectResult<string> GetUserName(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<string>("GetUserName", userIdParameter);
        //}

        public virtual string GetUserName(int userId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                string item = "";

                if (userId > 0)
                {
                    //Find the item
                    UserProfile user = _context.UserProfiles.SingleOrDefault(x => x.ID == userId);
                    if (user != null)
                        item = user.UserName;
                }

                return (item);
            }

        }

        public virtual ObjectResult<int> HonorAwards_Save(Nullable<int> iD, string name, Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, Nullable<int> userID)
        {
            var iDParameter = iD.HasValue ?
                new SqlParameter("ID", iD) :
                new SqlParameter("ID", typeof(int));

            var nameParameter = name != null ?
                new SqlParameter("Name", name) :
                new SqlParameter("Name", typeof(string));

            var dateStartParameter = dateStart.HasValue ?
                new SqlParameter("DateStart", dateStart) :
                new SqlParameter("DateStart", typeof(System.DateTime));

            var dateEndParameter = dateEnd.HasValue ?
                new SqlParameter("DateEnd", dateEnd) :
                new SqlParameter("DateEnd", typeof(System.DateTime));

            var userIDParameter = userID.HasValue ?
                new SqlParameter("UserID", userID) :
                new SqlParameter("UserID", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("HonorAwards_Save", iDParameter, nameParameter, dateStartParameter, dateEndParameter, userIDParameter);
        }

        public virtual List<Industry> Industries_GetAll()
        {
            IEnumerable<Industry> items = _context.Industries;

            return (items.ToList());
        }

        public virtual Industry Industries_Get(int id)
        {
            if (id < 1)
                return (new Industry()); //No items

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Industry item = _context.Industries.SingleOrDefault(x => x.ID == id);
                return (item);
            }
        }

        //public virtual ObjectResult<int> Industries_Save(Nullable<int> iD, string name, string industryCode)
        //{
        //    var iDParameter = iD.HasValue ?
        //        new SqlParameter("ID", iD) :
        //        new SqlParameter("ID", typeof(int));

        //    var nameParameter = name != null ?
        //        new SqlParameter("Name", name) :
        //        new SqlParameter("Name", typeof(string));

        //    var industryCodeParameter = industryCode != null ?
        //        new SqlParameter("IndustryCode", industryCode) :
        //        new SqlParameter("IndustryCode", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Industries_Save", iDParameter, nameParameter, industryCodeParameter);
        //}

        public virtual Industry Industries_Save(int iD, string name, string industryCode)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Industry item = new Industry();

                if (iD > 0)
                {
                    //Find the item
                    item = _context.Industries.SingleOrDefault(x => x.ID == iD);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new Industry();
                }

                //Update / Set properties
                item.Name = name;
                item.IndustryCode = industryCode;

                if (iD < 1)
                {
                    //Add the new item to the database
                    _context.Industries.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> ManagedBy_ConfirmManager(Nullable<System.Guid> activationID, SqlParameter confirmationID)
        {
            var activationIDParameter = activationID.HasValue ?
                new SqlParameter("ActivationID", activationID) :
                new SqlParameter("ActivationID", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ManagedBy_ConfirmManager", activationIDParameter, confirmationID);
        }

        //public virtual ObjectResult<int> ManagedBy_DeleteAllByUserId(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ManagedBy_DeleteAllByUserId", userIdParameter);
        //}

        public virtual bool ManagedBy_DeleteAllByUserId(int userId)
        {
            if (userId < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ManagedBy item = _context.ManagedBies.SingleOrDefault(x => x.UserID == userId);
                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }

            return (true);
        }

        //public virtual ObjectResult<ManagedBy_GetManagerByRequestConfirmationId_Result> ManagedBy_GetManagerByRequestConfirmationId(Nullable<System.Guid> requestConfirmationId)
        //{
        //    var requestConfirmationIdParameter = requestConfirmationId.HasValue ?
        //        new SqlParameter("RequestConfirmationId", requestConfirmationId) :
        //        new SqlParameter("RequestConfirmationId", typeof(System.Guid));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ManagedBy_GetManagerByRequestConfirmationId_Result>("ManagedBy_GetManagerByRequestConfirmationId", requestConfirmationIdParameter);
        //}

        public virtual ObjectResult<Nullable<int>> ManagedBy_GetManagerIdByRequestConfirmationId(Nullable<System.Guid> requestConfirmationId)
        {
            var requestConfirmationIdParameter = requestConfirmationId.HasValue ?
                new SqlParameter("RequestConfirmationId", requestConfirmationId) :
                new SqlParameter("RequestConfirmationId", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("ManagedBy_GetManagerIdByRequestConfirmationId", requestConfirmationIdParameter);
        }

        //public virtual ObjectResult<ManagedBy_GetResumesCreatedBy_Result> ManagedBy_GetResumesCreatedBy(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ManagedBy_GetResumesCreatedBy_Result>("ManagedBy_GetResumesCreatedBy", userIdParameter);
        //}

        public virtual ObjectResult<Nullable<int>> ManagedBy_GetUserIdByRequestConfirmationId(Nullable<System.Guid> requestConfirmationId)
        {
            var requestConfirmationIdParameter = requestConfirmationId.HasValue ?
                new SqlParameter("RequestConfirmationId", requestConfirmationId) :
                new SqlParameter("RequestConfirmationId", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("ManagedBy_GetUserIdByRequestConfirmationId", requestConfirmationIdParameter);
        }

        //public virtual ObjectResult<ManagedBy_GetUsersManagedBy_Result> ManagedBy_GetUsersManagedBy(Nullable<int> managerId)
        //{
        //    var managerIdParameter = managerId.HasValue ?
        //        new SqlParameter("ManagerId", managerId) :
        //        new SqlParameter("ManagerId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ManagedBy_GetUsersManagedBy_Result>("ManagedBy_GetUsersManagedBy", managerIdParameter);
        //}

        public virtual IEnumerable<ResumeManagerView> ResumeManagerView()
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                List<ResumeManagerView> items =
                    (from managedBy in _context.ManagedBies.AsEnumerable()
                     join userProfile in _context.UserProfiles on managedBy.UserID equals userProfile.ID
                     join resumeManager in _context.UserProfiles on managedBy.UserIDManager equals resumeManager.ID
                     select new ResumeManagerView()
                     {
                         ResumeManagerID = managedBy.ManagedByID,
                         ResumeManagerFirstName = resumeManager.FirstName,
                         ResumeManagerLastName = resumeManager.LastName,
                         ResumeManagerUserName = resumeManager.UserName,
                         UserID = userProfile.ID,
                         UserProfileFirstname = userProfile.FirstName,
                         UserProfileLastname = userProfile.LastName,
                         UserProfileUserName = userProfile.UserName
                     }).ToList();

                return (items);
            }
        }

        //public virtual ObjectResult<Nullable<int>> ManagedBy_IsManagedBy(Nullable<int> managedByUserId, Nullable<int> userId)
        //{
        //    var managedByUserIdParameter = managedByUserId.HasValue ?
        //        new SqlParameter("ManagedByUserId", managedByUserId) :
        //        new SqlParameter("ManagedByUserId", typeof(int));

        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("ManagedBy_IsManagedBy", managedByUserIdParameter, userIdParameter);
        //}

        public virtual bool ManagedBy_IsManagedBy(int managedByUserId, int userId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeManagerView> items =
                    from resumeViewManager in ResumeManagerView()
                    where (resumeViewManager.ResumeManagerID == managedByUserId)
                    && (resumeViewManager.UserID == userId)
                    select resumeViewManager;

                return (items.Count() > 0);
            }
        }

        public virtual ObjectResult<int> ManagedBy_Save(Nullable<int> managedById, Nullable<int> userId, SqlParameter requesterConfirmationId, SqlParameter newId)
        {
            var managedByIdParameter = managedById.HasValue ?
                new SqlParameter("ManagedById", managedById) :
                new SqlParameter("ManagedById", typeof(int));

            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ManagedBy_Save", managedByIdParameter, userIdParameter, requesterConfirmationId, newId);
        }

        //public virtual ObjectResult<int> Organizations_Save(Nullable<int> iD, string name, Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, Nullable<int> userID)
        //{
        //    var iDParameter = iD.HasValue ?
        //        new SqlParameter("ID", iD) :
        //        new SqlParameter("ID", typeof(int));

        //    var nameParameter = name != null ?
        //        new SqlParameter("Name", name) :
        //        new SqlParameter("Name", typeof(string));

        //    var dateStartParameter = dateStart.HasValue ?
        //        new SqlParameter("DateStart", dateStart) :
        //        new SqlParameter("DateStart", typeof(System.DateTime));

        //    var dateEndParameter = dateEnd.HasValue ?
        //        new SqlParameter("DateEnd", dateEnd) :
        //        new SqlParameter("DateEnd", typeof(System.DateTime));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Organizations_Save", iDParameter, nameParameter, dateStartParameter, dateEndParameter, userIDParameter);
        //}

        public virtual Organization Organizations_Get(int id)
        {
            if (id < 1)
                return (new Organization()); //No items

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Organization item = _context.Organizations.SingleOrDefault(x => x.ID == id);
                return (item);
            }
        }

        public virtual Organization Organizations_Save(Nullable<int> iD, string name, Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, Nullable<int> userID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Organization item = new Organization();

                if (iD.HasValue)
                {
                    //Find the item
                    item = _context.Organizations.SingleOrDefault(x => x.ID == iD.Value);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new Organization();
                }

                //Update / Set properties
                item.UserID = userID.Value;
                item.Name = name;
                item.DateStart = dateStart;
                item.DateEnd = dateEnd;

                if (iD.HasValue)
                {
                    //Add the new item to the database
                    _context.Organizations.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        //public virtual ObjectResult<int> Resume_Delete(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Resume_Delete", resumeIDParameter);
        //}

        public virtual bool Resume_Delete(int resumeID)
        {
            if (resumeID < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Resume item = _context.Resumes.SingleOrDefault(x => x.ID == resumeID);

                //Delete other associated items
                //Industries
                //Achievments
                //Skills
                //Educations
                //Volunteer Experience

                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }

            return (true);
        }

        //public virtual ObjectResult<Resume_Get_Result> Resume_Get(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Resume_Get_Result>("Resume_Get", resumeIDParameter);
        //}

        public virtual Resume Resume_Get(int id)
        {
            Resume item = new Resume();

            if (id < 1)
                return (item);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                //Find the item
                item = _context.Resumes.SingleOrDefault(x => x.ID == id);

                return (item);
            }
        }

        //public virtual ObjectResult<Resume_GetAllSkills_Result> Resume_GetAllSkills(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Resume_GetAllSkills_Result>("Resume_GetAllSkills", resumeIDParameter);
        //}

        public virtual IEnumerable<ResumeSkill> Resume_GetAllSkills(Nullable<int> resumeID)
        {
            if (!resumeID.HasValue)
                return (new List<ResumeSkill>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeSkill> items = new List<ResumeSkill>();

                if (resumeID.HasValue)
                {
                    //Find the item
                    items = _context.ResumeSkills.Where(x => x.ResumeID == resumeID.Value);
                }

                return (items.ToList());
            }
        }

        //public virtual IEnumerable<Resume_GetAllSkills_Result> ResumeSkillsView(int resumeID)
        //{
        //    if (resumeID < 1)
        //        return (new List<Resume_GetAllSkills_Result>());

        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        //IEnumerable<Resume_GetAllSkills_Result> items = new List<Resume_GetAllSkills_Result>();

        //        //Find the item
        //        var items = from rs in _context.ResumeSkills.Include(x => x.Skill).Include(x => x.Resume).Where(x => x.ResumeID == resumeID).AsQueryable()
        //                    select new Resume_GetAllSkills_Result
        //                    {
        //                        CompanyID = rs.Skill.CompanyID,
        //                        CompanyName = rs.Skill.Company.Name,
        //                        DateEnd = rs.Skill.Company.DateEnd,
        //                        DateStart = rs.Skill.Company.DateStart,
        //                        Description = rs.Skill.Description,
        //                        JobTitle = rs.Skill.Company.JobTitle,
        //                        Name = rs.Resume.Name,
        //                        ResumeDescription = rs.Resume.Description,
        //                        Summary = rs.Skill.Company.Summary,
        //                        SummaryObjectives = rs.Resume.SummaryObjectives,
        //                        URL = rs.Skill.Company.URL,
        //                        UserID = rs.Skill.UserID,
        //                        DisplayOrder = rs.DisplayOrder
        //                    };

        //        return (items.ToList());
        //    }
        //}

        //public virtual ObjectResult<Resume_IsAccessAllowed_Result> Resume_IsAccessAllowed(Nullable<int> resumeID, Nullable<int> currentUserID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var currentUserIDParameter = currentUserID.HasValue ?
        //        new SqlParameter("CurrentUserID", currentUserID) :
        //        new SqlParameter("CurrentUserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Resume_IsAccessAllowed_Result>("Resume_IsAccessAllowed", resumeIDParameter, currentUserIDParameter);
        //}

        //public virtual int Resume_IsAccessAllowed(int resumeID, int currentUserID)
        //{
        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        if (Resume_IsPublic(resumeID) == true)
        //            return ((int)AllowAccess.PublicUserGranted); //Public resumes are always accessible

        //        if (Roles_IsUserInRole(currentUserID, 1))
        //            return ((int)AllowAccess.AdministratorGranted); //Administrators are always allowed

        //        if (Resume_IsOwnerManger(resumeID, currentUserID) == true)
        //            return ((int)AllowAccess.UserManagerGranted); //The Resume Owner always has access

        //    }

        //    return ((int)AllowAccess.PrivateOrUserNotGranted);
        //}

        //public virtual ObjectResult<Nullable<int>> Resume_IsOwnerManger(Nullable<int> resumeId, Nullable<int> userId)
        //{
        //    var resumeIdParameter = resumeId.HasValue ?
        //        new SqlParameter("ResumeId", resumeId) :
        //        new SqlParameter("ResumeId", typeof(int));

        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("Resume_IsOwnerManger", resumeIdParameter, userIdParameter);
        //}

        //public virtual bool Resume_IsOwnerManger(int resumeId, int userId)
        //{
        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        Resume item = _context.Resumes.SingleOrDefault(x => x.ID == resumeId && x.UserID == userId);
        //        if (item != null)
        //            return (true); //User owns this resume

        //        if (ManagedBy_IsManagedBy(userId, item.UserID) == true)
        //            return (false); //Managers have access to all of the User's resume
        //    }

        //    return (false);
        //}

        //public virtual ObjectResult<Resume_IsPublic_Result> Resume_IsPublic(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Resume_IsPublic_Result>("Resume_IsPublic", resumeIDParameter);
        //}

        public virtual bool Resume_IsPublic(int resumeId)
        {
            Resume item = Resume_Get(resumeId);
            if (item != null)
            {
                if (item.IsPublic.HasValue)
                    return (item.IsPublic.Value);
            }

            return (false);
        }

        //public virtual ObjectResult<int> Resume_Save(string name, Nullable<int> userID, string description, string summaryObjectives, string tagLine, Nullable<int> resumeID, Nullable<bool> isPublic, Nullable<int> createdByUserID, SqlParameter newID)
        //{
        //    var nameParameter = name != null ?
        //        new SqlParameter("Name", name) :
        //        new SqlParameter("Name", typeof(string));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    var descriptionParameter = description != null ?
        //        new SqlParameter("Description", description) :
        //        new SqlParameter("Description", typeof(string));

        //    var summaryObjectivesParameter = summaryObjectives != null ?
        //        new SqlParameter("SummaryObjectives", summaryObjectives) :
        //        new SqlParameter("SummaryObjectives", typeof(string));

        //    var tagLineParameter = tagLine != null ?
        //        new SqlParameter("TagLine", tagLine) :
        //        new SqlParameter("TagLine", typeof(string));

        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var isPublicParameter = isPublic.HasValue ?
        //        new SqlParameter("IsPublic", isPublic) :
        //        new SqlParameter("IsPublic", typeof(bool));

        //    var createdByUserIDParameter = createdByUserID.HasValue ?
        //        new SqlParameter("CreatedByUserID", createdByUserID) :
        //        new SqlParameter("CreatedByUserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Resume_Save", nameParameter, userIDParameter, descriptionParameter, summaryObjectivesParameter, tagLineParameter, resumeIDParameter, isPublicParameter, createdByUserIDParameter, newID);
        //}

        public virtual Resume Resume_Save(string name, Nullable<int> userID, string description,
            string summaryObjectives, string tagLine, Nullable<int> resumeID, Nullable<bool> isPublic,
            Nullable<int> createdByUserID, SqlParameter newID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Resume item = new Resume();

                if (resumeID.HasValue)
                {
                    //Find the item
                    item = Resume_Get(resumeID.Value);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new Resume();
                }

                //Update / Set properties
                item.UserID = userID.Value;
                item.Name = name;
                item.Description = description;
                item.SummaryObjectives = summaryObjectives;
                item.TagLine = tagLine;
                item.IsPublic = isPublic;
                item.CreatedBy = createdByUserID;

                if (resumeID.HasValue)
                {
                    //Add the new item to the database
                    _context.Resumes.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> Resume_SavePublicProfile(Nullable<int> userId, SqlParameter newResumeId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Resume_SavePublicProfile", userIdParameter, newResumeId);
        }

        public virtual ObjectResult<int> ResumeAchievements_DeleteAllFromResume(Nullable<int> resumeID)
        {
            var resumeIDParameter = resumeID.HasValue ?
                new SqlParameter("ResumeID", resumeID) :
                new SqlParameter("ResumeID", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeAchievements_DeleteAllFromResume", resumeIDParameter);
        }

        //public virtual ObjectResult<ResumeAchievements_GetAll_Result> ResumeAchievements_GetAll(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeAchievements_GetAll_Result>("ResumeAchievements_GetAll", resumeIDParameter);
        //}

        public virtual IEnumerable<ResumeAchievement> ResumeAchievements_GetAll(int resumeID)
        {
            if (resumeID < 1)
                return (new List<ResumeAchievement>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeAchievement> items = _context.ResumeAchievements
                                .Include(x => x.Achievement)
                                .Include(x => x.Resume)
                                .Where(x => x.ResumeID == resumeID);
                return (items.ToList());
            }
        }

        //public virtual IEnumerable<ResumeAchievements_GetAll_Result> ResumeAchievementsView(int resumeID)
        //{
        //    if (resumeID < 1)
        //        return (new List<ResumeAchievements_GetAll_Result>());

        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        List<ResumeAchievement> achievements = ResumeAchievements_GetAll(resumeID).ToList();
        //        var items = from rs in achievements.AsQueryable()
        //                    select new ResumeAchievements_GetAll_Result
        //                    {
        //                        Name = rs.Achievement.Name,
        //                        UserID = rs.Achievement.UserID,
        //                        ID = rs.ID,
        //                        ResumeID = rs.Resume.ID,
        //                        ResumeName = rs.Resume.Name,
        //                        AchievementID = rs.ID
        //                    };

        //        return (items.ToList());
        //    }
        //}

        //public virtual ObjectResult<int> ResumeAchievements_Save(Nullable<int> resumeID, Nullable<int> achievementID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var achievementIDParameter = achievementID.HasValue ?
        //        new SqlParameter("AchievementID", achievementID) :
        //        new SqlParameter("AchievementID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeAchievements_Save", resumeIDParameter, achievementIDParameter);
        //}

        public virtual ResumeAchievement ResumeAchievements_Save(int resumeID, int achievementID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeAchievement item = new ResumeAchievement();

                if (resumeID > 0 && achievementID > 0)
                {
                    //Find the item
                    item = _context.ResumeAchievements.SingleOrDefault(x => x.ResumeID == resumeID && x.AchievementID == achievementID);
                }

                if (item == null)
                {
                    //Create a new item, we don't have an ID
                    item = new ResumeAchievement();

                    //Update / Set properties
                    item.ResumeID = resumeID;
                    item.AchievementID = achievementID;

                    //Add the new item to the database
                    _context.ResumeAchievements.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> ResumeCategories_DeleteAllFromResume(Nullable<int> resumeID)
        {
            var resumeIDParameter = resumeID.HasValue ?
                new SqlParameter("ResumeID", resumeID) :
                new SqlParameter("ResumeID", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeCategories_DeleteAllFromResume", resumeIDParameter);
        }

        //public virtual ObjectResult<ResumeCategories_GetAll_Result> ResumeCategories_GetAll(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeCategories_GetAll_Result>("ResumeCategories_GetAll", resumeIDParameter);
        //}

        public virtual IEnumerable<ResumeCategory> ResumeCategories_GetAll(int resumeID)
        {
            if (resumeID < 1)
                return (new List<ResumeCategory>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeCategory> items = _context.ResumeCategories
                    .Include(x => x.CategoryItem)
                    .Include(x => x.CategoryItem.Category)
                    .Include(x => x.Resume)
                    .Where(x => x.ResumeID == resumeID);
                return (items.ToList());
            }
        }

        //public virtual IEnumerable<ResumeCategories_GetAll_Result> ResumeCategoriesView(int resumeID)
        //{
        //    if (resumeID < 1)
        //        return (new List<ResumeCategories_GetAll_Result>());

        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        List<ResumeCategory> categories = ResumeCategories_GetAll(resumeID).ToList();
        //        var items = from rs in categories.AsQueryable()
        //                    select new ResumeCategories_GetAll_Result
        //                    {
        //                        CategoryID = rs.CategoryItem.CategoryID,
        //                        CategoryItemID = rs.CategoriesItemID,
        //                        CategoryItemName = rs.CategoryItem.Name,
        //                        CategoryName = rs.CategoryItem.Category.Name,
        //                        ID = rs.ID,
        //                        ResumeID = rs.Resume.ID,
        //                        ResumeName = rs.Resume.Name,
        //                        UserID = rs.Resume.UserID
        //                    };

        //        return (items.ToList());
        //    }
        //}

        //public virtual ObjectResult<int> ResumeCategories_Save(Nullable<int> resumeID, Nullable<int> categoriesItemID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var categoriesItemIDParameter = categoriesItemID.HasValue ?
        //        new SqlParameter("CategoriesItemID", categoriesItemID) :
        //        new SqlParameter("CategoriesItemID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeCategories_Save", resumeIDParameter, categoriesItemIDParameter);
        //}

        public virtual ResumeCategory ResumeCategories_Save(int resumeID, int categoriesItemID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeCategory item = new ResumeCategory();

                if (resumeID > 0 && categoriesItemID > 0)
                {
                    //Find the item
                    item = _context.ResumeCategories.SingleOrDefault(x => x.ResumeID == resumeID && x.CategoriesItemID == categoriesItemID);
                }

                if (item == null)
                {
                    //Create a new item, we don't have an ID
                    item = new ResumeCategory();

                    //Update / Set properties
                    item.ResumeID = resumeID;
                    item.CategoriesItemID = categoriesItemID;

                    //Add the new item to the database
                    _context.ResumeCategories.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> ResumeEducations_DeleteAllFromResume(Nullable<int> resumeID)
        {
            var resumeIDParameter = resumeID.HasValue ?
                new SqlParameter("ResumeID", resumeID) :
                new SqlParameter("ResumeID", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeEducations_DeleteAllFromResume", resumeIDParameter);
        }

        //public virtual ObjectResult<ResumeEducations_GetAll_Result> ResumeEducations_GetAll(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeEducations_GetAll_Result>("ResumeEducations_GetAll", resumeIDParameter);
        //}

        public virtual IEnumerable<ResumeEducation> ResumeEducations_GetAll(Nullable<int> resumeID)
        {
            if (!resumeID.HasValue)
                return (new List<ResumeEducation>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeEducation> items = _context.ResumeEducations.Where(x => x.ResumeID == resumeID.Value);
                return (items.ToList());
            }
        }

        //public virtual ObjectResult<int> ResumeEducations_Save(Nullable<int> resumeID, Nullable<int> educationID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var educationIDParameter = educationID.HasValue ?
        //        new SqlParameter("EducationID", educationID) :
        //        new SqlParameter("EducationID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeEducations_Save", resumeIDParameter, educationIDParameter);
        //}

        public virtual ResumeEducation ResumeEducations_Save(int resumeID, int educationID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeEducation item = new ResumeEducation();

                if (resumeID > 0 && educationID > 0)
                {
                    //Find the item
                    item = _context.ResumeEducations.SingleOrDefault(x => x.ResumeID == resumeID && x.EducationID == educationID);
                }

                if (item == null)
                {
                    //Create a new item, we don't have an ID
                    item = new ResumeEducation();

                    //Update / Set properties
                    item.ResumeID = resumeID;
                    item.EducationID = educationID;

                    //Add the new item to the database
                    _context.ResumeEducations.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> ResumeIndustries_DeleteAllFromResume(Nullable<int> resumeID)
        {
            var resumeIDParameter = resumeID.HasValue ?
                new SqlParameter("ResumeID", resumeID) :
                new SqlParameter("ResumeID", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeIndustries_DeleteAllFromResume", resumeIDParameter);
        }

        //public virtual ObjectResult<ResumeIndustries_GetAll_Result> ResumeIndustries_GetAll(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeIndustries_GetAll_Result>("ResumeIndustries_GetAll", resumeIDParameter);
        //}

        public virtual IEnumerable<ResumeIndustry> ResumeIndustries_GetAll(Nullable<int> resumeID)
        {
            if (!resumeID.HasValue)
                return (new List<ResumeIndustry>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeIndustry> items = _context.ResumeIndustries.Where(x => x.ResumeID == resumeID.Value);
                return (items.ToList());
            }
        }

        //public virtual ObjectResult<int> ResumeIndustries_Save(Nullable<int> resumeID, Nullable<int> industryID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var industryIDParameter = industryID.HasValue ?
        //        new SqlParameter("IndustryID", industryID) :
        //        new SqlParameter("IndustryID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeIndustries_Save", resumeIDParameter, industryIDParameter);
        //}

        public virtual ResumeIndustry ResumeIndustries_Save(int resumeID, int industryID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeIndustry item = new ResumeIndustry();

                if (resumeID > 0 && industryID > 0)
                {
                    //Find the item
                    item = _context.ResumeIndustries.SingleOrDefault(x => x.ResumeID == resumeID && x.IndustryID == industryID);
                }

                if (item == null)
                {
                    //Create a new item, we don't have an ID
                    item = new ResumeIndustry();

                    //Update / Set properties
                    item.ResumeID = resumeID;
                    item.IndustryID = industryID;

                    //Add the new item to the database
                    _context.ResumeIndustries.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> Resumes_DeleteAllByUserId(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Resumes_DeleteAllByUserId", userIdParameter);
        }

        //public virtual ObjectResult<Resumes_GetAllForUser_Result> Resumes_GetAllForUser(Nullable<int> userID)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Resumes_GetAllForUser_Result>("Resumes_GetAllForUser", userIDParameter);
        //}

        public virtual IEnumerable<Resume> Resumes_GetAllForUser(int userID)
        {
            if (userID < 1)
                return (new List<Resume>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<Resume> items = _context.Resumes
                                                .Include(x => x.ResumeAchievements)
                                                .Include(x => x.ResumeCategories)
                                                .Include(x => x.ResumeEducations)
                                                .Include(x => x.ResumeIndustries)
                                                .Include(x => x.ResumeSkills)
                                                .Include(x => x.ResumeSocialNetworks)
                                                .Include(x => x.ResumeVolunteerExperiences)
                                                .Include(x => x.UserProfile)
                    //.Include(x => x.CreatedByUserProfile)
                                                .Where(x => x.UserID == userID);
                return (items.ToList());
            }
        }

        public virtual Resume Resumes_GetPublicResume(int userId)
        {
            Resume item = Resumes_GetAllForUser(userId).FirstOrDefault(x => x.IsPublic == true);
            return (item);
        }

        //public virtual ObjectResult<int> ResumeSkills_AddToPublicResume(Nullable<int> userId, Nullable<int> skillId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    var skillIdParameter = skillId.HasValue ?
        //        new SqlParameter("SkillId", skillId) :
        //        new SqlParameter("SkillId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeSkills_AddToPublicResume", userIdParameter, skillIdParameter);
        //}

        public virtual int ResumeSkills_AddToPublicResume(int userId, int skillId)
        {
            Resume item = Resumes_GetPublicResume(userId);

            if (item == null)
                return (-1);

            ResumeSkill ret = ResumeSkills_Save(item.ID, skillId);

            return (ret.ID);
        }

        //public virtual ObjectResult<int> ResumeSkills_DeleteAllFromResume(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeSkills_DeleteAllFromResume", resumeIDParameter);
        //}

        public virtual List<ResumeSkill> ResumeSkills_GetByResumeId(int resumeID)
        {
            if (resumeID < 1)
                return (new List<ResumeSkill>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeSkill> items = _context.ResumeSkills
                    .Include(x => x.Skill)
                    .Include(x => x.Resume)
                    .Where(x => x.ResumeID == resumeID);
                return (items.ToList());
            }
        }

        public virtual List<ResumeSkill> ResumeSkills_GetBySkillId(int skillId)
        {
            if (skillId < 1)
                return (new List<ResumeSkill>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeSkill> items = _context.ResumeSkills
                    .Include(x => x.Skill)
                    .Include(x => x.Resume)
                    .Where(x => x.SkillID == skillId);
                return (items.ToList());
            }
        }

        public virtual bool ResumeSkills_DeleteAllFromResume(int resumeID)
        {
            if (resumeID < 1)
                return (false);

            {
                ResumeSkills_DeleteResumeSkills(ResumeSkills_GetByResumeId(resumeID));
            }

            return (true);
        }

        public virtual bool ResumeSkills_DeleteBySkillId(int skillId)
        {
            if (skillId < 1)
                return (false);

            {
                ResumeSkills_DeleteResumeSkills(ResumeSkills_GetBySkillId(skillId));

                return (true);
            }
        }

        public virtual bool ResumeSkills_DeleteResumeSkills(IEnumerable<ResumeSkill> items)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                _context.ResumeSkills.RemoveRange(items);
                _context.SaveChanges();

                return (true);
            }
        }

        //public virtual ObjectResult<ResumeSkills_GetPublicBySkillsId_Result> ResumeSkills_GetPublicBySkillsId(Nullable<int> skillId)
        //{
        //    var skillIdParameter = skillId.HasValue ?
        //        new SqlParameter("SkillId", skillId) :
        //        new SqlParameter("SkillId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeSkills_GetPublicBySkillsId_Result>("ResumeSkills_GetPublicBySkillsId", skillIdParameter);
        //}

        //public virtual ObjectResult<int> ResumeSkills_Save(Nullable<int> resumeID, Nullable<int> skillID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var skillIDParameter = skillID.HasValue ?
        //        new SqlParameter("SkillID", skillID) :
        //        new SqlParameter("SkillID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeSkills_Save", resumeIDParameter, skillIDParameter);
        //}

        public virtual ResumeSkill ResumeSkills_Get(int Id)
        {
            if (Id < 1)
                return (new ResumeSkill());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeSkill item = _context.ResumeSkills.SingleOrDefault(x => x.ID == Id);
                return (item);
            }
        }

        public virtual ResumeSkill ResumeSkills_GetByResumeIdAndSkillId(int resumeId, int skillId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeSkill item = _context.ResumeSkills.SingleOrDefault(x => x.ResumeID == resumeId && x.SkillID == skillId);

                if (item == null)
                    return (new ResumeSkill());

                return (item);
            }
        }

        public virtual ResumeSkill ResumeSkills_Save(int resumeId, int skillId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeSkill item = new ResumeSkill();

                if (resumeId > 0 && skillId > 0)
                {
                    //Find the item
                    item = ResumeSkills_GetByResumeIdAndSkillId(resumeId, skillId);
                }

                //Update / Set properties
                item.ResumeID = resumeId;
                item.SkillID = skillId;

                if (item.ID < 1)
                {
                    //Add the new item to the database
                    _context.ResumeSkills.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> ResumeSocialNetworks_DeleteAllFromResume(Nullable<int> resumeID)
        {
            var resumeIDParameter = resumeID.HasValue ?
                new SqlParameter("ResumeID", resumeID) :
                new SqlParameter("ResumeID", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeSocialNetworks_DeleteAllFromResume", resumeIDParameter);
        }

        //public virtual ObjectResult<ResumeSocialNetworks_GetAll_Result> ResumeSocialNetworks_GetAll(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeSocialNetworks_GetAll_Result>("ResumeSocialNetworks_GetAll", resumeIDParameter);
        //}

        public virtual IEnumerable<ResumeSocialNetwork> ResumeSocialNetworks_GetByResumeId(int resumeId)
        {
            if (resumeId < 1)
                return (new List<ResumeSocialNetwork>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeSocialNetwork> items = _context.ResumeSocialNetworks
                    .Include(x => x.UserSocialNetwork)
                    .Include(x => x.Resume)
                    .Where(x => x.ResumeID == resumeId);
                return (items.ToList());
            }
        }

        public virtual ResumeSocialNetwork ResumeSocialNetworks_GetByResumeIdAndSocialNetworkId(int resumeId, int socialNetworkId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeSocialNetwork item = _context.ResumeSocialNetworks
                    .SingleOrDefault(x => x.ResumeID == resumeId && x.UserSocialNetworkID == socialNetworkId);

                if (item == null)
                    return (new ResumeSocialNetwork());

                return (item);
            }
        }

        //public virtual ObjectResult<int> ResumeSocialNetworks_Save(Nullable<int> resumeID, Nullable<int> socialNetworkID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var socialNetworkIDParameter = socialNetworkID.HasValue ?
        //        new SqlParameter("SocialNetworkID", socialNetworkID) :
        //        new SqlParameter("SocialNetworkID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeSocialNetworks_Save", resumeIDParameter, socialNetworkIDParameter);
        //}

        public virtual ResumeSocialNetwork ResumeSocialNetworks_Save(int resumeID, int socialNetworkID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeSocialNetwork item = new ResumeSocialNetwork();

                if (resumeID > 0 && socialNetworkID > 0)
                {
                    //Find the item
                    item = ResumeSocialNetworks_GetByResumeIdAndSocialNetworkId(resumeID, socialNetworkID);
                }

                //Update / Set properties
                item.ResumeID = resumeID;
                item.UserSocialNetworkID = socialNetworkID;

                if (item.ID < 1)
                {
                    //Add the new item to the database
                    _context.ResumeSocialNetworks.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        //public virtual ObjectResult<ResumeView_Result> ResumeView(Nullable<int> resumeID, Nullable<int> userID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeView_Result>("ResumeView", resumeIDParameter, userIDParameter);
        //}

        //public virtual ObjectResult<ResumeView_Achievements_Result> ResumeView_Achievements(Nullable<int> resumeID, Nullable<int> userID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeView_Achievements_Result>("ResumeView_Achievements", resumeIDParameter, userIDParameter);
        //}

        //public virtual ObjectResult<ResumeView_Categories_Result> ResumeView_Categories(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeView_Categories_Result>("ResumeView_Categories", resumeIDParameter);
        //}

        //public virtual ObjectResult<ResumeView_Educations_Result> ResumeView_Educations(Nullable<int> resumeID, Nullable<int> userID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeView_Educations_Result>("ResumeView_Educations", resumeIDParameter, userIDParameter);
        //}

        //public virtual ObjectResult<ResumeView_Industries_Result> ResumeView_Industries(Nullable<int> resumeID, Nullable<int> userID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeView_Industries_Result>("ResumeView_Industries", resumeIDParameter, userIDParameter);
        //}

        //public virtual ObjectResult<ResumeView_SocialNetworks_Result> ResumeView_SocialNetworks(Nullable<int> resumeID, Nullable<int> userID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeView_SocialNetworks_Result>("ResumeView_SocialNetworks", resumeIDParameter, userIDParameter);
        //}

        //public virtual ObjectResult<ResumeView_VolunteerExperiences_Result> ResumeView_VolunteerExperiences(Nullable<int> resumeID, Nullable<int> userID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeView_VolunteerExperiences_Result>("ResumeView_VolunteerExperiences", resumeIDParameter, userIDParameter);
        //}

        //public virtual List<ResumeView_VolunteerExperiences_Result> ResumeView_VolunteerExperiences(Nullable<int> resumeID, Nullable<int> userID)
        //{
        //    if (!resumeID.HasValue)
        //        return (new List<ResumeSkill>());

        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        IEnumerable<ResumeSkill> items = _context.ResumeSkills.Where(x => x.ResumeID == resumeID.Value);
        //        return (items.ToList());
        //    }
        //}

        public virtual ObjectResult<int> ResumeVolunteerExperiences_DeleteAllFromResume(Nullable<int> resumeID)
        {
            var resumeIDParameter = resumeID.HasValue ?
                new SqlParameter("ResumeID", resumeID) :
                new SqlParameter("ResumeID", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeVolunteerExperiences_DeleteAllFromResume", resumeIDParameter);
        }

        //public virtual ObjectResult<ResumeSkill> ResumeVolunteerExperiences_GetAll(Nullable<int> resumeID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ResumeVolunteerExperiences_GetAll_Result>("ResumeVolunteerExperiences_GetAll", resumeIDParameter);
        //}

        public virtual IEnumerable<ResumeVolunteerExperience> ResumeVolunteerExperiences_GetByResumeId(int resumeID)
        {
            if (resumeID < 1)
                return (new List<ResumeVolunteerExperience>());

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<ResumeVolunteerExperience> items = _context.ResumeVolunteerExperiences
                    .Include(x => x.Resume)
                    .Include(x => x.VolunteerExperience)
                    .Where(x => x.ResumeID == resumeID);
                return (items.ToList());
            }
        }

        public virtual ResumeVolunteerExperience ResumeVolunteerExperiences_GetByResumeIdAndVolunteerExperienceId(int resumeId, int volunteerExperienceId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeVolunteerExperience item = _context.ResumeVolunteerExperiences
                    .SingleOrDefault(x => x.ResumeID == resumeId && x.VolunteerExperienceID == volunteerExperienceId);

                if (item == null)
                    return (new ResumeVolunteerExperience());

                return (item);
            }
        }

        //public virtual ObjectResult<int> ResumeVolunteerExperiences_Save(Nullable<int> resumeID, Nullable<int> volunteerExperienceID)
        //{
        //    var resumeIDParameter = resumeID.HasValue ?
        //        new SqlParameter("ResumeID", resumeID) :
        //        new SqlParameter("ResumeID", typeof(int));

        //    var volunteerExperienceIDParameter = volunteerExperienceID.HasValue ?
        //        new SqlParameter("VolunteerExperienceID", volunteerExperienceID) :
        //        new SqlParameter("VolunteerExperienceID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("ResumeVolunteerExperiences_Save", resumeIDParameter, volunteerExperienceIDParameter);
        //}

        public virtual ResumeVolunteerExperience ResumeVolunteerExperiences_Save(int resumeID, int volunteerExperienceID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                ResumeVolunteerExperience item = new ResumeVolunteerExperience();

                if (resumeID > 0 && volunteerExperienceID > 0)
                {
                    //Find the item
                    item = ResumeVolunteerExperiences_GetByResumeIdAndVolunteerExperienceId(resumeID, volunteerExperienceID);
                }

                //Update / Set properties
                item.ResumeID = resumeID;
                item.VolunteerExperienceID = volunteerExperienceID;

                if (item.ID < 1)
                {
                    //Add the new item to the database
                    _context.ResumeVolunteerExperiences.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        //public virtual ObjectResult<int> Roles_CreateRole(string roleName)
        //{
        //    var roleNameParameter = roleName != null ?
        //        new SqlParameter("RoleName", roleName) :
        //        new SqlParameter("RoleName", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Roles_CreateRole", roleNameParameter);
        //}

        public virtual webpages_Roles Roles_CreateRole(string roleName)
        {
            if (String.IsNullOrEmpty(roleName))
                return (null); //Not created 

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                webpages_Roles item = _context.webpages_Roles.SingleOrDefault(x => x.RoleName == roleName);

                if (item == null)
                {
                    //Not found
                    item = new webpages_Roles();
                    item.RoleName = roleName;
                    item.RoleNameDisplay = roleName;
                    item.IsPublic = true;

                    //Add the new item to the database
                    _context.webpages_Roles.Add(item);
                    _context.SaveChanges();
                }

                return (item);
            }
        }

        //public virtual ObjectResult<string> Roles_GetAllRoles()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<string>("Roles_GetAllRoles");
        //}

        public virtual List<string> Roles_GetAllRoles()
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                IEnumerable<string> items = _context.webpages_Roles.Select(x => x.RoleName);
                return (items.ToList());
            }
        }

        //public virtual ObjectResult<Roles_GetPublicRoles_Result> Roles_GetPublicRoles()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Roles_GetPublicRoles_Result>("Roles_GetPublicRoles");
        //}

        public virtual IEnumerable<webpages_Roles> Roles_GetPublicRoles()
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                List<webpages_Roles> items = _context.webpages_Roles.Where(x => x.IsPublic == true).ToList();
                return (items);
            }

        }

        //public virtual ObjectResult<string> Roles_GetRolesForUser(string userName)
        //{
        //    var userNameParameter = userName != null ?
        //        new SqlParameter("UserName", userName) :
        //        new SqlParameter("UserName", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<string>("Roles_GetRolesForUser @UserName", userNameParameter);
        //}

        public virtual IEnumerable<webpages_UsersInRoles> Roles_GetRolesForUser(string userName)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                int userId = UserProfile_GetUserIdByUserName(userName);
                List<webpages_UsersInRoles> items = _context.webpages_UsersInRoles
                    //.Include(x=>x.User)
                    //.Include(x=>x.webpages_Roles)
                    .Where(x => x.UserId == userId).ToList();
                return (items);
            }
        }

        public virtual IEnumerable<webpages_UsersInRoles> Roles_GetRolesForUserId(int userId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                List<webpages_UsersInRoles> items = _context.webpages_UsersInRoles
                    //.Include(x=>x.User)
                    //.Include(x=>x.webpages_Roles)
                    .Where(x => x.UserId == userId).ToList();
                return (items);
            }
        }

        //public virtual ObjectResult<string> Roles_GetUsersInRole(string roleName)
        //{
        //    var roleNameParameter = roleName != null ?
        //        new SqlParameter("RoleName", roleName) :
        //        new SqlParameter("RoleName", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<string>("Roles_GetUsersInRole", roleNameParameter);
        //}

        public virtual IEnumerable<webpages_UsersInRoles> Roles_GetUsersInRole(string roleName)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                webpages_Roles role = Roles_GetByRoleName(roleName);

                if (role != null)
                {
                    IEnumerable<webpages_UsersInRoles> items = _context.webpages_UsersInRoles
                                                                .Where(x => x.RoleId == role.RoleId);
                    return (items.ToList());
                }
            }

            return (null);
        }

        public virtual webpages_Roles Roles_GetByRoleId(int roleId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                webpages_Roles item = _context.webpages_Roles.FirstOrDefault(x => x.RoleId == roleId);
                return (item);
            }
        }

        public virtual webpages_Roles Roles_GetByRoleName(string roleName)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                webpages_Roles item = _context.webpages_Roles.FirstOrDefault(x => x.RoleName == roleName);
                return (item);
            }
        }

        //public virtual ObjectResult<Nullable<int>> Roles_IsUserInRole(string userName, string roleName)
        //{
        //    var userNameParameter = userName != null ?
        //        new SqlParameter("UserName", userName) :
        //        new SqlParameter("UserName", typeof(string));

        //    var roleNameParameter = roleName != null ?
        //        new SqlParameter("RoleName", roleName) :
        //        new SqlParameter("RoleName", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("Roles_IsUserInRole", userNameParameter, roleNameParameter);
        //}

        public virtual bool Roles_IsUserInRole(string userName, string roleName)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                var items = from urole in _context.webpages_UsersInRoles
                            join role in _context.webpages_Roles on urole.RoleId equals role.RoleId
                            join user in _context.UserProfiles on urole.UserId equals user.ID
                            where user.UserName == userName && role.RoleName == roleName
                            select new webpages_UsersInRoles
                            {
                                ID = urole.ID,
                                RoleId = urole.RoleId,
                                UserId = urole.UserId
                            };

                return (items.Count() > 0);

                //webpages_UsersInRoles item = _context.webpages_UsersInRoles
                //    .FirstOrDefault(x => x.webpages_Roles.RoleName == roleName && x.User.UserName == userName);
                //return (item != null);
            }
        }

        public virtual bool Roles_IsUserInRole(int userId, int roleId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                webpages_UsersInRoles item = _context.webpages_UsersInRoles.SingleOrDefault(x => x.UserId == userId && x.RoleId == roleId);


                //var items = from urole in _context.webpages_UsersInRoles
                //            join role in _context.webpages_Roles on urole.RoleId equals role.RoleId
                //            join user in _context.UserProfiles on urole.UserId equals user.ID
                //            where user.ID == userId && role.RoleId == roleId
                //            select new webpages_UsersInRoles
                //            {
                //                ID = urole.ID,
                //                RoleId = urole.RoleId,
                //                UserId = urole.UserId
                //            };

                //return (items.Count() > 0);

                //webpages_UsersInRoles item = _context.webpages_UsersInRoles
                //    .FirstOrDefault(x => x.webpages_Roles.RoleId == roleId &&
                //        x.User.ID == userId);
                return (item != null);
            }
        }

        public virtual bool Roles_RoleExists(string roleName)
        {
            {
                webpages_Roles item = Roles_GetByRoleName(roleName);
                return (item != null);
            }
        }

        //public virtual ObjectResult<int> Skills_DeleteAllByUserId(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Skills_DeleteAllByUserId", userIdParameter);
        //}

        /// <summary>
        /// Deletes all skill from a User
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public virtual int Skills_DeleteAllByUserId(int userId)
        {
            if (userId < 1)
                return (0);

            List<Skill> items = new List<Skill>();

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                items = _context.Skills.Where(x => x.UserID == userId).ToList();
            }

            if (items.Count < 1)
                return (0);

            foreach (Skill item in items)
            {
                //Delete ResumeSkills first
                ResumeSkills_DeleteBySkillId(item.ID);

                //Now Delete Skills
                Skills_DeleteId(item.ID);
            }

            return (items.Count);
        }

        public virtual Skill Skills_Get(int Id)
        {
            Skill item = new Skill();

            if (Id < 1)
                return (item);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                _context.Configuration.ProxyCreationEnabled = false;
                item = _context.Skills.Include(x => x.Company).SingleOrDefault(x => x.ID == Id);

                if (item == null)
                    return (new Skill());

                return (item);
            }
        }

        public virtual bool Skills_DeleteId(int Id)
        {
            if (Id < 1)
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Skill item = _context.Skills.SingleOrDefault(x => x.ID == Id);

                //Delete ResumeSkills first
                ResumeSkills_DeleteBySkillId(item.ID);

                //Now Delete Skills
                _context.Skills.Remove(item);// Entry(item).State = System.Data.Entity.EntityState.Deleted;

                _context.SaveChanges();

                return (true);
            }
        }

        //public virtual ObjectResult<Skills_GetAllForUser_Result> Skills_GetAllForUser(Nullable<int> userID)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Skills_GetAllForUser_Result>("Skills_GetAllForUser", userIDParameter);
        //}

        public virtual List<Skill> Skills_GetAllForUser(int userID)
        {
            if (userID < 1)
                return (new List<Skill>());

            {
                IEnumerable<Skill> items = _context.Skills.Where(x => x.UserID == userID);
                return (items.ToList());
            }
        }

        //public virtual ObjectResult<int> Skills_Save(Nullable<int> iD, string description, Nullable<int> userID, Nullable<int> companyID, SqlParameter skillId)
        //{
        //    var iDParameter = iD.HasValue ?
        //        new SqlParameter("ID", iD) :
        //        new SqlParameter("ID", typeof(int));

        //    var descriptionParameter = description != null ?
        //        new SqlParameter("Description", description) :
        //        new SqlParameter("Description", typeof(string));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    var companyIDParameter = companyID.HasValue ?
        //        new SqlParameter("CompanyID", companyID) :
        //        new SqlParameter("CompanyID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("Skills_Save", iDParameter, descriptionParameter, userIDParameter, companyIDParameter, skillId);
        //}

        public virtual Skill Skills_Save(int iD, string description, Nullable<int> userID, Nullable<int> companyID, SqlParameter skillId)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                Skill item = new Skill();

                if (iD > 0)
                {
                    //Find the item
                    item = Skills_Get(iD);
                }

                //Update / Set properties
                item.UserID = userID.Value;
                item.CompanyID = companyID;

                if (item.ID > 0)
                {
                    //Add the new item to the database
                    _context.Skills.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> SkillsSearch(string searchWord)
        {
            var searchWordParameter = searchWord != null ?
                new SqlParameter("SearchWord", searchWord) :
                new SqlParameter("SearchWord", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("SkillsSearch", searchWordParameter);
        }

        public virtual ObjectResult<int> SupportRequest_Approve(Nullable<System.Guid> supportRequestId, Nullable<int> approvedByUserId, Nullable<bool> approve)
        {
            var supportRequestIdParameter = supportRequestId.HasValue ?
                new SqlParameter("SupportRequestId", supportRequestId) :
                new SqlParameter("SupportRequestId", typeof(System.Guid));

            var approvedByUserIdParameter = approvedByUserId.HasValue ?
                new SqlParameter("ApprovedByUserId", approvedByUserId) :
                new SqlParameter("ApprovedByUserId", typeof(int));

            var approveParameter = approve.HasValue ?
                new SqlParameter("Approve", approve) :
                new SqlParameter("Approve", typeof(bool));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("SupportRequest_Approve", supportRequestIdParameter, approvedByUserIdParameter, approveParameter);
        }

        //public virtual ObjectResult<int> SupportRequest_Save(string description, Nullable<int> userId, string senderEmailAddress, string subject)
        //{
        //    var descriptionParameter = description != null ?
        //        new SqlParameter("Description", description) :
        //        new SqlParameter("Description", typeof(string));

        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    var senderEmailAddressParameter = senderEmailAddress != null ?
        //        new SqlParameter("SenderEmailAddress", senderEmailAddress) :
        //        new SqlParameter("SenderEmailAddress", typeof(string));

        //    var subjectParameter = subject != null ?
        //        new SqlParameter("Subject", subject) :
        //        new SqlParameter("Subject", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("SupportRequest_Save", descriptionParameter, userIdParameter, senderEmailAddressParameter, subjectParameter);
        //}

        public virtual SupportRequest SupportRequest_Save(string description, Nullable<int> userId, string senderEmailAddress, string subject)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                SupportRequest item = new SupportRequest();

                //Update / Set properties
                item.UserId = userId.Value;
                item.Description = description;
                item.SenderEmailAddress = senderEmailAddress;
                item.Subject = subject;

                //Add the new item to the database
                _context.SupportRequests.Add(item);

                _context.SaveChanges();

                return (item);
            }
        }

        //public virtual ObjectResult<int> UserProfile_ConfirmAccount(Nullable<System.Guid> activationID, SqlParameter confirmationID)
        //{
        //    var activationIDParameter = activationID.HasValue ?
        //        new SqlParameter("ActivationID", activationID) :
        //        new SqlParameter("ActivationID", typeof(System.Guid));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserProfile_ConfirmAccount", activationIDParameter, confirmationID);
        //}

        public virtual Guid UserProfile_ConfirmAccount(Nullable<System.Guid> activationID)
        {
            if (!activationID.HasValue)
                return (Guid.Empty);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = UserProfile_GetUserProfileByActivationId(activationID.Value);

                //Update / Set properties
                item.ConfirmationID = Guid.NewGuid();
                _context.Entry(item).State = System.Data.Entity.EntityState.Modified;

                _context.SaveChanges();

                return (item.ConfirmationID.Value);
            }
        }

        public virtual ObjectResult<int> UserProfile_Delete(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserProfile_Delete", userIdParameter);
        }

        //public virtual ObjectResult<Nullable<int>> UserProfile_GetUserIdByUserName(string userName)
        //{
        //    var userNameParameter = userName != null ?
        //        new SqlParameter("UserName", userName) :
        //        new SqlParameter("UserName", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Nullable<int>>("UserProfile_GetUserIdByUserName", userNameParameter);
        //}

        public virtual int UserProfile_GetUserIdByUserName(string userName)
        {
            int ret = -1;

            if (String.IsNullOrEmpty(userName))
                return (ret);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = UserProfile_GetUserProfileByUserName(userName);

                if (item != null)
                {
                    return (item.ID);
                }

            }

            return (ret);
        }

        public virtual UserProfile UserProfile_GetUserProfile(int userID)
        {
            if (userID < 1)
                return (null);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = _context.UserProfiles.Include(x => x.Country).Include(x => x.PublicResume).SingleOrDefault(x => x.ID == userID);

                return (item);
            }
        }

        public virtual UserProfile UserProfile_GetUserProfileByConfirmationId(Nullable<Guid> confirmationID)
        {
            if (!confirmationID.HasValue)
                return (null);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = _context.UserProfiles.FirstOrDefault(x => x.ConfirmationID == confirmationID.Value);

                return (item);
            }
        }

        //public virtual ObjectResult<UserProfile_GetUserProfileByActivationId_Result> UserProfile_GetUserProfileByActivationId(Nullable<System.Guid> activationId)
        //{
        //    var activationIdParameter = activationId.HasValue ?
        //        new SqlParameter("ActivationId", activationId) :
        //        new SqlParameter("ActivationId", typeof(System.Guid));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<UserProfile_GetUserProfileByActivationId_Result>("UserProfile_GetUserProfileByActivationId", activationIdParameter);
        //}

        public virtual UserProfile UserProfile_GetUserProfileByActivationId(Nullable<System.Guid> activationId)
        {
            if (!activationId.HasValue)
                return (null);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = _context.UserProfiles.FirstOrDefault(x => x.ActivationID == activationId.Value);

                return (item);
            }
        }

        //public virtual ObjectResult<UserProfile_GetUserProfileByEMail_Result> UserProfile_GetUserProfileByEMail(string eMailAddress)
        //{
        //    var eMailAddressParameter = eMailAddress != null ?
        //        new SqlParameter("EMailAddress", eMailAddress) :
        //        new SqlParameter("EMailAddress", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<UserProfile_GetUserProfileByEMail_Result>("UserProfile_GetUserProfileByEMail", eMailAddressParameter);
        //}

        public virtual UserProfile UserProfile_GetUserProfileByEMail(string eMailAddress)
        {
            if (String.IsNullOrEmpty(eMailAddress))
                return (null);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = _context.UserProfiles.FirstOrDefault(x => x.EMailAddress1 == eMailAddress);

                return (item);
            }
        }

        //public virtual ObjectResult<UserProfile_GetUserProfileByUserName_Result> UserProfile_GetUserProfileByUserName(string userName)
        //{
        //    var eMailAddressParameter = userName != null ?
        //        new SqlParameter("EMailAddress", userName) :
        //        new SqlParameter("EMailAddress", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<UserProfile_GetUserProfileByUserName_Result>("UserProfile_GetUserProfileByUserName", eMailAddressParameter);
        //}

        public virtual UserProfile UserProfile_GetUserProfileByUserName(string userName)
        {
            if (String.IsNullOrEmpty(userName))
                return (null);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = _context.UserProfiles.SingleOrDefault(x => x.UserName == userName);

                return (item);
            }
        }

        //public virtual ObjectResult<int> UserProfile_IsConfirmed(Nullable<System.Guid> userID, SqlParameter confirmed)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(System.Guid));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserProfile_IsConfirmed", userIDParameter, confirmed);
        //}

        public virtual bool UserProfile_IsConfirmed(Guid confirmationID)
        {
            if (!confirmationID.Equals(Guid.Empty))
                return (false);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = UserProfile_GetUserProfileByConfirmationId(confirmationID);
                if (item != null)
                {
                    if (item.Confirmed.HasValue)
                        return (item.Confirmed.Value);
                }

                return (false);
            }
        }

        //public virtual ObjectResult<int> UserProfile_IsConfirmedByUsername(string username, SqlParameter confirmed)
        //{
        //    var usernameParameter = username != null ?
        //        new SqlParameter("Username", username) :
        //        new SqlParameter("Username", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserProfile_IsConfirmedByUsername", usernameParameter, confirmed);
        //}

        public virtual bool UserProfile_IsConfirmedByUsername(string username)
        {
            UserProfile item = UserProfile_GetUserProfileByUserName(username);
            if (item != null)
            {
                if (item.Confirmed.HasValue)
                    return (item.Confirmed.Value);
            }

            return (false);
        }

        //public virtual ObjectResult<int> UserProfile_Save(Nullable<int> userID, string firstName, string lastName, string street, string city, string stateProvince, string postalCode, string zipCode, Nullable<int> countryID, string phoneNumber1, string phoneNumber2, string phoneNumber3, string eMailAddress1, string eMailAddress2)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    var firstNameParameter = firstName != null ?
        //        new SqlParameter("FirstName", firstName) :
        //        new SqlParameter("FirstName", typeof(string));

        //    var lastNameParameter = lastName != null ?
        //        new SqlParameter("LastName", lastName) :
        //        new SqlParameter("LastName", typeof(string));

        //    var streetParameter = street != null ?
        //        new SqlParameter("Street", street) :
        //        new SqlParameter("Street", typeof(string));

        //    var cityParameter = city != null ?
        //        new SqlParameter("City", city) :
        //        new SqlParameter("City", typeof(string));

        //    var stateProvinceParameter = stateProvince != null ?
        //        new SqlParameter("StateProvince", stateProvince) :
        //        new SqlParameter("StateProvince", typeof(string));

        //    var postalCodeParameter = postalCode != null ?
        //        new SqlParameter("PostalCode", postalCode) :
        //        new SqlParameter("PostalCode", typeof(string));

        //    var zipCodeParameter = zipCode != null ?
        //        new SqlParameter("ZipCode", zipCode) :
        //        new SqlParameter("ZipCode", typeof(string));

        //    var countryIDParameter = countryID.HasValue ?
        //        new SqlParameter("CountryID", countryID) :
        //        new SqlParameter("CountryID", typeof(int));

        //    var phoneNumber1Parameter = phoneNumber1 != null ?
        //        new SqlParameter("PhoneNumber1", phoneNumber1) :
        //        new SqlParameter("PhoneNumber1", typeof(string));

        //    var phoneNumber2Parameter = phoneNumber2 != null ?
        //        new SqlParameter("PhoneNumber2", phoneNumber2) :
        //        new SqlParameter("PhoneNumber2", typeof(string));

        //    var phoneNumber3Parameter = phoneNumber3 != null ?
        //        new SqlParameter("PhoneNumber3", phoneNumber3) :
        //        new SqlParameter("PhoneNumber3", typeof(string));

        //    var eMailAddress1Parameter = eMailAddress1 != null ?
        //        new SqlParameter("EMailAddress1", eMailAddress1) :
        //        new SqlParameter("EMailAddress1", typeof(string));

        //    var eMailAddress2Parameter = eMailAddress2 != null ?
        //        new SqlParameter("EMailAddress2", eMailAddress2) :
        //        new SqlParameter("EMailAddress2", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserProfile_Save", userIDParameter, firstNameParameter, lastNameParameter, streetParameter, cityParameter, stateProvinceParameter, postalCodeParameter, zipCodeParameter, countryIDParameter, phoneNumber1Parameter, phoneNumber2Parameter, phoneNumber3Parameter, eMailAddress1Parameter, eMailAddress2Parameter);
        //}

        public virtual UserProfile UserProfile_Save(int userID, string firstName, string lastName,
            string street, string city, string stateProvince, string postalCode, string zipCode,
            Nullable<int> countryID, string phoneNumber1, string phoneNumber2, string phoneNumber3,
            string eMailAddress1, string eMailAddress2)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = new UserProfile();

                if (userID > 0)
                {
                    //Find the item
                    item = _context.UserProfiles.SingleOrDefault(x => x.ID == userID);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new UserProfile();
                }

                //Update / Set properties
                item.FirstName = firstName;
                item.LastName = lastName;
                item.Street = street;
                item.City = city;
                item.StateProvince = stateProvince;
                item.PostalCode = postalCode;
                item.ZipCode = zipCode;
                item.CountryID = countryID;
                item.PhoneNumber1 = phoneNumber1;
                item.PhoneNumber2 = phoneNumber2;
                item.PhoneNumber3 = phoneNumber3;
                item.EMailAddress1 = eMailAddress1;
                item.EMailAddress2 = eMailAddress2;

                if (item.ID < 1)
                {
                    //Add the new item to the database
                    _context.UserProfiles.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        //public virtual ObjectResult<int> UserProfile_UserExistsByUserName(string username, SqlParameter exists)
        //{
        //    var parameters = new SqlParameter[]
        //    {
        //         new SqlParameter("Username", SqlDbType.NVarChar),
        //         new SqlParameter("Exists", SqlDbType.Bit)
        //    };
        //    parameters[0].Value = username;
        //    parameters[1].Direction = ParameterDirection.Output;
        //    //var usernameParameter = username != null ?
        //    //    new SqlParameter("Username", username) :
        //    //    new SqlParameter("Username", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("UserProfile_UserExistsByUserName", parameters, exists);
        //}

        public virtual bool UserProfile_UserExistsByUserName(string username)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                UserProfile item = UserProfile_GetUserProfileByUserName(username);
                return (item != null);
            }
        }

        //public virtual ObjectResult<UserProfileSummary_Get_Result> UserProfileSummary_Get(Nullable<int> userID)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<UserProfileSummary_Get_Result>("UserProfileSummary_Get @UserID", userIDParameter);
        //}

        //public virtual UserProfileSummary_Get_Result UserProfileSummary_Get(int userID)
        //{
        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        UserProfile item = UserProfile_GetUserProfile(userID);

        //        UserProfileSummary_Get_Result ret = new UserProfileSummary_Get_Result();

        //        ret.ID = item.ID;
        //        ret.AchievementsCount = item.Achievements.Count();
        //        ret.CompanyCount = item.Companies.Count();
        //        ret.EducationsCount = item.Educations.Count();
        //        ret.SkillsCount = item.Skills.Count();
        //        ret.UserSocialNetworksCount = item.UserSocialNetworks.Count();
        //        ret.VolunteerExperiencesCount = item.VolunteerExperiences.Count();

        //        UserProfilePercentCompleteView upPer = UserProfilePercentCompleteView(userID);
        //        ret.PercentComplete = upPer.PercentComplete;

        //        return (ret);
        //    }

        //}

        //public virtual UserProfilePercentCompleteView UserProfilePercentCompleteView(int userID)
        //{
        //    //SELECT        UserID, Flag, CONVERT(decimal(18, 0), Flag) / 8 AS PercentComplete
        //    //FROM            (
        //    //    SELECT        ID AS UserID, 
        //    //CAST(CASE WHEN FirstName IS NULL THEN 0 ELSE 1 END + 
        //    //CASE WHEN LastName IS NULL 
        //    //    THEN 0 ELSE 1 END + CASE WHEN Street IS NULL THEN 0 ELSE 1 END + 
        //    //CASE WHEN City IS NULL 
        //    //    THEN 0 ELSE 1 END + CASE WHEN StateProvince IS NULL THEN 0 ELSE 1 END + CASE WHEN CountryID IS NULL 
        //    //    THEN 0 ELSE 1 END + CASE WHEN PhoneNumber1 IS NULL THEN 0 ELSE 1 END + CASE WHEN EMailAddress1 IS NULL
        //    //THEN 0 ELSE 1 END AS int) 
        //    //    AS Flag
        //    //FROM            dbo.UserProfiles) AS UserComplete
        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {

        //        UserProfile item = UserProfile_GetUserProfile(userID);

        //        UserProfilePercentCompleteView ret = new UserProfilePercentCompleteView();

        //        int flag = (
        //            (String.IsNullOrEmpty(item.FirstName) ? 0 : 1) +
        //            (String.IsNullOrEmpty(item.LastName) ? 0 : 1) +
        //            (String.IsNullOrEmpty(item.Street) ? 0 : 1) +
        //            (String.IsNullOrEmpty(item.City) ? 0 : 1) +
        //            (String.IsNullOrEmpty(item.StateProvince) ? 0 : 1) +
        //            (String.IsNullOrEmpty(item.PhoneNumber1) ? 0 : 1) +
        //            (item.CountryID == null ? 0 : 1) +
        //            (String.IsNullOrEmpty(item.EMailAddress1) ? 0 : 1));

        //        ret.UserID = item.ID;
        //        ret.Flag = flag;
        //        ret.PercentComplete = ((decimal)flag / 8) * 100;

        //        return (ret);
        //    }

        //}

        //public virtual ObjectResult<int> UserSearch(string searchWord)
        //{
        //    var searchWordParameter = searchWord != null ?
        //        new SqlParameter("SearchWord", searchWord) :
        //        new SqlParameter("SearchWord", typeof(string));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserSearch", searchWordParameter);
        //}

        ////public virtual ObjectResult<int> UserSocialNetwork_Save(Nullable<int> iD, Nullable<int> userID, Nullable<int> socialNetworkID, string socialNetworkAccount, string displayAs)
        ////{
        ////    var iDParameter = iD.HasValue ?
        ////        new SqlParameter("ID", iD) :
        ////        new SqlParameter("ID", typeof(int));

        ////    var userIDParameter = userID.HasValue ?
        ////        new SqlParameter("UserID", userID) :
        ////        new SqlParameter("UserID", typeof(int));

        ////    var socialNetworkIDParameter = socialNetworkID.HasValue ?
        ////        new SqlParameter("SocialNetworkID", socialNetworkID) :
        ////        new SqlParameter("SocialNetworkID", typeof(int));

        ////    var socialNetworkAccountParameter = socialNetworkAccount != null ?
        ////        new SqlParameter("SocialNetworkAccount", socialNetworkAccount) :
        ////        new SqlParameter("SocialNetworkAccount", typeof(string));

        ////    var displayAsParameter = displayAs != null ?
        ////        new SqlParameter("DisplayAs", displayAs) :
        ////        new SqlParameter("DisplayAs", typeof(string));

        ////    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserSocialNetwork_Save", iDParameter, userIDParameter, socialNetworkIDParameter, socialNetworkAccountParameter, displayAsParameter);
        ////}

        //public virtual UserSocialNetwork UserSocialNetwork_Save(Nullable<int> iD, Nullable<int> userID, Nullable<int> socialNetworkID, string socialNetworkAccount, string displayAs)
        //{
        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        UserSocialNetwork item = new UserSocialNetwork();

        //        if (iD.HasValue)
        //        {
        //            //Find the item
        //            item = _context.UserSocialNetworks.SingleOrDefault(x => x.ID == iD.Value);
        //        }
        //        else
        //        {
        //            //Create a new item, we don't have an ID
        //            item = new UserSocialNetwork();
        //        }

        //        //Update / Set properties
        //        item.UserID = userID;
        //        item.SocialNetworkID = socialNetworkID;
        //        item.SocialNetworkAccount = socialNetworkAccount;
        //        item.DisplayAs = displayAs;

        //        if (iD.HasValue)
        //        {
        //            //Add the new item to the database
        //            _context.UserSocialNetworks.Add(item);
        //        }

        //        _context.SaveChanges();

        //        return (item);
        //    }
        //}

        //public virtual ObjectResult<int> UserSocialNetworks_DeleteAllByUserId(Nullable<int> userId)
        //{
        //    var userIdParameter = userId.HasValue ?
        //        new SqlParameter("UserId", userId) :
        //        new SqlParameter("UserId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("UserSocialNetworks_DeleteAllByUserId", userIdParameter);
        //}

        ////public virtual ObjectResult<UserSocialNetworks_GetAllForUser_Result> UserSocialNetworks_GetAllForUser(Nullable<int> userID)
        ////{
        ////    var userIDParameter = userID.HasValue ?
        ////        new SqlParameter("UserID", userID) :
        ////        new SqlParameter("UserID", typeof(int));

        ////    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<UserSocialNetworks_GetAllForUser_Result>("UserSocialNetworks_GetAllForUser", userIDParameter);
        ////}

        //public virtual IEnumerable<UserSocialNetwork> UserSocialNetworks_GetAllForUser(Nullable<int> userID)
        //{
        //    //using (NuvolaResumeContext context = new NuvolaResumeContext())
        //    {
        //        IEnumerable<UserSocialNetwork> items = _context.UserSocialNetworks.Where(x => x.UserID == userID);
        //        return (items.ToList());
        //    }
        //}

        //public virtual ObjectResult<UserSocialNetworks_GetById_Result> UserSocialNetworks_GetById(Nullable<int> iD)
        //{
        //    var iDParameter = iD.HasValue ?
        //        new SqlParameter("ID", iD) :
        //        new SqlParameter("ID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<UserSocialNetworks_GetById_Result>("UserSocialNetworks_GetById", iDParameter);
        //}

        //public virtual ObjectResult<int> VolunteerExperience_Save(Nullable<int> iD, string name, string summary, Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, Nullable<int> userID)
        //{
        //    var iDParameter = iD.HasValue ?
        //        new SqlParameter("ID", iD) :
        //        new SqlParameter("ID", typeof(int));

        //    var nameParameter = name != null ?
        //        new SqlParameter("Name", name) :
        //        new SqlParameter("Name", typeof(string));

        //    var summaryParameter = summary != null ?
        //        new SqlParameter("Summary", summary) :
        //        new SqlParameter("Summary", typeof(string));

        //    var dateStartParameter = dateStart.HasValue ?
        //        new SqlParameter("DateStart", dateStart) :
        //        new SqlParameter("DateStart", typeof(System.DateTime));

        //    var dateEndParameter = dateEnd.HasValue ?
        //        new SqlParameter("DateEnd", dateEnd) :
        //        new SqlParameter("DateEnd", typeof(System.DateTime));

        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("VolunteerExperience_Save", iDParameter, nameParameter, summaryParameter, dateStartParameter, dateEndParameter, userIDParameter);
        //}

        public virtual UserSocialNetwork UserSocialNetwork_Get(int Id)
        {
            UserSocialNetwork item = new UserSocialNetwork();

            if (Id < 1)
                return (item);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                //_context.Configuration.ProxyCreationEnabled = false;
                item = _context.UserSocialNetworks.Include(x => x.SocialNetwork).SingleOrDefault(x => x.ID == Id);

                if (item == null)
                    return (new UserSocialNetwork());

                return (item);
            }
        }

        public virtual List<UserSocialNetwork> UserSocialNetwork_GetAllForUser(int UserId)
        {
            UserSocialNetwork item = new UserSocialNetwork();

            if (UserId < 1)
                return (new List<UserSocialNetwork>() { item });

            IEnumerable<UserSocialNetwork> items = _context.UserSocialNetworks.Where(x => x.UserID == UserId);

            return (items.ToList());
        }

        public virtual VolunteerExperience VolunteerExperience_Get(int Id)
        {
            VolunteerExperience item = new VolunteerExperience();

            if (Id < 1)
                return (item);

            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                //_context.Configuration.ProxyCreationEnabled = false;
                item = _context.VolunteerExperiences.SingleOrDefault(x => x.ID == Id);

                if (item == null)
                    return (new VolunteerExperience());

                return (item);
            }
        }

        public virtual VolunteerExperience VolunteerExperience_Save(Nullable<int> iD, string name, string summary, Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd, Nullable<int> userID)
        {
            //using (NuvolaResumeContext context = new NuvolaResumeContext())
            {
                VolunteerExperience item = new VolunteerExperience();

                if (iD.HasValue)
                {
                    //Find the item
                    item = _context.VolunteerExperiences.SingleOrDefault(x => x.ID == iD.Value);
                }
                else
                {
                    //Create a new item, we don't have an ID
                    item = new VolunteerExperience();
                }

                //Update / Set properties
                item.UserID = userID.Value;
                item.Name = name;
                item.Summary = summary;
                item.DateStart = dateStart;
                item.DateEnd = dateEnd;

                if (iD.HasValue)
                {
                    //Add the new item to the database
                    _context.VolunteerExperiences.Add(item);
                }

                _context.SaveChanges();

                return (item);
            }
        }

        public virtual ObjectResult<int> VolunteerExperiences_DeleteAllByUserId(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("VolunteerExperiences_DeleteAllByUserId", userIdParameter);
        }

        //public virtual ObjectResult<VolunteerExperiences_GetAllForUser_Result> VolunteerExperiences_GetAllForUser(Nullable<int> userID)
        //{
        //    var userIDParameter = userID.HasValue ?
        //        new SqlParameter("UserID", userID) :
        //        new SqlParameter("UserID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<VolunteerExperiences_GetAllForUser_Result>("VolunteerExperiences_GetAllForUser", userIDParameter);
        //}

        public virtual List<VolunteerExperience> VolunteerExperiences_GetAllForUser(Nullable<int> userID)
        {
            {
                IEnumerable<VolunteerExperience> items = _context.VolunteerExperiences.Where(x => x.UserID == userID);
                return (items.ToList());
            }
        }

        public virtual ObjectResult<int> webpages_Membership_DeleteAllByUserId(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("webpages_Membership_DeleteAllByUserId", userIdParameter);
        }

        public virtual ObjectResult<int> webpages_UsersInRoles_DeleteAllByUserId(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<int>("webpages_UsersInRoles_DeleteAllByUserId", userIdParameter);
        }

    }
}