#pragma checksum "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f761eac4bda79dea92cb16b70e6952705f865c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SortPartial), @"mvc.1.0.view", @"/Views/Shared/_SortPartial.cshtml")]
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
#line 1 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f761eac4bda79dea92cb16b70e6952705f865c", @"/Views/Shared/_SortPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660a035cbfdd8bc190284b7642210544650f1481", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SortPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("second-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("  \r\n");
#nullable restore
#line 3 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
 foreach (var item in Model)
                            {   
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
                                 foreach (var img in item.ProductImages)
                                {
                                    if (img.IsMain)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""product-col col-md-4 col-sm-6"">
                                    <div class=""single-product mt-30"">
                                        <div class=""product-image"">
                                            <a href=""single-product.html"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47f761eac4bda79dea92cb16b70e6952705f865c5368", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 671, "~/images/", 671, 9, true);
#nullable restore
#line 13 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
AddHtmlAttributeValue("", 680, img.ImageUrl, 680, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47f761eac4bda79dea92cb16b70e6952705f865c7095", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 790, "~/images/", 790, 9, true);
#nullable restore
#line 14 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
AddHtmlAttributeValue("", 799, img.ImageUrl, 799, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                            <ul class=""product-meta"">
                                                <li><a href=""#""><i class=""icon ion-bag""></i></a></li>
                                                <li><a href=""#""><i class=""icon ion-android-favorite-outline""></i></a></li>
                                                <li><a href=""#""><i class=""icon ion-android-options""></i></a></li>
                                                <li><a data-toggle=""modal"" data-target=""#productQuickModal"" href=""#""><i class=""icon ion-android-open""></i></a></li>
                                            </ul>
                                            <span class=""discount-product"">");
#nullable restore
#line 22 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
                                                                      Write(item.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                        </div>\r\n                                        <div class=\"product-content\">\r\n                                            <h4 class=\"product-title\"><a href=\"single-product.html\">");
#nullable restore
#line 25 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
                                                                                               Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h4>
                                            <ul class=""product-rating"">
                                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                            </ul>                                            
                                            <div class=""product-price"">
                                                <span class=""regular-price"">€");
#nullable restore
#line 34 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
                                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <span class=\"price-sale\">€");
#nullable restore
#line 35 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
                                                                      Write(item.Price-(item.Price*item.DiscountPrice/100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div> <!-- single product -->\r\n                                </div>\r\n");
#nullable restore
#line 40 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
                                 }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Views\Shared\_SortPartial.cshtml"
                             
                                
                         }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
