#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f879ca3f175359adf8a7bebd17f25244a6eedc65"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DigitalMarketing.Web.Components.Form
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using DigitalMarketing.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using DigitalMarketing.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
using SendGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
using SendGrid.Helpers.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
using DigitalMarketing.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
using DigitalMarketing.Model.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
using DigitalMarketing.Web.Components.Basic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
using DigitalMarketing.Model.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
using DigitalMarketing.Web.Model;

#line default
#line hidden
#nullable disable
    public partial class ContactFormWithMapComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Form\ContactFormWithMapComponent.razor"
       
    [Parameter]
    public bool IsIFrame { get; set; }

    protected string _name;
    protected string _email;
    protected string _message;
    protected bool _isSent;

    //https://github.com/sample-by-jsakamoto/Blazor-UseGoogleReCAPTCHA
    private RecaptchaComponent reCaptcha;

    private bool ValidReCAPTCHA = false;

    private bool ServerVerificatiing = false;

    private void OnSuccess()
    {
        ValidReCAPTCHA = true;
    }

    private void OnExpired()
    {
        ValidReCAPTCHA = false;
    }

    private async Task SendMessage()
    {
        if (ValidReCAPTCHA)
        {
            var response = await reCaptcha.GetResponseAsync();
            try
            {
                ServerVerificatiing = true;
                StateHasChanged();
                var result = await DigitalMarketing.Web.Model.reCaptchaValidator.Validate(response);

                if (result.Success)
                {
                    var client = new SendGridClient(SiteState.Settings.ThirdPartyServices.SendGrid.Key);
                    var authorizedSenderEmail = new EmailAddress(SiteState.Settings.ThirdPartyServices.SendGrid.AuthorizedSenderEmail);
                    var subject = "Webpage Contact";

                    var plainTextContent = $@"Name: {_name} \n
                                          Email: {_email} \n
                                          Message: {_message}";
                    var htmlContent = plainTextContent;

                    Customer customer = new Customer();
                    customer.Id = Guid.NewGuid();
                    customer.TenantId = SiteState.Id;
                    customer.Name = _name;
                    customer.Email = _email;

                    await DatabaseRepository.SaveCustomer(customer);

                    Touchpoint newEvent = new Touchpoint()
                    {
                        Id = Guid.NewGuid(),
                        TenantId = SiteState.Id,
                        CustomerId = customer.Id,
                        Message = $"[WEBSITE_CONTACT] {_message}"
                    };

                    await DatabaseRepository.SaveTouchpoint(newEvent);

                    var msg = MailHelper.CreateSingleEmail(authorizedSenderEmail, authorizedSenderEmail, subject, plainTextContent, htmlContent);
                    var emailResponse = await client.SendEmailAsync(msg);

                    if (true)
                    {
                        _isSent = true;//TODO: store flag in database
                    }

                }
                else
                {

                    throw new Exception("Invalid reCaptcha");
                }
            }
            catch (HttpRequestException e)
            {

            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TenantConfigurationSession SiteState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DigitalMarketing.Model.DatabaseRepository DatabaseRepository { get; set; }
    }
}
#pragma warning restore 1591
