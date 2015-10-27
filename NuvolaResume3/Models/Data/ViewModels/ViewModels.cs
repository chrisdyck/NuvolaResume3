using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuvolaResume3.Models.Data.ViewModels
{
    public class ViewModel
    {
        public virtual IEnumerable<object> Items { get; set; }
        public virtual string Label { get; set; }
        public virtual string[] SelectedItemsIds { get; set; }
        public string ControlId { get; set; }
    }

    public class ResumeCategoriesViewModel : ViewModel
    {
        new public virtual IEnumerable<NuvolaResume3.Models.Data.Category> Items { get; set; }
    }
}