namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract(Namespace = "")]
    public partial class Company
    {
        public Company()
        {
            Skills = new HashSet<Skill>();
        }

        [DataMember]
        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(80)]
        [DataMember]
        public string Name { get; set; }

        [StringLength(100)]
        [DataMember]
        public string JobTitle { get; set; }

        [StringLength(1000)]
        [DataMember]
        public string URL { get; set; }

        [StringLength(500)]
        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public DateTime? DateStart { get; set; }

        [DataMember]
        public DateTime? DateEnd { get; set; }

        [DataMember]
        [NotMapped]
        public long DateStartTicks
        {
            get
            {
                return (DateStart.HasValue ? DateStart.Value.Ticks : DateTime.Now.Ticks);
            }

            set{}
        }

        [DataMember]
        [NotMapped]
        public long DateEndTicks
        {
            get
            {
                return (DateEnd.HasValue ? DateEnd.Value.Ticks : DateTime.Now.Ticks);
            }

            set{}
        }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        [DataMember]
        public virtual ICollection<Skill> Skills { get; set; }

        [ForeignKey("UserID")]
        public virtual UserProfile UserProfile { get; set; }
    }
}
