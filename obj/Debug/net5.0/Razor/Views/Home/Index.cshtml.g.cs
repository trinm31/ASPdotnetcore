#pragma checksum "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cccd66f9715bf4e74dabdc9392b52616bfeda3d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/_ViewImports.cshtml"
using ORM_EFcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/_ViewImports.cshtml"
using ORM_EFcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cccd66f9715bf4e74dabdc9392b52616bfeda3d5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78f729c10b9e614fca69e202c6a25988ca85861a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ORM_EFcore.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>So tu controller la </h1>\n\n<table>\n    <thead>\n        <tr>\n            <th>Name</th>\n            <th>Age</th>\n            <th>HomeTown</th>\n            <th>StudentFee</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 19 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml"
     foreach (var student in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 22 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml"
               Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml"
               Write(student.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml"
               Write(student.HomeTown);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml"
               Write(student.StudentFee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 27 "/Users/nguyenminhtri/RiderProjects/ORM-EFcore/ORM-EFcore/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ORM_EFcore.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
