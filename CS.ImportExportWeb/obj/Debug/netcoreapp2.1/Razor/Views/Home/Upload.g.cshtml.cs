#pragma checksum "/Users/andrei/Work/andrei-alex-m/CadSys/CS.ImportExportWeb/Views/Home/Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f91f09b17afff7ecf009bf89a9f5fe5080e82b84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Upload), @"mvc.1.0.view", @"/Views/Home/Upload.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Upload.cshtml", typeof(AspNetCore.Views_Home_Upload))]
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
#line 1 "/Users/andrei/Work/andrei-alex-m/CadSys/CS.ImportExportWeb/Views/_ViewImports.cshtml"
using CS.ImportExportWeb;

#line default
#line hidden
#line 2 "/Users/andrei/Work/andrei-alex-m/CadSys/CS.ImportExportWeb/Views/_ViewImports.cshtml"
using CS.ImportExportWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91f09b17afff7ecf009bf89a9f5fe5080e82b84", @"/Views/Home/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1516f8a14feed67e37c3b754cc6055179991c9dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/andrei/Work/andrei-alex-m/CadSys/CS.ImportExportWeb/Views/Home/Upload.cshtml"
  
    ViewData["Title"] = "Upload";

#line default
#line hidden
            BeginContext(42, 22, true);
            WriteLiteral("<h2>Upload Form</h2>\r\n");
            EndContext();
#line 5 "/Users/andrei/Work/andrei-alex-m/CadSys/CS.ImportExportWeb/Views/Home/Upload.cshtml"
 using (Html.BeginForm("UploadFile", "Import", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(174, 115, true);
            WriteLiteral("    <input type = \"file\" name = \"file\" multiple/>\r\n    <br/>\r\n    <button type = \"submit\" > Upload File </button>\r\n");
            EndContext();
#line 10 "/Users/andrei/Work/andrei-alex-m/CadSys/CS.ImportExportWeb/Views/Home/Upload.cshtml"
}

#line default
#line hidden
            BeginContext(292, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(510, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
