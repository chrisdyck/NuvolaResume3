namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ManagerComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommentID { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        public int UserIDManager { get; set; }

        public int ResumeID { get; set; }
    }
}
