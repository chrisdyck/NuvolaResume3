namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConfirmationStatu
    {
        [Key]
        public int ConfirmedStatusID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
