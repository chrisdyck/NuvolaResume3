namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [DataContract(Namespace="")]
    public partial class SocialNetwork
    {
        public SocialNetwork()
        {
            UserSocialNetworks = new HashSet<UserSocialNetwork>();
        }

        [DataMember]
        public int ID { get; set; }

        [StringLength(150)]
        [DataMember]
        public string Name { get; set; }

        [StringLength(300)]
        [DataMember]
        public string URL { get; set; }

        [StringLength(300)]
        [XmlIgnore]
        public string ButtonLink1 { get; set; }

        [StringLength(1000)]
        [XmlIgnore]
        public string ButtonScript1 { get; set; }

        [StringLength(300)]
        [XmlIgnore]
        public string ButtonLink2 { get; set; }

        [StringLength(1000)]
        [XmlIgnore]
        public string ButtonScript2 { get; set; }

        [StringLength(300)]
        [XmlIgnore]
        public string ButtonLink3 { get; set; }

        [StringLength(1000)]
        [XmlIgnore]
        public string ButtonScript3 { get; set; }

        [StringLength(300)]
        [XmlIgnore]
        public string ButtonLink4 { get; set; }

        [StringLength(1000)]
        [XmlIgnore]
        public string ButtonScript4 { get; set; }

        [XmlIgnore]
        public DateTime? DateEdited { get; set; }

        [XmlIgnore]
        public DateTime? DateCreated { get; set; }

        [XmlIgnore]
        public virtual ICollection<UserSocialNetwork> UserSocialNetworks { get; set; }
    }
}
