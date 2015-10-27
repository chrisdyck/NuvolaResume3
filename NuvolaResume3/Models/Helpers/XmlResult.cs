using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NuvolaResume3.Models.Helpers
{
    public class XmlResult : ActionResult
    {
        public XmlResult()
        {
            attrs.XmlIgnore = true;
        }
        public XmlResult(object data) : this() { this.Data = data; }

        public static string Serialize(object obj)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (StreamReader reader = new StreamReader(memoryStream))
            {
                DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
                serializer.WriteObject(memoryStream, obj);
                memoryStream.Position = 0;
                return reader.ReadToEnd();
            }
        }

        // Create the XmlAttributeOverrides and XmlAttributes objects.
        public XmlAttributeOverrides xOver = new XmlAttributeOverrides();
        public XmlAttributes attrs = new XmlAttributes();

        public string ContentType { get; set; }
        public Encoding ContentEncoding { get; set; }
        public object Data { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            HttpResponseBase response = context.HttpContext.Response;
            if (!string.IsNullOrEmpty(this.ContentType))
                response.ContentType = this.ContentType;
            else
                response.ContentType = "text/xml";

            if (this.ContentEncoding != null)
                response.ContentEncoding = this.ContentEncoding;

            if (this.Data != null)
            {
                if (this.Data is XmlNode)
                    response.Write(((XmlNode)this.Data).OuterXml);
                else if (this.Data is XNode)
                    response.Write(((XNode)this.Data).ToString());
                else
                {
                    var dataType = this.Data.GetType();
                    //if (dataType.GetCustomAttributes(typeof(DataContractAttribute), true).FirstOrDefault() != null)
                    //{
                        var dSer = new DataContractSerializer(dataType);
                        dSer.WriteObject(response.OutputStream, this.Data);
                    //}
                    //else
                    //{
                    //    var xSer = new XmlSerializer(dataType, xOver);
                    //    xSer.Serialize(response.OutputStream, this.Data);
                    //}
                }
            }
        }
    }
}