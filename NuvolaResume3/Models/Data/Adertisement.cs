namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adertisement
    {
        public Guid AdertisementID { get; set; }

        [StringLength(50)]
        public string ImagePath { get; set; }

        public int? AdvertiserID { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }
    }
}
