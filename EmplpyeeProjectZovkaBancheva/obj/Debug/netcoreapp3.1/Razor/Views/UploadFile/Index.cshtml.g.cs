#pragma checksum "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2227c0b0beed4ac27ddf4c0405895e1c7625ac8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UploadFile_Index), @"mvc.1.0.view", @"/Views/UploadFile/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\_ViewImports.cshtml"
using EmplpyeeProjectZovkaBancheva;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\_ViewImports.cshtml"
using EmplpyeeProjectZovkaBancheva.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2227c0b0beed4ac27ddf4c0405895e1c7625ac8b", @"/Views/UploadFile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af538c536cd6fe17a628bbf43b0d6e46cf1b019f", @"/Views/_ViewImports.cshtml")]
    public class Views_UploadFile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmplpyeeProjectZovkaBancheva.Models.TeamViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml"
  
    ViewData["Title"] = "Table Teams Worked Together";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2227c0b0beed4ac27ddf4c0405895e1c7625ac8b3678", async() => {
                WriteLiteral(@"
    <style>
        #tableStyle {
            font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

            #tableStyle td, #tableStyle th {
                border: 1px solid #ddd;
                padding: 8px;
            }

            #tableStyle tr:nth-child(even) {
                background-color: #f2f2f2;
            }

            #tableStyle tr:hover {
                background-color: #ddd;
            }

            #tableStyle th {
                padding-top: 12px;
                padding-bottom: 12px;
                text-align: left;
                background-color: #4CAF50;
                color: white;
            }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2227c0b0beed4ac27ddf4c0405895e1c7625ac8b5412", async() => {
                WriteLiteral("\r\n    <table id=\"tableStyle\">\r\n        <tr>\r\n            <th> First Employee Id</th>\r\n            <th> Second Employee Id</th>\r\n            <th> Project Id</th>\r\n            <th> Days Worked</th>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml"
         foreach (var modelItem in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml"
               Write(modelItem.FirstUserId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml"
               Write(modelItem.SecondUserId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml"
               Write(modelItem.ProjectID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml"
               Write(modelItem.DaysSpentTogether);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\User\source\repos\EmplpyeeProjectZovkaBancheva\EmplpyeeProjectZovkaBancheva\Views\UploadFile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmplpyeeProjectZovkaBancheva.Models.TeamViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
