namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResumeAccess")]
    public partial class ResumeAccess
    {
        public int ResumeAccessId { get; set; }

        public int ResumeId { get; set; }

        public int UserId { get; set; }

        public virtual Resume Resume { get; set; }
    }
}
