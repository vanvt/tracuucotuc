#pragma checksum "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497ef48194719eb85c4b6d2bc055d6973c59f563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BankAccounts_Index), @"mvc.1.0.view", @"/Views/BankAccounts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BankAccounts/Index.cshtml", typeof(AspNetCore.Views_BankAccounts_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497ef48194719eb85c4b6d2bc055d6973c59f563", @"/Views/BankAccounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7270791f3251624f4c590c4cfdce1df5ba22d191", @"/Views/_ViewImports.cshtml")]
    public class Views_BankAccounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication34.Paging.PaginatedList<WebApplication34.Data.BankAccount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(124, 36, true);
            WriteLiteral("\r\n    <h1>Danh sách TKNH</h1>\r\n<p>\r\n");
            EndContext();
#line 9 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
     using (Html.BeginForm("Index", "BankAccounts", FormMethod.Get))
    {

#line default
#line hidden
            BeginContext(237, 187, true);
            WriteLiteral("    <p>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n                <div class=\"form-group\">\r\n                    <input id=\"search\" class=\"form-control\" name=\"search\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 424, "\"", 447, 1);
#line 15 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
WriteAttributeValue("", 432, ViewBag.search, 432, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(448, 338, true);
            WriteLiteral(@" onchange=""handleSearch(this);"" placeholder=""Nhập CMND"" />
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <input type=""submit"" value=""Tìm kiếm"" class=""btn btn-primary"" />
                </div>
            </div>
        </div>
    </p>
");
            EndContext();
#line 25 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
}

#line default
#line hidden
            BeginContext(789, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497ef48194719eb85c4b6d2bc055d6973c59f5635966", async() => {
                BeginContext(812, 7, true);
                WriteLiteral("Tạo mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(823, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(826, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497ef48194719eb85c4b6d2bc055d6973c59f5637335", async() => {
                BeginContext(849, 6, true);
                WriteLiteral("Import");
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
            BeginContext(859, 318, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                CMDN
            </th>
            <th>
                Người hưởng thụ
            </th>
            <th>
                Số tài khoản
            </th>
            <th>
                Ngân hàng
            </th>
");
            EndContext();
            BeginContext(1213, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1304, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1365, 45, false);
#line 51 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CmndNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1478, 48, false);
#line 54 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Beneficiaries));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1594, 48, false);
#line 57 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberAccount));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1710, 39, false);
#line 60 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Bank));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(2039, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 68 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2092, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 71 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
            BeginContext(2251, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2255, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497ef48194719eb85c4b6d2bc055d6973c59f56312114", async() => {
                BeginContext(2369, 16, true);
                WriteLiteral("\r\n    Previous\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2338, "btn", 2338, 3, true);
            AddHtmlAttributeValue(" ", 2341, "btn-default", 2342, 12, true);
#line 79 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
AddHtmlAttributeValue(" ", 2353, prevDisabled, 2354, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2389, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2391, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497ef48194719eb85c4b6d2bc055d6973c59f56315077", async() => {
                BeginContext(2505, 12, true);
                WriteLiteral("\r\n    Next\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2474, "btn", 2474, 3, true);
            AddHtmlAttributeValue(" ", 2477, "btn-default", 2478, 12, true);
#line 84 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
AddHtmlAttributeValue(" ", 2489, nextDisabled, 2490, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication34.Paging.PaginatedList<WebApplication34.Data.BankAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
