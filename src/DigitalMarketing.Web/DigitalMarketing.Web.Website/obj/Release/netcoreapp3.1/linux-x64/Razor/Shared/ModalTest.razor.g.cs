#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25459f41d8f91315bcc2cc6139047bd0a0ddefc3"
// <auto-generated/>
#pragma warning disable 1591
namespace DigitalMarketing.Web.Shared
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/modaltest")]
    public partial class ModalTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
                  e => IsModalOpened = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Open modal");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 5 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
 if (SelectedButton != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "You have selected ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
                          SelectedButton

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 8 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
}


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DigitalMarketing.Web.Shared.Modal>(9);
            __builder.AddAttribute(10, "Close", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 11 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
                                         OnClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
                   IsModalOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsModalOpened = __value, IsModalOpened))));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "foundry_modal text-center reveal-modal");
                __builder2.AddAttribute(17, "modal-link", "2");
                __builder2.AddAttribute(18, "method", "dialog");
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "i");
                __builder2.AddAttribute(21, "class", "ti-close close-modal");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
                                                  CancelModal

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddMarkupContent(24, "<h3 class=\"uppercase\">Sign Up &amp; Be Cool.</h3>\r\n        ");
                __builder2.AddMarkupContent(25, "<p class=\"lead mb48\">\r\n            Stay in the loop with our awesome newsletter. We\'ll send you monthly\r\n            <br> updates of our latest and greatest tools and resources.\r\n        </p>\r\n        ");
                __builder2.OpenElement(26, "form");
                __builder2.AddAttribute(27, "class", "form-newsletter halves");
                __builder2.AddAttribute(28, "data-success", "Thanks for your registration, we will be in touch shortly.");
                __builder2.AddAttribute(29, "data-error", "Please fill all fields correctly.");
                __builder2.AddMarkupContent(30, "\r\n            <input type=\"text\" name=\"email\" class=\"mb0 validate-email validate-required  signup-email-field\" placeholder=\"Email Address\">\r\n            ");
                __builder2.OpenElement(31, "a");
                __builder2.AddAttribute(32, "class", "btn btn-lg btn-filled");
                __builder2.AddAttribute(33, "href", "#");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
                                                                ButtonClicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(35, "Download");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\ModalTest.razor"
      
    public bool IsModalOpened { get; set; }
    public string SelectedButton { get; set; }

    void OnClose(string value)
    {
        SelectedButton = value;
    }

    void CancelModal()
    {
        IsModalOpened = false;
    }

    void ButtonClicked()
    {
        //TODO: Execute Call-To-Action
        IsModalOpened = false;
        OnClose("ss");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
