namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupportRequest
    {
        public Guid SupportRequestId { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? UserId { get; set; }

        [StringLength(255)]
        public string SenderEmailAddress { get; set; }

        [StringLength(200)]
        public string Subject { get; set; }

        public int? ApprovedByUserId { get; set; }

        public bool? Approved { get; set; }

        public DateTime? DateEdited { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
