#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e34bde75026b17b698b662b7be91d8117003e20"
// <auto-generated/>
#pragma warning disable 1591
namespace DigitalMarketing.Web.Components
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
#line 1 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor"
using DigitalMarketing.Model.Settings;

#line default
#line hidden
#nullable disable
    public partial class Gallery : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "bg-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-sm-12 text-center");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "h4");
            __builder.AddAttribute(13, "class", "uppercase mb16");
            __builder.AddContent(14, 
#nullable restore
#line 9 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor"
                                            SiteState.Settings.Components.Gallery.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "lead mb64");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.AddContent(19, 
#nullable restore
#line 11 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor"
                     SiteState.Settings.Components.Gallery.Paragraph

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-12");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "lightbox-grid square-thumbs");
            __builder.AddAttribute(32, "data-gallery-title", "Gallery");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "ul");
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 20 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor"
                         foreach (var image in @SiteState.Settings.Components.Gallery.Images)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                            ");
            __builder.OpenElement(37, "li");
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "background-image-holder");
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "img");
            __builder.AddAttribute(43, "alt", "image");
            __builder.AddAttribute(44, "class", "background-image");
            __builder.AddAttribute(45, "src", 
#nullable restore
#line 24 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor"
                                                                                    image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 27 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Components\Gallery.razor"
       

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeAsync<object>("SetGallery");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DigitalMarketing.Web.Model.TenantConfigurationSession SiteState { get; set; }
    }
}
#pragma warning restore 1591
