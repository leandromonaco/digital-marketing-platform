// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DigitalMarketing.Web.Website.Components.Basic
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
#line 1 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Components\Basic\ButtonComponent.razor"
using DigitalMarketing.Web.Model;

#line default
#line hidden
#nullable disable
    public partial class ButtonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Components\Basic\ButtonComponent.razor"
       

    [Parameter]
    public DigitalMarketing.Model.Settings.Section Section { get; set; }

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
