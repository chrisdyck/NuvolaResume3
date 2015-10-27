using NuvolaResume3.Models.Data;
using NuvolaResume3.Models.Helpers;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Text;

namespace NuvolaResume3.Controllers
{
    [System.Web.Mvc.Authorize]
    public class ResumesController : BaseController
    {
        //
        // GET: /Resumes/
        public ActionResult Index()
        {
            List<Resume> items = repository.Resumes_GetAllForUser(CurrentUser.ID).ToList();
            return View(items);
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult Edit(int id)
        {
            Resume item = repository.Resume_Get(id);

            item.Achievements = repository.Achievement_GetAllForUser(CurrentUser.ID);
            item.Skills = repository.Skills_GetAllForUser(CurrentUser.ID);
            item.VolunteerExperiences = repository.VolunteerExperiences_GetAllForUser(CurrentUser.ID);
            item.UserSocialNetworks = repository.UserSocialNetwork_GetAllForUser(CurrentUser.ID);
            item.Educations = repository.Educations_GetAllForUser(CurrentUser.ID);

            item.Industries = repository.Industries_GetAll();
            item.Categories = repository.Categories_GetAll();

            return (View(item));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Edit(Resume item)
        {

            return (View(item));
        }

        public ActionResult GetResumeAsMarkup(int id)
        {
            //var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            //var dcs = new DataContractSerializer(typeof(Resume), null, int.MaxValue,
            //    false, /* preserveObjectReferences: */ true, null);
            repository._context.Configuration.ProxyCreationEnabled = false;
            var item = repository._context.Resumes
                .Include(x => x.UserProfile)
                .Include(x => x.UserProfile.Country)
                .Include(x => x.ResumeAchievements)
                .Include(x => x.ResumeEducations)
                .Include(x => x.ResumeSkills)
                .Include(x => x.ResumeSocialNetworks)
                .Include(x => x.ResumeVolunteerExperiences)
                .AsNoTracking()
                .FirstOrDefault(x => x.ID == id); //repository.Resume_Get(id);

            foreach (ResumeAchievement x in item.ResumeAchievements)
            {
                Achievement aTmp = repository.Achievement_Get(x.AchievementID);

                item.Achievements.Add(aTmp);
            }

            foreach (ResumeSkill x in item.ResumeSkills)
            {
                Skill aTmp = repository.Skills_Get(x.SkillID);

                item.Skills.Add(aTmp);
            }

            item.Companies = (from company in item.Skills
                              group company by new { company.Company.ID, 
                                                        company.Company.Name, 
                                                        company.Company.JobTitle,
                                                        company.Company.DateStart,
                                                        company.Company.DateEnd,
                                                        company.Company.URL,
                                                        company.Company.Summary
                              }
                                          into gCompanies
                                          select new Company
                                          {
                                              ID = gCompanies.Key.ID,
                                              Name = gCompanies.Key.Name,
                                              JobTitle = gCompanies.Key.JobTitle,
                                              DateStart = gCompanies.Key.DateStart,
                                              DateEnd = gCompanies.Key.DateEnd,
                                              Summary = gCompanies.Key.Summary,
                                              URL = gCompanies.Key.URL,
                                              Skills = item.Skills.Where(x=>x.Company.ID == gCompanies.Key.ID).ToList()
                                          }).ToList();

            foreach (ResumeEducation x in item.ResumeEducations)
            {
                Education aTmp = repository.Educations_Get(x.EducationID);

                item.Educations.Add(aTmp);
            }

            foreach (ResumeVolunteerExperience x in item.ResumeVolunteerExperiences)
            {
                VolunteerExperience aTmp = repository.VolunteerExperience_Get(x.VolunteerExperienceID);

                item.VolunteerExperiences.Add(aTmp);
            }

            foreach (ResumeSocialNetwork x in item.ResumeSocialNetworks)
            {
                UserSocialNetwork aTmp = repository.UserSocialNetwork_Get(x.UserSocialNetworkID);

                item.UserSocialNetworks.Add(aTmp);
            }

            //var serializer = new DataContractSerializer(typeof(Resume));
            //var obj = item;
            //StringBuilder sb = new StringBuilder();
            //using (XmlWriter xw = XmlWriter.Create(sb) /*String.Format("{0}\\test.xml", Server.MapPath("/Content")))*/)
            //{
            //    serializer.WriteObject(xw, obj);
            //    xw.Close();
            //}

            using (System.IO.StreamWriter fs = new System.IO.StreamWriter(String.Format("{0}\\test.xml", Server.MapPath("/Content"))))
            {
                fs.Write(item.ToXMLString());
                fs.Close();
            }

            using (System.IO.StreamWriter fs = new System.IO.StreamWriter(String.Format("{0}\\test.html", Server.MapPath("/Content"))))
            {
                fs.Write(item.ToHTMLString(Server.MapPath("~/Content/Resume.xslt")));
                fs.Close();
            }

            return (View());
        }

    }
}