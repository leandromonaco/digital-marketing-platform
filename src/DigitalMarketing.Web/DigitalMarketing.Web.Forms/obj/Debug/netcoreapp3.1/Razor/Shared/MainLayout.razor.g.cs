#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b1cacaa09580cb06c7643631f93f95fb1992cb8"
// <auto-generated/>
#pragma warning disable 1591
namespace DigitalMarketing.Web.Forms.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using DigitalMarketing.Web.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\_Imports.razor"
using DigitalMarketing.Web.Forms.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<DigitalMarketing.Web.Forms.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content px-4");
            __builder.AddContent(8, 
#nullable restore
#line 9 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Forms\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
