#pragma checksum "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "930e4d2e5a5a5c9a74e16a5576648bba65f88756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DirectorDetails), @"mvc.1.0.view", @"/Views/Movie/DirectorDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/DirectorDetails.cshtml", typeof(AspNetCore.Views_Movie_DirectorDetails))]
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
#line 1 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\_ViewImports.cshtml"
using MOVIEInfoCURD;

#line default
#line hidden
#line 2 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\_ViewImports.cshtml"
using MOVIEInfoCURD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930e4d2e5a5a5c9a74e16a5576648bba65f88756", @"/Views/Movie/DirectorDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65d193395b1d9283067b9ec1ebc990541248466", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DirectorDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MOVIEInfoCURD.Models.DirectorDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml"
  
    ViewData["Title"] = "DirectorDetails";

#line default
#line hidden
            BeginContext(98, 137, true);
            WriteLiteral("\r\n<h2>DirectorDetails</h2>\r\n\r\n<div>\r\n    <h4>DirectorDetails</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(236, 40, false);
#line 14 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(276, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(320, 36, false);
#line 17 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(400, 39, false);
#line 20 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(483, 35, false);
#line 23 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(518, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(562, 43, false);
#line 26 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Biodata));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 39, false);
#line 29 "C:\Users\IRGMHT\source\repos\MOVIEInfoCURD\MOVIEInfoCURD\Views\Movie\DirectorDetails.cshtml"
       Write(Html.DisplayFor(model => model.Biodata));

#line default
#line hidden
            EndContext();
            BeginContext(688, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(735, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41b66a8d3a544f81b14cb3722f71a903", async() => {
                BeginContext(757, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(773, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MOVIEInfoCURD.Models.DirectorDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
