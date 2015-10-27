namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SkillsCategory
    {
        public int ID { get; set; }

        public int? CategoryID { get; set; }

        public int? SkillID { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        public virtual Category Category { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
