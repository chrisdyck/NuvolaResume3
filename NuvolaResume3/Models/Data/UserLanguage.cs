namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserLanguage
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? LanguageId { get; set; }

        public int? LanguageProficiencyId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        [ForeignKey("UserID")]
        public virtual UserProfile UserProfile { get; set; }
    }
}
