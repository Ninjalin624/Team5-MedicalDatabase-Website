#pragma checksum "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b97a7f0cf143abe8162ea9835ec3b4da86da43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ClinicWeb.Pages.Locations.Pages_Locations_Create), @"mvc.1.0.razor-page", @"/Pages/Locations/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Locations/Create.cshtml", typeof(ClinicWeb.Pages.Locations.Pages_Locations_Create), null)]
namespace ClinicWeb.Pages.Locations
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b97a7f0cf143abe8162ea9835ec3b4da86da43", @"/Pages/Locations/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1402308e72288a91f4404363d32cb61e5bad5508", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Locations_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(93, 19, true);
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
            EndContext();
            BeginContext(112, 1972, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b97a7f0cf143abe8162ea9835ec3b4da86da434688", async() => {
                BeginContext(156, 146, true);
                WriteLiteral("\r\n    <h4>Doctor</h4>\r\n    <hr />\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(303, 84, false);
#line 15 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.LabelFor(m => m.Office.Address.StreetAddress, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(387, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(406, 51, false);
#line 16 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.EditorFor(m => m.Office.Address.StreetAddress));

#line default
#line hidden
                EndContext();
                BeginContext(457, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(476, 62, false);
#line 17 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Office.Address.StreetAddress));

#line default
#line hidden
                EndContext();
                BeginContext(538, 126, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(665, 76, false);
#line 23 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.LabelFor(m => m.Office.Address.State, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(741, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(760, 43, false);
#line 24 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.EditorFor(m => m.Office.Address.State));

#line default
#line hidden
                EndContext();
                BeginContext(803, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(822, 54, false);
#line 25 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Office.Address.State));

#line default
#line hidden
                EndContext();
                BeginContext(876, 126, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1003, 75, false);
#line 31 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.LabelFor(m => m.Office.Address.City, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1078, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1097, 42, false);
#line 32 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.EditorFor(m => m.Office.Address.City));

#line default
#line hidden
                EndContext();
                BeginContext(1139, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1158, 53, false);
#line 33 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Office.Address.City));

#line default
#line hidden
                EndContext();
                BeginContext(1211, 159, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1371, 81, false);
#line 40 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.LabelFor(m => m.Office.Address.PostalCode, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1452, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1471, 48, false);
#line 41 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.EditorFor(m => m.Office.Address.PostalCode));

#line default
#line hidden
                EndContext();
                BeginContext(1519, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1538, 59, false);
#line 42 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Office.Address.PostalCode));

#line default
#line hidden
                EndContext();
                BeginContext(1597, 126, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1724, 68, false);
#line 48 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.LabelFor(m => m.Office.Phone, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1792, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1811, 35, false);
#line 49 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.EditorFor(m => m.Office.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(1846, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1865, 46, false);
#line 50 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Locations\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Office.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(1911, 166, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2084, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2097, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b97a7f0cf143abe8162ea9835ec3b4da86da4314326", async() => {
                BeginContext(2119, 24, true);
                WriteLiteral("Back to Office Locations");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2147, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicWeb.Pages.Offices.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicWeb.Pages.Offices.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicWeb.Pages.Offices.CreateModel>)PageContext?.ViewData;
        public ClinicWeb.Pages.Offices.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591