namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeaturesList")]
    public partial class FeaturesList
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string ProblemToFix { get; set; }

        public int UserID { get; set; }

        public int ReportedByUserID { get; set; }

        public bool HighlightAsComingSoon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FixedDate { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }
    }
}
