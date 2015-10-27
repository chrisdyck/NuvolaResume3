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
    public partial class Achievement
    {
        public Achievement()
        {
            ResumeAchievements = new HashSet<ResumeAchievement>();
        }

        [DataMember]
        public int ID { get; set; }

        [XmlIgnore]
        public int UserID { get; set; }

        [StringLength(500)]
        [DataMember]
        public string Name { get; set; }

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
        public virtual ICollection<ResumeAchievement> ResumeAchievements { get; set; }

        [ForeignKey("UserID")]
        [XmlIgnore]
        public virtual UserProfile UserProfile { get; set; }
    }
}
