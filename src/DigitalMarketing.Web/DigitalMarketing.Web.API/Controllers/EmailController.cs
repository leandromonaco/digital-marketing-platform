using AgilityManager.API.Model.SendGrid;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AgilityManager.API.Controllers
{
    [Route("v1/email")]
    public class EmailController : ControllerBase
    {
        //https://app.sendgrid.com/settings/mail_settings
        //https://sendgrid.com/docs/API_Reference/Event_Webhook/event.html#processed

        [HttpPost]
        [Route("event")]
        public IActionResult CaptureEmailEvent()
        {
            var reader = new System.IO.StreamReader(HttpContext.Request.Body);
            string rawSendGridJSON = reader.ReadToEnd();
            List<SendGridEvents> sendGridEvents = JsonConvert.DeserializeObject<List<SendGridEvents>>(rawSendGridJSON);
            string count = sendGridEvents.Count.ToString();
            System.Diagnostics.Trace.TraceError(rawSendGridJSON); // For debugging to the Azure Streaming logs
            foreach (SendGridEvents sendGridEvent in sendGridEvents)
            {
                var emailEvent = new EmailEvent()
                {
                    Id = sendGridEvent.id,
                    EventTime = DateTime.UtcNow,
                    Email = sendGridEvent.email,
                    EventId = sendGridEvent.sendgrid_event_id,
                    Event = sendGridEvent.sendgrid_event,
                    Category = sendGridEvent.category,
                    IpAddress = sendGridEvent.ip,
                    Reason = sendGridEvent.reason,
                    MessageId = sendGridEvent.sg_message_id,
                    SmtpId = sendGridEvent.smtp_id,
                    Status = sendGridEvent.status,
                    Timestamp = sendGridEvent.timestamp,
                    Type = sendGridEvent.type,
                    Uid = sendGridEvent.uid,
                    Url = sendGridEvent.url,
                    UserAgent = sendGridEvent.useragent
                };

                //_dataContext.EmailEvents.Add(emailEvent);
                //_dataContext.SaveChanges();
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult SendEmail(string tenantDomain)
        {
            return Ok();
        }
    }
}