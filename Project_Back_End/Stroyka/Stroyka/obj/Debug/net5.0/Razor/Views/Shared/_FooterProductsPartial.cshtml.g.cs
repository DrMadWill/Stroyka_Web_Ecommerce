#pragma checksum "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_FooterProductsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "187298094449f9245147fc5859b789d8f721f241"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterProductsPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterProductsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187298094449f9245147fc5859b789d8f721f241", @"/Views/Shared/_FooterProductsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b09a3051950d72242719712a2fdd6e3b2ffc8ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__FooterProductsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SmallProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"block-product-columns__column\">\r\n\r\n");
#nullable restore
#line 6 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_FooterProductsPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"block-product-columns__item\">\r\n            <div class=\"product-card product-card--layout--horizontal\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "187298094449f9245147fc5859b789d8f721f2415673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_FooterProductsPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\nofel\OneDrive\Desktop\Stroyka_Web_Ecommerce\Project_Back_End\Stroyka\Stroyka\Views\Shared\_FooterProductsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
