namespace NuvolaResume.Models.Data.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResumeManagerView")]
    public partial class ResumeManagerView
    {
        [StringLength(50)]
        public string ResumeManagerFirstName { get; set; }

        [StringLength(50)]
        public string ResumeManagerLastName { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ResumeManagerUserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResumeManagerID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string UserProfileUserName { get; set; }

        [StringLength(50)]
        public string UserProfileFirstname { get; set; }

        [StringLength(50)]
        public string UserProfileLastname { get; set; }
    }
}
