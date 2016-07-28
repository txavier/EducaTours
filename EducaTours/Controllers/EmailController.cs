using EducaTours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace EducaTours.Controllers
{
    [RoutePrefix("api/email")]
    public class EmailController : ApiController
    {
        [Route("sendMessage")]
        [HttpPost]
        public IHttpActionResult SendMessage(EmailInformation emailInformation)
        {
            MailMessage message = new MailMessage();

            message.From = new MailAddress("noreply@xaviersoftware.com");

            message.To.Add(new MailAddress("txavier@gmail.com"));
            
            message.Subject = "EducaTours - Email from " + emailInformation.name;

            message.Body = @"Name: " + emailInformation.name + "\n Address: " + emailInformation.address + 
                "\n Message: " + emailInformation.message;

            SmtpClient client = new SmtpClient();

            client.Send(message);

            return Ok();
        }
    }
}
