#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9605d9e55e0fd6f24a258f3ea3293c3aaaee3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_ProductFilterByStore), @"mvc.1.0.view", @"/Views/Common/ProductFilterByStore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e9605d9e55e0fd6f24a258f3ea3293c3aaaee3a", @"/Views/Common/ProductFilterByStore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_ProductFilterByStore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
  
    List<ProductModel> products = new List<ProductModel>();
    StoreModel store = new StoreModel();
    if (ViewData.ContainsKey("Products"))
        products = (List<ProductModel>)ViewData["Products"];
    if (ViewData.ContainsKey("Store"))
        store = (StoreModel)ViewData["Store"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center mb-5 text-danger\">\r\n    <h2 class=\"section-title px-5\">\r\n        <span class=\"px-2\">");
#nullable restore
#line 11 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                      Write(store.StoreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </h2>\r\n</div>\r\n<br>\r\n<!-- Shop Product Start -->\r\n<div class=\"col-lg-12 col-md-12\">\r\n    <div class=\"row\" id=\"products\">\r\n");
#nullable restore
#line 18 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
         foreach(ProductModel product in products)
        {
            if(product.ProductStatus == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 col-sm-12 pb-1 product"">
                    <div class=""card product-item border-0 mb-4"">
                        <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                            <img");
            BeginWriteAttribute("class", " class=\"", 978, "\"", 986, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 987, "\"", 1014, 1);
#nullable restore
#line 25 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 993, product.ProductImage, 993, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1015, "\"", 1021, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                 style=""width: 100%;"" height=""360"">
                        </div>
                        <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                            <h6 class=""text-truncate mb-3"">");
#nullable restore
#line 29 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                                                      Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"d-flex justify-content-center\">\r\n                                <h6>");
#nullable restore
#line 31 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                               Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h6>\r\n                                <h6 class=\"text-muted ml-2\">\r\n                                    <del>");
#nullable restore
#line 33 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                                    Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$ </del>\r\n                                </h6>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"card-footer d-flex justify-content-between bg-light border\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1818, "\"", 1876, 2);
            WriteAttributeValue("", 1825, "/Common/Product/Detail?productId=", 1825, 33, true);
#nullable restore
#line 38 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 1858, product.ProductId, 1858, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               class=\"btn btn-sm text-dark p-0\">\r\n                                <i class=\"fas fa-eye text-primary mr-1\"></i>View Detail\r\n                            </a>\r\n");
#nullable restore
#line 42 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                             if(GlobalVar.IsLogin)
                            {
                                if (!product.IsWished)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 2280, "\"", 2370, 4);
            WriteAttributeValue("", 2287, "/Common/WishList/Insert?productId=", 2287, 34, true);
#nullable restore
#line 46 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 2321, product.ProductId, 2321, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2339, "&accountId=", 2339, 11, true);
#nullable restore
#line 46 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 2350, GlobalVar.AccountId, 2350, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                       class=\"btn btn-sm text-dark p-0\">\r\n                                        <i class=\"far fa-heart text-primary mr-1\"></i>Add To Wishlist\r\n                                    </a>\r\n");
#nullable restore
#line 50 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                                }
                                else if (product.IsWished)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 2760, "\"", 2850, 4);
            WriteAttributeValue("", 2767, "/Common/WishList/Delete?productId=", 2767, 34, true);
#nullable restore
#line 53 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 2801, product.ProductId, 2801, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2819, "&accountId=", 2819, 11, true);
#nullable restore
#line 53 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 2830, GlobalVar.AccountId, 2830, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                       class=\"btn btn-sm text-dark p-0\">\r\n                                        <i class=\"fas fa-heart text-primary mr-1\"></i>Wished\r\n                                    </a>\r\n");
#nullable restore
#line 57 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                                }
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <a href=""/Common/Account/Login""
                                   class=""btn btn-sm text-dark p-0"">
                                    <i class=""far fa-heart text-primary mr-1""></i>Add To Wishlist
                                </a>
");
#nullable restore
#line 65 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 3527, "\"", 3579, 2);
            WriteAttributeValue("", 3534, "/Common/Cart/Add?productId=", 3534, 27, true);
#nullable restore
#line 66 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 3561, product.ProductId, 3561, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                               class=""btn btn-sm text-dark p-0"">
                                <i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart
                            </a>
                        </div>
                        <div class=""card-footer d-flex justify-content-between bg-light border"">        
");
#nullable restore
#line 72 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                             if(GlobalVar.IsLogin)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 4036, "\"", 4116, 3);
            WriteAttributeValue("", 4043, "<%=request.getContextPath()", 4043, 27, true);
            WriteAttributeValue(" ", 4070, "%>/common/buyNow?productId=", 4071, 28, true);
#nullable restore
#line 74 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 4098, product.ProductId, 4098, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block text-dark p-0\">\r\n                                    <i class=\"fas fa-shopping-cart text-primary mr-1\"></i>Buy now\r\n                                </a>\r\n");
#nullable restore
#line 77 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                            }
                            else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"/Common/Account/Login\" class=\"btn btn-block text-dark p-0\">\r\n                                    <i class=\"fas fa-shopping-cart text-primary mr-1\"></i>Buy now\r\n                                </a>\r\n");
#nullable restore
#line 82 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 86 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"

            }
            else if(product.ProductStatus == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 col-sm-12 pb-1 product"">
                    <div class=""card product-item border-0 mb-4 bg-secondary"">
                        <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                            <img");
            BeginWriteAttribute("class", " class=\"", 5103, "\"", 5111, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 5112, "\"", 5139, 1);
#nullable restore
#line 93 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 5118, product.ProductImage, 5118, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5140, "\"", 5146, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                 style=""width: 100%;"" height=""360"">
                        </div>
                        <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                            <h6 class=""text-truncate mb-3"">");
#nullable restore
#line 97 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 5778, "\"", 5836, 2);
            WriteAttributeValue("", 5785, "/Common/Product/Detail?productId=", 5785, 33, true);
#nullable restore
#line 103 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
WriteAttributeValue("", 5818, product.ProductId, 5818, 18, false);

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
#line 110 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\ProductFilterByStore.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<!-- Shop Product End -->");
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
