#pragma checksum "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc7a18a74b03644c7814d727024bc15833209ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BlogListPartial), @"mvc.1.0.view", @"/Views/Shared/_BlogListPartial.cshtml")]
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
using Stroyka.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc7a18a74b03644c7814d727024bc15833209ce", @"/Views/Shared/_BlogListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac159b872a800ce4250da71fc3ea34984a542271", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BlogListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginationList<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PaginationList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"posts-view\">\r\n    <div class=\"posts-view__list posts-list posts-list--layout--list\">\r\n        <div class=\"posts-list__body\">\r\n");
#nullable restore
#line 7 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"posts-list__item\">\r\n                    <div class=\"post-card post-card--layout--list post-card--size--nl\">\r\n                        <div class=\"post-card__image\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 451, "\"", 479, 2);
            WriteAttributeValue("", 458, "/Blog/Single/", 458, 13, true);
#nullable restore
#line 12 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
WriteAttributeValue("", 471, item.Id, 471, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5fc7a18a74b03644c7814d727024bc15833209ce6395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 525, "~/images/posts/", 525, 15, true);
#nullable restore
#line 13 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
AddHtmlAttributeValue("", 540, item.Image, 540, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"post-card__info\">\r\n                            <div class=\"post-card__category\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 780, "\"", 837, 2);
            WriteAttributeValue("", 787, "/BlogAsistant/BlogListByCategory/", 787, 33, true);
#nullable restore
#line 18 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
WriteAttributeValue("", 820, item.Category.Id, 820, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
                                                                                        Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                            <div class=\"post-card__name\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 993, "\"", 1021, 2);
            WriteAttributeValue("", 1000, "/Blog/Single/", 1000, 13, true);
#nullable restore
#line 21 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
WriteAttributeValue("", 1013, item.Id, 1013, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                            <div class=\"post-card__date\">\r\n                                ");
#nullable restore
#line 24 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
                           Write(item.Date.ToString("M"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 24 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
                                                    Write(item.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"post-card__content\">");
#nullable restore
#line 26 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
                                                       Write(item.PreviewDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"post-card__read-more\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1463, 2);
            WriteAttributeValue("", 1442, "/Blog/Single/", 1442, 13, true);
#nullable restore
#line 28 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
WriteAttributeValue("", 1455, item.Id, 1455, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               class=\"btn btn-secondary btn-sm\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
     if (Model.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fc7a18a74b03644c7814d727024bc15833209ce12574", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 39 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.PaginationLinkModel;

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
#line 40 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_BlogListPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginationList<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591