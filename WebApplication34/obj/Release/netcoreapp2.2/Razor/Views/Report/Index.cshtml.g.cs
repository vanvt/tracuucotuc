#pragma checksum "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "166159c98a1f86b0e1835197415b8a75511767d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Index), @"mvc.1.0.view", @"/Views/Report/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/Index.cshtml", typeof(AspNetCore.Views_Report_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"166159c98a1f86b0e1835197415b8a75511767d3", @"/Views/Report/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7270791f3251624f4c590c4cfdce1df5ba22d191", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication34.Models.ReportVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(82, 343, true);
            WriteLiteral(@"
<h1>Báo cáo tổng hợp</h1>
<h3>Đã chi</h3>
<table class=""table table-hover"">
    <thead>
        <tr>

            <th scope=""col"">Đã chi</th>
            <th scope=""col"">Số tiền</th>
            <th scope=""col"">Số cổ đông</th>
        </tr>
    </thead>
    <tbody>
        <tr>

            <td>Tiền mặt</td>
            <td>");
            EndContext();
            BeginContext(426, 23, false);
#line 21 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tienMatDachi_tien);

#line default
#line hidden
            EndContext();
            BeginContext(449, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(473, 21, false);
#line 22 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tienMatDachi_cd);

#line default
#line hidden
            EndContext();
            BeginContext(494, 89, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n\r\n            <td>Chuyển khoản</td>\r\n            <td>");
            EndContext();
            BeginContext(584, 27, false);
#line 27 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.chuyenKhoanDachi_tien);

#line default
#line hidden
            EndContext();
            BeginContext(611, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(635, 25, false);
#line 28 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.chuyenKhoanDachi_cd);

#line default
#line hidden
            EndContext();
            BeginContext(660, 79, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Tổng</td>\r\n            <td>");
            EndContext();
            BeginContext(740, 20, false);
#line 32 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tongDachi_tien);

#line default
#line hidden
            EndContext();
            BeginContext(760, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(784, 18, false);
#line 33 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tongDachi_cd);

#line default
#line hidden
            EndContext();
            BeginContext(802, 372, true);
            WriteLiteral(@"</td>
        </tr>
    </tbody>
</table>

<hr />
<h3>Còn lại</h3>
<table class=""table table-hover"">
    <thead>
        <tr>

            <th scope=""col"">Còn lại</th>
            <th scope=""col"">Số tiền</th>
            <th scope=""col"">Số cổ đông</th>
        </tr>
    </thead>
    <tbody>
        <tr>

            <td>Tiền mặt</td>
            <td>");
            EndContext();
            BeginContext(1175, 24, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tienMatConlai_tien);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1223, 22, false);
#line 54 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tienMatConlai_cd);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 89, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n\r\n            <td>Chuyển khoản</td>\r\n            <td>");
            EndContext();
            BeginContext(1335, 28, false);
#line 59 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.chuyenKhoanConlai_tien);

#line default
#line hidden
            EndContext();
            BeginContext(1363, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1387, 26, false);
#line 60 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.chuyenKhoanConlai_cd);

#line default
#line hidden
            EndContext();
            BeginContext(1413, 79, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Tổng</td>\r\n            <td>");
            EndContext();
            BeginContext(1493, 21, false);
#line 64 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tongConlai_tien);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1538, 19, false);
#line 65 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Report\Index.cshtml"
           Write(Model.tongConlai_cd);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 46, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication34.Models.ReportVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
