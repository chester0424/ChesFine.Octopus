using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.Controllers
{
    public class CommonController : Controller
    {
        [ChildActionOnly]
        // GET: Common
        public ActionResult GetPage(int pageCount,int currentIndex)
        {
            ViewData["PageCount"] = pageCount;
            ViewData["PageCurrentIndex"] = currentIndex;
            //ViewData["RequestUrl"] = requestUrl;
            return View();
        }

        public ActionResult FileUpload()
        {
            HttpFileCollectionBase files = Request.Files;

            if (files.Count > 0)
            {
                files[0].SaveAs(Server.MapPath("~/UploadedFiles/") + System.IO.Path.GetFileName(files[0].FileName));

                var imgurl = "/UploadedFiles/" + files[0].FileName;
                var error = "";
                var msg = "成功";
                string res = "{ error:'" + error + "', message:'" + msg + "',imgurl:'" + imgurl + "'}";
                return Content(res);
            }
            return Json("");
        }
    }
}