#pragma checksum "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44615abfd858a0a04a42540254f7955ed42575e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_AccountProfileUpdate), @"mvc.1.0.view", @"/Views/Common/AccountProfileUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44615abfd858a0a04a42540254f7955ed42575e6", @"/Views/Common/AccountProfileUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c211fd23c49f7320d953ecf8f20810fb55c617", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_AccountProfileUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myAvatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/common/account/profileUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("CSS", async() => {
                WriteLiteral(@" 
    <style>
        .myModal {
            position: fixed;
            top: 0;
            left: 0;
            z-index: 1;
            display: none;
            width: 100%;
            height: 100%;
            background-color: rgba(0,0,0,0.4);
        }

        .myModalContent {
            width: 60%;
            margin: 10% auto;
            background-color: #fefefe;
            box-shadow: 1px 1px 20px 2px rgba(0,0,0,0.2);
            border-radius: 5px;
            animation-name: moveFade;
            animation-duration: 2.4s;
        }

        #myModalCloseBtn {
            float: right;
            font: bold 40px sans-serif;
            color: gray;
            cursor: pointer;
        }

        .myModalHeader::after {
            display: table;
            content: """";
            clear: both;
        }

        .myModalHeader {
            padding: 15px;
        }

        #myModalCloseBtn:hover, #myModalCloseBtn:focus {
            color: black;");
                WriteLiteral(@"
        }

        .myModalBody {
            height: 400px;
            padding: 40px;
            background-color: white;
            /*quan trọng khi có quá nhiều icon trong modal*/
            overflow-y: scroll;
        }

        .myProfileIcon {
            cursor: pointer;
            transition: .4s ease-in-out;
        }

            .myProfileIcon:hover {
                transform: scale(1.2);
                opacity: 0.9;
            }

        ");
                WriteLiteral("@keyframes moveFade {\r\n            from {\r\n                top: 500px;\r\n                opacity: 0;\r\n            }\r\n\r\n            to {\r\n                top: 0;\r\n                opacity: 1;\r\n            }\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"<!-- boostrap icons -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.2.3/js/bootstrap.min.js"" integrity=""sha512-1/RvZTcCDEUjY/CypiMz+iqqtaoQfAITmNSJY17Myp4Ms5mdxPS5UV7iOfdZoxcGhzFbOm6sntTKJppjvuhg4g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>

<section style=""background-color: #eee;"">
    <div class=""container py-5"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""card mb-4"">
                    <div class=""card-body text-center"">
");
#nullable restore
#line 86 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
                         if(Model.AccountImage != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img id=\"myAvatar\"");
            BeginWriteAttribute("src", " src=\"", 2432, "\"", 2457, 1);
#nullable restore
#line 88 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
WriteAttributeValue("", 2438, Model.AccountImage, 2438, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\" class=\"rounded-circle img-fluid\" style=\"width: 150px;height:150px;\">\r\n");
#nullable restore
#line 89 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "44615abfd858a0a04a42540254f7955ed42575e610218", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"my-3\">");
#nullable restore
#line 94 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
                                Write(Model.AccountUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <p class=""text-muted mb-1"">Full Stack Developer</p>
                        <p class=""text-muted mb-4"">Bay Area, San Francisco, CA</p>
                        <div class=""d-flex justify-content-center mb-2"">
                            <button id=""myBtnEditProfile"" type=""button"" class=""btn border-0 btn-outline-primary rounded-circle""><i class=""fa fa-pencil"" aria-hidden=""true""></i></button>
                            <button id=""myBtnEditProfilePicture"" type=""button"" class=""btn border-0 btn-outline-primary rounded-circle""><i class=""fas fa-image"" aria-hidden=""true""></i></button>
                            <a href=""/Common/Product/List"" class=""btn border-0 btn-outline-primary rounded-circle""><i class=""fa fa-home""></i></a>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-lg-8"">
                <div class=""card mb-4"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44615abfd858a0a04a42540254f7955ed42575e613119", async() => {
                WriteLiteral(@"
                        <div class=""card-body"">
                            <div class=""row form-group"">
                                <div class=""col-sm-3"">
                                    <p class=""mb-0"">Full Name</p>
                                </div>
                                <div class=""col-sm-9"">
                                    <input type=""text"" name=""accountFullname""");
                BeginWriteAttribute("value", " value=\"", 4298, "\"", 4328, 1);
#nullable restore
#line 115 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
WriteAttributeValue("", 4306, Model.AccountFullName, 4306, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""text-muted form-control"" readonly=""readonly"" />
                                </div>
                            </div>
                            <hr>
                            <div class=""row form-group"">
                                <div class=""col-sm-3"">
                                    <p class=""mb-0"">Email</p>
                                </div>
                                <div class=""col-sm-9"">
                                    <input type=""email"" name=""accountEmail""");
                BeginWriteAttribute("value", " value=\"", 4844, "\"", 4871, 1);
#nullable restore
#line 124 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
WriteAttributeValue("", 4852, Model.AccountEmail, 4852, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""text-muted form-control"" readonly=""readonly"" />
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <p class=""mb-0"">Phone</p>
                                </div>
                                <div class=""col-sm-9"">
                                    <input type=""tel"" name=""accountPhone""");
                BeginWriteAttribute("value", " value=\"", 5374, "\"", 5401, 1);
