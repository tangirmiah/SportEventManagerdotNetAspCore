#pragma checksum "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Admin\AdminViewEventDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3205215e1d43d6f83f4c3671ad0234a1548ceda6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminViewEventDetails), @"mvc.1.0.view", @"/Views/Admin/AdminViewEventDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\_ViewImports.cshtml"
using SportEvent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\_ViewImports.cshtml"
using SportEvent.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3205215e1d43d6f83f4c3671ad0234a1548ceda6", @"/Views/Admin/AdminViewEventDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c814789d8410b5bb5740af378e567b73769d88", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminViewEventDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportEvent.Models.Event>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Admin\AdminViewEventDetails.cshtml"
  
    ViewData["Title"] = "Events";
    Layout = "_Layout1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Admin\AdminViewEventDetails.cshtml"
   Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>");
#nullable restore
#line 11 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Admin\AdminViewEventDetails.cshtml"
   Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <span>Description :  </span>\r\n    <p>");
#nullable restore
#line 14 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Admin\AdminViewEventDetails.cshtml"
  Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <span>Date :  </span>\r\n    <p>");
#nullable restore
#line 16 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Admin\AdminViewEventDetails.cshtml"
  Write(Html.DisplayFor(model => model.dateOfEvent));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportEvent.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
