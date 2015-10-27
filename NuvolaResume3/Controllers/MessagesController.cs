    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NuvolaResume3.Controllers
{
    public class MessagesController : BaseController
    {
        //
        // GET: /Messages/

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Errors(int id)
        {
            switch (id)
            {
                case 1001:
                    ViewBag.ErrorTitle = "Unauthorized Access";
                    ViewBag.ErrorMessage = "You are not authorized to view this page.";
                    break;
                //Resume Related Errors
                case 2000:
                    ViewBag.Title = "Access is denied";
                    ViewBag.Message = "The resume you are requesting has been marked as Private by the user.  Please select another resume.";
                    break;
                case 2001:
                    ViewBag.Title = "Access is denied";
                    ViewBag.Message = "Access is denied.  If you are the Resume Manager please contact the user to allow access.";
                    break;
                case 3001:
                    ViewBag.ErrorTitle = "Invalid Resume ID";
                    ViewBag.ErrorMessage = "The resume you are trying to display is invalid.";
                    break;
            }
            return View();
        }

    }
}
