#pragma checksum "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89401fbf73037afe964c0bd3c107fe25cb32144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EUsuarios_Delete), @"mvc.1.0.view", @"/Views/EUsuarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EUsuarios/Delete.cshtml", typeof(AspNetCore.Views_EUsuarios_Delete))]
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
#line 1 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\_ViewImports.cshtml"
using SGIAMT;

#line default
#line hidden
#line 2 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\_ViewImports.cshtml"
using SGIAMT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89401fbf73037afe964c0bd3c107fe25cb32144", @"/Views/EUsuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b20b0f7b55ea1a0c1a96c7107a5ec5de00ea87", @"/Views/_ViewImports.cshtml")]
    public class Views_EUsuarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGIAMT.Models.EUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(75, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>EUsuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(245, 44, false);
#line 15 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(333, 40, false);
#line 18 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 46, false);
#line 21 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(463, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(507, 42, false);
#line 24 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(549, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(593, 46, false);
#line 27 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(639, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(683, 42, false);
#line 30 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(725, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(769, 45, false);
#line 33 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuCelular));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(858, 41, false);
#line 36 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuCelular));

#line default
#line hidden
            EndContext();
            BeginContext(899, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(943, 44, false);
#line 39 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuCorreo));

#line default
#line hidden
            EndContext();
            BeginContext(987, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1031, 40, false);
#line 42 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuCorreo));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1115, 47, false);
#line 45 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuDireccion));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1206, 43, false);
#line 48 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuDireccion));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1293, 53, false);
#line 51 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1390, 49, false);
#line 54 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1483, 42, false);
#line 57 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1569, 38, false);
#line 60 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1651, 48, false);
#line 63 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1743, 44, false);
#line 66 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1831, 44, false);
#line 69 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuEstado));

#line default
#line hidden
            EndContext();
            BeginContext(1875, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1919, 40, false);
#line 72 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuEstado));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2003, 45, false);
#line 75 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuHorario));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2092, 41, false);
#line 78 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuHorario));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2177, 40, false);
#line 81 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkIc));

#line default
#line hidden
            EndContext();
            BeginContext(2217, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2261, 48, false);
#line 84 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkIc.VcNombreCat));

#line default
#line hidden
            EndContext();
            BeginContext(2309, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2353, 54, false);
#line 87 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkIdiCodNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2407, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2451, 63, false);
#line 90 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkIdiCodNavigation.VdiNombreDis));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2558, 62, false);
#line 93 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkItuTipoUsuarioNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2664, 79, false);
#line 96 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkItuTipoUsuarioNavigation.VtuNombreTipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(2743, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2781, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b2b9f4ffad44ff8b4e4693aa09a522", async() => {
                BeginContext(2807, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2817, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9149cb2aad6c4351a7d60d8d309a6636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 101 "C:\Users\Windows 8.1\Desktop\progra\SGIAMT\SGIAMT\Views\EUsuarios\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PkIuDni);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2858, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2942, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011b9e6313444b4391b7c15defde397e", async() => {
                    BeginContext(2964, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2980, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2993, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGIAMT.Models.EUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591