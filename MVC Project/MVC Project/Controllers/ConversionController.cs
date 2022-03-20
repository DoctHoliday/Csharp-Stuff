using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

using ImageGear.Core;
using ImageGear.Formats;
using ImageGear.Formats.PDF;

namespace MVC_Project.Controllers
{
    public class ConversionController : Controller
    {

        class ConvertDocumentOptions
        {
            private String filePath = String.Empty;
            public String InputPath
            {
                get { return filePath; }
                set { filePath = value; }
            }
            private String outputDirectory = String.Empty;
            public String OuputDir
            {
                get { return outputDirectory; }
                set { outputDirectory = value; }
            }
        }


        // GET: Conversion
        public ActionResult Index()
        {
            return View();
        }

        public void ProcessDocuments()
        {
            Queue<ConvertDocumentOptions> workQueue = new Queue<ConvertDocumentOptions>();

            string inputDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../Samples"));
            string outputDirectory = Path.Combine(inputDirectory, "Outputs");

            workQueue = CreateDocumentOptions(inputDirectory, outputDirectory);

        }


    }
}