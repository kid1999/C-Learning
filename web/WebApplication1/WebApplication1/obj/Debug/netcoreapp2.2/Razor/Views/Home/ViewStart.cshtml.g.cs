#pragma checksum "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6fe6ef15aedc3305699b83e31205df74849224a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewStart), @"mvc.1.0.view", @"/Views/Home/ViewStart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewStart.cshtml", typeof(AspNetCore.Views_Home_ViewStart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6fe6ef15aedc3305699b83e31205df74849224a", @"/Views/Home/ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b7a7b446882307f86cad7e88cbc8991effffa9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Home\ViewStart.cshtml"
  
    ViewBag.Title = "这是title";

#line default
#line hidden
            BeginContext(41, 24, true);
            WriteLiteral("\r\n<h1>ViewStart</h1>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(82, 76, true);
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/vue/dist/vue.js\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(161, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591