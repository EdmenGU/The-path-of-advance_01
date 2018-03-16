using MyMVC_Project1.BLL;
using MyMVC_Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC_Project1.Controllers
{
    public class HomeController : Controller
    {
        SkyZenTaskService skyZenTaskService = new SkyZenTaskService();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult index2()
        {
            SkyZenTask task = skyZenTaskService.GetSkyTaskList(new SkyZenTask() { id = 10086 });

            return View(task);
        }

        public ActionResult index3()
        {
            return View();
        }

        public JsonResult GetTaskInfo(int taskId)
        {
            SkyZenTask task = skyZenTaskService.GetSkyTaskList(new SkyZenTask() { id = taskId });
            return Json(new { data = task }, JsonRequestBehavior.AllowGet);
        }
    }
}
