namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PasswordReset
    {
        public Guid PasswordResetId { get; set; }

        public int? UserId { get; set; }
    }
}
