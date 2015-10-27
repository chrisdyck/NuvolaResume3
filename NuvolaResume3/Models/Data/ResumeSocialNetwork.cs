namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    public partial class ResumeSocialNetwork
    {
        public int ID { get; set; }

        public int ResumeID { get; set; }

        public int UserSocialNetworkID { get; set; }

        [XmlIgnore]
        public int? DisplayOrder { get; set; }

        [XmlIgnore]
        [ForeignKey("ResumeID")]
        public virtual Resume Resume { get; set; }

        [XmlIgnore]
        [ForeignKey("UserSocialNetworkID")]
        public virtual UserSocialNetwork UserSocialNetwork { get; set; }
    }
}
