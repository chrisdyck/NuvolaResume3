using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Web;

namespace NuvolaResume3.Models.Data
{
    [DataContract(Namespace = "")]
    public class BaseModel
    {
        public BaseModel()
        {
            Create();
            Edit();
        }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateEdited { get; set; }

        public virtual void Create()
        {
            DateCreated = DateTime.Now;
        }

        public virtual void Edit()
        {
            DateEdited = DateTime.Now;
        }

        public string[] GenericListPropertyExtractor(IEnumerable<object> Collection, string Property)
        {
            string tmp = "";
            string [] ret = new string[1] { "" };

            if (Collection == null)
                return (ret);

            if (Collection.Count() < 1)
                return (ret);

            foreach (object item in Collection)
            {
                Type itemtype = item.GetType();
                PropertyInfo itemProperty = itemtype.GetProperty(Property);

                if (tmp != "")
                    tmp += ",";
                tmp += itemProperty.GetValue(item);//.ToString();
            }

            return (tmp.Split(','));
        }
    }
}