namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Connection
    {
        public int ConnectionID { get; set; }

        public int? UserId { get; set; }

        public int? ConnectionUserId { get; set; }

        public int? ConfirmationStatusId { get; set; }
    }
}
