using ChesFine.Octopus.Services.Thmes;
using ChesFine.Octopus.Web.Areas.Admin.Models;
using ChesFine.Octopus.Web.FrameWork;
using ChesFine.Octopus.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.Areas.Admin.Controllers
{
    public class ThemeController : Controller
    {
        IThemeService _themeService;

        public ThemeController(IThemeService _themeService)
        {
            this._themeService = _themeService;
        }

        // GET: Admin/Theme
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Theme/ThemeDate
        public ActionResult ThemeDate(ThemeQueryModel query) {
            var themeData= _themeService.GetAllThemes();
            PaginationModel pagination = new PaginationModel();
            pagination.total = 40;
            pagination.rows = themeData;
            return Json(pagination,JsonRequestBehavior.AllowGet);
        }

        public ActionResult ThemeQuery(ThemeQueryModel query)
        {
            var total = 0;
            var themeData = _themeService.Qury(query.page,query.rows,query.Name,query.Resume,out total);

            PaginationModel pagination = new PaginationModel();
            pagination.total = total;
            pagination.rows = themeData;

            return Json(pagination, JsonRequestBehavior.AllowGet);
        }
    }
}