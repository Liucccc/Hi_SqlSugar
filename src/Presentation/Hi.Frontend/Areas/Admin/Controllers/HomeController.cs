using Hi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hi.Frontend.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 用户服务接口
        /// </summary>
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult TableJson()
        {
            var post = _userService.FindAll();
            return Json(post, JsonRequestBehavior.AllowGet);
        }
    }
}