using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace NuvolaResume3.Controllers
{
    [Authorize]
    public class SecurityChecksController : BaseController
    {
        //
        // GET: /SecurityChecks/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminOnly(int? uid)
        {
            //if (!base.roleprovider.IsAdministrator(uid.Value))
            //    return (RedirectToError(1001));

            if (!base.roleprovider.IsManagedBy(WebSecurity.CurrentUserId, uid.Value))
                return (RedirectToError(2001));


            return (RedirectToIndex());
        }

        public ActionResult ResumeAdminOwnerOnly(int? uid)
        {
            return (RedirectToIndex());
        }
    }
}