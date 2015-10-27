namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class webpages_UsersInRoles
    {
        public int ID { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }

        [ForeignKey("RoleId")]
        public virtual webpages_Roles webpages_Roles { get; set; }

        [ForeignKey("UserId")]
        public virtual UserProfile UserProfile { get; set; }
    }
}
