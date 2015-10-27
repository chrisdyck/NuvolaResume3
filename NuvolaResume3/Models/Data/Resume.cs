namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.IO;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Web.Script.Serialization;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Xml.Xsl;

    [DataContract(Namespace = "")]
    public partial class Resume : BaseModel
    {
        public Resume()
        {
            Achievements = new List<Achievement>();
            Skills = new List<Skill>();
            Educations = new List<Education>();
            VolunteerExperiences = new List<VolunteerExperience>();
            UserSocialNetworks = new List<UserSocialNetwork>();
            Companies = new List<Company>();
            Industries = new List<Industry>();
            Categories = new List<Category>();

            //ResumeAccesses = new HashSet<ResumeAccess>();
            ResumeAchievements = new HashSet<ResumeAchievement>();
            ResumeCategories = new HashSet<ResumeCategory>();
            ResumeEducations = new HashSet<ResumeEducation>();
            ResumeIndustries = new HashSet<ResumeIndustry>();
            ResumeSkills = new HashSet<ResumeSkill>();
            ResumeSocialNetworks = new HashSet<ResumeSocialNetwork>();
            ResumeVolunteerExperiences = new HashSet<ResumeVolunteerExperience>();
        }

        [Key]
        [DataMember]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        [Display(Name="Resume Name")]
        public string Name { get; set; }

        [DataMember]
        public int UserID { get; set; }

        [StringLength(500)]
        [DataMember]
        [Display(Name = "Resume Description")]
        public string Description { get; set; }

        [StringLength(2000)]
        [DataMember]
        [Display(Name = "Summary or Objectives")]
        public string SummaryObjectives { get; set; }

        [StringLength(150)]
        [DataMember]
        public string TagLine { get; set; }

        [Display(Name = "This is a Public Resume")]
        public bool? IsPublic { get; set; }

        [Display(Name = "Use as Profile Resume")]
        public bool? IsProfile { get; set; }

        public int? CreatedBy { get; set; }

        //public virtual ICollection<ResumeAccess> ResumeAccesses { get; set; }

        public virtual ICollection<ResumeAchievement> ResumeAchievements { get; set; }
        private string[] _ResumeAchievementsIds;

        [NotMapped]
        public string[] ResumeAchievementsIds
        {
            get
            {
                string[] tmps = GenericListPropertyExtractor(ResumeAchievements, "AchievementID");

                return (tmps);
            }

            set
            {
                _ResumeAchievementsIds = value;
            }
        }

        public virtual ICollection<ResumeCategory> ResumeCategories { get; set; }

        private string[] _ResumeCategoriesIds;

        [NotMapped]
        public string[] ResumeCategoriesIds
        {
            get
            {
                string[] tmps = GenericListPropertyExtractor(ResumeCategories, "CategoriesItemID");

                return (tmps);
            }

            set
            {
                _ResumeCategoriesIds = value;
            }
        }

        public virtual ICollection<ResumeEducation> ResumeEducations { get; set; }

        private string[] _ResumeEducationsIds;

        [NotMapped]
        public string[] ResumeEducationsIds
        {
            get
            {
                string[] tmps = GenericListPropertyExtractor(ResumeEducations, "EducationID");

                return (tmps);
            }

            set
            {
                _ResumeEducationsIds = value;
            }
        }

        public virtual ICollection<ResumeIndustry> ResumeIndustries { get; set; }

        private string[] _ResumeIndustriesIds;

        [NotMapped]
        public string[] ResumeIndustriesIds
        {
            get
            {
                string[] tmps = GenericListPropertyExtractor(ResumeIndustries, "IndustryID");

                return (tmps);
            }

            set
            {
                _ResumeIndustriesIds = value;
            }
        }

        public virtual ICollection<ResumeSkill> ResumeSkills { get; set; }

        private string[] _ResumeSkillsIds;

        [NotMapped]
        public string[] ResumeSkillsIds
        {
            get
            {
                string[] tmps = GenericListPropertyExtractor(ResumeSkills, "SkillID");

                return (tmps);
            }

            set
            {
                _ResumeSkillsIds = value;
            }
        }

        public virtual ICollection<ResumeSocialNetwork> ResumeSocialNetworks { get; set; }

        private string[] _ResumeSocialNetworksIds;

        [NotMapped]
        public string[] ResumeSocialNetworksIds
        {
            get
            {
                string[] tmps = GenericListPropertyExtractor(ResumeSocialNetworks, "UserSocialNetworkID");

                return (tmps);
            }

            set
            {
                _ResumeSocialNetworksIds = value;
            }
        }

        public virtual ICollection<ResumeVolunteerExperience> ResumeVolunteerExperiences { get; set; }

        private string[] _ResumeVolunteerExperiencesIds;

        [NotMapped]
        public string[] ResumeVolunteerExperiencesIds
        {
            get
            {
                string[] tmps = GenericListPropertyExtractor(ResumeVolunteerExperiences, "VolunteerExperienceID");

                return (tmps);
            }

            set
            {
                _ResumeVolunteerExperiencesIds = value;
            }
        }

        [ForeignKey("UserID")]
        [DataMember]
        public virtual UserProfile UserProfile { get; set; }

        //[ForeignKey("CreatedBy")]
        //public virtual UserProfile CreatedByUserProfile { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Achievements")]
        public virtual List<Achievement> Achievements { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Education")]
        public virtual List<Education> Educations { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Career Experience")]
        public virtual List<Skill> Skills { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Volunteer Experience")]
        public virtual List<VolunteerExperience> VolunteerExperiences { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Social Networks")]
        public virtual List<UserSocialNetwork> UserSocialNetworks { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Companies")]
        public virtual List<Company> Companies { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Industries")]
        public virtual List<Industry> Industries { get; set; }

        [NotMapped]
        [DataMember]
        [Display(Name = "Categories")]
        public virtual List<Category> Categories { get; set; }

        public string ToXMLString()
        {
            var serializer = new DataContractSerializer(typeof(Resume));
            var obj = this;
            StringBuilder sb = new StringBuilder();
            using (XmlWriter xw = XmlWriter.Create(sb) /*String.Format("{0}\\test.xml", Server.MapPath("/Content")))*/)
            {
                serializer.WriteObject(xw, obj);
                xw.Close();
            }
            return (sb.ToString());
        }

        public string ToHTMLString(string xsltPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(ToXMLString());

            IDictionary<string, string> parameters = new Dictionary<string, string>();
            XsltArgumentList args = new XsltArgumentList();
            if (parameters != null)
                foreach (string key in parameters.Keys)
                    args.AddParam(key, "", parameters[key]);

            StringBuilder sb = new StringBuilder();
            XslCompiledTransform t = new XslCompiledTransform();
            t.Load(xsltPath);

            StringWriter writer = new StringWriter();
            t.Transform(xmlDoc, args, writer);
            return (writer.ToString());
        }


    }
}
