#pragma checksum "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5068be0a8ee49edbc9b0997620433ba01c4908a9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5068be0a8ee49edbc9b0997620433ba01c4908a9", @"/Views/BankAccounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7270791f3251624f4c590c4cfdce1df5ba22d191", @"/Views/_ViewImports.cshtml")]
    public class Views_BankAccounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication34.Paging.PaginatedList<WebApplication34.Data.BankAccount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pagingvan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
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
            BeginContext(124, 32, true);
            WriteLiteral("\r\n<h1>Danh sách TKNH</h1>\r\n<p>\r\n");
            EndContext();
#line 9 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
     using (Html.BeginForm("Index", "BankAccounts", FormMethod.Get))
    {

#line default
#line hidden
            BeginContext(233, 187, true);
            WriteLiteral("    <p>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n                <div class=\"form-group\">\r\n                    <input id=\"search\" class=\"form-control\" name=\"search\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 420, "\"", 443, 1);
#line 15 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
WriteAttributeValue("", 428, ViewBag.search, 428, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(444, 338, true);
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
            BeginContext(785, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(789, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5068be0a8ee49edbc9b0997620433ba01c4908a96198", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5068be0a8ee49edbc9b0997620433ba01c4908a97567", async() => {
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
            BeginContext(859, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 28 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
      
        if (Model.Count() > 0)
        {


#line default
#line hidden
            BeginContext(924, 502, true);
            WriteLiteral(@"            <table class=""table table-hover"">
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
            BeginContext(1474, 78, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1625, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1722, 45, false);
#line 55 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CmndNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1871, 48, false);
#line 58 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Beneficiaries));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2023, 48, false);
#line 61 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NumberAccount));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2175, 39, false);
#line 64 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Bank));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
            BeginContext(2572, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 72 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2661, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 75 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2745, 70, true);
            WriteLiteral("            <p style=\"text-align:center\">Không tìm thấy dữ liệu!</p>\r\n");
            EndContext();
#line 79 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\BankAccounts\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(2833, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5068be0a8ee49edbc9b0997620433ba01c4908a913299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
