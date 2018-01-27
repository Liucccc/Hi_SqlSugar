using Hi.AutoMapperConfig;
using Hi.Repositories;
using Hi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hi.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        public HomeController(IPostService postService)
        {
            _postService = postService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult admin()
        {
            //如果未登录，则跳转到登录页面
            if (Session["user_account"] == null)
            {
                return RedirectToAction("login", "account");
            }
            //var postRepository = new PostRepository();
            //var post = postRepository.FindById(1);
            var post = _postService.FindById(1).ToModel();
            ViewBag.post = post;
            return View();
        }
    }
}