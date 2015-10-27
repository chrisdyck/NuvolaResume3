namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Web.Script.Serialization;
    using System.Xml.Serialization;

    [Table("UserProfiles")]
    [DataContract(Namespace = "")]
    public partial class UserProfile
    {
        public UserProfile()
        {
            Resumes = new HashSet<Resume>();
            Companies = new HashSet<Company>();
            Skills = new HashSet<Skill>();
            VolunteerExperiences = new HashSet<VolunteerExperience>();
            UserSocialNetworks = new HashSet<UserSocialNetwork>();
            Educations = new HashSet<Education>();
            Achievements = new HashSet<Achievement>();
            //webpages_UsersInRoles = new HashSet<webpages_UsersInRoles>();
        }

        [Key]
        [DataMember]
        public int ID { get; set; }

        public Guid? OpenID { get; set; }

        public Guid? DeveloperID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        [DataMember]
        public string FirstName { get; set; }

        [StringLength(50)]
        [DataMember]
        public string LastName { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Street { get; set; }

        [StringLength(50)]
        [DataMember]
        public string City { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Region { get; set; }

        [StringLength(50)]
        [DataMember]
        public string StateProvince { get; set; }

        [StringLength(6)]
        [DataMember]
        public string PostalCode { get; set; }

        [StringLength(12)]
        [DataMember]
        public string ZipCode { get; set; }

        public int? CountryID { get; set; }

        [StringLength(11)]
        [DataMember]
        public string PhoneNumber1 { get; set; }

        [StringLength(11)]
        [DataMember]
        public string PhoneNumber2 { get; set; }

        [StringLength(11)]
        [DataMember]
        public string PhoneNumber3 { get; set; }

        [StringLength(255)]
        [DataMember]
        public string EMailAddress1 { get; set; }

        [StringLength(255)]
        [DataMember]
        public string EMailAddress2 { get; set; }

        public int? PublicResumeID { get; set; }

        [StringLength(100)]
        public string TwitterAccount { get; set; }

        [StringLength(100)]
        public string LinkedInURL { get; set; }

        [StringLength(100)]
        public string FacebookAccount { get; set; }

        public Guid? ActivationID { get; set; }

        public Guid? ConfirmationID { get; set; }

        public bool? Confirmed { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        public bool? IsSearchable { get; set; }

        [DataMember]
        public virtual Country Country { get; set; }

        [ForeignKey("PublicResumeID")]
        public virtual Resume PublicResume { get; set; }

        [InverseProperty("UserProfile")]
        public virtual ICollection<Resume> Resumes { get; set; }

        [XmlIgnore]
        public virtual ICollection<Company> Companies { get; set; }

        [XmlIgnore]
        public virtual ICollection<Skill> Skills { get; set; }

        [XmlIgnore]
        public virtual ICollection<VolunteerExperience> VolunteerExperiences { get; set; }

        [XmlIgnore]
        public virtual ICollection<UserSocialNetwork> UserSocialNetworks { get; set; }

        [XmlIgnore]
        public virtual ICollection<Achievement> Achievements { get; set; }

        [XmlIgnore]
        public virtual ICollection<Education> Educations { get; set; }

        [DataMember]
        [NotMapped]
        public virtual string FullName
        {
            get
            {
                return (String.Format("{0} {1}", FirstName, LastName));
            }

            set { }
        }
    }
}
