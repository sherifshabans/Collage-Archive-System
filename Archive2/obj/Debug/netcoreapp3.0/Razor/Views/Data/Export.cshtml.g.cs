#pragma checksum "D:\SW Engineering\Sixth term\Software Development\Project\Project\Software-Development-Project\Archive2\Views\Data\Export.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de97fc145c1786cacc6363764d4e59efe601b202"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_Export), @"mvc.1.0.view", @"/Views/Data/Export.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de97fc145c1786cacc6363764d4e59efe601b202", @"/Views/Data/Export.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e686de7ce6e2b4c2b71065f22d651816412f73e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Data_Export : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container text-center mb-5 login-btn"">
    <div>
        <h1 style=""color:black""> Export Message </h1>
        <hr class="" w/75"" />
    </div>
</div>

<style>
    .input-group {
        width: 50%;
        display: flex;
        justify-content: center; /* Added to center search button */
        margin: 0 auto; /* Added to center input group */
    }

    select {
        width: 150px;
    }

        select:focus {
            min-width: 150px;
            width: auto;
        }
</style>

<style>
    body {
        background-image: url('../login/img/bench-accounting-nvzvopqw0gc-unsplash.jpg');
        background-repeat: no-repeat;
        background-attachment: fixed;
        background-size: 100% 100%;
    }
</style>

<div>
    <div class=""input-group input-group-sm mb-3"">
        <div class="" shiftleft btn-group"" role=""group"" aria-label=""Basic outlined example"">
            <input type=""text"" class=""form-control"" aria-label=""Sizing example input"" aria-describedby=""inputGroup-sizing-sm"">
     ");
            WriteLiteral(@"       <button type=""button"" style=""color:white; background-color:#CD9775; border-color:#CD9775"" class=""btn btn-outline-primary"">Search</button>
        </div>
    </div>

</div>

<div class=""container rounded mt-5 mb-5"">

    <div id=""datatable""></div>

    <div dir=""ltr"">
        <table class=""table table-striped table-hover"">
            <thead class=""table-light"">
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Date</th>
                    <th scope=""col"">The letter coming from</th>
                    <th scope=""col"">Address of the letter</th>
                    <th scope=""col"">Show the letter</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>255</td>
                    <td>2022-06-08</td>
                    <td>faculty of Engineering</td>
                    <td>faculty of Computers and Information</td>
                    <td>


                        <a href=""https://localhost:44339");
            WriteLiteral(@"/User/ViewMessage"" class=""btn btn-outline-primary btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""عرض""><i class=""fa fa-table""></i>Show</a>

                    </td>
                </tr>
                <tr>
                    <td>255</td>
                    <td>2022-06-08</td>
                    <td>faculty of Engineering</td>
                    <td>faculty of Computers and Information</td>
                    <td>


                        <a href=""https://localhost:44339/User/ViewMessage"" class=""btn btn-outline-primary btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""عرض""><i class=""fa fa-table""></i>Show</a>

                    </td>
                </tr>
                <tr>
                    <td>255</td>
                    <td>2022-06-08</td>
                    <td>faculty of Engineering</td>
                    <td>faculty of Computers and Information</td>
                    <td>


                        <a href=""https://local");
            WriteLiteral(@"host:44339/User/ViewMessage"" class=""btn btn-outline-primary btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""عرض""><i class=""fa fa-table""></i>Show</a>

                    </td>
                </tr>
                <tr>
                    <td>255</td>
                    <td>2022-06-08</td>
                    <td>faculty of Engineering</td>
                    <td>faculty of Computers and Information</td>
                    <td>


                        <a href=""https://localhost:44339/User/ViewMessage"" class=""btn btn-outline-primary btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""عرض""><i class=""fa fa-table""></i>Show</a>

                    </td>
                </tr>
                <tr>
                    <td>255</td>
                    <td>2022-06-08</td>
                    <td>faculty of Engineering</td>
                    <td>faculty of Computers and Information</td>
                    <td>


                        <a href=""htt");
            WriteLiteral(@"ps://localhost:44339/User/ViewMessage"" class=""btn btn-outline-primary btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""عرض""><i class=""fa fa-table""></i>Show</a>

                    </td>
                </tr>
            </tbody>
        </table>
    </div>


</div>


");
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