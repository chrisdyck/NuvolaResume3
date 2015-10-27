namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [DataContract(Namespace = "")]
    public partial class Education
    {
        public Education()
        {
            ResumeEducations = new HashSet<ResumeEducation>();
        }

        [DataMember]
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        [DataMember]
        public string InstitutionName { get; set; }

        [StringLength(150)]
        [DataMember]
        public string CourseName { get; set; }

        [StringLength(1500)]
        [DataMember]
        public string CourseDescription { get; set; }

        [XmlIgnore]
        public int UserID { get; set; }

        [XmlIgnore]
        [DataMember]
        public DateTime? DateStart { get; set; }

        [XmlIgnore]
        [DataMember]
        public DateTime? DateEnd { get; set; }

        [XmlIgnore]
        public DateTime? DateCreated { get; set; }

        [XmlIgnore]
        public DateTime? DateEdited { get; set; }

        [XmlIgnore]
        public virtual ICollection<ResumeEducation> ResumeEducations { get; set; }

        [ForeignKey("UserID")]
        [XmlIgnore]
        public virtual UserProfile UserProfile { get; set; }
    }
}
