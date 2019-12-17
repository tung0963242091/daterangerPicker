using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Daterangepicker.Controllers
{
    public class DaterangePickerController : Controller
    {
        // GET: DaterangePicker
        public ActionResult Index(string start, string end)

        {

            var startTime = DateTime.Now;

            startTime = startTime.AddYears(-1);

            try

            {

                startTime = DateTime.Parse(start.ToString());

            }

            catch (Exception e)

            {

                Console.WriteLine(e);

            }



            var endTime = DateTime.Now;

            try

            {

                endTime = DateTime.Parse(end.ToString());

            }

            catch (Exception e)

            {

                Console.WriteLine(e);

            }

            ViewBag.Start = startTime;

            ViewBag.End = endTime;

            return View();

        }

    }
}