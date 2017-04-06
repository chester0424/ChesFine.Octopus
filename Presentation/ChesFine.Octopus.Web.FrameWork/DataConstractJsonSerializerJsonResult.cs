using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.FrameWork
{
   public class DataConstractJsonSerializerJsonResult: JsonResult
    {
        public DataConstractJsonSerializerJsonResult(object data, JsonRequestBehavior behavior = JsonRequestBehavior.AllowGet, string contentType = null, Encoding contentEncoding = null)
        {
            this.Data = data;
            this.JsonRequestBehavior = behavior;
            this.ContentEncoding = contentEncoding;
            this.ContentType = contentType;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            if (this.JsonRequestBehavior == JsonRequestBehavior.DenyGet && string.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("JSON GET is not allowed");

            System.Web.HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = string.IsNullOrEmpty(this.ContentType) ? "application/json" : this.ContentType;

            if (this.ContentEncoding != null)
                response.ContentEncoding = this.ContentEncoding;
            if (this.Data == null)
                return;

            //var scriptSerializer = JsonSerializer.Create(this.Settings);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(this.Data.GetType());

            using (MemoryStream menoryStream = new MemoryStream())
            {
                serializer.WriteObject(menoryStream, this.Data);
                response.Write(menoryStream.ToString());
            }
        }
    }
}
