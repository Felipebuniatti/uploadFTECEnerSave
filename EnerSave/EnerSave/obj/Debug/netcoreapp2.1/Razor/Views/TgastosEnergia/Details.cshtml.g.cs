#pragma checksum "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fd8f84202b8cb8b0ca76f00b91657db7e3593f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TgastosEnergia_Details), @"mvc.1.0.view", @"/Views/TgastosEnergia/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TgastosEnergia/Details.cshtml", typeof(AspNetCore.Views_TgastosEnergia_Details))]
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
#line 1 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd8f84202b8cb8b0ca76f00b91657db7e3593f7", @"/Views/TgastosEnergia/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1708d709ae3a6985fcc5e605b14b8455b00aad", @"/Views/_ViewImports.cshtml")]
    public class Views_TgastosEnergia_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsultasMVC.dbenersave.TgastosEnergia>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(92, 179, true);
            WriteLiteral("\r\n<h2>Detalhes do Gastos de Energia</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Kilowatts(kWh):\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(272, 41, false);
#line 16 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kilowatts));

#line default
#line hidden
            EndContext();
            BeginContext(313, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor(R$):\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(410, 37, false);
#line 22 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Details.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(447, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Período:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(542, 39, false);
#line 28 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Details.cshtml"
       Write(Html.DisplayFor(model => model.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(581, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Usuário:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(676, 41, false);
#line 34 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Details.cshtml"
       Write(Html.DisplayFor(model => model.UsuarioId));

#line default
#line hidden
            EndContext();
            BeginContext(717, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <br />\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(780, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd8f84202b8cb8b0ca76f00b91657db7e3593f76443", async() => {
                BeginContext(826, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\User\Desktop\TCC_VERSION_GABI\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(837, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(845, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd8f84202b8cb8b0ca76f00b91657db7e3593f78796", async() => {
                BeginContext(867, 6, true);
                WriteLiteral("Voltar");
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
            BeginContext(877, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsultasMVC.dbenersave.TgastosEnergia> Html { get; private set; }
    }
}
#pragma warning restore 1591
