#pragma checksum "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Me.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfb925473a4fce00ac5063ab05070a9396a022f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ClinicWeb.Pages.Pages_Me), @"mvc.1.0.razor-page", @"/Pages/Me.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Me.cshtml", typeof(ClinicWeb.Pages.Pages_Me), null)]
namespace ClinicWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\_ViewImports.cshtml"
using ClinicWeb;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb925473a4fce00ac5063ab05070a9396a022f8", @"/Pages/Me.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1402308e72288a91f4404363d32cb61e5bad5508", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Me : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Me.cshtml"
  
    ViewData["Title"] = "Me";

#line default
#line hidden
            BeginContext(61, 82, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h3 class=\"card-title\">");
            EndContext();
            BeginContext(145, 17, false);
#line 9 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Me.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(163, 362, true);
            WriteLiteral(@"</h3>
        <div class=""list-group"">
            <a href=""/Me/Appointments"" class=""list-group-item list-group-item-action"">
                Appointment History
            </a>
            <a href=""/Me/Information"" class=""list-group-item list-group-item-action"">
                Medical Information
            </a>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MeModel>)PageContext?.ViewData;
        public MeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591