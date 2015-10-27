namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [DataContract(Namespace = "")]
    public partial class UserSocialNetwork
    {
        public UserSocialNetwork()
        {
            ResumeSocialNetworks = new HashSet<ResumeSocialNetwork>();
        }

        [DataMember]
        public int ID { get; set; }

        [Display(Name = "Social Network")]
        [DataMember]
        public int SocialNetworkID { get; set; }

        [XmlIgnore]
        [Display(Name = "User Profile")]
        public int UserID { get; set; }

        [StringLength(150)]
        [Display(Name = "Social Network Account")]
        [DataMember]
        public string SocialNetworkAccount { get; set; }

        [StringLength(50)]
        [Display(Name = "Display As")]
        [DataMember]
        public string DisplayAs { get; set; }

        [XmlIgnore]
        public DateTime? DateEdited { get; set; }

        [XmlIgnore]
        public DateTime? DateCreated { get; set; }

        [XmlIgnore]
        [ForeignKey("SocialNetworkID")]
        [DataMember]
        public virtual SocialNetwork SocialNetwork { get; set; }

        [XmlIgnore]
        [ForeignKey("UserID")]
        public virtual UserProfile UserProfile { get; set; }

        [XmlIgnore]
        public virtual ICollection<ResumeSocialNetwork> ResumeSocialNetworks { get; set; }

        [NotMapped]
        [DataMember]
        public string URL
        {
            get
            {
                if (SocialNetwork == null)
                    return (String.Empty);

                if (String.IsNullOrEmpty(SocialNetworkAccount))
                    return (String.Empty);

                return (String.Format("{0}/{1}", SocialNetwork != null ? 
                    SocialNetwork.URL : "", SocialNetworkAccount));
            }

            set { }
        }
    }
}
