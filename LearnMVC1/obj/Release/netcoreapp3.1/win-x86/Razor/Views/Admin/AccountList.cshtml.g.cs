#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AccountList), @"mvc.1.0.view", @"/Views/Admin/AccountList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7ccfce78ebea5db8316fdf42ab4bda387a7fe3", @"/Views/Admin/AccountList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AccountList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tab.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle border-1 border-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tab.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/easing/easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/owlcarousel/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mail/jqBootstrapValidation.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mail/contact.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
  
    List<ProductModel> products = new List<ProductModel>();
    List<AccountModel> userAccounts = new List<AccountModel>();
    List<AccountModel> sellerAccounts = new List<AccountModel>();
    List<AccountModel> accounts = new List<AccountModel>();
    if (ViewData.ContainsKey("Products"))
        products = (List<ProductModel>)ViewData["Products"];
    if (ViewData.ContainsKey("Accounts"))
        accounts = (List<AccountModel>)ViewData["Accounts"];
    if (ViewData.ContainsKey("UserAccounts"))
        userAccounts = (List<AccountModel>)ViewData["UserAccounts"];
    if (ViewData.ContainsKey("SellerAccounts"))
        sellerAccounts = (List<AccountModel>)ViewData["SellerAccounts"];

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe39046", async() => {
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
    <button class=""tablinks defaultOpen"" onclick=""openTab(event,'userAccountsTab')""
            id=""default"">
        User Accounts
    </button>
    <button class=""tablinks"" onclick=""openTab(event,'sellerAccountsTab')"">Seller Accounts</button>
    <button class=""tablinks"" onclick=""openTab(event,'allProductsTab')"">All Products</button>
</div>
<br />
<br />
<!-- User Accounts Start -->
<div id=""userAccountsTab"" class=""tabcontents container-fluid py-5 mb-5"">
    <div class=""text-center mb-4"">
        <h2 class=""section-title px-5"">
            <span class=""px-2"">User 's Accounts</span>
        </h2>
    </div>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""d-flex justify-content-start align-items-center text-center"">
");
#nullable restore
#line 38 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                 foreach (var account in userAccounts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"p-1\" style=\"width:10%\">\r\n                        <div>\r\n");
#nullable restore
#line 42 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                             if (account.AccountImage == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe311785", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 2097, "\"", 2124, 1);
#nullable restore
#line 48 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 2103, account.AccountImage, 2103, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle border-1 border-dark\" width=\"75\" height=\"75\" />\r\n");
#nullable restore
#line 49 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <h4 class=\"p-0 m-0\"><a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 2324, "\"", 2381, 2);
            WriteAttributeValue("", 2331, "/Admin/Account/Detail?accountId=", 2331, 32, true);
#nullable restore
#line 51 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 2363, account.AccountId, 2363, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                                                                                                                      Write(account.AccountUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n");
#nullable restore
#line 52 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                         if (account.AccountStatus == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small class=\"text-dark mb-4 d-block\">\r\n                                Status: <span class=\"text-success\">Active</span>\r\n                            </small>\r\n");
#nullable restore
#line 57 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                        }
                        else if (account.AccountStatus == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small class=\"text-dark mb-4 d-block\">\r\n                                Status: <span class=\"text-danger\">Inactive</span>\r\n                            </small>\r\n");
#nullable restore
#line 63 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 66 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
            </div>
        </div>
    </div>
</div>
<!-- User Accounts End -->

<!-- Seller Accounts Start -->
<div id=""sellerAccountsTab"" class=""tabcontents container-fluid py-5 mb-5"">
    <div class=""text-center mb-4"">
        <h2 class=""section-title px-5"">
            <span class=""px-2"">Seller 's Accounts</span>
        </h2>
    </div>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""d-flex justify-content-start align-items-center text-center"">
");
#nullable restore
#line 84 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                 foreach (AccountModel acc in sellerAccounts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"p-1\" style=\"width:10%\">\r\n                        <div>\r\n");
#nullable restore
#line 88 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                             if (acc.AccountImage == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe317633", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 4117, "\"", 4140, 1);
#nullable restore
#line 94 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 4123, acc.AccountImage, 4123, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle border-1 border-dark\" width=\"75\" height=\"75\" />\r\n");
#nullable restore
#line 95 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <h4 class=\"p-0 m-0\"><a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 4340, "\"", 4393, 2);
            WriteAttributeValue("", 4347, "/Admin/Account/Detail?accountId=", 4347, 32, true);
