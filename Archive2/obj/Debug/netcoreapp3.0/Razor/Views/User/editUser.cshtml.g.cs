#pragma checksum "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\User\editUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60220fcf5025339ccea0fe78c38a2ffb1eda02b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_editUser), @"mvc.1.0.view", @"/Views/User/editUser.cshtml")]
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
#line 1 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\_ViewImports.cshtml"
using Archive2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\_ViewImports.cshtml"
using Archive2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60220fcf5025339ccea0fe78c38a2ffb1eda02b1", @"/Views/User/editUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e686de7ce6e2b4c2b71065f22d651816412f73e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_editUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-3 border-right"">
        <div class=""d-flex flex-column align-items-center text-center p-3 py-5""><img class=""rounded-circle mt-5"" width=""150px"" src=""https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg""><span class=""font-weight-bold""></span><span class=""text-black-50""></span></div>
    </div>
    <div class=""col-md-5 border-right"">
        <div class=""p-3 py-5"">
            <div class=""d-flex justify-content-between align-items-center mb-3"">
                <h4 class=""text-right"">Edit User</h4>
            </div>
            <div class=""row mt-2"">
                <div class=""col-md-6""><label class=""labels"">First Name</label><input type=""text"" class=""form-control"" placeholder=""First Name""");
            BeginWriteAttribute("value", " value=\"", 824, "\"", 832, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"col-md-6\"><label class=\"labels\">Second Name</label><input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 959, "\"", 967, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Second Name\"></div>\n            </div>\n            <div class=\"row mt-3\">\n                <div class=\"col-md-12\"><label class=\"labels\">Mobile Number</label><input type=\"text\" class=\"form-control\" placeholder=\"enter phone number\"");
            BeginWriteAttribute("value", " value=\"", 1210, "\"", 1218, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"col-md-12\"><label class=\"labels\">Address Line</label><input type=\"text\" class=\"form-control\" placeholder=\"enter address line\"");
            BeginWriteAttribute("value", " value=\"", 1380, "\"", 1388, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"col-md-12\"><label class=\"labels\">Email</label><input type=\"text\" readonly class=\"form-control\" placeholder=\"enter email id\"");
            BeginWriteAttribute("value", " value=\"", 1548, "\"", 1556, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"col-md-12\"><label class=\"labels\">Password</label><input type=\"text\" class=\"form-control\" placeholder=\"enter Password\"");
            BeginWriteAttribute("value", " value=\"", 1710, "\"", 1718, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"col-md-12\"><label class=\"labels\">Job Title</label><input type=\"text\" class=\"form-control\" placeholder=\"Job Title\"");
            BeginWriteAttribute("value", " value=\"", 1868, "\"", 1876, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"col-md-12\"><label class=\"labels\">Department</label><input type=\"text\" class=\"form-control\" placeholder=\"Department\"");
            BeginWriteAttribute("value", " value=\"", 2028, "\"", 2036, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"col-md-12\"><label class=\"labels\">Country</label><input type=\"text\" class=\"form-control\" placeholder=\"country\"");
            BeginWriteAttribute("value", " value=\"", 2182, "\"", 2190, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n\n            </div>\n\n            <div class=\"mt-5 text-center\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60220fcf5025339ccea0fe78c38a2ffb1eda02b17477", async() => {
                WriteLiteral("\n                    <button class=\"btn btn-primary profile-button\" type=\"button\">Save Profile</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"mt-5 text-center\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60220fcf5025339ccea0fe78c38a2ffb1eda02b19038", async() => {
                WriteLiteral("\n                    <button type=\"button\" class=\"btn btn-danger\">Delete Profile</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
