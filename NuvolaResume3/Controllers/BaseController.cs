using NuvolaResume3.Filters;
using NuvolaResume3.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace NuvolaResume3.Controllers
{
    public class BaseController : Controller
    {
        public NuvolaResume3.Models.Data.NuvolaResumeContext context = new Models.Data.NuvolaResumeContext();
        public NuvolaResume3.Models.Data.NuvolaResumeRepository repository = new Models.Data.NuvolaResumeRepository();
        public NuvolaResume3.Models.Security.NuvolaResumeRoleProvider roleprovider = new Models.Security.NuvolaResumeRoleProvider();

        public string[] Roles { get; set; }
        public UserProfile CurrentUser { get; set; }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            if (WebSecurity.IsAuthenticated)
            {
                Roles = roleprovider.GetRolesForUser(WebSecurity.CurrentUserName);
                CurrentUser = repository.UserProfile_GetUserProfile(WebSecurity.CurrentUserId);
            }
            else
            {
                Roles = new string[] { "User" };
            }

            //Check Autentication Level
            var uid = requestContext.HttpContext.Request.QueryString["uid"];
            if (uid != null)
            {
                if (uid.Length > 0)
                {
                    if (!roleprovider.IsManagedBy(WebSecurity.CurrentUserId, Convert.ToInt32(uid)))
                        RedirectToError(2001);
                }
            }

            //Check Administration Level
            string controller = requestContext.RouteData.Values["controller"].ToString();
            string action = requestContext.RouteData.Values["action"].ToString();

            switch (controller)
            {
                case "Resumes":
                    switch (action)
                    {
                        case "Index":
                            break;
                        case "Edit":
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            base.Initialize(requestContext);
        }

        public RedirectToRouteResult RedirectToError(int errorid)
        {
            return RedirectToAction("Errors", "Messages", new { id = errorid });
        }

        public RedirectToRouteResult RedirectToIndex()
        {
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
                repository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}