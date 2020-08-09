using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HotelBooking_Assignment.Utils
{
    public class EmailSender
    {
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "HotelBooking.com");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);


        }
        public void SendMul(ArrayList receipents, String subject, String contents)
        {
            List<EmailAddress> mysendList = new List<EmailAddress>();
            for (int i = 0; i < receipents.Count; i++) {
                EmailAddress em= new EmailAddress(receipents[i].ToString(), "HotelBooking.com");

                //em = new EmailAddress(receipents[i].ToString(), "HotelBooking.com");
                mysendList.Add(em);
            }

            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "HotelBooking.com");
           // var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, mysendList, subject, plainTextContent, htmlContent);


            string filePath = HttpContext.Current.Request.MapPath("~/Utils/Attachments/29339472_Studio_Assessment_Task 3.pdf");
            var data = File.ReadAllBytes(filePath);
            var file = Convert.ToBase64String(data);
            msg.AddAttachment("29339472_Studio_Assessment_Task 3.pdf", file);

            var response = client.SendEmailAsync(msg);
        }
    }
}