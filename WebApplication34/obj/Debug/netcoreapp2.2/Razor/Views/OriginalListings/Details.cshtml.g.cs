#pragma checksum "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b97989d1f7e794f0c830ff29455a4273d5faa9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OriginalListings_Details), @"mvc.1.0.view", @"/Views/OriginalListings/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OriginalListings/Details.cshtml", typeof(AspNetCore.Views_OriginalListings_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b97989d1f7e794f0c830ff29455a4273d5faa9c", @"/Views/OriginalListings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7270791f3251624f4c590c4cfdce1df5ba22d191", @"/Views/_ViewImports.cshtml")]
    public class Views_OriginalListings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication34.Data.OriginalListing>
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 137, true);
            WriteLiteral("\r\n<h1>Chi tiết</h1>\r\n\r\n<div>\r\n    <h4>Thông tin gốc</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(229, 44, false);
#line 14 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(273, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(337, 40, false);
#line 17 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(377, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 46, false);
#line 20 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CmndNumber));

#line default
#line hidden
            EndContext();
            BeginContext(486, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(550, 42, false);
#line 23 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.CmndNumber));

#line default
#line hidden
            EndContext();
            BeginContext(592, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(655, 48, false);
#line 26 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CmndIssueDay));

#line default
#line hidden
            EndContext();
            BeginContext(703, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(767, 44, false);
#line 29 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.CmndIssueDay));

#line default
#line hidden
            EndContext();
            BeginContext(811, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(874, 43, false);
#line 32 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(917, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(981, 39, false);
#line 35 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1083, 43, false);
#line 38 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1190, 39, false);
#line 41 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1292, 56, false);
#line 44 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberStockDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1412, 52, false);
#line 47 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberStockDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1527, 58, false);
#line 50 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberStockNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1649, 54, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberStockNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1766, 52, false);
#line 56 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberStockTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1882, 48, false);
#line 59 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberStockTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1993, 53, false);
#line 62 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2110, 49, false);
#line 65 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DividendDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2222, 55, false);
#line 68 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2341, 51, false);
#line 71 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DividendNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(2392, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2455, 49, false);
#line 74 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2568, 45, false);
#line 77 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DividendTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2613, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2676, 48, false);
#line 80 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2724, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2788, 44, false);
#line 83 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaxDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(2832, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2895, 50, false);
#line 86 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(2945, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3009, 46, false);
#line 89 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaxNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3118, 44, false);
#line 92 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3162, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3226, 40, false);
#line 95 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaxTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3266, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3329, 61, false);
#line 98 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendReceivedDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(3390, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3454, 57, false);
#line 101 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DividendReceivedDeposited));

#line default
#line hidden
            EndContext();
            BeginContext(3511, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3574, 63, false);
#line 104 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendReceivedNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(3637, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3701, 59, false);
#line 107 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DividendReceivedNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(3760, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3823, 57, false);
#line 110 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DividendReceivedTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3880, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3944, 53, false);
#line 113 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DividendReceivedTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3997, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4060, 40, false);
#line 116 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(4100, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4164, 36, false);
#line 119 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(4200, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4263, 58, false);
#line 122 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AssignmentOrganization));

#line default
#line hidden
            EndContext();
            BeginContext(4321, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4385, 54, false);
#line 125 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.AssignmentOrganization));

#line default
#line hidden
            EndContext();
            BeginContext(4439, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4502, 41, false);
#line 128 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Txnum));

#line default
#line hidden
            EndContext();
            BeginContext(4543, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4607, 37, false);
#line 131 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Txnum));

#line default
#line hidden
            EndContext();
            BeginContext(4644, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4707, 41, false);
#line 134 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4748, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4812, 37, false);
#line 137 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4849, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4912, 41, false);
#line 140 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(4953, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5017, 37, false);
#line 143 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(5054, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5117, 40, false);
#line 146 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(5157, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5221, 36, false);
#line 149 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(5257, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5320, 40, false);
#line 152 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(5360, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5424, 36, false);
#line 155 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(5460, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5523, 41, false);
#line 158 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Batch));

#line default
#line hidden
            EndContext();
            BeginContext(5564, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5628, 37, false);
#line 161 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Batch));

#line default
#line hidden
            EndContext();
            BeginContext(5665, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5728, 43, false);
#line 164 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(5771, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5835, 39, false);
#line 167 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(5874, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5937, 43, false);
#line 170 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(5980, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6044, 39, false);
#line 173 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(6083, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(6146, 45, false);
#line 176 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(6191, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6255, 41, false);
#line 179 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(6296, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(6359, 44, false);
#line 182 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateBy));

#line default
#line hidden
            EndContext();
            BeginContext(6403, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6467, 40, false);
#line 185 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdateBy));

#line default
#line hidden
            EndContext();
            BeginContext(6507, 55, true);
            WriteLiteral("\r\n        </dd>\r\n      \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6562, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b97989d1f7e794f0c830ff29455a4273d5faa9c30384", async() => {
                BeginContext(6608, 4, true);
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
#line 191 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\OriginalListings\Details.cshtml"
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
            BeginContext(6616, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(6624, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b97989d1f7e794f0c830ff29455a4273d5faa9c32727", async() => {
                BeginContext(6646, 12, true);
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
            BeginContext(6662, 10, true);
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
