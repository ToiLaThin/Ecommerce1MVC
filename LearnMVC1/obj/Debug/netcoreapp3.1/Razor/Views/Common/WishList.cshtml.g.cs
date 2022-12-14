#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "065d60eb6a41966b7b7f64734ad292481eb831b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_WishList), @"mvc.1.0.view", @"/Views/Common/WishList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065d60eb6a41966b7b7f64734ad292481eb831b1", @"/Views/Common/WishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_WishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center mb-4 text-danger\">\r\n    <div class=\"display-1\"><i class=\"fas fa-heart\"></i></div>\r\n    <h2 class=\"section-title px-5\">\r\n        <span class=\"px-2\">Your Wishlist</span>\r\n    </h2>\r\n</div>\r\n");
#nullable restore
#line 9 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
 if(Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-xxl py-1 text-center"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-6"">
                <p class=""mb-4"">Empty. Would you like to add more product to wish list?</p>
                <a class=""btn btn-success rounded-pill py-3 px-5"" href=""/Common/Product/List"">Yes !!!</a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 19 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
}
else if(Model.Count > 0)
{    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container mb-4"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""table-responsive"">
                    <table class=""table table-striped  text-center mb-0"">
                        <thead>
                            <tr>
                                <th scope=""col""></th>
                                <th scope=""col"">Product</th>
                                <th scope=""col"" class=""text-right"">Price</th>
                                <th scope=""col"">Column</th>
                                <th scope=""col"">Action</th>
                            </tr>
                        </thead>
                        <tbody class=""align-middle"">
");
#nullable restore
#line 37 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
                             foreach(var product in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1586, "\"", 1613, 1);
#nullable restore
#line 40 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
WriteAttributeValue("", 1592, product.ProductImage, 1592, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n                                    <td>");
#nullable restore
#line 41 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
                                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-right\">");
#nullable restore
#line 42 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
                                                      Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"€</td>
                                    <td class=""text-center"">
                                        <a class=""btn btn-sm btn-warning"" href=""<%=request.getContextPath() %>/common/buyNow?productId=${product.productId }"">
                                            <i class=""fa fa-shopping-cart""></i>
                                        </a>
                                    </td>
                                    <td class=""text-center"">
                                        <a class=""btn btn-sm btn-danger""");
            BeginWriteAttribute("href", " href=\"", 2328, "\"", 2420, 4);
            WriteAttributeValue("", 2335, "/Common/WishList/Delete?productId=", 2335, 34, true);
#nullable restore
#line 49 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
WriteAttributeValue("", 2369, product.ProductId, 2369, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2387, "&accountId=", 2387, 11, true);
#nullable restore
#line 49 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
WriteAttributeValue("", 2398, GlobalVar.AccountId, 2398, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                                            <i class=\"fa fa-trash\"></i>\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 55 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""container-xxl py-5"">
            <div class=""container px-lg-5 text-center"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-6"">
                        <a class=""btn btn-success rounded-pill py-3 px-5""
                           href=""/Common/Product/List"">
                            Go Back To
                            Home
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 75 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\WishList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
