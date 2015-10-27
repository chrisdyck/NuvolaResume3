namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResumeSkill
    {
        public int ID { get; set; }

        public int ResumeID { get; set; }

        public int SkillID { get; set; }

        public int? DisplayOrder { get; set; }

        public virtual Resume Resume { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
