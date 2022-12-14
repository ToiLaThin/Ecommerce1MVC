#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "067fd3289995a4f25cb81608cfd820e15bf0b05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_Cart), @"mvc.1.0.view", @"/Views/Common/Cart.cshtml")]
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
#nullable restore
#line 1 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"067fd3289995a4f25cb81608cfd820e15bf0b05f", @"/Views/Common/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
  
    List<CartItemModel> cart = JsonConvert.DeserializeObject<List<CartItemModel>>(Context.Session.GetString("cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
 if(cart == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- 404 Start -->
    <div class=""container-xxl py-5"">
        <div class=""container px-lg-5 text-center"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-6"">
                    <i class=""bi bi-exclamation-triangle display-1 text-primary""></i>
                    <h1 class=""mb-4"">Cart is empty</h1>
                    <p class=""mb-4"">We’re sorry, the page you have looked for does not exist in our website! Maybe go to our home page or try to use a search?</p>
                    <a class=""btn btn-primary rounded-pill py-3 px-5"" href=""/Common/Product/List"">Go Back To Home</a>
                </div>
            </div>
        </div>
    </div>
    <!-- 404 End -->
");
#nullable restore
#line 22 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
}
else if(cart.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- 404 Start -->
    <div class=""container-xxl py-5"">
        <div class=""container px-lg-5 text-center"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-6"">
                    <i class=""bi bi-exclamation-triangle display-1 text-primary""></i>
                    <h1 class=""mb-4"">Cart is empty</h1>
                    <p class=""mb-4"">We’re sorry, the page you have looked for does not exist in our website! Maybe go to our home page or try to use a search?</p>
                    <a class=""btn btn-primary rounded-pill py-3 px-5"" href=""/Common/Product/List"">Go Back To Home</a>
                </div>
            </div>
        </div>
    </div>
    <!-- 404 End -->
");
#nullable restore
#line 39 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
}
else if(cart != null && cart.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Cart Start -->
    <div class=""container-fluid pt-5"">
        <div class=""row px-xl-5"">
            <div class=""col-lg-8 table-responsive mb-5"">
                <table class=""table table-bordered text-center mb-0"">
                    <thead class=""bg-secondary text-dark"">
                        <tr>
                            <th>Products</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Total</th>
                            <th>Remove</th>
                        </tr>
                    </thead>
                    <tbody class=""align-middle"">
                        <!-- tag declare chỉ chạy 1 lần -->
");
#nullable restore
#line 57 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
                           
                            decimal totalPrice = 0;
                            foreach(CartItemModel cartItem in cart)
                            {
                                totalPrice += cartItem.CartItemQuantity * cartItem.CartItemProduct.ProductPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"align-middle\"><img");
            BeginWriteAttribute("src", " src=\"", 2829, "\"", 2873, 1);
#nullable restore
#line 63 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
WriteAttributeValue("", 2835, cartItem.CartItemProduct.ProductImage, 2835, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /> ");
#nullable restore
#line 63 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
                                                                                                                                    Write(cartItem.CartItemProduct.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle\">");
#nullable restore
#line 64 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
                                                        Write(cartItem.CartItemProduct.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" €</td>
                                    <td class=""align-middle"">
                                        <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                            <!-- <div class=""input-group-btn"">
                                                <button class=""btn btn-sm btn-primary btn-minus"" >
                                                <i class=""fa fa-minus""></i>
                                                </button>
                                            </div> -->
                                            <input type=""text"" class=""form-control form-control-sm bg-secondary text-center""");
            BeginWriteAttribute("value", " value=\"", 3718, "\"", 3752, 1);
#nullable restore
#line 72 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
WriteAttributeValue("", 3726, cartItem.CartItemQuantity, 3726, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <!-- <div class=""input-group-btn"">
                                                <button class=""btn btn-sm btn-primary btn-plus"">
                                                    <i class=""fa fa-plus""></i>
                                                </button>
                                            </div> -->
                                        </div>
                                    </td>
                                    <td class=""align-middle"">");
#nullable restore
#line 80 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
                                                         Write(cartItem.CartItemUnitPrice * cartItem.CartItemQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle\"><a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 4438, "\"", 4510, 2);
            WriteAttributeValue("", 4445, "/Common/Cart/Remove?productId=", 4445, 30, true);
#nullable restore
#line 81 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
WriteAttributeValue("", 4475, cartItem.CartItemProduct.ProductId, 4475, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 83 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "067fd3289995a4f25cb81608cfd820e15bf0b05f12617", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control p-4"" placeholder=""Coupon Code"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"">Apply Coupon</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""card border-secondary mb-5"">
                    <div class=""card-header bg-secondary border-0"">
                        <h4 class=""font-weight-semi-bold m-0"">Cart Summary</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between mb-3 pt-1"">
                            <h6 class=""font-weight-medium"">Subtotal</h6>
                            <h6 class=""font-weight-medium""><%=totalPrice %></h6>
                        </div>
                        <div class=""d-flex justify-content-between"">
                            <h6 class=""font-weight-medium"">Shipping</h6>
                            <h6 class=""font-weight-medium"">6,90 €</h6>
                        </div>
                    </div>
                    <div class=""card-footer border-secondary bg-transparent"">
                        <div class=""d-flex justify-content-between mt-2"">
                            <h5 class=""font");
            WriteLiteral(@"-weight-bold"">Total</h5>
                            <h5 class=""font-weight-bold""><%=totalPrice+6.90 %> €</h5>
                        </div>
                        <c:if test=""${isLogin != null }"">
                            <c:set var=""isLogin"" value=""false"" />
                            <c:set var=""username"" value='${session.getAttribute(""username"") }' />
                        </c:if>
                        <c:if test=""${username != null }"">
                            <c:set var=""isLogin"" value=""true"" />
                        </c:if>
                        <c:if test=""${username == null }"">
                            <c:set var=""isLogin"" value=""false"" />
                        </c:if>
                        <c:if test=""${isLogin == true }"">
                            <a class=""btn btn-block btn-primary my-3 py-3"" href='<%=request.getContextPath() %>/common/order'>Order</a>
                        </c:if>
                        <c:if test=""${isLogin == false }"">
             ");
            WriteLiteral(@"               <a class=""btn btn-block btn-primary my-3 py-3"" href='<%=request.getContextPath() %>/views/common/login.jsp'>Order</a>
                        </c:if>
                        <a class=""btn btn-block btn-light  my-3 py-3"" href=""<%=request.getContextPath() %>/common/home"">Continue Shopping</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Cart End -->
");
#nullable restore
#line 140 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    window.onload = function () {
        let outOfProduct = ${ outOfProduct };
        console.log(outOfProduct);
        console.log(typeof (outOfProduct));

        if (outOfProduct === true) {
            alert(""Không còn hàng trong kho"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
