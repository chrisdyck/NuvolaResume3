namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract(Namespace="")]
    public partial class Country
    {
        public Country()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        [DataMember]
        public int ID { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Name { get; set; }

        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
