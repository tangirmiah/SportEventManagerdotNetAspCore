#pragma checksum "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7960fbb59d04b3e1a2e94dd185b3c45494b35d98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7960fbb59d04b3e1a2e94dd185b3c45494b35d98", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c814789d8410b5bb5740af378e567b73769d88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SportEvent.Models.Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn-small light-blue lighten-3 black-text halfway-fab "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Welcome!</h1>\r\n    \r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {




#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col s12 m6 l3\">\r\n                <div class=\"card medium\">\r\n                    <div class=\"card-image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 356, "\"", 419, 3);
            WriteAttributeValue("", 362, "https://i.picsum.photos/id/", 362, 27, true);
#nullable restore
#line 19 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
WriteAttributeValue("", 389, item.eventID*10, 389, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 407, "/300/300.jpg", 407, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <span class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7960fbb59d04b3e1a2e94dd185b3c45494b35d986114", async() => {
                WriteLiteral("See more");
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
#nullable restore
#line 21 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
                                                    WriteLiteral(item.eventID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-content\">\r\n                        <p>");
#nullable restore
#line 24 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 25 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.dateOfEvent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\Tangir\Desktop\.net assignment\assignment\SportEvent\SportEvent\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SportEvent.Models.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
