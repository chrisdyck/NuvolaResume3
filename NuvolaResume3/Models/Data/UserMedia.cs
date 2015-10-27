namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserMedia
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? MediaType { get; set; }

        [StringLength(50)]
        public string MediaFileName { get; set; }

        [ForeignKey("UserID")]
        public virtual UserProfile UserProfile { get; set; }
    }
}
