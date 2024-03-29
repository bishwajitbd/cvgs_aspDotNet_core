#pragma checksum "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d87013e8b41d83083b34c566d89d3423da550e51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reports_GameListReport), @"mvc.1.0.view", @"/Areas/Admin/Views/Reports/GameListReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Reports/GameListReport.cshtml", typeof(AspNetCore.Areas_Admin_Views_Reports_GameListReport))]
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
#line 1 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\_ViewImports.cshtml"
using CVGS;

#line default
#line hidden
#line 2 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\_ViewImports.cshtml"
using CVGS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d87013e8b41d83083b34c566d89d3423da550e51", @"/Areas/Admin/Views/Reports/GameListReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50662a4b06b34ddc6a7692a13ac4f749ea9cc64c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Reports_GameListReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CVGS.Models.Games>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ReportLayout.cshtml";

#line default
#line hidden
            BeginContext(133, 862, true);
            WriteLiteral(@"<h1>Game List Report</h1>
<div class=""row"">
    <div class=""col-12"">
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>
                    Title
                </th>
                <th>
                    Genre
                </th>
                <th>
                    Description
                </th>
                <th>
                    Developer
                </th>
                <th>
                    Publisher
                </th>
                <th>
                    ESRB Rating
                </th>
                <th>
                    Release Date
                </th>
                <th>
                    Price
                </th>
                <th>
                    Availability
                </th>
            </tr>
");
            EndContext();
#line 39 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1052, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1125, 32, false);
#line 43 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1237, 32, false);
#line 46 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1349, 38, false);
#line 49 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1469, 36, false);
#line 53 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.Developer));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1585, 36, false);
#line 56 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1701, 39, false);
#line 59 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.ESRB_Ratings));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1820, 38, false);
#line 62 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1938, 32, false);
#line 65 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2050, 36, false);
#line 68 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
                   Write(Html.DisplayFor(m => item.Available));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 71 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Admin\Views\Reports\GameListReport.cshtml"
            }

#line default
#line hidden
            BeginContext(2153, 40, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CVGS.Models.Games>> Html { get; private set; }
    }
}
#pragma warning restore 1591
