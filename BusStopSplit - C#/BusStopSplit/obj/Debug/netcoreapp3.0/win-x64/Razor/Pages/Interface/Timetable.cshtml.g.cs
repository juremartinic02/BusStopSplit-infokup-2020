#pragma checksum "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\Interface\Timetable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efcfb8651c7ff2a010c58b8f79c08e16e7491f6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BusStopSplit.Pages.Interface.Pages_Interface_Timetable), @"mvc.1.0.razor-page", @"/Pages/Interface/Timetable.cshtml")]
namespace BusStopSplit.Pages.Interface
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\_ViewImports.cshtml"
using BusStopSplit;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efcfb8651c7ff2a010c58b8f79c08e16e7491f6e", @"/Pages/Interface/Timetable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2388f682b11f0349f6b1e663f860a1fba2bdaf92", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Interface_Timetable : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"">
    <div>
        <h1 style=""margin-top:10px;"">Timetable</h1>
    </div>


    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">WORKDAY</th>
                <th scope=""col"">SATURDAY</th>
                <th scope=""col"">SUNDAY AND HOLIDAYS</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\Interface\Timetable.cshtml"
             foreach (var entry in Model.Entries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\"></td>\r\n                    <td scope=\"row\">");
#nullable restore
#line 26 "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\Interface\Timetable.cshtml"
                               Write(entry.WorkingDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td scope=\"row\">");
#nullable restore
#line 27 "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\Interface\Timetable.cshtml"
                               Write(entry.Saturday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td scope=\"row\">");
#nullable restore
#line 28 "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\Interface\Timetable.cshtml"
                               Write(entry.Sunday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\Interface\Timetable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusStopSplit.Pages.Interface.TimetableModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BusStopSplit.Pages.Interface.TimetableModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BusStopSplit.Pages.Interface.TimetableModel>)PageContext?.ViewData;
        public BusStopSplit.Pages.Interface.TimetableModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
