using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApmathAzureCloudLarisa.Controllers
{
    public class HomeController : Controller
    {
        public string text = "Test";
        public double[] Haha(double[,] x)
        {
            /*
                        double[,] y = new double[3, 3];
                        y[0, 0] = 2;
                        y[0, 1] = -1;
                        y[0, 2] = -1;
                        y[1, 0] = 3;
                        y[1, 1] = -2;
                        y[1, 2] = -3;
                        y[2, 0] = -1;
                        y[2, 1] = 1;
                        y[2, 2] = 2;
            */
            int length = Convert.ToInt32( Math.Sqrt(Convert.ToDouble(x.Length)));
            double[] d = new double[length];
            double[,] z = new double[x.Length, x.Length];
            //        alglib.evd.smatrixevd(x, Convert.ToInt32(Math.Sqrt(x.Length)),0,false,ref d,ref z);
            alglib.evd.smatrixevd(x, length, 0, false, ref d, ref z);
            return d;
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
    }
}