#nullable restore
#line 133 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
WriteAttributeValue("", 5382, Model.AccountPhone, 5382, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""text-muted form-control"" readonly=""readonly"" pattern=""[0][0-9]{3}[0-9]{3}[0-9]{3}"" />
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <p class=""mb-0"">Address</p>
                                </div>
                                <div class=""col-sm-9"">
                                    <p class=""text-muted mb-0"">Unknow, remain secret</p>
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <p class=""mb-0"">Icon URL</p>
                                </div>
                                <div class=""col-sm-9"">
                                    <input id=""myAvatarPathInput"" type=""text"" name=""accoun");
                WriteLiteral("tImage\"");
                BeginWriteAttribute("value", " value=\"", 6433, "\"", 6460, 1);
#nullable restore
#line 151 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
WriteAttributeValue("", 6441, Model.AccountImage, 6441, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"text-muted form-control\" readonly=\"readonly\" />\r\n                                    <input name=\"accountId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6591, "\"", 6615, 1);
#nullable restore
#line 152 "D:\Bi\Bi code\ASP.NET Core\LearnMVC1\LearnMVC1\Views\Common\AccountProfileUpdate.cshtml"
WriteAttributeValue("", 6599, Model.AccountId, 6599, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </div>
                            </div>
                        </div>

                        <div class=""card-footer d-flex justify-content-center mb-2"">
                            <button id=""myProfileSubmitBtn"" type=""submit"" class=""btn btn-outline-success"">Submit</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""card mb-4 mb-lg-0"">
                    <div class=""card-body p-0"">
                        <ul class=""list-group list-group-flush rounded-3"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fas fa-globe fa-lg text-warning""></i>
                                <p class=""mb-0"">https://mdbootstrap.com</p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-github fa-lg"" style=""color: #333333;""></i>
                                <p class=""mb-0"">mdbootstrap</p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-twitter fa-lg"" style=""color: #55acee;""></i>
        ");
            WriteLiteral("                        <p class=\"mb-0\">");
            WriteLiteral(@"@mdbootstrap</p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-instagram fa-lg"" style=""color: #ac2bac;""></i>
                                <p class=""mb-0"">mdbootstrap</p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-facebook-f fa-lg"" style=""color: #3b5998;""></i>
                                <p class=""mb-0"">mdbootstrap</p>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""myModal"">
        <div class=""myModalContent"">
            <div class=""myModalHeader"">
                <span id=""myModalCloseBtn"">&times;</span>
                <h2 class=""toast-header"">
             ");
            WriteLiteral(@"       <i class=""fas fa-image"" style=""padding-right:12px; font-size: 40px; color: lightgray;""></i>
                    Choose image:
                </h2>
            </div>
            <div class=""myModalBody d-flex flex-wrap justify-content-center align-items-center"">
");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#myProfileSubmitBtn"").hide();
            $(""#myBtnEditProfilePicture"").click(function () {
                $("".myModal"").fadeIn();
            });
            $(""#myModalCloseBtn"").click(function () {
                $("".myModal"").fadeOut();
            });

            $(""#myAvatarPathInput"").bind(""change paste keyup"", function () {
                if ($(this).val() === """") {
                    let root = ""${pageContext.request.contextPath}""
                    document.getElementById(""myAvatar"").src = root + ""/img/user.jpg"";
                }
                else
                    document.getElementById(""myAvatar"").src = $(this).val();
            });
        });

        //code cho phần thay đổi icon
        /* let currIconRelativePath = """";
        let allIcons = document.querySelectorAll("".myProfileIcon"");
        for (let i = 0; i < allIcons.length; i++) {
            allIcons[i].addEventListener(""click"", ");
                WriteLiteral(@"function (evt) {
                for (let j = 0; j < allIcons.length; j++) {
                    allIcons[j].children[0].style.border = ""0px solid white"";
                }
                //evt.Target là img chứa trong .MyProfileIcon nên nếu đổi style cho allIcon[j] thì không đúng
                evt.target.style.border = ""2px solid dodgerblue"";

                currIconRelativePath = evt.target.src;
                //là đường dẫn có https://localhost ... -> ko nên lưu đường dẫn này vào Db mà chỉ nên đưa đường dẫn tương đối
                let posToTakeSubStr = currIconRelativePath.indexOf(""/assets"");
                currIconRelativePath = currIconRelativePath.slice(posToTakeSubStr, currIconRelativePath.length);

                document.getElementById(""myAvatar"").src = currIconRelativePath;
                document.getElementById(""myAvatarPathInput"").value = currIconRelativePath;
            });
        } */


        let myEditProfileBtn = document.getElementById(""myBtnEditProfile"");
   ");
                WriteLiteral(@"     myEditProfileBtn.addEventListener(""click"", function () {
            let inputs = document.querySelectorAll(""input.text-muted"");
            console.log(inputs);
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i].readOnly === true) {
                    inputs[i].readOnly = false;
                    $(""#myProfileSubmitBtn"").show();
                }
                else {
                    inputs[i].readOnly = true;
                    $(""#myProfileSubmitBtn"").hide();
                }
            }
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
