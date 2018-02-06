using Senparc.Weixin.Plugins.WeixinTraceManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeixinTraceMamager.Web.Models;

namespace WeixinTraceMamager.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vd = new Home_IndexVD()
            {
                DateList = WeixinTraceHelper.GetLogDate()
            };

            return View(vd);
        }
        public ActionResult DateLog(string date)
        {
            var vd = new Home_DateLogVD()
            {
                  WeixinTraceItemList = WeixinTraceHelper.GetAllLogs(date)
            };

            return View(vd);
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
    }
}