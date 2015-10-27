namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    public partial class ResumeAchievement
    {
        public int ID { get; set; }

        public int ResumeID { get; set; }

        public int AchievementID { get; set; }

        [XmlIgnore]
        public int? DisplayOrder { get; set; }

        [XmlIgnore]
        public virtual Achievement Achievement { get; set; }

        [XmlIgnore]
        public virtual Resume Resume { get; set; }
    }
}
