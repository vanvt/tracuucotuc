#pragma checksum "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355209af244df141ca0a9b18f96a769fe20b331f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Payment), @"mvc.1.0.view", @"/Views/Transactions/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transactions/Payment.cshtml", typeof(AspNetCore.Views_Transactions_Payment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355209af244df141ca0a9b18f96a769fe20b331f", @"/Views/Transactions/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7270791f3251624f4c590c4cfdce1df5ba22d191", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication34.Data.Transaction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(87, 698, true);
            WriteLiteral(@"

<div id=""print"" style=""border:solid; padding: 0px 0px 0px 10px;"">
    <dl class=""row"">
        <dt class=""col-md-12"">
            Đơn vị: CÔNG TY CỔ PHẦN SÔNG BA
        </dt>
        <dt class=""col-md-12"">
            Địa chỉ: 573 Núi Thành - TP Đà Nẵng
        </dt>
        <dt class=""col-md-12"">
            <p class=""text-center"" style=""font-size: 30px;"">PHIẾU CHI</p>
        </dt>
        <dt class=""col-md-12 text-center font-weight-light"" style=""font-style: oblique;font-family: none;"">
            Liên 01: Lưu
        </dt>
        <dt class=""col-md-12 text-center font-weight-normal"" style=""font-style: oblique;font-family: none;margin-left: 200px;"">
            Số: ");
            EndContext();
            BeginContext(786, 8, false);
#line 23 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(794, 199, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Họ tên người nhận tiền:\r\n        </dt>\r\n        <dt class=\"col-md-4 font-weight-normal\">\r\n            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 993, "\"", 1016, 1);
#line 29 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
WriteAttributeValue("", 1001, Model.FullName, 1001, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1017, 254, true);
            WriteLiteral(" />\r\n        </dt>\r\n        <dt class=\"col-md-5 font-weight-normal\">\r\n\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Số CMND:\r\n        </dt>\r\n        <dt class=\"col-md-4 font-weight-normal\">\r\n            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1271, "\"", 1290, 1);
#line 38 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
WriteAttributeValue("", 1279, Model.Cnmd, 1279, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1291, 92, true);
            WriteLiteral(" />\r\n        </dt>\r\n        <dt class=\"col-md-5 font-weight-normal\">\r\n            Ngày cấp: ");
            EndContext();
            BeginContext(1384, 27, false);
#line 41 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                 Write(Model.Original.CmndIssueDay);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 166, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Địa chỉ:\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(1578, 22, false);
#line 47 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(Model.Original.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1600, 184, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Lý do chi:\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            Tiền cổ tức năm ");
            EndContext();
            BeginContext(1785, 10, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                       Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1795, 5, true);
            WriteLiteral(" đợt ");
            EndContext();
            BeginContext(1801, 11, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                       Write(Model.Batch);

#line default
#line hidden
            EndContext();
            BeginContext(1812, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1814, 37, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                                    Write(Model.Original.NumberStockNotDeposite);

#line default
#line hidden
            EndContext();
            BeginContext(1851, 6, true);
            WriteLiteral(" CP x ");
            EndContext();
            BeginContext(1858, 102, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                                                                                Write(string.Format("{0:#,##0}", Model.Original.DividendNotDeposite / Model.Original.NumberStockNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 6, true);
            WriteLiteral("  đ = ");
            EndContext();
            BeginContext(1967, 62, false);
#line 53 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                                                                                                                                                                                             Write(string.Format("{0:#,##0}", Model.Original.DividendNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 175, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Trừ thuế TNCN 5%:\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(2205, 37, false);
#line 59 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(string.Format("{0:#,##0}", Model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(2242, 175, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Số tiền nhận được\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(2418, 50, false);
#line 65 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(string.Format("{0:#,##0}", Model.RealRecevieMoney));

#line default
#line hidden
            EndContext();
            BeginContext(2468, 189, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Số tiền nhận được viết bằng chữ\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(2658, 83, false);
#line 71 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(WebApplication34.Helper.ConverterMoney.NumberToTextVN(Model.RealRecevieMoney.Value));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 576, true);
            WriteLiteral(@"
        </dt>
        <dt class=""col-md-4 text-center"" style=""padding-bottom: 70px;"">
            Phòng TC-KT
        </dt>
        <dt class=""col-md-4 text-center"">
            Thủ quỹ
        </dt>
        <dt class=""col-md-4 text-center"">
            Người nhận
        </dt>
        <dt class=""col-md-4 text-center font-weight-normal"">
            Phạm Thái Hùng
        </dt>
        <dt class=""col-md-4 text-center font-weight-normal"">
            Võ Thị Minh Thu
        </dt>
        <dt class=""col-md-4 text-center font-weight-normal"">
            ");
            EndContext();
            BeginContext(3318, 14, false);
#line 89 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3332, 745, true);
            WriteLiteral(@"
        </dt>
    </dl>
</div>
<hr />
<div id=""print"" style=""border:solid; padding: 0px 0px 0px 10px;"">
    <dl class=""row"">
        <dt class=""col-md-12"">
            Đơn vị: CÔNG TY CỔ PHẦN SÔNG BA
        </dt>
        <dt class=""col-md-12"">
            Địa chỉ: 573 Núi Thành - TP Đà Nẵng
        </dt>
        <dt class=""col-md-12"">
            <p class=""text-center"" style=""font-size: 30px;"">PHIẾU CHI</p>
        </dt>
        <dt class=""col-md-12 text-center font-weight-light"" style=""font-style: oblique;font-family: none;"">
            Liên 02: Giao khách
        </dt>
        <dt class=""col-md-12 text-center font-weight-normal"" style=""font-style: oblique;font-family: none;margin-left: 200px;"">
            Số: ");
            EndContext();
            BeginContext(4078, 8, false);
#line 109 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4086, 199, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Họ tên người nhận tiền:\r\n        </dt>\r\n        <dt class=\"col-md-4 font-weight-normal\">\r\n            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4285, "\"", 4308, 1);
#line 115 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
WriteAttributeValue("", 4293, Model.FullName, 4293, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4309, 254, true);
            WriteLiteral(" />\r\n        </dt>\r\n        <dt class=\"col-md-5 font-weight-normal\">\r\n\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Số CMND:\r\n        </dt>\r\n        <dt class=\"col-md-4 font-weight-normal\">\r\n            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4563, "\"", 4582, 1);
#line 124 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
WriteAttributeValue("", 4571, Model.Cnmd, 4571, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4583, 92, true);
            WriteLiteral(" />\r\n        </dt>\r\n        <dt class=\"col-md-5 font-weight-normal\">\r\n            Ngày cấp: ");
            EndContext();
            BeginContext(4676, 27, false);
#line 127 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                 Write(Model.Original.CmndIssueDay);

#line default
#line hidden
            EndContext();
            BeginContext(4703, 166, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Địa chỉ:\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(4870, 22, false);
#line 133 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(Model.Original.Address);

#line default
#line hidden
            EndContext();
            BeginContext(4892, 184, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Lý do chi:\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            Tiền cổ tức năm ");
            EndContext();
            BeginContext(5077, 10, false);
#line 139 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                       Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(5087, 5, true);
            WriteLiteral(" đợt ");
            EndContext();
            BeginContext(5093, 11, false);
#line 139 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                       Write(Model.Batch);

#line default
#line hidden
            EndContext();
            BeginContext(5104, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5106, 37, false);
#line 139 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                                    Write(Model.Original.NumberStockNotDeposite);

#line default
#line hidden
            EndContext();
            BeginContext(5143, 6, true);
            WriteLiteral(" CP x ");
            EndContext();
            BeginContext(5150, 102, false);
#line 139 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                                                                                Write(string.Format("{0:#,##0}", Model.Original.DividendNotDeposite / Model.Original.NumberStockNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(5252, 6, true);
            WriteLiteral("  đ = ");
            EndContext();
            BeginContext(5259, 62, false);
#line 139 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
                                                                                                                                                                                                             Write(string.Format("{0:#,##0}", Model.Original.DividendNotDeposite));

#line default
#line hidden
            EndContext();
            BeginContext(5321, 175, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Trừ thuế TNCN 5%:\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(5497, 37, false);
#line 145 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(string.Format("{0:#,##0}", Model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(5534, 175, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Số tiền nhận được\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(5710, 50, false);
#line 151 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(string.Format("{0:#,##0}", Model.RealRecevieMoney));

#line default
#line hidden
            EndContext();
            BeginContext(5760, 189, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-md-3 font-weight-normal\">\r\n            Số tiền nhận được viết bằng chữ\r\n        </dt>\r\n        <dt class=\"col-md-9 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(5950, 83, false);
#line 157 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(WebApplication34.Helper.ConverterMoney.NumberToTextVN(Model.RealRecevieMoney.Value));

#line default
#line hidden
            EndContext();
            BeginContext(6033, 576, true);
            WriteLiteral(@"
        </dt>
        <dt class=""col-md-4 text-center"" style=""padding-bottom: 70px;"">
            Phòng TC-KT
        </dt>
        <dt class=""col-md-4 text-center"">
            Thủ quỹ
        </dt>
        <dt class=""col-md-4 text-center"">
            Người nhận
        </dt>
        <dt class=""col-md-4 text-center font-weight-normal"">
            Phạm Thái Hùng
        </dt>
        <dt class=""col-md-4 text-center font-weight-normal"">
            Võ Thị Minh Thu
        </dt>
        <dt class=""col-md-4 text-center font-weight-normal"">
            ");
            EndContext();
            BeginContext(6610, 14, false);
#line 175 "C:\Users\votha\source\repos\WebApplication34\WebApplication34\Views\Transactions\Payment.cshtml"
       Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(6624, 164, true);
            WriteLiteral("\r\n        </dt>\r\n    </dl>\r\n</div>\r\n<div class=\"form-group no-print\">\r\n    <button onclick=\"window.print();\" class=\"btn btn-primary\">In phiếu chi</button>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6807, 107, true);
                WriteLiteral("\r\n    <script>\r\n        function handlePrint() {\r\n            window.print();\r\n\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(6917, 214, true);
            WriteLiteral("<style type=\"text/css\">\r\n    dt {\r\n        padding: 10px 0px 0px 0px;\r\n    }\r\n\r\n    input[type=\"text\"] {\r\n        width: 100%;\r\n    }\r\n    hr{\r\n        margin-top: 3rem;\r\n    margin-bottom: 3rem;\r\n    }\r\n</style>\r\n");
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
