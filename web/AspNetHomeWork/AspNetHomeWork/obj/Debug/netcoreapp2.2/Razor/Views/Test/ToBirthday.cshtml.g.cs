#pragma checksum "F:\Git\C#Learning\web\AspNetHomeWork\AspNetHomeWork\Views\Test\ToBirthday.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b692db4e974725ebf2c4f39878656d995b207fa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_ToBirthday), @"mvc.1.0.view", @"/Views/Test/ToBirthday.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/ToBirthday.cshtml", typeof(AspNetCore.Views_Test_ToBirthday))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b692db4e974725ebf2c4f39878656d995b207fa0", @"/Views/Test/ToBirthday.cshtml")]
    public class Views_Test_ToBirthday : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Git\C#Learning\web\AspNetHomeWork\AspNetHomeWork\Views\Test\ToBirthday.cshtml"
  
    ViewData["Title"] = "ToBirthday";

#line default
#line hidden
            BeginContext(48, 255, true);
            WriteLiteral("\r\n<h1>ToBirthday</h1>\r\n\r\n<form action=\"/birthday\" method=\"post\">\r\n    <input type=\"text\" name=\"name\" placeholder=\"请输入....\" />\r\n    <input type=\"datetime-local\" name=\"birthday\" placeholder=\"请输入....\" />\r\n    <button type=\"submit\">判断</button>\r\n</form>\r\n\r\n<p>");
            EndContext();
            BeginContext(304, 11, false);
#line 14 "F:\Git\C#Learning\web\AspNetHomeWork\AspNetHomeWork\Views\Test\ToBirthday.cshtml"
Write(ViewBag.res);

#line default
#line hidden
            EndContext();
            BeginContext(315, 8, true);
            WriteLiteral("</p>\r\n\r\n");
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