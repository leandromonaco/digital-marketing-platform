using DigitalMarketing.Core.Database;
using DigitalMarketing.Model;
using DigitalMarketing.Model.Events;
using DigitalMarketing.Model.Settings;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DigitalMarketing.Model.Extensions;

namespace DigitalMarketing.Core.Controller
{
    public class ApiController
    {
        public static async Task ImportStagingConfigurationAsync(string filename, DateTime lastModified, string jsonContent, bool isPromoted)
        {
            DatabaseRepository databaseRepository = new DatabaseRepository();
            await databaseRepository.ImportStagingConfigurationAsync(filename, lastModified, jsonContent, isPromoted);
        }

        public static async Task DownloadFile(Guid tenantId, SendGridConfiguration sendGridConfiguration, TouchPointEvent touchPointEvent, string downloadUrl) 
        {
            DatabaseRepository databaseRepository = new DatabaseRepository();
            touchPointEvent.EventType = TouchPointEventType.DownloadFile;

            Customer customer = new Customer();

            customer.TenantId = tenantId;
            customer.Name = touchPointEvent.FirstName;
            customer.Email = touchPointEvent.Email;

            await databaseRepository.SaveCustomer(customer);

            Touchpoint newEvent = new Touchpoint()
            {
                Id = Guid.NewGuid(),
                CustomerId = customer.Id,
                Description = JsonSerializer.Serialize(touchPointEvent)
            };

            var client = new SendGridClient(sendGridConfiguration.Key);
            var fromEmail = new EmailAddress(sendGridConfiguration.AuthorizedSenderEmail);
            var toEmail = new EmailAddress(touchPointEvent.Email);

            //string html = System.IO.File.ReadAllText(@"D:\Build\GitHub\DigitalMarketingPlatform\docs\emails\DownloadFile.html");
            //html = html.Replace("{FirstName}", touchPointEvent.FirstName)
            //           .Replace("{DownloadUrl}", downloadUrl);

            var msg = MailHelper.CreateSingleEmail(fromEmail, toEmail, "¡Tu brochure está aquí!", $@"Puedes descargar tu brochure haciendo clic <a href=""{downloadUrl}"">aquí</a>", $@"Puedes descargar tu brochure haciendo clic <a href=""{downloadUrl}"">aquí</a>");
            msg.ReplyTo = new EmailAddress(touchPointEvent.Email);
            var emailResponse = await client.SendEmailAsync(msg);

            if (emailResponse.StatusCode.ToString().Equals("Accepted"))
            {
                newEvent.IsEmailDelivered = true;
            }

            await databaseRepository.SaveTouchpoint(newEvent);
        }

        public static async Task SendMessage(Guid tenantId, SendGridConfiguration sendGridConfiguration, TouchPointEvent touchPointEvent)
        {
            DatabaseRepository databaseRepository = new DatabaseRepository();
            var client = new SendGridClient(sendGridConfiguration.Key);
            var authorizedSenderEmail = new EmailAddress(sendGridConfiguration.AuthorizedSenderEmail);
            var subject = "Webpage Contact";


            //dynamic customData = new ExpandoObject();
            //customData.Message = _message;
            //customData.ProductId = _productId;
            //_touchPointEvent.CustomData = customData;

            var plainTextContent = $@"<b>Nombre:</b> {touchPointEvent.FirstName} <br/>
                      <b>Email:</b> {touchPointEvent.Email} <br/>
                      <b>Telefono:</b> {touchPointEvent.Phone} <br/>
                      <b>Ciudad:</b> {touchPointEvent.City} <br/>
                      <b>Como nos conocio:</b> {touchPointEvent.Source} <br/>
                      <b>Mensaje:</b> {touchPointEvent.Message} <br/>";
            var htmlContent = plainTextContent;

            Customer customer = new Customer();

            customer.TenantId = tenantId;
            customer.Name = touchPointEvent.FirstName;
            customer.Email = touchPointEvent.Email;

            await databaseRepository.SaveCustomer(customer);

            Touchpoint newEvent = new Touchpoint()
            {
                Id = Guid.NewGuid(),
                CustomerId = customer.Id,
                Description = JsonSerializer.Serialize(touchPointEvent)
            };

            var msg = MailHelper.CreateSingleEmail(authorizedSenderEmail, authorizedSenderEmail, subject, plainTextContent, htmlContent);
            msg.ReplyTo = new EmailAddress(touchPointEvent.Email);
            var emailResponse = await client.SendEmailAsync(msg);

            if (emailResponse.StatusCode.ToString().Equals("Accepted"))
            {
                newEvent.IsEmailDelivered = true;
            }

            await databaseRepository.SaveTouchpoint(newEvent);
        }
    }
}
