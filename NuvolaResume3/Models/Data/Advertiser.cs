namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Advertiser
    {
        public int AdvertiserID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
