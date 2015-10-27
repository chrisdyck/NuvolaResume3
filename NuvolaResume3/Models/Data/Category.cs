namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Category
    {
        public Category()
        {
            CategoryItems = new HashSet<CategoryItem>();
            SkillsCategories = new HashSet<SkillsCategory>();
        }

        [DataMember]
        public int ID { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Name { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        public virtual ICollection<SkillsCategory> SkillsCategories { get; set; }
    }
}
