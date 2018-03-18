using Hi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace Hi.Frontend.Areas.Admin.Controllers
{
    public class AdvertiseController : Controller
    {
        /// <summary>
        /// 用户服务接口
        /// </summary>
        private readonly IAdvertiseService _advertiseService;

        public AdvertiseController(IAdvertiseService advertiseService)
        {
            _advertiseService = advertiseService;
        }
        // GET: Admin/Advertise
        public ActionResult Index(int k)
        {
            var advertise = _advertiseService.FindById(k);
            ViewBag.advertise = advertise;
            return View();
        }

        [HttpPost]
        public ActionResult Form(short k, string Pic1, string Url, string Atitle)
        {
            var model = new zzlh2017_Advertise { Aid = k, Pic1 = Pic1, Url = Url, Atitle = Atitle };
            _advertiseService.Update(model);
            return Content("修改成功！");
        }

        public ActionResult FileInput()
        {
            return View();
        }
    }
}