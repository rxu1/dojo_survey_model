#pragma checksum "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/Home/Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf51b9f81b89be10171e425b1dd35e7d194d71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Results.cshtml", typeof(AspNetCore.Views_Home_Results))]
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
#line 1 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/_ViewImports.cshtml"
using DojoSurveyModel;

#line default
#line hidden
#line 2 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/_ViewImports.cshtml"
using DojoSurveyModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf51b9f81b89be10171e425b1dd35e7d194d71b", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4289d96fd8ae90127722315813cc45e29f652a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/Home/Results.cshtml"
  
  ViewData["title"] = "Dojo Survey Index";

#line default
#line hidden
            BeginContext(48, 67, true);
            WriteLiteral("<div class=\"container-fluid\">\n  <h1>Submitted Info</h1>\n  <p>Name: ");
            EndContext();
            BeginContext(116, 10, false);
#line 6 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/Home/Results.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(126, 16, true);
            WriteLiteral("</p>\n  <p>Name: ");
            EndContext();
            BeginContext(143, 15, false);
#line 7 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/Home/Results.cshtml"
      Write(Model.Languages);

#line default
#line hidden
            EndContext();
            BeginContext(158, 16, true);
            WriteLiteral("</p>\n  <p>Name: ");
            EndContext();
            BeginContext(175, 15, false);
#line 8 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/Home/Results.cshtml"
      Write(Model.Locations);

#line default
#line hidden
            EndContext();
            BeginContext(190, 16, true);
            WriteLiteral("</p>\n  <p>Name: ");
            EndContext();
            BeginContext(207, 14, false);
#line 9 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/DojoSurveyModel/Views/Home/Results.cshtml"
      Write(Model.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(221, 62, true);
            WriteLiteral("</p>\n  <a href=\"/\" class=\"btn btn-primary\">Go Back!</a>\n</div>");
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