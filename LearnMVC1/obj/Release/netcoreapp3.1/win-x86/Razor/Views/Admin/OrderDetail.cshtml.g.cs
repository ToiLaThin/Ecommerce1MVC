#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f429cf5b4664db783c5774e2479783e417d655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OrderDetail), @"mvc.1.0.view", @"/Views/Admin/OrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f429cf5b4664db783c5774e2479783e417d655", @"/Views/Admin/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderItemModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
     
    decimal totalPrice = 0;
    int orderId = -1;
    if (ViewData.ContainsKey("OrderId"))
        orderId = (int)ViewData["OrderId"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css\" rel=\"stylesheet\">\r\n\r\n<div class=\"text-center mb-4 text-danger\">\r\n    <h2 class=\"section-title px-5\">\r\n        <span class=\"px-2\">Order");
#nullable restore
#line 13 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                            Write(orderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
    </h2>
</div>
<div class=""container mb-4"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""table-responsive"">
                <table class=""table table-bordered text-center mb-0"">
                    <thead class=""bg-secondary text-dark"">
                        <tr>
                            <th>Products</th>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Total</th>

                        </tr>
                    </thead>

                    <c:set var=""finalPrice"" value=""0"" />
                    <tbody class=""align-middle"">
");
#nullable restore
#line 34 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                         foreach(OrderItemModel orderItem in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"align-middle\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1356, "\"", 1402, 1);
#nullable restore
#line 38 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
WriteAttributeValue("", 1362, orderItem.OrderItemProduct.ProductImage, 1362, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n                                </td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 40 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                                                    Write(orderItem.OrderItemProduct.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 41 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                                                    Write(orderItem.OrderItemProduct.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("€</td>\r\n\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 43 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                                                    Write(orderItem.OrderItemQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 44 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                                                     Write(orderItem.OrderItemProduct.ProductPrice * orderItem.OrderItemQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n");
#nullable restore
#line 46 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                            totalPrice += orderItem.OrderItemProduct.ProductPrice * orderItem.OrderItemQuantity;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <td class=""align-middle""></td>
                            <td class=""align-middle""></td>
                            <td class=""align-middle""></td>
                            <td class=""align-middle""><b class=""text-danger"">Total</b></td>
                            <td class=""align-middle""><b class=""text-success"">");
#nullable restore
#line 53 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\OrderDetail.cshtml"
                                                                        Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</b></td>\r\n                        </tr>\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
