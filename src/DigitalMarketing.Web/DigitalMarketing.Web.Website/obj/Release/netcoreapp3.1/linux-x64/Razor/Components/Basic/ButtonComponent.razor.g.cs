#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "097979ea2a9e658f774ad1cd375900ec2c40467d"
// <auto-generated/>
#pragma warning disable 1591
namespace DigitalMarketing.Web.Components.Basic
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
#line 1 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
using DigitalMarketing.Web.Model;

#line default
#line hidden
#nullable disable
    public partial class ButtonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddMarkupContent(1, "\r\n.btn {\r\n    background: ");
            __builder.AddContent(2, 
#nullable restore
#line 6 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
                 _backgroundColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, ";\r\n    color: ");
            __builder.AddContent(4, 
#nullable restore
#line 7 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
            _color

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, ";\r\n}\r\n\r\n.btn:hover {\r\n    background: ");
            __builder.AddContent(6, 
#nullable restore
#line 11 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
                 _hoverBackgroundColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, ";\r\n    color: ");
            __builder.AddContent(8, 
#nullable restore
#line 12 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
            _hoverColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, ";\r\n}\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "class", "btn btn-lg");
            __builder.AddAttribute(13, "href", 
#nullable restore
#line 16 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
                             SiteState.Settings.Components.Cover.DownloadFile

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "target", "_blank");
            __builder.AddContent(15, 
#nullable restore
#line 16 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
                                                                                                Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Basic\ButtonComponent.razor"
       

    [Parameter]
    public string Text { get; set; }

    string _color;
    string _backgroundColor;
    string _hoverColor;
    string _hoverBackgroundColor;

    // although the title is set on loading, if it is changed by a component we
    // need to call StateHasChanged to trigger Blazor to rerender since the event
    // that triggered it is outside this component
    protected async override void OnInitialized()
    {
        _color = "#000000";
        _backgroundColor = "#808080";
        _hoverColor = "#808080";
        _hoverBackgroundColor = "#000000";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TenantConfigurationSession SiteState { get; set; }
    }
}
#pragma warning restore 1591
