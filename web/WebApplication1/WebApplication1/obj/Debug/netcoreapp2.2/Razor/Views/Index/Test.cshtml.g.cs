#pragma checksum "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Index\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a247dc0823abc5455617e0d3bfc8a6795f156f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index_Test), @"mvc.1.0.view", @"/Views/Index/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Index/Test.cshtml", typeof(AspNetCore.Views_Index_Test))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a247dc0823abc5455617e0d3bfc8a6795f156f5f", @"/Views/Index/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdddd25c3e69039bbb70728fd51658e9e600c7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Index_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Index\Test.cshtml"
  
    ViewData["Title"] = "Test Vue and Element-UI";

#line default
#line hidden
            BeginContext(61, 188, true);
            WriteLiteral("\r\n\r\n<h1>Test</h1>\r\n\r\n<div id=\"test\">\r\n    <el-button type=\"danger\" v-if=\"flag\">vue-button</el-button>\r\n    <el-button type=\"text\" v-on:click=\"open\">点击打开 Message Box</el-button>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(266, 756, true);
                WriteLiteral(@"
    <script>
        new Vue({
            el: '#test',
            data: { flag: true },
            methods: {
              open() {
                this.$prompt('请输入邮箱', '提示', {
                  confirmButtonText: '确定',
                  cancelButtonText: '取消',
                  inputErrorMessage: '邮箱格式不正确'
                }).then(({ value }) => {
                  this.$message({
                    type: 'success',
                    message: '你的邮箱是: ' + value
                  });
                }).catch(() => {
                  this.$message({
                    type: 'info',
                    message: '取消输入'
                  });
                });
              }
            }
        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(1025, 2, true);
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
