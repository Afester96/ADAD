#pragma checksum "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69d0557080a821782bc583655c16a5d3b162bd10"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d0557080a821782bc583655c16a5d3b162bd10", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a869f899f6ac616b76295d1c9a8bbad0abdd3fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/all_pages.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/content.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69d0557080a821782bc583655c16a5d3b162bd104573", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0\" />\n    <title>");
#nullable restore
#line 6 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69d0557080a821782bc583655c16a5d3b162bd105257", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69d0557080a821782bc583655c16a5d3b162bd106433", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69d0557080a821782bc583655c16a5d3b162bd108311", async() => {
                WriteLiteral("\n    <div class=\"wrapper\">\n        <header class=\"header\">\n            <div class=\"container\">\n                <div class=\"header_row\">\n                    <div class=\"header_logo\">\n                        <a");
                BeginWriteAttribute("href", " href=\'", 554, "\'", 589, 1);
#nullable restore
#line 16 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 561, Url.Action("Index", "Home"), 561, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            <img");
                BeginWriteAttribute("src", " src=\'", 624, "\'", 671, 1);
#nullable restore
#line 17 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 630, Url.Content("~/pictures/HeaderLogo.png"), 630, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        </a>\n                    </div>\n                    <div class=\"header_socialMedia\">\n                        <a href=\"https://vk.com/afester24\"><img");
                BeginWriteAttribute("src", " src=\'", 848, "\'", 887, 1);
#nullable restore
#line 21 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 854, Url.Content("~/pictures/Vk.png"), 854, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></a>\n                        <a href=\"https://github.com/Afester96\"><img");
                BeginWriteAttribute("src", " src=\'", 963, "\'", 1006, 1);
#nullable restore
#line 22 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 969, Url.Content("~/pictures/Github.png"), 969, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></a>\n                    </div>\n                    <div class=\"header_notifications\">\n                        <a");
                BeginWriteAttribute("href", " href=\'", 1123, "\'", 1149, 1);
#nullable restore
#line 25 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1130, Url.Action("", ""), 1130, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            <img");
                BeginWriteAttribute("src", " src=\'", 1184, "\'", 1225, 1);
#nullable restore
#line 26 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1190, Url.Content("~/pictures/Bell.png"), 1190, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </a>
                    </div>
                    <div class=""header_account"">
                        <button class=""header_account_dropbtn"">Аккаунт</button>
                        <div class=""header_account_dropdown_content"">
                            ");
#nullable restore
#line 32 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Профиль", "", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 33 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Аккаунт", "", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 34 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Персонажи", "", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 35 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Выйти", "", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </header>
        <menu class=""menu"">
            <div class=""container"">
                <div class=""menu_row"">
                    <div class=""menu_body"">
                        <button class=""menu_dropbtn"">Игровые правила</button>
                        <div class=""menu_dropdown_content"">
                            ");
#nullable restore
#line 47 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Расы", "AllRaces", "Races"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 48 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Классы", "AllClasses", "Classes"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 49 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Предыстории", "AllBackgrounds", "Backgrounds"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""menu_body"">
                        <button class=""menu_dropbtn"">Кастомные игровые правила</button>
                        <div class=""menu_dropdown_content"">
                            ");
#nullable restore
#line 55 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Создать расу", "Races", "RaceCreator"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 56 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Создать класс", "Classes", "ClassCreator"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 57 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Создать предысторию", "Backgrounds", "BackgroundCreator"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </menu>\n        <div class=\"content\">\n            <div class=\"container\">\n                ");
#nullable restore
#line 65 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
        <footer class=""footer"">
            <div class=""container"">
                <div class=""footer_row"">
                    <div class=""footer_info"">
                        <p>2021 - AfroDungeonAndDragons</p>
                        <p>Приятной игры всем любителям D&D!</p>
                    </div>
                    <div class=""footer_media"">
                        <a href=""https://github.com/Afester96"">GitHub</a>
                        <a href=""https://vk.com/afester24"">VK</a>
                    </div>
                </div>
            </div>
        </footer>
    </div>
    ");
#nullable restore
#line 83 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Shared\_Layout.cshtml"
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
