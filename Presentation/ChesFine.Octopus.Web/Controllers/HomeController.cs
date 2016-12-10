using ChesFine.Octopus.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        IUserService _userService;

        #endregion

        #region Ctor

        public HomeController(IUserService userService)
        {
            this._userService = userService;
        }

        #endregion

        // GET: Default
        public ActionResult Index()
        {
            var data = _userService.GetAllUsers();
            return View();
        }
    }
}