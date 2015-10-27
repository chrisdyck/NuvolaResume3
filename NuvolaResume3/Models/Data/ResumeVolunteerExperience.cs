namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResumeVolunteerExperience
    {
        public int ID { get; set; }

        public int ResumeID { get; set; }

        public int VolunteerExperienceID { get; set; }

        public virtual Resume Resume { get; set; }

        public virtual VolunteerExperience VolunteerExperience { get; set; }
    }
}
