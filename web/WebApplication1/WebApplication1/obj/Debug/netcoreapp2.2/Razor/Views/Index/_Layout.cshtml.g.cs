#pragma checksum "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Index\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a2039967b87140b8072bac7c38333c647d7c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index__Layout), @"mvc.1.0.view", @"/Views/Index/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Index/_Layout.cshtml", typeof(AspNetCore.Views_Index__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a2039967b87140b8072bac7c38333c647d7c62", @"/Views/Index/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdddd25c3e69039bbb70728fd51658e9e600c7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Index__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 509, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7a2039967b87140b8072bac7c38333c647d7c623229", async() => {
                BeginContext(33, 201, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"keywords\" content=\"MyPetShop, XHTML5\" />\r\n    <meta name=\"description\" content=\"XHTML5页面示范\" />\r\n    <meta name=\"author\" content=\"kid1999\" />\r\n    <title>");
                EndContext();
                BeginContext(235, 13, false);
#line 9 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Index\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(248, 281, true);
                WriteLiteral(@"</title>
    <script src=""https://unpkg.com/vue@2.6.11/dist/vue.js""></script>
    <!-- 引入样式 -->
    <link rel=""stylesheet"" href=""https://unpkg.com/element-ui/lib/theme-chalk/index.css"">
    <!-- 引入组件库 -->
    <script src=""https://unpkg.com/element-ui/lib/index.js""></script>
");
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
            BeginContext(536, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(538, 1652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7a2039967b87140b8072bac7c38333c647d7c625266", async() => {
                BeginContext(544, 1213, true);
                WriteLiteral(@"
    <div>
        <div id=""head"">
            <el-menu :default-active=""activeIndex"" class=""el-menu-demo"" mode=""horizontal"">
                <el-menu-item index=""1"">处理中心</el-menu-item>
                <el-submenu index=""2"">
                    <template slot=""title"">
                        我的工作台
                    </template>
                    <el-menu-item index=""2-1"">选项1</el-menu-item>
                    <el-menu-item index=""2-2"">选项2</el-menu-item>
                    <el-menu-item index=""2-3"">选项3</el-menu-item>
                    <el-submenu index=""2-4"">
                        <template slot=""title"">
                            选项4
                        </template>
                        <el-menu-item index=""2-4-1"">选项1</el-menu-item>
                        <el-menu-item index=""2-4-2"">选项2</el-menu-item>
                        <el-menu-item index=""2-4-3"">选项3</el-menu-item>
                    </el-submenu>
                </el-submenu>
                <el-menu-item index=""3""");
                WriteLiteral(" disabled>消息中心</el-menu-item>\r\n                <el-menu-item index=\"4\"><a href=\"https://www.ele.me\" target=\"_blank\">订单管理</a></el-menu-item>\r\n            </el-menu>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(1758, 12, false);
#line 41 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Index\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1770, 365, true);
                WriteLiteral(@"
    </div>
    <script>
        new Vue({
            el: '#head',
            data: {
                visible: false,
                activeIndex: '1',
            },
            methods: {
                handleSelect(key, keyPath) {
                    console.log(key, keyPath);
                }
            }
        })
    </script>


    ");
                EndContext();
                BeginContext(2136, 41, false);
#line 59 "F:\Git\C#Learning\web\WebApplication1\WebApplication1\Views\Index\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2177, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
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
            BeginContext(2190, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
