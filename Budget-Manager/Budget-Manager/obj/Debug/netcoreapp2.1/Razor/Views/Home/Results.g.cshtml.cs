#pragma checksum "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5628a062129bb44f067d0bb930a1cd3d292bd440"
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
#line 1 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\_ViewImports.cshtml"
using Budget_Manager;

#line default
#line hidden
#line 2 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\_ViewImports.cshtml"
using Budget_Manager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5628a062129bb44f067d0bb930a1cd3d292bd440", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c9d3d4faf0ef0b648a42a26e1147451c526d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<decimal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 68, true);
            WriteLiteral("<h2>Personal Budget Manager and Tracker</h2>\r\n\r\n<h3>Total Expenses: ");
            EndContext();
            BeginContext(136, 8, false);
#line 7 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Home\Results.cshtml"
               Write(Model[0]);

#line default
#line hidden
            EndContext();
            BeginContext(144, 25, true);
            WriteLiteral("</h3>\r\n<h3>Total Income: ");
            EndContext();
            BeginContext(170, 8, false);
#line 8 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Home\Results.cshtml"
             Write(Model[1]);

#line default
#line hidden
            EndContext();
            BeginContext(178, 51, true);
            WriteLiteral("</h3>\r\n\r\n<h3>Total Money left over for the month:  ");
            EndContext();
            BeginContext(230, 8, false);
#line 10 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Home\Results.cshtml"
                                     Write(Model[2]);

#line default
#line hidden
            EndContext();
            BeginContext(238, 5, true);
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<decimal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
