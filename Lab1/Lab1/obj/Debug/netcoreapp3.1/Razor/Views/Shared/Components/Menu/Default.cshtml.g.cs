#pragma checksum "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "795c2fbaded9148afa4655de734a585340506fdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
#line 1 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\_ViewImports.cshtml"
using Lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\_ViewImports.cshtml"
using Lab1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\_ViewImports.cshtml"
using Lab1.DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795c2fbaded9148afa4655de734a585340506fdd", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c853dbc9a5a36f62c82e274df7ea80ef46bf002f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"navbar-nav\">\r\n");
#nullable restore
#line 3 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
         if (item.IsPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "795c2fbaded9148afa4655de734a585340506fdd3821", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 10 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
           Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 157, "nav-item", 157, 8, true);
            AddHtmlAttributeValue(" ", 165, "nav-link", 166, 9, true);
#nullable restore
#line 7 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 174, item.Active, 175, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
             WriteLiteral(item.Area);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
             WriteLiteral(item.Page);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "795c2fbaded9148afa4655de734a585340506fdd7211", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
           Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 371, "nav-item", 371, 8, true);
            AddHtmlAttributeValue(" ", 379, "nav-link", 380, 9, true);
#nullable restore
#line 15 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 388, item.Active, 389, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
                   WriteLiteral(item.Controller);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
               WriteLiteral(item.Action);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\anast\OneDrive\Рабочий стол\Lab1\Lab1\Views\Shared\Components\Menu\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
