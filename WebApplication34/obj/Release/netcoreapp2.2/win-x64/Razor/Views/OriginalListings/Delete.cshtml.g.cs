#pragma checksum "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6c853646139bf2afa4b0a2d0432b0b4346204e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OriginalListings_Delete), @"mvc.1.0.view", @"/Views/OriginalListings/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OriginalListings/Delete.cshtml", typeof(AspNetCore.Views_OriginalListings_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6c853646139bf2afa4b0a2d0432b0b4346204e", @"/Views/OriginalListings/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7270791f3251624f4c590c4cfdce1df5ba22d191", @"/Views/_ViewImports.cshtml")]
    public class Views_OriginalListings_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication34.Data.OriginalListing>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 185, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>OriginalListing</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(276, 44, false);
#line 15 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(320, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(384, 40, false);
#line 18 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(424, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(487, 46, false);
#line 21 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CmndNumber));

#line default
#line hidden
            EndContext();
            BeginContext(533, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(597, 42, false);
#line 24 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CmndNumber));

#line default
#line hidden
            EndContext();
            BeginContext(639, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(702, 48, false);
#line 27 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CmndIssueDay));

#line default
#line hidden
            EndContext();
            BeginContext(750, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(814, 44, false);
#line 30 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CmndIssueDay));

#line default
#line hidden
            EndContext();
            BeginContext(858, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(921, 43, false);
#line 33 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(964, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1028, 39, false);
#line 36 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1130, 43, false);
#line 39 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1237, 39, false);
#line 42 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1339, 56, false);
#line 45 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberStockDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1459, 52, false);
#line 48 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumberStockDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1574, 58, false);
#line 51 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberStockNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1696, 54, false);
#line 54 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumberStockNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1813, 52, false);
#line 57 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberStockTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1929, 48, false);
#line 60 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumberStockTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2040, 53, false);
#line 63 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2157, 49, false);
#line 66 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DividendDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2206, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2269, 55, false);
#line 69 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2388, 51, false);
#line 72 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DividendNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(2439, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2502, 49, false);
#line 75 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2551, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2615, 45, false);
#line 78 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DividendTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2660, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2723, 48, false);
#line 81 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2771, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2835, 44, false);
#line 84 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaxDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2879, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2942, 50, false);
#line 87 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(2992, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3056, 46, false);
#line 90 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaxNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(3102, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3165, 44, false);
#line 93 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3209, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3273, 40, false);
#line 96 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaxTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3313, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3376, 61, false);
#line 99 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendReceivedDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(3437, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3501, 57, false);
#line 102 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DividendReceivedDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(3558, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3621, 63, false);
#line 105 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendReceivedNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(3684, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3748, 59, false);
#line 108 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DividendReceivedNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(3807, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3870, 57, false);
#line 111 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendReceivedTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3927, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3991, 53, false);
#line 114 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DividendReceivedTotal));

#line default
#line hidden
            EndContext();
            BeginContext(4044, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4107, 40, false);
#line 117 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(4147, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4211, 36, false);
#line 120 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(4247, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4310, 58, false);
#line 123 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AssignmentOrganization));

#line default
#line hidden
            EndContext();
            BeginContext(4368, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4432, 54, false);
#line 126 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AssignmentOrganization));

#line default
#line hidden
            EndContext();
            BeginContext(4486, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4549, 41, false);
#line 129 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Txnum));

#line default
#line hidden
            EndContext();
            BeginContext(4590, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4654, 37, false);
#line 132 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Txnum));

#line default
#line hidden
            EndContext();
            BeginContext(4691, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4754, 41, false);
#line 135 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4795, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4859, 37, false);
#line 138 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4896, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4959, 41, false);
#line 141 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(5000, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5064, 37, false);
#line 144 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(5101, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5164, 40, false);
#line 147 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(5204, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5268, 36, false);
#line 150 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(5304, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5367, 40, false);
#line 153 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(5407, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5471, 36, false);
#line 156 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(5507, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5570, 41, false);
#line 159 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Batch));

#line default
#line hidden
            EndContext();
            BeginContext(5611, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5675, 37, false);
#line 162 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Batch));

#line default
#line hidden
            EndContext();
            BeginContext(5712, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5775, 43, false);
#line 165 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(5818, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5882, 39, false);
#line 168 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(5921, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5984, 43, false);
#line 171 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(6027, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6091, 39, false);
#line 174 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(6130, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(6193, 45, false);
#line 177 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(6238, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6302, 41, false);
#line 180 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(6343, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(6406, 44, false);
#line 183 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateBy));

#line default
#line hidden
            EndContext();
            BeginContext(6450, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6514, 40, false);
#line 186 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdateBy));

#line default
#line hidden
            EndContext();
            BeginContext(6554, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(6617, 41, false);
#line 189 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tesss));

#line default
#line hidden
            EndContext();
            BeginContext(6658, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6722, 37, false);
#line 192 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tesss));

#line default
#line hidden
            EndContext();
            BeginContext(6759, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(6797, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6c853646139bf2afa4b0a2d0432b0b4346204e31940", async() => {
                BeginContext(6823, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6833, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b6c853646139bf2afa4b0a2d0432b0b4346204e32333", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 197 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6869, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(6952, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6c853646139bf2afa4b0a2d0432b0b4346204e34259", async() => {
                    BeginContext(6974, 12, true);
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
                BeginContext(6990, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7003, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication34.Data.OriginalListing> Html { get; private set; }
    }
}
#pragma warning restore 1591