#pragma checksum "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7f9cc62a5c83341969995ee175f90babb58490"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7f9cc62a5c83341969995ee175f90babb58490", @"/Views/Shared/_Layout.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b7f9cc62a5c83341969995ee175f90babb584904213", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 6 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b7f9cc62a5c83341969995ee175f90babb584904861", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b7f9cc62a5c83341969995ee175f90babb584906739", async() => {
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
                WriteLiteral("</li>\n                        <li>");
#nullable restore
#line 25 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Классы", "AllClasses", "Classes"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                        <li>");
#nullable restore
#line 26 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Предыстории", "AllBackgrounds", "Backgrounds"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 929, "\"", 936, 0);
                EndWriteAttribute();
                WriteLiteral(">Черты</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 983, "\"", 990, 0);
                EndWriteAttribute();
                WriteLiteral(">Заклинания и заговоры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1053, "\"", 1060, 0);
                EndWriteAttribute();
                WriteLiteral(">Монстры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1109, "\"", 1116, 0);
                EndWriteAttribute();
                WriteLiteral(">Предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1166, "\"", 1173, 0);
                EndWriteAttribute();
                WriteLiteral(">Магические предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1234, "\"", 1241, 0);
                EndWriteAttribute();
                WriteLiteral(">Транспорт</a></li>\n                    </ul>\n                </details>\n                <details>\n                    <summary>Домашние заготовочки</summary>\n                    <ul>\n                        <li>");
#nullable restore
#line 38 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Создать расу", "Races", "RaceCreator"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                        <li>");
#nullable restore
#line 39 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Создать класс", "Classes", "ClassCreator"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                        <li>");
#nullable restore
#line 40 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Создать предысторию", "Backgrounds", "BackgroundCreator"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1749, "\"", 1756, 0);
                EndWriteAttribute();
                WriteLiteral(">Черты</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1803, "\"", 1810, 0);
                EndWriteAttribute();
                WriteLiteral(">Заклинания и заговоры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1873, "\"", 1880, 0);
                EndWriteAttribute();
                WriteLiteral(">Монстры</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1929, "\"", 1936, 0);
                EndWriteAttribute();
                WriteLiteral(">Предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1986, "\"", 1993, 0);
                EndWriteAttribute();
                WriteLiteral(">Магические предметы</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2054, "\"", 2061, 0);
                EndWriteAttribute();
                WriteLiteral(@">Транспорт</a></li>
                    </ul>
                </details>
            </div>
            <div class=""accauntNavigation"">
                <details>
                    <summary>Имя пользователя</summary>
                    <ul>
                        <li>Персонажи</li>
                        <li>Настройки</li>
                    </ul>
                </details>
            </div>
        </nav>
        <main class=""mainContent"">
            <div class=""divContent"">
                ");
#nullable restore
#line 62 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
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
#line 78 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
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
