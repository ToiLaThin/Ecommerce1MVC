#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c50ef7251e10013827d5880f32de7f9089985b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_OrderInsert), @"mvc.1.0.view", @"/Views/Common/OrderInsert.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c50ef7251e10013827d5880f32de7f9089985b24", @"/Views/Common/OrderInsert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_OrderInsert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItemModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Common/Order/Insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
   
    decimal productQuantityPrice = 0, finalPrice = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Checkout Start -->\r\n<div class=\"container-fluid pt-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c50ef7251e10013827d5880f32de7f9089985b245056", async() => {
                WriteLiteral(@"
        <div class=""row px-xl-5"">
            <section class=""col-lg-8"">
                <div class=""mb-4 collapse"" id=""shipping-address"">
                    <h4 class=""font-weight-semi-bold mb-4"">Shipping Address</h4>
                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <label>First Name</label>
                            <input class=""form-control"" type=""text"" placeholder=""John"">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>Last Name</label>
                            <input class=""form-control"" type=""text"" placeholder=""Doe"">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>E-mail</label>
                            <input class=""form-control"" type=""text"" placeholder=""example@email.com"">
                        </div>
                        <div class=""col-md-6 fo");
                WriteLiteral(@"rm-group"">
                            <label>Mobile No *</label>
                            <input class=""form-control"" type=""text"" name=""phoneNumber"" placeholder=""Ex: 0928354635"" required>
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>Deliver Address *</label>
                            <input class=""form-control"" type=""text"" placeholder=""123 Street"" name=""address"" required>
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>Address Line 2</label>
                            <input class=""form-control"" type=""text"" placeholder=""123 Street"">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>Country</label>
                            <select class=""custom-select"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c50ef7251e10013827d5880f32de7f9089985b247386", async() => {
                    WriteLiteral("United States");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c50ef7251e10013827d5880f32de7f9089985b248762", async() => {
                    WriteLiteral("England");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c50ef7251e10013827d5880f32de7f9089985b249809", async() => {
                    WriteLiteral("Japan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c50ef7251e10013827d5880f32de7f9089985b2410854", async() => {
                    WriteLiteral("Viet Nam");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>City</label>
                            <input class=""form-control"" type=""text"" placeholder=""New York"">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>State</label>
                            <input class=""form-control"" type=""text"" placeholder=""New York"">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>ZIP Code</label>
                            <input class=""form-control"" type=""text"" placeholder=""123"">
                        </div>
                        <div class=""col-md-12 form-group"">
                            <div class=""custom-control custom-checkbox"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""shipto"">
                    ");
                WriteLiteral(@"            <label class=""custom-control-label"" for=""shipto"" data-toggle=""collapse"" data-target=""#shipping-address"">Ship to different address</label>
                            </div>
                        </div>
                    </div>
                </div>

            </section>
            <section class=""col-lg-4"">
                <div class=""card border-secondary mb-5"">
                    <div class=""card-header bg-secondary border-0"">
                        <h4 class=""font-weight-semi-bold m-0"">Order Total</h4>
                    </div>
                    <div class=""card-body"">
                        <h5 class=""font-weight-medium mb-3"">Products</h5>
                        <c:set var=""finalPrice"" value=""0"" />
");
#nullable restore
#line 76 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                         foreach (var cartItem in Model)
                        {
                            productQuantityPrice = cartItem.CartItemProduct.ProductPrice * cartItem.CartItemQuantity;
                            finalPrice += productQuantityPrice;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"d-flex justify-content-between\">\r\n                                <p>");
#nullable restore
#line 81 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                              Write(cartItem.CartItemProduct.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 81 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                                                                     Write(cartItem.CartItemProduct.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("$ x ");
#nullable restore
#line 81 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                                                                                                               Write(cartItem.CartItemQuantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</p>\r\n                                <p>");
#nullable restore
#line 82 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                              Write(productQuantityPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</p>\r\n                            </div>\r\n");
#nullable restore
#line 84 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <hr class=""mt-0"">
                        <div class=""d-flex justify-content-between mb-3 pt-1"">
                            <h6 class=""font-weight-medium"">Subtotal</h6>
                            <h6 class=""font-weight-medium"">");
#nullable restore
#line 88 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                                                      Write(finalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                        </div>
                        <div class=""d-flex justify-content-between"">
                            <h6 class=""font-weight-medium"">Shipping</h6>
                            <h6 class=""font-weight-medium"">$6.90</h6>
                        </div>
                    </div>
                    <div class=""card-footer border-secondary bg-transparent"">
                        <div class=""d-flex justify-content-between mt-2"">
                            <h5 class=""font-weight-bold"">Total</h5>
                            <h5 class=""font-weight-bold"">");
#nullable restore
#line 98 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                                                     Write(finalPrice + Convert.ToDecimal(6.90));

#line default
#line hidden
#nullable disable
                WriteLiteral("$</h5>\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5741, "\"", 5788, 1);
#nullable restore
#line 99 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
WriteAttributeValue("", 5749, finalPrice + Convert.ToDecimal(6.90), 5749, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"totalPrice\" />\r\n                        </div>\r\n                        <div class=\'d-flex justify-content-between mt-2\'>\r\n                            <h5 class=\'text-muted\'>Date</h5> \r\n                            <h5 class=\'text-muted\'>");
#nullable restore
#line 103 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\OrderInsert.cshtml"
                                              Write(DateTime.Now.ToLocalTime());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                        </div>
                    </div>

                </div>
                <div class=""card border-secondary mb-5"">
                    <div class=""card-header bg-secondary border-0"">
                        <h4 class=""font-weight-semi-bold m-0"">Payment</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <div class=""custom-control custom-radio"">
                                <input type=""radio"" class=""custom-control-input"" name=""payment"" id=""paypal"" value=""paypal"">
                                <label class=""custom-control-label"" for=""paypal"" data-toggle=""collapse"" data-target=""#shipping-address"">Paypal</label>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""custom-control custom-radio"">
                                <input type=""radio"" class=""custom-co");
                WriteLiteral(@"ntrol-input"" name=""payment"" id=""directcheck"">
                                <label class=""custom-control-label"" for=""directcheck"" data-toggle=""collapse"" data-target=""#shipping-address"">Direct Check</label>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""custom-control custom-radio"">
                                <input type=""radio"" class=""custom-control-input"" name=""payment"" id=""momo"" value=""momo"">
                                <label class=""custom-control-label"" for=""momo"" data-toggle=""collapse"" data-target=""#shipping-address"">Momo</label>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""custom-control custom-radio"">
                                <input type=""radio"" class=""custom-control-input"" name=""payment"" id=""stripe"" value=""stripe"">
                                <label cla");
                WriteLiteral(@"ss=""custom-control-label"" for=""stripe"" data-toggle=""collapse"" data-target=""#shipping-address"">Stripe</label>
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer border-secondary bg-transparent"">
                        <button type=""submit"" class=""btn btn-lg btn-block btn-primary font-weight-bold my-3 py-3"">Place Order</button>
                        <a type=""button"" class=""btn btn-lg btn-block btn-secondary font-weight-bold my-3 py-3"" href=""/Common/Product/List"">Back</a>
                    </div>
                </div>
            </section>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<!-- Checkout End -->

<script type=""text/javascript"">
	window.onload = function() {
		let outOfProduct = ${outOfProduct};
		console.log(outOfProduct);
		console.log(typeof(outOfProduct));

		if(outOfProduct === true)
		{
			alert(""Không còn sản phẩm trong kho nên không thể mua ngay"");
			let root = ""${pageContext.request.contextPath}""
			window.location.href = root + ""/common/home"";
		}
	}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
