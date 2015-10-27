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
    public class CountriesController : Controller
    {
        private NuvolaResume3Context context = new NuvolaResume3Context();

        //
        // GET: /Countries/

        public ViewResult Index()
        {
            return View(context.Countries.Include(country => country.UserProfiles).ToList());
        }

        //
        // GET: /Countries/Details/5

        public ViewResult Details(int id)
        {
            Country country = context.Countries.Single(x => x.ID == id);
            return View(country);
        }

        //
        // GET: /Countries/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Countries/Create

        [HttpPost]
        public ActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                context.Countries.Add(country);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(country);
        }
        
        //
        // GET: /Countries/Edit/5
 
        public ActionResult Edit(int id)
        {
            Country country = context.Countries.Single(x => x.ID == id);
            return View(country);
        }

        //
        // POST: /Countries/Edit/5

        [HttpPost]
        public ActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                context.Entry(country).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(country);
        }

        //
        // GET: /Countries/Delete/5
 
        public ActionResult Delete(int id)
        {
            Country country = context.Countries.Single(x => x.ID == id);
            return View(country);
        }

        //
        // POST: /Countries/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Country country = context.Countries.Single(x => x.ID == id);
            context.Countries.Remove(country);
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