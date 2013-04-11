using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.ReportViewer.Mvc;

namespace m.Controllers
{
    public class ReportsController : Controller
    {
        //
        // GET: /Reports/

        public ActionResult Index()
        {
            ViewData["ReportModel"] = this.GetModel();

            return View();
        }
        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ViewReport(ReportViewerParams param)
        {
            return new ReportViewerHtmlActionResult(this.GetModel(), param);
        }
        
        ReportViewerModel GetModel()
        {
            ReportViewerModel reportModel = new ReportViewerModel();
            reportModel.ReportPath = Server.MapPath("~/App_Data/Sample.rdl");
            return reportModel;
        }
    }
}
