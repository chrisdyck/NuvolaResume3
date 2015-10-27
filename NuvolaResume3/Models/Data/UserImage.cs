namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserImage
    {
        public Guid UserImageID { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string ImagePath { get; set; }

        public bool? IsProfilePic { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        [ForeignKey("UserId")]
        public virtual UserProfile UserProfile { get; set; }
    }
}
