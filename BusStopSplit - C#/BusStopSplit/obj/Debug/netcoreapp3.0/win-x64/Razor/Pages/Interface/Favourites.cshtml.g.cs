#pragma checksum "C:\Users\jurem\OneDrive\Desktop\Projekt 2020\BusStopSplit\Pages\Interface\Favourites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633f49c25e1dfd42146c1442ac0eaff06aae0d9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BusStopSplit.Pages.Interface.Pages_Interface_Favourites), @"mvc.1.0.razor-page", @"/Pages/Interface/Favourites.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633f49c25e1dfd42146c1442ac0eaff06aae0d9c", @"/Pages/Interface/Favourites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2388f682b11f0349f6b1e663f860a1fba2bdaf92", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Interface_Favourites : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"">

    <div>
        <h1>
            Favourites
        </h1>
    </div>
    <div>
        <table>
            <thead>
                <th scope=""col""></th>
            </thead>
        </table>
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusStopSplit.Pages.Interface.FavouritesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BusStopSplit.Pages.Interface.FavouritesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BusStopSplit.Pages.Interface.FavouritesModel>)PageContext?.ViewData;
        public BusStopSplit.Pages.Interface.FavouritesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
