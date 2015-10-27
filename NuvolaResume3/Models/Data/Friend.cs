namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Friend
    {
        public int FriendID { get; set; }

        public int? UserID { get; set; }

        public int? RequestUserID { get; set; }

        public int? ConfirmedStatusID { get; set; }

        public Guid? ConfirmationId { get; set; }

        public Guid? RequesterConfirmationId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }
    }
}
