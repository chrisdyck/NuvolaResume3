using NuvolaResume3.Models.Data;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuvolaResume3.Filters;

namespace NuvolaResume3.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            IEnumerable<UserProfile> items = context.UserProfiles
                                                .Include(x => x.Achievements)
                                                .Include(x => x.Companies)
                                                .Include(x => x.Educations)
                                                .Include(x => x.Resumes)
                                                .Include(x => x.Skills)
                                                .Include(x => x.UserSocialNetworks)
                                                .Include(x => x.VolunteerExperiences);

            return View(items.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
