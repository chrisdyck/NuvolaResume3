namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APITokenManager")]
    public partial class APITokenManager
    {
        public Guid APITokenManagerID { get; set; }

        public int? UserID { get; set; }

        public int? MaximumPublicUses { get; set; }

        public int? MaximumSandboxUses { get; set; }
    }
}
