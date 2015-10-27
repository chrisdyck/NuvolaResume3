namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AuthToken
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string AccessToken { get; set; }

        [StringLength(50)]
        public string TokenSecret { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public DateTime? Date_Created { get; set; }

        public DateTime? Date_Expires { get; set; }

        [StringLength(50)]
        public string Specifier { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
