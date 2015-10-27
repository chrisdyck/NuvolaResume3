namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [Serializable]
    [DataContract(Namespace = "")]
    public partial class Skill
    {
        public Skill()
        {
            ResumeSkills = new HashSet<ResumeSkill>();
            SkillsCategories = new HashSet<SkillsCategory>();
        }

        [DataMember]
        public int ID { get; set; }

        [XmlIgnore]
        public int UserID { get; set; }

        [XmlIgnore]
        public int? CompanyID { get; set; }

        //[XmlElement(ElementName = "CompanyID", Type = typeof(string))]
        //[DataMember]
        //public string XMLCompanyID
        //{
        //    get
        //    {
        //        return (CompanyID.HasValue ? CompanyID.Value.ToString() : "None");
        //    }

        //    private set { }
        //}

        //[XmlElement(ElementName = "CompanyName", Type = typeof(string))]
        //[DataMember]
        //public string XMLCompanyName
        //{
        //    get
        //    {
        //        return (Company != null ? Company.Name : "None");
        //    }
        //    private set { }
        //}

        [Required]
        [StringLength(500)]
        [DataMember]
        public string Description { get; set; }

        [XmlIgnore]
        public bool? IsAchievement { get; set; }

        [XmlIgnore]
        public DateTime? DateCreated { get; set; }

        [XmlIgnore]
        public DateTime? DateEdited { get; set; }

        [ForeignKey("CompanyID")]
        [XmlIgnore]
        public virtual Company Company { get; set; }

        [XmlIgnore]
        public virtual ICollection<ResumeSkill> ResumeSkills { get; set; }

        [XmlIgnore]
        public virtual ICollection<SkillsCategory> SkillsCategories { get; set; }

        [ForeignKey("UserID")]
        [XmlIgnore]
        public virtual UserProfile UserProfile { get; set; }
    }
}
