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

            message.From = new MailAddress("info45fda525-3925-40c4-894e-768d951ca270@45fda525-3925-40c4-894e-768d951ca270chillycloud45fda525-3925-40c4-894e-768d951ca270.45fda525-3925-40c4-894e-768d951ca270com".Replace("45fda525-3925-40c4-894e-768d951ca270", string.Empty));

#if DEBUG
            message.To.Add(new MailAddress("txavier45fda525-3925-40c4-894e-768d951ca270@45fda525-3925-40c4-894e-768d951ca270gmail45fda525-3925-40c4-894e-768d951ca270.45fda525-3925-40c4-894e-768d951ca270com".Replace("45fda525-3925-40c4-894e-768d951ca270", string.Empty)));
#else 
            message.To.Add(new MailAddress("kenrick8145fda525-3925-40c4-894e-768d951ca270@45fda525-3925-40c4-894e-768d951ca270gmail45fda525-3925-40c4-894e-768d951ca270.45fda525-3925-40c4-894e-768d951ca270com".Replace("45fda525-3925-40c4-894e-768d951ca270", string.Empty)));
            message.To.Add(new MailAddress("sonia.euson45fda525-3925-40c4-894e-768d951ca270@45fda525-3925-40c4-894e-768d951ca270gmail45fda525-3925-40c4-894e-768d951ca270.45fda525-3925-40c4-894e-768d951ca270com".Replace("45fda525-3925-40c4-894e-768d951ca270", string.Empty)));
#endif

            message.Subject = "EducaTours - Email from " + emailInformation.name;

            message.Body = @"Name: " + emailInformation.name + "\n Address: " + emailInformation.address + 
                "\n Message: " + emailInformation.message;

            SmtpClient client = new SmtpClient();

            client.Send(message);

            return Ok();
        }
    }
}
