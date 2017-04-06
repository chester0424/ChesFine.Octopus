using ChesFine.Octopus.Entities;
using ChesFine.Octopus.Web.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        //类别维护
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET:Admin/GetCategoryData
        ///
        /// </summary>
        /// <returns></returns>
        public ActionResult GetCategoryData()
        {
            //Category c = new Category();
            //c.ParentId = null;
            //c.Id = 1;
            //c.Name = "文章";
            //c.Priority = 1;
            Web.Models.TreeNodeModel tree = new Web.Models.TreeNodeModel();
            tree.Id = 1;
            tree.State = "Open";
            tree.Text = "文章管理";

            return new JsonNetResult(tree, JsonRequestBehavior.AllowGet);

            //return Json(tree, JsonRequestBehavior.AllowGet);
         }
    }
}