#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0a30b189c8bd36148939f6509824cd4c1e9370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OrderList), @"mvc.1.0.view", @"/Views/Admin/OrderList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\_ViewImports.cshtml"
using LearnMVC1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\_ViewImports.cshtml"
using LearnMVC1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\_ViewImports.cshtml"
using LearnMVC1.DAO.DAO.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\_ViewImports.cshtml"
using LearnMVC1.Models.EntityFramwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\_ViewImports.cshtml"
using LearnMVC1.Global;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0a30b189c8bd36148939f6509824cd4c1e9370", @"/Views/Admin/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tab.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tab.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
  
    List<OrderModel> waitingOrders = new List<OrderModel>();
    List<OrderModel> validOrders = new List<OrderModel>();
    List<OrderModel> inValidOrders = new List<OrderModel>();
    if (ViewData.ContainsKey("WaitingOrders"))
        waitingOrders = (List<OrderModel>)ViewData["WaitingOrders"];
    if (ViewData.ContainsKey("ValidOrders"))
        validOrders = (List<OrderModel>)ViewData["ValidOrders"];
    if (ViewData.ContainsKey("InValidOrders"))
        inValidOrders = (List<OrderModel>)ViewData["InValidOrders"];


#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f0a30b189c8bd36148939f6509824cd4c1e93705633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""tab"">
    <button class=""tablinks defaultOpen"" onclick=""openTab(event,'ordersWaiting')""
            id=""default"">
        Waiting Orders
    </button>
    <button class=""tablinks"" onclick=""openTab(event,'ordersAccepted')"">Accepted Orders</button>
    <button class=""tablinks"" onclick=""openTab(event,'ordersDeclined')"">Declined Orders</button>
</div>
<br>
<br>

<div id=""ordersWaiting"" class=""tabcontents"">
    <table class=""table table-bordered text-center mb-0"">
        <thead class=""text-dark bg-warning"">
            <tr>
                <th>OrderId</th>
                <th>UserId</th>
                <th>Buy Date</th>
                <th>Status</th>
                <th>Address</th>
                <th>PhoneNumber</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody class=""align-middle"">
");
#nullable restore
#line 41 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
             foreach (OrderModel order in waitingOrders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a class=\"text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 1630, "\"", 1681, 2);
            WriteAttributeValue("", 1637, "/Admin/Order/Detail?orderId=", 1637, 28, true);
#nullable restore
#line 44 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
WriteAttributeValue("", 1665, order.OrderId, 1665, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Order");
#nullable restore
#line 44 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                                                                                                             Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>Account");
#nullable restore
#line 45 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                           Write(order.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderBuyDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2050, "\"", 2122, 3);
            WriteAttributeValue("", 2057, "/Admin/Order/ChangeStatus?orderId=", 2057, 34, true);
#nullable restore
#line 51 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
WriteAttributeValue("", 2091, order.OrderId, 2091, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2107, "&status=InValid", 2107, 15, true);
            EndWriteAttribute();
            WriteLiteral(">Mark Invalid</a>\r\n                        <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("href", " href=\"", 2199, "\"", 2269, 3);
            WriteAttributeValue("", 2206, "/Admin/Order/ChangeStatus?orderId=", 2206, 34, true);
#nullable restore
#line 52 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
WriteAttributeValue("", 2240, order.OrderId, 2240, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2256, "&status=Valid", 2256, 13, true);
            EndWriteAttribute();
            WriteLiteral(">Mark Valid</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <br>
    <br>
</div>

<div id=""ordersAccepted"" class=""tabcontents"">
    <table class=""table table-bordered text-center mb-0"">
        <thead class=""text-dark bg-success"">
            <tr>
                <th>OrderId</th>
                <th>UserId</th>
                <th>Buy Date</th>
                <th>Status</th>
                <th>Address</th>
                <th>PhoneNumber</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody class=""align-middle"">
");
#nullable restore
#line 77 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
             foreach (OrderModel order in validOrders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a class=\"text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 3049, "\"", 3100, 2);
            WriteAttributeValue("", 3056, "/Admin/Order/Detail?orderId=", 3056, 28, true);
#nullable restore
#line 80 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
WriteAttributeValue("", 3084, order.OrderId, 3084, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Order");
#nullable restore
#line 80 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                                                                                                             Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>Account");
#nullable restore
#line 81 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                           Write(order.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderBuyDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 85 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 3469, "\"", 3541, 3);
            WriteAttributeValue("", 3476, "/Admin/Order/ChangeStatus?orderId=", 3476, 34, true);
#nullable restore
#line 87 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
WriteAttributeValue("", 3510, order.OrderId, 3510, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3526, "&status=InValid", 3526, 15, true);
            EndWriteAttribute();
            WriteLiteral(">Mark Invalid</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 90 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <br>
    <br>
</div>

<div id=""ordersDeclined"" class=""tabcontents"">
    <table class=""table table-bordered text-center mb-0"">
        <thead class=""text-dark bg-danger"">
            <tr>
                <th>OrderId</th>
                <th>UserId</th>
                <th>Buy Date</th>
                <th>Status</th>
                <th>Address</th>
                <th>PhoneNumber</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody class=""align-middle"">
");
#nullable restore
#line 112 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
             foreach (OrderModel order in inValidOrders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a class=\"text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 4324, "\"", 4375, 2);
            WriteAttributeValue("", 4331, "/Admin/Order/Detail?orderId=", 4331, 28, true);
#nullable restore
#line 115 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
WriteAttributeValue("", 4359, order.OrderId, 4359, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Order");
#nullable restore
#line 115 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                                                                                                             Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>Account");
#nullable restore
#line 116 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                           Write(order.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 117 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderBuyDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 118 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 119 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 120 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
                   Write(order.OrderPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("href", " href=\"", 4745, "\"", 4815, 3);
            WriteAttributeValue("", 4752, "/Admin/Order/ChangeStatus?orderId=", 4752, 34, true);
#nullable restore
#line 122 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"
WriteAttributeValue("", 4786, order.OrderId, 4786, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4802, "&status=Valid", 4802, 13, true);
            EndWriteAttribute();
            WriteLiteral(">Mark Valid</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 125 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderList.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <br>\r\n    <br>\r\n</div>\r\n<a class=\"btn btn-primary\" href=\"/common/product/list\">Back</a>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0a30b189c8bd36148939f6509824cd4c1e937019902", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591