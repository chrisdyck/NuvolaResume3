namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    
    [DataContract]
    public partial class CategoryItem
    {
        public CategoryItem()
        {
            ResumeCategories = new HashSet<ResumeCategory>();
        }

        [DataMember]
        public int ID { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int CategoryID { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        [ForeignKey("CategoryID")]
        [DataMember]
        public virtual Category Category { get; set; }

        public virtual ICollection<ResumeCategory> ResumeCategories { get; set; }
    }
}
