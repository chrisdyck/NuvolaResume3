namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManagedBy")]
    public partial class ManagedBy
    {
        public int ManagedByID { get; set; }

        public int? UserID { get; set; }

        public int? UserIDManager { get; set; }

        public int? ConfirmedStatusID { get; set; }

        public Guid? ConfirmationId { get; set; }

        public Guid? RequesterConfirmationId { get; set; }
    }
}
