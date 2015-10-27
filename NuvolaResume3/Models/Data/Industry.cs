namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Industry
    {
        public Industry()
        {
            ResumeIndustries = new HashSet<ResumeIndustry>();
        }

        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string IndustryCode { get; set; }

        public DateTime? DateEdited { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual ICollection<ResumeIndustry> ResumeIndustries { get; set; }
    }
}
