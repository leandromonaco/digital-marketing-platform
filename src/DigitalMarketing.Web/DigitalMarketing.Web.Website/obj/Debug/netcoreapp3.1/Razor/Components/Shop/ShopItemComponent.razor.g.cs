#pragma checksum "D:\Build\AgilityManager\DigitalMarketing\src\DigitalMarketing.Web\DigitalMarketing.Web.Website\Components\Shop\ShopItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43757ee812a3f911a1c2579b5746b545ec9af443"
// <auto-generated/>
#pragma warning disable 1591
namespace DigitalMarketing.Web.Website.Components.Shop
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
    public partial class ShopItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-md-3 hidden-sm\"><div class=\"widget\"><h6 class=\"title\">Shop Categories</h6>\r\n                    <hr>\r\n                    <ul class=\"link-list\"><li><a href=\"#\">Bags</a></li>\r\n                        <li><a href=\"#\">Accessories</a></li>\r\n                        <li><a href=\"#\">Shirts</a></li>\r\n                        <li><a href=\"#\">Trousers</a></li></ul></div>\r\n                \r\n                <div class=\"widget\"><h6 class=\"title\">Search Shop</h6>\r\n                    <hr>\r\n                    <form><input class=\"mb0\" type=\"text\" placeholder=\"Type Here\"></form></div>\r\n                \r\n                <div class=\"widget\"><h6 class=\"title\">Popular Items</h6>\r\n                    <hr>\r\n                    <ul class=\"cart-overview\"><li><a href=\"#\"><img alt=\"Product\" src=\"img/shop-product-7.jpg\">\r\n                                <div class=\"description\"><span class=\"product-title\">Vladimir Flask</span>\r\n                                    <span class=\"price number\">$49.95</span></div></a></li>\r\n                        <li><a href=\"#\"><img alt=\"Product\" src=\"img/shop-product-13.jpg\">\r\n                                <div class=\"description\"><span class=\"product-title\">Bradley Journal</span>\r\n                                    <span class=\"price number\">$29.95</span></div></a></li></ul></div>\r\n                \r\n                <div class=\"widget\"><h6 class=\"title\">Returns Policy</h6>\r\n                    <hr>\r\n                    <p>\r\n                        Sed ut perspiciatis unde omnis iste natus error sit voluptatem antium doloremque laudantium, totam rem aperiam, eaque ipsa quae.\r\n                    </p></div></div>\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-9");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "product-single");
            __builder.AddMarkupContent(10, "<div class=\"row mb24 mb-xs-48\"><div class=\"col-sm-6\"><div class=\"image-slider slider-thumb-controls controls-inside\"><span class=\"label\">Sale</span>\r\n\r\n                                <div class=\"flex-viewport\" style=\"overflow: hidden; position: relative;\"><ul class=\"slides\" style=\"width: 1000%; transition-duration: 0.6s; transform: translate3d(-1227px, 0px, 0px);\"><li data-thumb=\"img/shop-product-4_2.jpg\" class=\"clone\" aria-hidden=\"true\" style=\"width: 409px; float: left; display: block;\"><img alt=\"Image\" src=\"img/shop-product-4_2.jpg\" draggable=\"false\"></li>\r\n                                        <li data-thumb=\"img/shop-product-4.jpg\" class style=\"width: 409px; float: left; display: block;\"><img alt=\"Image\" src=\"img/shop-product-4.jpg\" draggable=\"false\"></li>\r\n                                        <li data-thumb=\"img/shop-product-4_1.jpg\" class style=\"width: 409px; float: left; display: block;\"><img alt=\"Image\" src=\"img/shop-product-4_1.jpg\" draggable=\"false\"></li>\r\n                                        <li data-thumb=\"img/shop-product-4_2.jpg\" class=\"flex-active-slide\" style=\"width: 409px; float: left; display: block;\"><img alt=\"Image\" src=\"img/shop-product-4_2.jpg\" draggable=\"false\"></li>\r\n                                        <li data-thumb=\"img/shop-product-4.jpg\" class=\"clone\" aria-hidden=\"true\" style=\"width: 409px; float: left; display: block;\"><img alt=\"Image\" src=\"img/shop-product-4.jpg\" draggable=\"false\"></li></ul></div><ol class=\"flex-control-nav flex-control-thumbs\"><li><img src=\"img/shop-product-4.jpg\" class draggable=\"false\"></li><li><img src=\"img/shop-product-4_1.jpg\" draggable=\"false\" class></li><li><img src=\"img/shop-product-4_2.jpg\" draggable=\"false\" class=\"flex-active\"></li></ol><ul class=\"flex-direction-nav\"><li><a class=\"flex-prev\" href=\"#\">Previous</a></li><li><a class=\"flex-next\" href=\"#\">Next</a></li></ul></div></div>\r\n                        <div class=\"col-sm-6\"><div class=\"description\"><h4 class=\"uppercase\">Logan - Sturdy Canvas Black Backpack</h4>\r\n                                <div class=\"mb32 mb-xs-24\"><span class=\"number price old-price\">$149.95</span>\r\n                                    <span class=\"number price\">$119.95</span></div>\r\n                                <p>\r\n                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis.\r\n                                </p>\r\n                                <ul><li><strong>SKU:</strong> 8660\r\n                                    </li>\r\n                                    <li><strong>COLOURS:</strong> Black, Blue\r\n                                    </li>\r\n                                    <li><strong>SIZES:</strong> XS,S,M,L,XL\r\n                                    </li></ul></div>\r\n                            <hr class=\"mb48 mb-xs-24\">\r\n                            <form class=\"add-to-cart\"><input type=\"text\" placeholder=\"QTY\">\r\n                                <input type=\"submit\" value=\"Add To Cart\"></form></div></div>\r\n                    \r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-12");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "tabbed-content text-tabs");
            __builder.AddMarkupContent(17, @"<ul class=""tabs""><li class=""active""><div class=""tab-title""><span>Description</span></div></li>
                                    <li><div class=""tab-title""><span>Size Guide</span></div></li>
                                    <li><div class=""tab-title""><span>Ratings</span></div></li></ul>
                                ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "content");
            __builder.AddMarkupContent(20, @"<li class=""active""><div class=""tab-content""><p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident.
                                            </p></div></li>
                                    ");
            __builder.AddMarkupContent(21, @"<li><div class=""tab-content""><table class=""table table-striped table-bordered""><thead><tr><th>Size</th>
                                                        <th>Measurement</th></tr></thead>
                                                <tbody><tr><th scope=""row"">Small</th>
                                                        <td><span class=""number"">16""</span> Neck /
                                                            <span class=""number"">8""</span> Sleeve
                                                        </td></tr>
                                                    <tr><th scope=""row"">Medium</th>
                                                        <td><span class=""number"">18""</span> Neck /
                                                            <span class=""number"">9""</span> Sleeve
                                                        </td></tr>
                                                    <tr><th scope=""row"">Large</th>
                                                        <td><span class=""number"">20""</span> Neck /
                                                            <span class=""number"">10""</span> Sleeve
                                                        </td></tr></tbody></table></div></li>
                                    ");
            __builder.OpenElement(22, "li");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "tab-content");
            __builder.AddMarkupContent(25, "<ul class=\"ratings\"><li><div class=\"user\"><ul class=\"list-inline star-rating\"><li><i class=\"ti-star\"></i></li>\r\n                                                            <li><i class=\"ti-star\"></i></li>\r\n                                                            <li><i class=\"ti-star\"></i></li>\r\n                                                            <li><i class=\"ti-star\"></i></li></ul>\r\n                                                        <span class=\"bold-h6\">Murray Rafferty</span>\r\n                                                        <span class=\"date number\">23/02/2015</span></div>\r\n                                                    <p>\r\n                                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.\r\n                                                    </p></li>\r\n                                                <li><div class=\"user\"><ul class=\"list-inline star-rating\"><li><i class=\"ti-star\"></i></li>\r\n                                                            <li><i class=\"ti-star\"></i></li>\r\n                                                            <li><i class=\"ti-star\"></i></li>\r\n                                                            <li><i class=\"ti-star\"></i></li>\r\n                                                            <li><i class=\"ti-star\"></i></li></ul>\r\n                                                        <span class=\"bold-h6\">Claire Taurus</span>\r\n                                                        <span class=\"date number\">15/02/2015</span></div>\r\n                                                    <p>\r\n                                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.\r\n                                                    </p></li></ul>\r\n                                            \r\n                                            ");
            __builder.AddMarkupContent(26, "<h6 class=\"uppercase\">Leave A Rating</h6>\r\n                                            ");
            __builder.OpenElement(27, "form");
            __builder.AddAttribute(28, "class", "ratings-form");
            __builder.AddMarkupContent(29, "<div class=\"overflow-hidden\"><input type=\"text\" placeholder=\"Your Name\">\r\n                                                    <input type=\"text\" placeholder=\"Email Address\"></div>\r\n                                                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "select-option");
            __builder.AddMarkupContent(32, "<i class=\"ti-angle-down\"></i>\r\n                                                    ");
            __builder.OpenElement(33, "select");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "selected", true);
            __builder.AddAttribute(36, "value", "Default");
            __builder.AddContent(37, "Select A Rating");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                                        ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "1");
            __builder.AddContent(41, "1 Star");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                                        ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "2");
            __builder.AddContent(45, "2 Stars");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                                        ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "3");
            __builder.AddContent(49, "3 Stars");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                                        ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "4");
            __builder.AddContent(53, "4 Stars");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                                        ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "5");
            __builder.AddContent(57, "5 Stars");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                                <textarea placeholder=\"Comment\" rows=\"3\"></textarea>\r\n                                                <input type=\"submit\" value=\"Leave Comment\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DigitalMarketing.Web.Model.TenantConfigurationSession SiteState { get; set; }
    }
}
#pragma warning restore 1591
