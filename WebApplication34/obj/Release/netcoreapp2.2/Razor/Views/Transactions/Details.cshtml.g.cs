#pragma checksum "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0349d7f91a3cc026e281ec44d4cff2576eb213a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Details), @"mvc.1.0.view", @"/Views/Transactions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transactions/Details.cshtml", typeof(AspNetCore.Views_Transactions_Details))]
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
#line 1 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\_ViewImports.cshtml"
using WebApplication34;

#line default
#line hidden
#line 2 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\_ViewImports.cshtml"
using WebApplication34.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0349d7f91a3cc026e281ec44d4cff2576eb213a9", @"/Views/Transactions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7270791f3251624f4c590c4cfdce1df5ba22d191", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication34.Data.Transaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 134, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Transaction</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(222, 40, false);
#line 14 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnmd));

#line default
#line hidden
            EndContext();
            BeginContext(262, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(326, 36, false);
#line 17 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cnmd));

#line default
#line hidden
            EndContext();
            BeginContext(362, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(425, 40, false);
#line 20 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(465, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(529, 36, false);
#line 23 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(565, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(628, 44, false);
#line 26 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(672, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(736, 40, false);
#line 29 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(776, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(839, 48, false);
#line 32 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReceiveMoney));

#line default
#line hidden
            EndContext();
            BeginContext(887, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(951, 44, false);
#line 35 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReceiveMoney));

#line default
#line hidden
            EndContext();
            BeginContext(995, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1058, 39, false);
#line 38 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1161, 35, false);
#line 41 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1259, 52, false);
#line 44 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RealRecevieMoney));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1375, 48, false);
#line 47 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.RealRecevieMoney));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1486, 43, false);
#line 50 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1593, 39, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1695, 42, false);
#line 56 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsPaid));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1801, 38, false);
#line 59 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsPaid));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1902, 44, false);
#line 62 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaidDate));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2010, 40, false);
#line 65 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaidDate));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2113, 47, false);
#line 68 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BankAccount));

#line default
#line hidden
            EndContext();
            BeginContext(2160, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2224, 54, false);
#line 71 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.BankAccount.CmndNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2341, 44, false);
#line 74 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Original));

#line default
#line hidden
            EndContext();
            BeginContext(2385, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2449, 43, false);
#line 77 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Original.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2492, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2539, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0349d7f91a3cc026e281ec44d4cff2576eb213a914005", async() => {
                BeginContext(2585, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2593, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2601, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0349d7f91a3cc026e281ec44d4cff2576eb213a916343", async() => {
                BeginContext(2623, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2639, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication34.Data.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
