#pragma checksum "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36bb905588f5c568f21245822e2c00e6501342ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_AboutClass), @"mvc.1.0.view", @"/Views/Classes/AboutClass.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36bb905588f5c568f21245822e2c00e6501342ff", @"/Views/Classes/AboutClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a869f899f6ac616b76295d1c9a8bbad0abdd3fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_AboutClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AfroDungeonAndDragons.Models.DefaultInformation.DefaultClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Classes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllClasses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
  
    ViewBag.Title = @Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"line_row\">\r\n    <div class=\"line_text\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36bb905588f5c568f21245822e2c00e6501342ff4751", async() => {
                WriteLiteral("Главная");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"line_arrow\"></div>\r\n    <div class=\"line_text\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36bb905588f5c568f21245822e2c00e6501342ff6208", async() => {
                WriteLiteral("Классы");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"line_arrow\"></div>\r\n    <div class=\"line_text\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"about_race_container\">\r\n    <div class=\"all_content_row\">\r\n        <div class=\"upper_page_body\">\r\n            <div class=\"upper_page_body_title\">\r\n                <h1>");
#nullable restore
#line 22 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"upper_page_body_from_book\">\r\n                <h2>");
#nullable restore
#line 25 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
               Write(Model.FromBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"content_litrature_description\">\r\n            <p>");
#nullable restore
#line 29 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
          Write(Html.Raw(Model.LitratureDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"content_short_description\">\r\n            <p>");
#nullable restore
#line 32 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
          Write(Html.Raw(Model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n");
#nullable restore
#line 35 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
             for (int i = 0; i < Model.DescriptionTitle?.Length && i < Model.Description?.Length; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"content_title\">\r\n                    <h4>");
#nullable restore
#line 38 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                   Write(Model.DescriptionTitle[i].ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"content_text\">\r\n                    <p>");
#nullable restore
#line 41 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                  Write(Html.Raw(Model.Description[i]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n            <div class=\"content_title\">\r\n                <h4>");
#nullable restore
#line 47 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
               Write(Model.ClassCreationTitle.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p>");
#nullable restore
#line 50 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
              Write(Html.Raw(Model.ClassCreationDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_title\">\r\n                <p>");
#nullable restore
#line 53 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
              Write(Model.ClassCreationTableTitle.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_table\">\r\n                <p>");
#nullable restore
#line 56 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
              Write(Html.Raw(Model.ClassCreationTable));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <div class=\"content_title\">\r\n                <h4>БЫСТРОЕ СОЗДАНИЕ</h4>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p>");
#nullable restore
#line 64 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
              Write(Html.Raw(Model.QuickBuild));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_title\">\r\n                <h4>МУЛЬТИКЛАССИРОВАНИЕ И ");
#nullable restore
#line 67 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                                     Write(Model.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p>");
#nullable restore
#line 70 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
              Write(Html.Raw(Model.Multiclass));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
        <div>
            <div class=""content_title_without_border"">
                <h4>КЛАССОВЫЕ УМЕНИЯ</h4>
            </div>
            <div class=""content_title"">
                <h4>ХИТЫ</h4>
            </div>
            <div class=""content_text"">
                <p><b>Кость Хитов: </b>");
#nullable restore
#line 81 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                                  Write(Model.HitDice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p><b>Хиты на 1 уровне: </b>");
#nullable restore
#line 84 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                                       Write(Model.HitPointsAtFirstLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p><b>Хиты на следующих уровнях: </b>");
#nullable restore
#line 87 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                                                Write(Model.HitPointsAtHigherLevels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_title\">\r\n                <h4>ВЛАДЕНИЕ</h4>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p><b>Доспехи: </b>");
#nullable restore
#line 93 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                              Write(Model.Armor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p><b>Оружие: </b>");
#nullable restore
#line 96 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                             Write(Model.Weapons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p><b>Инструменты: </b>");
#nullable restore
#line 99 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                                  Write(Model.Tools);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p><b>Спасброски: </b>");
#nullable restore
#line 102 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                                 Write(Model.SavingThrows);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p><b>Навыки: </b>");
#nullable restore
#line 105 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                             Write(Model.Skills);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"content_title\">\r\n                <h4>СНАРЯЖЕНИЕ</h4>\r\n            </div>\r\n            <div class=\"content_text\">\r\n");
#nullable restore
#line 111 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                 for (int i = 0; i < Model.Equipment.Length; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 113 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                  Write(Html.Raw(Model.Equipment[i]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 114 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div>\r\n");
#nullable restore
#line 118 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
             if (Model.ClassSpellTitle != null || Model.ClassSpellDescription != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"content_title_without_border\">\r\n                    <h4>ИСПОЛЬЗОВАНИЕ ЗАКЛИНАНИЙ</h4>\r\n                </div>\r\n");
#nullable restore
#line 123 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
             for (int i = 0; i < Model.ClassSpellTitle?.Length && i < Model.ClassSpellDescription?.Length; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"content_title\">\r\n                    <h4>");
#nullable restore
#line 127 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                   Write(Model.ClassSpellTitle[i].ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"content_text\">\r\n                    <p>");
#nullable restore
#line 130 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                  Write(Html.Raw(Model.ClassSpellDescription[i]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 132 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n            <div class=\"content_title\">\r\n                <h4>");
#nullable restore
#line 136 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
               Write(Model.TypeTitle.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"content_text\">\r\n                <p>");
#nullable restore
#line 139 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
              Write(Model.TypeDescriprion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 141 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
             for (int i = 0; i < Model.VariantsTitle?.Length && i < Model.VariantDescription?.Length && i < Model.VariantSpellsTitle?.Length && i < Model.VariantSpellsDescription?.Length; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"content_title\">\r\n                    <h4>");
#nullable restore
#line 144 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                   Write(Model.VariantsTitle[i].ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"content_text\">\r\n                    <p>");
#nullable restore
#line 147 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                  Write(Html.Raw(Model.VariantDescription[i]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"content_title\">\r\n                    <h4>");
#nullable restore
#line 150 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                   Write(Model.VariantSpellsTitle[i].ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"content_text\">\r\n                    <p>");
#nullable restore
#line 153 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
                  Write(Html.Raw(Model.VariantSpellsDescription[i]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 155 "C:\Users\Afest\Repositories\ADAD\AfroDungeonAndDragons\AfroDungeonAndDragons\Views\Classes\AboutClass.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AfroDungeonAndDragons.Models.DefaultInformation.DefaultClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
