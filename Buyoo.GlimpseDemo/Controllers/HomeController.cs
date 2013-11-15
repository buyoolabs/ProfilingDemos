using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Buyoo.GlimpseDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            System.Diagnostics.Trace.Write("Entered Index Action", "HomeController");
            System.Diagnostics.Trace.TraceInformation("Adding some Trace Info", "HomeController");
            System.Diagnostics.Trace.TraceWarning("Warning: May explode anytime");
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            System.Diagnostics.Trace.TraceError("Boom Boom");

            GenerateStringByConcat();
            GenerateStringByBuilder();

            return View();
        }

        private string GenerateStringByConcat()
        {
            string result = String.Empty;
            int n = 999;
            for (int i = 0; i < n; i++)
            {
                result += i.ToString();
            }

            return result;
        }

        private string GenerateStringByBuilder()
        {

            StringBuilder stringBuilder = new StringBuilder();
            int n = 999;
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(i);
            }

            return stringBuilder.ToString();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
