#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e65c1faba01176bd6d858102e4369828d7d4791f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_ProductFilterByCategory), @"mvc.1.0.view", @"/Views/Common/ProductFilterByCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e65c1faba01176bd6d858102e4369828d7d4791f", @"/Views/Common/ProductFilterByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_ProductFilterByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Shop Start -->\r\n<div class=\"container-fluid pt-5\">\r\n    <div class=\"row px-xl-5\">\r\n        <div class=\"text-center mb-4\">\r\n            <h2 class=\"section-title px-5\"><span class=\"px-2\">Product of category: ");
#nullable restore
#line 5 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                                                               Write((string)ViewData["CategoryName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span></h2>
        </div>


        <!-- Shop Product Start -->
        <div class=""col-lg-12 col-md-12"">
            <div class=""row pb-3"">
                <div class=""col-12 pb-1"">
                    <div class=""container-fluid mb-4 clearfix"">
                        <div class=""dropdown ml-4 float-right"">
                            <button class=""btn border dropdown-toggle"" type=""button"" id=""triggerId"" data-toggle=""dropdown"" aria-haspopup=""true""
                                    aria-expanded=""false"">
                                Sort by
                            </button>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""triggerId"">
                                <a class=""dropdown-item"" href=""#"">Latest</a>
                                <a class=""dropdown-item"" href=""#"">Popularity</a>
                                <a class=""dropdown-item"" href=""#"">Best Rating</a>
                            </div>
                        </div>");
            WriteLiteral("\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 29 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                 foreach (ProductModel product in Model)
                {
                    if(product.ProductStatus == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
                            <div class=""card product-item border-0 mb-4"">
                                <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                    <img style=""width:100%; height:254px;""");
            BeginWriteAttribute("src", " src=\"", 1878, "\"", 1905, 1);
#nullable restore
#line 36 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
WriteAttributeValue("", 1884, product.ProductImage, 1884, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"card-body border-left border-right text-center p-0 pt-4 pb-3\">\r\n                                    <h6 class=\"text-truncate mb-3\">");
#nullable restore
#line 39 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                                              Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <div class=\"d-flex justify-content-center\">\r\n                                        <h6>");
#nullable restore
#line 41 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                       Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h6>\r\n                                        <h6 class=\"text-muted ml-2\">\r\n                                            <del>");
#nullable restore
#line 43 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                            Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</del>\r\n                                        </h6>\r\n                                    </div>\r\n");
#nullable restore
#line 46 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                     if(product.ProductDescription.Length < 101)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h6>\r\n                                            <small class=\"text-muted mb-3\">");
#nullable restore
#line 49 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                                                      Write(product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </h6>\r\n");
#nullable restore
#line 51 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                    }
                                    else if(product.ProductDescription.Length >= 101)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h6>\r\n                                            <small class=\"text-muted mb-3\">");
#nullable restore
#line 55 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                                                      Write(product.ProductDescription.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</small>\r\n                                        </h6>\r\n");
#nullable restore
#line 57 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"card-footer d-flex justify-content-between bg-light border\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3485, "\"", 3543, 2);
            WriteAttributeValue("", 3492, "/Common/Product/Detail?productId=", 3492, 33, true);
#nullable restore
#line 60 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
WriteAttributeValue("", 3525, product.ProductId, 3525, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"btn btn-sm text-dark p-0\">\r\n                                        <i class=\"fas fa-eye text-primary mr-1\"></i>View Detail\r\n                                    </a> \r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3799, "\"", 3894, 4);
            WriteAttributeValue("", 3806, "<%=request.getContextPath()", 3806, 27, true);
            WriteAttributeValue(" ", 3833, "%>/common/cart?productId=", 3834, 26, true);
#nullable restore
#line 64 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
WriteAttributeValue("", 3859, product.ProductId, 3859, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3877, "&action=addToCart", 3877, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                            class=""btn btn-sm text-dark p-0"">
                                        <i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart
                                    </a>
                                </div>
                                <div class=""card-footer d-flex justify-content-between bg-light border"">
");
#nullable restore
#line 70 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                     if (GlobalVar.IsLogin)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 4413, "\"", 4471, 2);
            WriteAttributeValue("", 4420, "/Common/Product/BuyNow?productId=", 4420, 33, true);
#nullable restore
#line 72 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
WriteAttributeValue("", 4453, product.ProductId, 4453, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                           class=\"btn btn-block text-dark p-0\">\r\n                                            <i class=\"fas fa-shopping-cart text-primary mr-1\"></i>Buy now\r\n                                        </a>\r\n");
#nullable restore
#line 76 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <a href=""/Common/Account/Login""
                                           class=""btn btn-block text-dark p-0"">
                                            <i class=""fas fa-shopping-cart text-primary mr-1""></i>Buy now
                                        </a>
");
#nullable restore
#line 83 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 87 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                            }
                    else if(product.ProductStatus == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
                            <div class=""card product-item border-0 mb-4 bg-secondary"">
                                <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                    <img style=""width:100%; height:254px;""");
            BeginWriteAttribute("src", " src=\"", 5758, "\"", 5785, 1);
#nullable restore
#line 93 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
WriteAttributeValue("", 5764, product.ProductImage, 5764, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"card-body border-left border-right text-center p-0 pt-4 pb-3\">\r\n                                    <h6 class=\"text-truncate mb-3\">");
#nullable restore
#line 96 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                                                              Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                    <div class=""d-flex justify-content-center"">
                                        <h6 class=""text-muted ml-2"">Locked</h6>
                                    </div>
                                </div>
                                <div class=""card-footer d-flex justify-content-between bg-light border"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 6421, "\"", 6479, 2);
            WriteAttributeValue("", 6428, "/Common/Product/Detail?productId=", 6428, 33, true);
#nullable restore
#line 102 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
WriteAttributeValue("", 6461, product.ProductId, 6461, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                       class=""btn btn-sm text-dark p-0"">
                                        <i class=""fas fa-eye text-primary mr-1""></i>View Detail
                                    </a>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 109 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByCategory.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <!-- Shop Product End -->\r\n    </div>\r\n</div>\r\n<!-- Shop End -->\r\n");
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
