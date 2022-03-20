using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ImageGear.Core;
using ImageGear.Evaluation;
using ImageGear.Formats;
using ImageGear.Formats.PDF;

namespace MVC_Project
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            ImGearEvaluationManager.Initialize();

            ImGearCommonFormats.Initialize();

            ImGearFileFormats.Filters.Insert(0, ImGearPDF.CreatePDFFormat(@"C:\Users\Kite\Documents\GitHub\Csharp-Stuff\MVC Project\MVC Project\bin\"));

            ImGearPDF.Initialize();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            ImGearPDF.Terminate();
        }
    }
}
