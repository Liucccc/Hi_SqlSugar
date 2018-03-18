using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hi.Frontend.Areas.Admin.Controllers
{
    public class FileInputController : Controller
    {
        // GET: Admin/FileInput
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            try
            {
                HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;
                //string path1 = System.Web.HttpContext.Current.Request.Form["path"];//接收参数
                List<string> file = new List<string>();
                for (int iFile = 0; iFile < files.Count; iFile++)
                {
                    //检查文件扩展名字
                    HttpPostedFile postedFile = files[iFile];
                    string fileName, fileExtension;
                    fileName = System.IO.Path.GetFileName(postedFile.FileName);
                    if (fileName != "")
                    {
                        fileExtension = System.IO.Path.GetExtension(fileName);
                        Random rd = new Random();
                        fileName = DateTime.Now.ToString("yyyyMMddHHmmsssffff") + rd.Next(1000, 9999).ToString() + fileExtension;
                        string path = "/UploadFile/temp/";

                        if (!Directory.Exists(Server.MapPath(path)))
                        {
                            Directory.CreateDirectory(Server.MapPath(path));
                        }
                        postedFile.SaveAs(Server.MapPath(path) + fileName);
                        file.Add(path + fileName);
                    }
                }
                return Json(new { success = "上传成功!", filePath = file });
            }
            catch (Exception ex)
            {
                return Json(new { error = "上传失败！" + ex.Message });
            }

        }
    }
}