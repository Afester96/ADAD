#pragma checksum "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d688d49be426fc5816499ad4be40d0eff54aa3fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\_ViewImports.cshtml"
using AfroDungeonAndDragons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\_ViewImports.cshtml"
using AfroDungeonAndDragons.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d688d49be426fc5816499ad4be40d0eff54aa3fe", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a869f899f6ac616b76295d1c9a8bbad0abdd3fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d688d49be426fc5816499ad4be40d0eff54aa3fe4213", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 6 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d688d49be426fc5816499ad4be40d0eff54aa3fe4861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d688d49be426fc5816499ad4be40d0eff54aa3fe6739", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <header class=""mainHeader"">
            <div>
                <div class=""headerLogo""></div>
            </div>
            <div>

            </div>
        </header>
        <nav class=""mainNavigation"">
            <div class=""divNavigation"">
                <details>
                    <summary>Игровые правила</summary>
                    <ul>
                        <li>");
#nullable restore
#line 24 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Расы", "AllRaces", "Races"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 746, "\"", 753, 0);
                EndWriteAttribute();
                WriteLiteral(">Классы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 801, "\"", 808, 0);
                EndWriteAttribute();
                WriteLiteral(">Предыстории</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 861, "\"", 868, 0);
                EndWriteAttribute();
                WriteLiteral(">Черты</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 915, "\"", 922, 0);
                EndWriteAttribute();
                WriteLiteral(">Заклинания и заговоры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 985, "\"", 992, 0);
                EndWriteAttribute();
                WriteLiteral(">Монстры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1041, "\"", 1048, 0);
                EndWriteAttribute();
                WriteLiteral(">Предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1098, "\"", 1105, 0);
                EndWriteAttribute();
                WriteLiteral(">Магические предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1166, "\"", 1173, 0);
                EndWriteAttribute();
                WriteLiteral(">Транспорт</a></li>\n                    </ul>\n                </details>\n                <details>\n                    <summary>Домашние заготовочки</summary>\n                    <ul>\n                        <li>");
#nullable restore
#line 38 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Расы", "Races", "RaceCreator"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1470, "\"", 1477, 0);
                EndWriteAttribute();
                WriteLiteral(">Классы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1525, "\"", 1532, 0);
                EndWriteAttribute();
                WriteLiteral(">Предыстории</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1585, "\"", 1592, 0);
                EndWriteAttribute();
                WriteLiteral(">Черты</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1639, "\"", 1646, 0);
                EndWriteAttribute();
                WriteLiteral(">Заклинания и заговоры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1709, "\"", 1716, 0);
                EndWriteAttribute();
                WriteLiteral(">Монстры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1765, "\"", 1772, 0);
                EndWriteAttribute();
                WriteLiteral(">Предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1822, "\"", 1829, 0);
                EndWriteAttribute();
                WriteLiteral(">Магические предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1890, "\"", 1897, 0);
                EndWriteAttribute();
                WriteLiteral(">Транспорт</a></li>\n                    </ul>\n                </details>\n            </div>\n        </nav>\n        <main class=\"mainContent\">\n            <div class=\"divContent\">\n                ");
#nullable restore
#line 53 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </main>
        <footer class=""mainFooter"">
            <div class=""leftSideFooter"">
                2021 - AfroDungeonAndDragons<br />
                Приятной игры всем любителям D&D!
            </div>
            <div class=""rightSideFooter"">
                
                <a href=""#"">Ссылка</a>
                <a href=""#"">Ссылка</a>
                <a href=""#"">Ссылка</a>
            </div>
        </footer>
    </div>
    ");
#nullable restore
#line 69 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
            WriteLiteral("\n</html>\n");
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
