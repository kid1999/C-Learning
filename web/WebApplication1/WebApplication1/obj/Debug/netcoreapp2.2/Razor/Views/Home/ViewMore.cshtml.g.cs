#pragma checksum "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewMore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ec51524768fbed467fd7f2dbb4a62047b5423e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewMore), @"mvc.1.0.view", @"/Views/Home/ViewMore.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewMore.cshtml", typeof(AspNetCore.Views_Home_ViewMore))]
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
#line 1 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ec51524768fbed467fd7f2dbb4a62047b5423e5", @"/Views/Home/ViewMore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdddd25c3e69039bbb70728fd51658e9e600c7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewMore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(39, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ec51524768fbed467fd7f2dbb4a62047b5423e53223", async() => {
                BeginContext(45, 33, true);
                WriteLiteral("\r\n    <title>more info </title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(85, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(89, 346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ec51524768fbed467fd7f2dbb4a62047b5423e54439", async() => {
                BeginContext(95, 13, true);
                WriteLiteral("\r\n    <div>\r\n");
                EndContext();
#line 10 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewMore.cshtml"
         foreach (var student in Model)
        {

#line default
#line hidden
                BeginContext(160, 41, true);
                WriteLiteral("            <div>\r\n                name: ");
                EndContext();
                BeginContext(202, 12, false);
#line 13 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewMore.cshtml"
                 Write(student.Name);

#line default
#line hidden
                EndContext();
                BeginContext(214, 64, true);
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                class: ");
                EndContext();
                BeginContext(279, 17, false);
#line 16 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewMore.cshtml"
                  Write(student.ClassName);

#line default
#line hidden
                EndContext();
                BeginContext(296, 64, true);
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                Email: ");
                EndContext();
                BeginContext(361, 13, false);
#line 19 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewMore.cshtml"
                  Write(student.Email);

#line default
#line hidden
                EndContext();
                BeginContext(374, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 21 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewMore.cshtml"
        }

#line default
#line hidden
                BeginContext(407, 21, true);
                WriteLiteral("    </div>\r\n \r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(435, 19, true);
            WriteLiteral("\r\n\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
