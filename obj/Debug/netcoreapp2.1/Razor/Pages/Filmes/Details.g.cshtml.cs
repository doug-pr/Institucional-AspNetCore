#pragma checksum "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "684cc7d4c6b205bb7cb76a23f2958b65949ad4cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FilmesCRUDRazor.Pages.Filmes.Pages_Filmes_Details), @"mvc.1.0.razor-page", @"/Pages/Filmes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Filmes/Details.cshtml", typeof(FilmesCRUDRazor.Pages.Filmes.Pages_Filmes_Details), null)]
namespace FilmesCRUDRazor.Pages.Filmes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\_ViewImports.cshtml"
using FilmesCRUDRazor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684cc7d4c6b205bb7cb76a23f2958b65949ad4cc", @"/Pages/Filmes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03f637ad4cf2d0e4c8cf6ffbde05383ab748a3f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Filmes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(103, 229, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h2>Detalhes</h2>\r\n        <div>\r\n            <h4>Filmes Top +</h4>\r\n            <hr />\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(333, 48, false);
#line 16 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Filme.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(381, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(449, 44, false);
#line 19 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayFor(model => model.Filme.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(493, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(561, 56, false);
#line 22 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Filme.DataLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(617, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(685, 52, false);
#line 25 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayFor(model => model.Filme.DataLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(737, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(805, 48, false);
#line 28 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Filme.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(853, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(921, 44, false);
#line 31 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayFor(model => model.Filme.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(965, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1033, 47, false);
#line 34 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Filme.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1148, 43, false);
#line 37 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
               Write(Html.DisplayFor(model => model.Filme.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 87, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1278, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5e1b633c18e42aa8c687628052884a6", async() => {
                BeginContext(1359, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Projetos\Core\asp-net-core-iniciantes\src\FilmesCRUDRazor\Pages\Filmes\Details.cshtml"
                                                           WriteLiteral(Model.Filme.FilmeId);

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
            BeginContext(1369, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1383, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c81fc748bf4601a8e9d6a67f0d86b2", async() => {
                BeginContext(1429, 8, true);
                WriteLiteral("Retornar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1441, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmesCRUDRazor.Pages.Filmes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmesCRUDRazor.Pages.Filmes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmesCRUDRazor.Pages.Filmes.DetailsModel>)PageContext?.ViewData;
        public FilmesCRUDRazor.Pages.Filmes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
