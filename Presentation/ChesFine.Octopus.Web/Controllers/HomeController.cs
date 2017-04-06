using AutoMapper;
using ChesFine.Octopus.Entities;
using ChesFine.Octopus.Services.Users;
using ChesFine.Octopus.Web.Models;
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
            var datas = _userService.GetAllUsers();
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserModel>());
            var models = Mapper.Map<IList<UserModel>>(datas);
            return View(models);
        }
    }
}