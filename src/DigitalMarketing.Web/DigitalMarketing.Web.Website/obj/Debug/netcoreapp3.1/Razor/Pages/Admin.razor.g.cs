#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "064d61267bcf754e8c9afe6ba9ffa1d1f620f754"
// <auto-generated/>
#pragma warning disable 1591
namespace DigitalMarketing.Web.Website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using DigitalMarketing.Web.Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using DigitalMarketing.Web.Website.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Web.Website.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Web.Website.Components.CTA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Web.Website.Components.Countdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Web.Website.Components.Pricing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Web.Website.Components.Tabs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Model.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
using DigitalMarketing.Model.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Admin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Single file</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>A single file input that uploads automatically on file selection</p>\r\n\r\n");
            __builder.OpenComponent<BlazorInputFile.InputFile>(2);
            __builder.AddAttribute(3, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 21 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
                     HandleSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 23 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
    status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", "data:image/webp;base64," + (
#nullable restore
#line 25 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
                                  _base64

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Pages\Admin.razor"
       
    string status;
    string _base64;

    async Task HandleSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            var b = ms.ToArray();

            _base64 = Convert.ToBase64String(b, 0, b.Length);

            status = $"Finished loading {file.Size} bytes from {file.Name} {_base64}";
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DigitalMarketing.Web.Model.TenantConfigurationSession SiteState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DigitalMarketing.Model.DatabaseRepository DatabaseRepository { get; set; }
    }
}
#pragma warning restore 1591
