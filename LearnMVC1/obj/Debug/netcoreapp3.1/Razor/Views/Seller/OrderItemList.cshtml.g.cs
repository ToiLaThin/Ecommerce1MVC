#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "316e843b08474f6ee695ff079ff039d2597f0fb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_OrderItemList), @"mvc.1.0.view", @"/Views/Seller/OrderItemList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316e843b08474f6ee695ff079ff039d2597f0fb7", @"/Views/Seller/OrderItemList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Seller_OrderItemList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
   
    List<OrderItemModel> waitingOrderItems = new List<OrderItemModel>();
    if (ViewData.ContainsKey("WaitingOrderItems"))
    {
        waitingOrderItems = (List<OrderItemModel>)ViewData["WaitingOrderItems"];
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""orderItemsWaiting"">
    <table class=""table table-bordered text-center mb-0"">
        <thead class=""text-dark bg-warning"">
            <tr>
                <th>OrderItemId</th>
                <th>Quantity</th>
                <th>Unit Price</th>
                <th>Product Name</th>
                <th>Product Image</th>
                <th>OrderId</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody class=""align-middle"">
");
#nullable restore
#line 22 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
             foreach(OrderItemModel orderItem in waitingOrderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>OrderItem");
#nullable restore
#line 25 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
                             Write(orderItem.OrderItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
                   Write(orderItem.OrderItemQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
                   Write(orderItem.OrderItemUnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
                   Write(orderItem.OrderItemProduct.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1101, "\"", 1147, 1);
#nullable restore
#line 29 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
WriteAttributeValue("", 1107, orderItem.OrderItemProduct.ProductImage, 1107, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n                    <td>");
#nullable restore
#line 30 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
                   Write(orderItem.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td>
                        <a class=""btn btn-sm btn-success"" href=""<%=request.getContextPath() %>/seller/orderItem/changeValid/?cartItemId=${orderItem.cartItemId}"">Mark Valid</a>
                    </td>
                </tr>
");
#nullable restore
#line 35 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Seller\OrderItemList.cshtml"
            }    

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <br>\r\n    <br>\r\n</div>\r\n\r\n\r\n<a class=\"btn btn-primary\" href=\"/Common/Product/List\">Back</a>\r\n");
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