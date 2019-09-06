using Dirty_money_ASP.NET_MVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace Dirty_money_ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        private static Data data = InitialData();
        private static List<string> positionsList = new List<string>() { "Машинист", "Оператор" };

        // 1,2,3 extruders
        const double mach420_459 = 0.34304;
        const double oper420_459 = 0.23757;

        const double mach460_549 = 0.27408;
        const double oper460_549 = 0.1897;

        const double mach550_600 = 0.24608;
        const double oper550_600 = 0.16973;

        const double mach601_999 = 0.1864;
        const double oper601_999 = 0.128;

        const double mach1000_1800 = 0.35776;
        const double oper1000_1800 = 0.24678;

        const double mach600_850_color = 0.22;
        const double oper600_850_color = 0.1527;

        const double mach1000_1800_color = 0.42112;
        const double oper1000_1800_color = 0.32692;

        // 4 extruder
        const double mach1000_1800_4EX = 0.548;
        const double oper1000_1800_4EX = 0.37786;

        const double mach1000_1800_color_4EX = 0.56448;
        const double oper1000_1800_color_4EX = 0.38925;
        // FBR(4 ex)
        const double mach1500_1700_FBR_4EX = 0.548;
        const double oper1500_1700_FBR_4EX = 0.37786;

        const double mach1500_1700_color_FBR_4EX = 0.56448;
        const double oper1500_1700_color_FBR_4EX = 0.38925;

        private static Data InitialData()
        {
            if (data == null)
            {
                data = new Data();
            }
            return data;
        }

        [HttpGet]
        public ActionResult Index()
        {
            SelectList positions = new SelectList(positionsList);
            ViewBag.pos = positions;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Data data)
        {
            SelectList positions = new SelectList(positionsList);
            ViewBag.pos = positions;

            double result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11 = 0;
            double sumSalary = 0;
            //420 - 440
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb440kg"] != "" && Request.Form["tb440rate"] != "")
                {
                    result1 = data.tb440kg * data.tb440rate * mach420_459;
                    data.tbCash1 = result1;
                    sumSalary += data.tbCash1;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb440kg"] != "" && Request.Form["tb440rate"] != "")
                {
                    result1 = data.tb440kg * data.tb440rate * oper420_459;
                    data.tbCash1 = result1;
                    sumSalary += data.tbCash1;
                    data.Total = sumSalary;
                }
            }
            //460 - 549
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb460kg"] != "" && Request.Form["tb460rate"] != "")
                {
                    result2 = data.tb460kg * data.tb460rate * mach460_549;
                    data.tbCash2 = result2;
                    sumSalary += data.tbCash2;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb460kg"] != "" && Request.Form["tb460rate"] != "")
                {
                    result2 = data.tb460kg * data.tb460rate * oper460_549;
                    data.tbCash2 = result2;
                    sumSalary += data.tbCash2;
                    data.Total = sumSalary;
                }
            }
            //550 - 600
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb560kg"] != "" && Request.Form["tb560rate"] != "")
                {
                    result3 = data.tb560kg * data.tb560rate * mach550_600;
                    data.tbCash3 = result3;
                    sumSalary += data.tbCash3;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb560kg"] != "" && Request.Form["tb560rate"] != "")
                {
                    result3 = data.tb560kg * data.tb560rate * oper550_600;
                    data.tbCash3 = result3;
                    sumSalary += data.tbCash3;
                    data.Total = sumSalary;
                }
            }
            //601 - 999
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb601kg"] != "" && Request.Form["tb601rate"] != "")
                {
                    result4 = data.tb601kg * data.tb601rate * mach601_999;
                    data.tbCash4 = result4;
                    sumSalary += data.tbCash4;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb601kg"] != "" && Request.Form["tb601rate"] != "")
                {
                    result4 = data.tb601kg * data.tb601rate * oper601_999;
                    data.tbCash4 = result4;
                    sumSalary += data.tbCash4;
                    data.Total = sumSalary;
                }
            }
            //1000 - 1800
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb1000kg"] != "" && Request.Form["tb1000rate"] != "")
                {
                    result5 = data.tb1000kg * data.tb1000rate * mach1000_1800;
                    data.tbCash5 = result5;
                    sumSalary += data.tbCash5;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb1000kg"] != "" && Request.Form["tb1000rate"] != "")
                {
                    result5 = data.tb1000kg * data.tb1000rate * oper1000_1800;
                    data.tbCash5 = result5;
                    sumSalary += data.tbCash5;
                    data.Total = sumSalary;
                }
            }
            //600 - 850 color
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb600colorkg"] != "" && Request.Form["tb600colorrate"] != "")
                {
                    result6 = data.tb600colorkg * data.tb600colorrate * mach600_850_color;
                    data.tbCash6 = result6;
                    sumSalary += data.tbCash6;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb600colorkg"] != "" && Request.Form["tb600colorrate"] != "")
                {
                    result6 = data.tb600colorkg * data.tb600colorrate * oper600_850_color;
                    data.tbCash6 = result6;
                    sumSalary += data.tbCash6;
                    data.Total = sumSalary;
                }
            }
            //1000 - 1800 color
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb1000colorkg"] != "" && Request.Form["tb1000colorrate"] != "")
                {
                    result7 = data.tb1000colorkg * data.tb1000colorrate * mach1000_1800_color;
                    data.tbCash7 = result7;
                    sumSalary += data.tbCash7;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb1000colorkg"] != "" && Request.Form["tb1000colorrate"] != "")
                {
                    result7 = data.tb1000colorkg * data.tb1000colorrate * oper1000_1800_color;
                    data.tbCash7 = result7;
                    sumSalary += data.tbCash7;
                    data.Total = sumSalary;
                }
            }
            //1000 - 1800 4ex
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb1000ex4kg"] != "" && Request.Form["tb1000ex4rate"] != "")
                {
                    result8 = data.tb1000ex4kg * data.tb1000ex4rate * mach1000_1800_4EX;
                    data.tbCash8 = result8;
                    sumSalary += data.tbCash8;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb1000ex4kg"] != "" && Request.Form["tb1000ex4rate"] != "")
                {
                    result8 = data.tb1000ex4kg * data.tb1000ex4rate * oper1000_1800_4EX;
                    data.tbCash8 = result8;
                    sumSalary += data.tbCash8;
                    data.Total = sumSalary;
                }
            }
            //1000 - 1800 4ex color
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb1000ex4colorkg"] != "" && Request.Form["tb1000ex4colorrate"] != "")
                {
                    result9 = data.tb1000ex4colorkg * data.tb1000ex4colorrate * mach1000_1800_color_4EX;
                    data.tbCash9 = result9;
                    sumSalary += data.tbCash9;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb1000ex4colorkg"] != "" && Request.Form["tb1000ex4colorrate"] != "")
                {
                    result9 = data.tb1000ex4colorkg * data.tb1000ex4colorrate * oper1000_1800_color_4EX;
                    data.tbCash9 = result9;
                    sumSalary += data.tbCash9;
                    data.Total = sumSalary;
                }
            }
            //1500 - 1700 4ex FBR
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb1500fbrkg"] != "" && Request.Form["tb1500fbrrate"] != "")
                {
                    result10 = data.tb1500fbrkg * data.tb1500fbrrate * mach1500_1700_FBR_4EX;
                    data.tbCash10 = result10;
                    sumSalary += data.tbCash10;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb1500fbrkg"] != "" && Request.Form["tb1500fbrrate"] != "")
                {
                    result10 = data.tb1500fbrkg * data.tb1500fbrrate * oper1500_1700_FBR_4EX;
                    data.tbCash10 = result10;
                    sumSalary += data.tbCash10;
                    data.Total = sumSalary;
                }
            }
            //1500 - 1700 4ex FBR color
            if (Request.Form["positions"] == "Машинист")
            {
                if (Request.Form["tb1500fbrcolorkg"] != "" && Request.Form["tb1500fbrcolorrate"] != "")
                {
                    result11 = data.tb1500fbrcolorkg * data.tb1500fbrcolorrate * mach1500_1700_color_FBR_4EX;
                    data.tbCash11 = result11;
                    sumSalary += data.tbCash11;
                    data.Total = sumSalary;
                }
            }
            if (Request.Form["positions"] == "Оператор")
            {
                if (Request.Form["tb1500fbrcolorkg"] != "" && Request.Form["tb1500fbrcolorrate"] != "")
                {
                    result11 = data.tb1500fbrcolorkg * data.tb1500fbrcolorrate * oper1500_1700_color_FBR_4EX;
                    data.tbCash11 = result11;
                    sumSalary += data.tbCash11;
                    data.Total = sumSalary;
                }
            }          
            return View(data);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}