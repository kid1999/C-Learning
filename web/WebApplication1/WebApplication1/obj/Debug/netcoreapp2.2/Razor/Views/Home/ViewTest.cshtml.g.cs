#pragma checksum "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "732e97e526fcf93ccd6cc31aebae6d8b8bbc473e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewTest), @"mvc.1.0.view", @"/Views/Home/ViewTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewTest.cshtml", typeof(AspNetCore.Views_Home_ViewTest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"732e97e526fcf93ccd6cc31aebae6d8b8bbc473e", @"/Views/Home/ViewTest.cshtml")]
    public class Views_Home_ViewTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Student>
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
            BeginContext(39, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(49, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "732e97e526fcf93ccd6cc31aebae6d8b8bbc473e2916", async() => {
                BeginContext(55, 23, true);
                WriteLiteral("\r\n    <title></title>\r\n");
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
            BeginContext(89, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "732e97e526fcf93ccd6cc31aebae6d8b8bbc473e4122", async() => {
                BeginContext(95, 10, true);
                WriteLiteral("\r\n    <h2>");
                EndContext();
                BeginContext(106, 10, false);
#line 9 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewTest.cshtml"
   Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(116, 32, true);
                WriteLiteral("</h2>\r\n    <div>\r\n        name: ");
                EndContext();
                BeginContext(149, 10, false);
#line 11 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewTest.cshtml"
         Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(159, 40, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        class: ");
                EndContext();
                BeginContext(200, 15, false);
#line 14 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewTest.cshtml"
          Write(Model.ClassName);

#line default
#line hidden
                EndContext();
                BeginContext(215, 40, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Email: ");
                EndContext();
                BeginContext(256, 11, false);
#line 17 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewTest.cshtml"
          Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(267, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
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
            BeginContext(288, 15, true);
            WriteLiteral("\r\n\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591