#nullable restore
#line 97 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 4379, acc.AccountId, 4379, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                                                                                                                  Write(acc.AccountUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n");
#nullable restore
#line 98 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                         if (acc.AccountStatus == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small class=\"text-dark mb-4 d-block\">\r\n                                Status: <span class=\"text-success\">Active</span>\r\n                            </small>\r\n");
#nullable restore
#line 103 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                        }
                        else if (acc.AccountStatus == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small class=\"text-dark mb-4 d-block\">\r\n                                Status: <span class=\"text-danger\">Inactive</span>\r\n                            </small>\r\n");
#nullable restore
#line 109 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 112 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
        </div>
    </div>
</div>
<!-- Seller Accounts End -->
<!-- Back to Top -->
<a href=""#"" class=""btn btn-primary back-to-top""><i class=""fa fa-angle-double-up""></i></a>




<div id=""allProductsTab"" class=""tabcontents container-fluid mt-3"">
    <div class=""text-center mb-4"">
        <h2 class=""section-title px-5"">
            <span class=""px-2"">All Products</span>
        </h2>
    </div>
    <div class=""row"">
");
#nullable restore
#line 131 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
         foreach(ProductModel product in products)
        {
            if(product.ProductStatus == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-2 col-md-4 col-sm-12 pb-1"">
                    <div class=""card product-item border-0 mb-4"">
                        <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                            <img");
            BeginWriteAttribute("class", " class=\"", 5938, "\"", 5946, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 5947, "\"", 5974, 1);
#nullable restore
#line 138 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 5953, product.ProductImage, 5953, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5975, "\"", 5981, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                 style=""width: 100%;"" height=""360"">
                        </div>
                        <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                            <h6 class=""text-truncate mb-3"">");
#nullable restore
#line 142 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                                                      Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"d-flex justify-content-center\">\r\n                                <h6>");
#nullable restore
#line 144 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                               Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h6>\r\n                                <h6 class=\"text-muted ml-2\">\r\n                                    <del>");
#nullable restore
#line 146 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
                                    Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$ </del>\r\n                                </h6>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"card-footer d-flex justify-content-between bg-light border\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 6778, "\"", 6836, 2);
            WriteAttributeValue("", 6785, "/Common/Product/Detail?productId=", 6785, 33, true);
#nullable restore
#line 151 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 6818, product.ProductId, 6818, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                               class=""btn btn-sm text-dark p-0"">
                                <i class=""fas fa-eye text-primary mr-1""></i>View Detail
                            </a>
                            <p class=""m-0 p-0"">
                                Status: <span class=""text-success"">Active</span>
                            </p>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 161 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
            }
            else if(product.ProductStatus == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-2 col-md-4 col-sm-12 pb-1"">
                    <div class=""card product-item border-0 mb-4 bg-secondary"">
                        <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                            <img");
            BeginWriteAttribute("class", " class=\"", 7655, "\"", 7663, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 7664, "\"", 7691, 1);
#nullable restore
#line 167 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 7670, product.ProductImage, 7670, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7692, "\"", 7698, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                 style=""width: 100%;"" height=""360"">
                        </div>
                        <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                            <h6 class=""text-truncate mb-3"">");
#nullable restore
#line 171 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 8330, "\"", 8388, 2);
            WriteAttributeValue("", 8337, "/Common/Product/Detail?productId=", 8337, 33, true);
#nullable restore
#line 177 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
WriteAttributeValue("", 8370, product.ProductId, 8370, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                               class=""btn btn-sm text-dark p-0"">
                                <i class=""fas fa-eye text-primary mr-1""></i>View Detail
                            </a>
                            <p class=""m-0 p-0"">
                                Status: <span class=""text-danger"">Inactive</span>
                            </p>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 187 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Admin\AccountList.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe329695", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- load back to top -->\r\n    <!-- JavaScript Libraries -->\r\n    <script src=\"https://code.jquery.com/jquery-3.4.1.min.js\"></script>\r\n    <script src=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe331053", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe332153", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- Contact Javascript File -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe333297", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe334397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- Template Javascript -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7ccfce78ebea5db8316fdf42ab4bda387a7fe335538", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
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