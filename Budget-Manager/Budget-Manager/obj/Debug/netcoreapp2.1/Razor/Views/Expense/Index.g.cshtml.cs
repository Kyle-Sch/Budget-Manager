#pragma checksum "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28f5246416ee51e6fb66aa6511426c989298ad64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense_Index), @"mvc.1.0.view", @"/Views/Expense/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Expense/Index.cshtml", typeof(AspNetCore.Views_Expense_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f5246416ee51e6fb66aa6511426c989298ad64", @"/Views/Expense/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c9d3d4faf0ef0b648a42a26e1147451c526d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExpensePost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewExpense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(63, 28, true);
            WriteLiteral("\r\n<h2> Expense Board </h2>\r\n");
            EndContext();
#line 8 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
 if (Model.PostSuccess) {

#line default
#line hidden
            BeginContext(118, 43, true);
            WriteLiteral("    <h2>Your message has been saved!</h2>\r\n");
            EndContext();
#line 10 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
}

#line default
#line hidden
            BeginContext(164, 43, true);
            WriteLiteral("<nav style=\"text-align:center\">\r\n\r\n</nav>\r\n");
            EndContext();
#line 14 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
  
    for (int i = 0; i < Model.Results.Count; i++) {
        if (i % 2 != 0) {

#line default
#line hidden
            BeginContext(291, 77, true);
            WriteLiteral("            <div style=\"background-color: lightgray\">\r\n                <p><b>");
            EndContext();
            BeginContext(369, 35, false);
#line 18 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
                 Write(Model.Results[i].ExpenseDescription);

#line default
#line hidden
            EndContext();
            BeginContext(404, 32, true);
            WriteLiteral("</b></p>\r\n                <p>by ");
            EndContext();
            BeginContext(437, 32, false);
#line 19 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
                 Write(Model.Results[i].ExpenseCategory);

#line default
#line hidden
            EndContext();
            BeginContext(469, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(471, 24, false);
#line 19 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
                                                   Write(Model.Results[i].GroupId);

#line default
#line hidden
            EndContext();
            BeginContext(495, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(521, 30, false);
#line 20 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
              Write(Model.Results[i].ExpenseAmount);

#line default
#line hidden
            EndContext();
            BeginContext(551, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(573, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba603b0283654735afbf87e15da1da42", async() => {
                BeginContext(638, 14, true);
                WriteLiteral("Post a Message");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(656, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 23 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
        }
        else {

#line default
#line hidden
            BeginContext(705, 18, true);
            WriteLiteral("            <p><b>");
            EndContext();
            BeginContext(724, 35, false);
#line 25 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
             Write(Model.Results[i].ExpenseDescription);

#line default
#line hidden
            EndContext();
            BeginContext(759, 28, true);
            WriteLiteral("</b></p>\r\n            <p>by ");
            EndContext();
            BeginContext(788, 32, false);
#line 26 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
             Write(Model.Results[i].ExpenseCategory);

#line default
#line hidden
            EndContext();
            BeginContext(820, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(822, 24, false);
#line 26 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
                                               Write(Model.Results[i].GroupId);

#line default
#line hidden
            EndContext();
            BeginContext(846, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(868, 30, false);
#line 27 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
          Write(Model.Results[i].ExpenseAmount);

#line default
#line hidden
            EndContext();
            BeginContext(898, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(916, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f04d37a04b44034add07c3a58f79a75", async() => {
                BeginContext(981, 14, true);
                WriteLiteral("Post a Message");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(999, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\Kyle S\workspace\Ind Projects\Budget-Manager\Budget-Manager\Budget-Manager\Views\Expense\Index.cshtml"
        }
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpensePost> Html { get; private set; }
    }
}
#pragma warning restore 1591
