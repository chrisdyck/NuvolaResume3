namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class webpages_Roles
    {
        public webpages_Roles()
        {
            webpages_UsersInRoles = new HashSet<webpages_UsersInRoles>();
        }

        [Key]
        public int RoleId { get; set; }

        [Required]
        [StringLength(256)]
        public string RoleName { get; set; }

        [StringLength(300)]
        public string RoleNameDisplay { get; set; }

        public bool IsPublic { get; set; }

        public virtual ICollection<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
    }
}
