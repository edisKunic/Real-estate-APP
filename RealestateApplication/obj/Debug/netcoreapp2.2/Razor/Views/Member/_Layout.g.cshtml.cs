#pragma checksum "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c804abd0ecdc7df838c3ed089245c5a1c9257130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member__Layout), @"mvc.1.0.view", @"/Views/Member/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/_Layout.cshtml", typeof(AspNetCore.Views_Member__Layout))]
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
#line 1 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\_ViewImports.cshtml"
using RealestateApplication;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\_ViewImports.cshtml"
using RealestateApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c804abd0ecdc7df838c3ed089245c5a1c9257130", @"/Views/Member/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fce30a1728e8d913b2eff14e8c99f0daa3a95c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Member__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/static/Member_default_image.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-hidden", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 7 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(123, 247, true);
            WriteLiteral("\r\n<h1>Member Panel</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row profile\">\r\n        <div class=\"col-md-3\">\r\n            <div class=\"profile-sidebar\">\r\n                <!-- SIDEBAR USERPIC -->\r\n                <div class=\"profile-userpic\">\r\n");
            EndContext();
#line 19 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
                     if (Model.Image != null)
                    {
                        string imageBase64 = Convert.ToBase64String(Model.Image);
                        string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);

#line default
#line hidden
            BeginContext(623, 47, true);
            WriteLiteral("                        <img class=\"user-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 670, "\"", 685, 1);
#line 23 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
WriteAttributeValue("", 676, imageSrc, 676, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(686, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 24 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(763, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(787, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c804abd0ecdc7df838c3ed089245c5a1c92571308201", async() => {
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
            EndContext();
            BeginContext(861, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
                    }

#line default
#line hidden
            BeginContext(886, 183, true);
            WriteLiteral("                </div>\r\n                <div class=\"profile-usertitle\">\r\n                    <hr />\r\n                    <div class=\"profile-usertitle-name\">\r\n                        ");
            EndContext();
            BeginContext(1070, 15, false);
#line 33 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1087, 14, false);
#line 33 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1101, 111, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"profile-usertitle-job\">\r\n                        ");
            EndContext();
            BeginContext(1213, 10, false);
#line 36 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
                   Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 255, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <nav class=\"side-menu\">\r\n                    <ul class=\"nav\">\r\n                        <li><a href=\"#\"><span class=\"fa fa-home\"></span> Start Page</a></li>\r\n                        <li>");
            EndContext();
            BeginContext(1478, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c804abd0ecdc7df838c3ed089245c5a1c925713011388", async() => {
                BeginContext(1568, 40, true);
                WriteLiteral("<span class=\"fa fa-user\"></span> Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1612, 37, true);
            WriteLiteral("</li>\r\n\r\n                        <li>");
            EndContext();
            BeginContext(1649, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c804abd0ecdc7df838c3ed089245c5a1c925713013200", async() => {
                BeginContext(1694, 46, true);
                WriteLiteral("<span class=\"fa fa-list-alt\"></span> My offers");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1744, 384, true);
            WriteLiteral(@"</li>

                        <li><a href=""user-drive.html""><span class=""fa fa-th""></span> Drive</a></li>
                        <li><a href=""#""><span class=""fa fa-clock-o""></span> Reminders</a></li>
                    </ul>
                </nav>
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""profile-content"">
                ");
            EndContext();
            BeginContext(2129, 12, false);
#line 54 "C:\Users\User\Documents\GitHub\Real-estate-APP\RealestateApplication\Views\Member\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(2141, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
