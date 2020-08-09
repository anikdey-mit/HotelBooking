using HotelBooking_Assignment.Models;
using HotelBooking_Assignment.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.IO;

namespace HotelBooking_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private object filePath;

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

        
        public ActionResult Send_Email()
        {
            return View(new SendEmail());
        }

        [HttpPost]
        public ActionResult Send_Email(SendEmail model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    String toEmail = model.ToEmail;
                    String subject = model.Subject;
                    String contents = model.Contents;

                    EmailSender es = new EmailSender();
                    es.Send(toEmail, subject, contents);

                    //ArrayList a = new ArrayList();
                    //a.Add("anik11ads@gmail.com");
                    //a.Add("adey0001@student.monash.edu");
                    //a.Add("miffy.wu@monash.edu");

                    //es.SendMul(a, subject, contents);

                    ViewBag.Result = "Email Sent.";

                    ModelState.Clear();

                    return View(new SendEmail());
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }
    }
}