namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMail")]
    public partial class UserMail
    {
        public int ID { get; set; }

        public Guid MailId { get; set; }

        public Guid? MailThreadId { get; set; }

        public int? SenderUserID { get; set; }

        public int? ReceiverUserID { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        [StringLength(3000)]
        public string MessageBody { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }
    }
}
