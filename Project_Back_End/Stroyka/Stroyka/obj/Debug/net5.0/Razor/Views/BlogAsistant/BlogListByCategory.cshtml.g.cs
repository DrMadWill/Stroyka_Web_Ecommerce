#pragma checksum "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\BlogAsistant\BlogListByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b586b7e621a60441ecdd14775928362e543be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogAsistant_BlogListByCategory), @"mvc.1.0.view", @"/Views/BlogAsistant/BlogListByCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b586b7e621a60441ecdd14775928362e543be5", @"/Views/BlogAsistant/BlogListByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac159b872a800ce4250da71fc3ea34984a542271", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BlogAsistant_BlogListByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListByCategoryVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BlogListPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                        <li class=""breadcrumb-item"">
                            <a href=""/Blog/Index"">Blog</a>
                            <svg class=""breadcrumb-arrow""
                                 width=""6px"" height=""9px"">
                                <use xlink:href=""/images/sprite.svg#arrow-rounded-right-6x9""></use>
                            </svg>
   ");
            WriteLiteral(@"                     </li>
                        <li class=""breadcrumb-item active"">
                            Category
                            <svg class=""breadcrumb-arrow""
                                 width=""6px"" height=""9px"">
                                <use xlink:href=""/images/sprite.svg#arrow-rounded-right-6x9""></use>
                            </svg>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">");
#nullable restore
#line 31 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\BlogAsistant\BlogListByCategory.cshtml"
                                                                          Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ol>\r\n                </nav>\r\n            </div>\r\n            <div class=\"page-header__title\">\r\n                <h1>");
#nullable restore
#line 36 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\BlogAsistant\BlogListByCategory.cshtml"
               Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-lg-8\">\r\n                <div class=\"block\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4b586b7e621a60441ecdd14775928362e543be57371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\BlogAsistant\BlogListByCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Blogs;

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-12 col-lg-4\">\r\n                ");
#nullable restore
#line 48 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\BlogAsistant\BlogListByCategory.cshtml"
           Write(await Component.InvokeAsync("BlogRightSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListByCategoryVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
