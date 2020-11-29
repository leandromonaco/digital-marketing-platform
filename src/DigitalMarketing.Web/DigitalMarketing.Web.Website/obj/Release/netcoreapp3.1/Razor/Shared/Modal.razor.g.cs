#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031f5507c6c95e0265ef1be5d082399fe34a8cb8"
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
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "dialog");
            __builder.AddElementReferenceCapture(1, (__value) => {
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\Modal.razor"
              _element = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(2, 
#nullable restore
#line 3 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\Modal.razor"
                         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\Shared\Modal.razor"
       
    private DotNetObjectReference<Modal> _this;
    private ElementReference _element;

    // Content of the dialog
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public bool Open { get; set; }

    // This parameter allows to use @bind-Open=... as explained in the previous post
    // https://www.meziantou.net/two-way-binding-in-blazor.htm
    [Parameter]
    public EventCallback<bool> OpenChanged { get; set; }

    [Parameter]
    public EventCallback<string> Close { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        // Initialize the dialog events the first time th ecomponent is rendered
        if (firstRender)
        {
            _this = DotNetObjectReference.Create(this);
            await JSRuntime.InvokeVoidAsync("blazorInitializeModal", _element, _this);
        }

        if (Open)
        {
            await JSRuntime.InvokeVoidAsync("blazorOpenModal", _element);
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("blazorCloseModal", _element);
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    [JSInvokable]
    public async Task OnClose(string returnValue)
    {
        if (Open == true)
        {
            Open = false;
            await OpenChanged.InvokeAsync(Open);
        }

        await Close.InvokeAsync(returnValue);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
