using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace AgilityManager.API.Controllers
{
    [Route("v1/sms")]
    public class SMSController
    {
        [HttpPost]
        public void SendSms()
        {
            //TODO
            const string accountSid = "Stored in User Secrets";
            const string authToken = "Stored in User Secrets";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "test",
                from: new Twilio.Types.PhoneNumber("+61488851111"),
                to: new Twilio.Types.PhoneNumber("+61423031111")
            );
        }
    }
}