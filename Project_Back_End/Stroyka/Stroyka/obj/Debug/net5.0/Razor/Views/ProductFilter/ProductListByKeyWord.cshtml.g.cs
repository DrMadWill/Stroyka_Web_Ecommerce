#pragma checksum "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46d7945ffc74d688dbd23e50551a9229225d7b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductFilter_ProductListByKeyWord), @"mvc.1.0.view", @"/Views/ProductFilter/ProductListByKeyWord.cshtml")]
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
#line 1 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.ViewModels.ViewComponentModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.Models.Commoun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.Models.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\_ViewImports.cshtml"
using Stroyka.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d7945ffc74d688dbd23e50551a9229225d7b83", @"/Views/ProductFilter/ProductListByKeyWord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b09a3051950d72242719712a2fdd6e3b2ffc8ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductFilter_ProductListByKeyWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListByKeyWordVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "A-Z", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Z-A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sort_list_key_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ProductFilter/ProductListByKeyWord"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductListPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PaginationList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""site__body"">
    <div class=""page-header"">
        <div class=""page-header__container container"">
            <div class=""page-header__breadcrumb"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">
                            <a href=""/"">Home</a>
                            <svg class=""breadcrumb-arrow""
                                 width=""6px"" height=""9px"">
                                <use xlink:href=""/images/sprite.svg#arrow-rounded-right-6x9""></use>
                            </svg>
                        </li>
                        <li class=""breadcrumb-item active"">
                            <a> Search Product </a>
                            <svg class=""breadcrumb-arrow""
                                 width=""6px"" height=""9px"">
                                <use xlink:href=""/images/sprite.svg#arrow-rounded-right-6x9""></use>
                            </svg>
     ");
            WriteLiteral("                   </li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 23 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                                                                          Write(Model.SearchKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ol>\r\n                </nav>\r\n            </div>\r\n            <div class=\"page-header__title\">\r\n                <h1>");
#nullable restore
#line 28 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
               Write(Model.SearchKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"shop-layout shop-layout--sidebar--start\">\r\n            ");
#nullable restore
#line 34 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
       Write(await Component.InvokeAsync("SearchSideBar",@Model.MegaCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""shop-layout__content"">
                <div class=""block"">
                    <div class=""products-view"">

                        <div class=""products-view__options"">
                            <div class=""view-options"">

                                <div class=""view-options__layout"">
                                    <div class=""layout-switcher"">
                                        <div class=""layout-switcher__list"">
                                            <button data-layout=""grid-3-sidebar"" data-with-features=""false"" title=""Grid"" type=""button""
                                                    class=""layout-switcher__button layout-switcher__button--active"">
                                                <svg width=""16px"" height=""16px"">
                                                    <use xlink:href=""/images/sprite.svg#layout-grid-16x16""></use>
                                                </svg>
                                            </b");
            WriteLiteral(@"utton>

                                            <button data-layout=""grid-3-sidebar"" data-with-features=""true"" title=""Grid With Features""
                                                    type=""button"" class=""layout-switcher__button"">
                                                <svg width=""16px""
                                                     height=""16px"">
                                                    <use xlink:href=""/images/sprite.svg#layout-grid-with-details-16x16"">
                                                    </use>
                                                </svg>
                                            </button>

                                            <button data-layout=""list""
                                                    data-with-features=""false"" title=""List"" type=""button""
                                                    class=""layout-switcher__button"">
                                                <svg width=""16px"" height=""16px"">
 ");
            WriteLiteral(@"                                                   <use xlink:href=""/images/sprite.svg#layout-list-16x16""></use>
                                                </svg>
                                            </button>
                                        </div>
                                    </div>
                                </div>
                                <div class=""view-options__legend"">Showing ");
#nullable restore
#line 71 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                                                                     Write(Model.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 71 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                                                                                              Write(Model.Products.TotalElement);

#line default
#line hidden
#nullable disable
            WriteLiteral(" products</div>\r\n                                <div class=\"view-options__divider\"></div>\r\n                                <div class=\"view-options__control\">\r\n                                    <label");
            BeginWriteAttribute("for", " for=\"", 4297, "\"", 4303, 0);
            EndWriteAttribute();
            WriteLiteral(">Sort By</label>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8314133", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 4509, "\"", 4533, 1);
#nullable restore
#line 76 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
WriteAttributeValue("", 4517, Model.SearchKey, 4517, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                        <select class=\"form-control sort_list_select form-control-sm\" name=\"key\" >\r\n                                            \r\n");
#nullable restore
#line 79 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                                             if (Model.SortedKey == "A-Z")
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8315500", async() => {
                    WriteLiteral("Default");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8316773", async() => {
                    WriteLiteral("Name (A-Z)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8318136", async() => {
                    WriteLiteral("Name (Z-A)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                                            }
                                            else if (Model.SortedKey == "Z-A")
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8319837", async() => {
                    WriteLiteral("Default");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8321110", async() => {
                    WriteLiteral("Name (A-Z)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8322386", async() => {
                    WriteLiteral("Name (Z-A)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8324144", async() => {
                    WriteLiteral("Default");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8325417", async() => {
                    WriteLiteral("Name (A-Z)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d7945ffc74d688dbd23e50551a9229225d7b8326693", async() => {
                    WriteLiteral("Name (Z-A)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 96 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </select>\r\n                                        \r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                               </div>
                            </div>
                        </div>

                        <div class=""products-view__list products-list"" data-layout=""grid-3-sidebar"" data-with-features=""false"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46d7945ffc74d688dbd23e50551a9229225d7b8329766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 106 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Products;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"products-view__pagination\">\r\n");
#nullable restore
#line 110 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                             if (Model.Products.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46d7945ffc74d688dbd23e50551a9229225d7b8331877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 112 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Products.PaginationLinkModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\ProductFilter\ProductListByKeyWord.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("script", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\".sort_list_select\").change(function(){\r\n\r\n            document.querySelector(\".sort_list_key_form\").submit();\r\n        })\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListByKeyWordVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
