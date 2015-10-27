using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuvolaResume3.Models.Data;
using NuvolaResume3.Models;

namespace NuvolaResume3.Controllers
{   
    public class UserSocialNetworksController : BaseController
    {
        //
        // GET: /UserSocialNetworks/

        public ViewResult Index()
        {
            return View(context.UserSocialNetworks.Include(usersocialnetwork => usersocialnetwork.SocialNetwork).ToList());
        }

        //
        // GET: /UserSocialNetworks/Details/5

        public ViewResult Details(int id)
        {
            UserSocialNetwork usersocialnetwork = context.UserSocialNetworks.Single(x => x.ID == id);
            return View(usersocialnetwork);
        }

        //
        // GET: /UserSocialNetworks/Create

        public ActionResult Create()
        {
            ViewBag.PossibleSocialNetworks = context.SocialNetworks;
            return View();
        } 

        //
        // POST: /UserSocialNetworks/Create

        [HttpPost]
        public ActionResult Create(UserSocialNetwork usersocialnetwork)
        {
            if (ModelState.IsValid)
            {
                context.UserSocialNetworks.Add(usersocialnetwork);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleSocialNetworks = context.SocialNetworks;
            return View(usersocialnetwork);
        }
        
        //
        // GET: /UserSocialNetworks/Edit/5
 
        public ActionResult Edit(int id)
        {
            UserSocialNetwork usersocialnetwork = context.UserSocialNetworks.Single(x => x.ID == id);
            ViewBag.PossibleSocialNetworks = context.SocialNetworks;
            return View(usersocialnetwork);
        }

        //
        // POST: /UserSocialNetworks/Edit/5

        [HttpPost]
        public ActionResult Edit(UserSocialNetwork usersocialnetwork)
        {
            if (ModelState.IsValid)
            {
                context.Entry(usersocialnetwork).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleSocialNetworks = context.SocialNetworks;
            return View(usersocialnetwork);
        }

        //
        // GET: /UserSocialNetworks/Delete/5
 
        public ActionResult Delete(int id)
        {
            UserSocialNetwork usersocialnetwork = context.UserSocialNetworks.Single(x => x.ID == id);
            return View(usersocialnetwork);
        }

        //
        // POST: /UserSocialNetworks/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            UserSocialNetwork usersocialnetwork = context.UserSocialNetworks.Single(x => x.ID == id);
            context.UserSocialNetworks.Remove(usersocialnetwork);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}