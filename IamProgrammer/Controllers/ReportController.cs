using IamProgrammer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IamProgrammer.Controllers
{
    public class ReportController : Controller
    {
        ReportService report = new ReportService();
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GenerateReport()
        {
            var result = report.ReportProcessing();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ShowReport()
        {
            var lastReport = report.GetLateastReport();
            return View(lastReport);
        }
        public ActionResult JsonShowReport()
        {
            var lastReport = report.GetLateastReport();
            return Json(lastReport , JsonRequestBehavior.AllowGet);
        }
    }
}