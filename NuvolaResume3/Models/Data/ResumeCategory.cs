namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResumeCategory
    {
        public int ID { get; set; }

        public int ResumeID { get; set; }

        public int CategoriesItemID { get; set; }

        public virtual CategoryItem CategoryItem { get; set; }

        public virtual Resume Resume { get; set; }
    }
}
