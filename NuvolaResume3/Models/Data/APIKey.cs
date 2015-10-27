namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APIKey
    {
        public int ID { get; set; }

        public int OAuthClientID { get; set; }

        [Required]
        [StringLength(100)]
        public string ConsumerKey { get; set; }

        [Required]
        [StringLength(100)]
        public string ConsumerSecret { get; set; }
    }
}
