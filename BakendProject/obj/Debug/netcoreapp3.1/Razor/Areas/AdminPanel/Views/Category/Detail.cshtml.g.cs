#pragma checksum "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Areas\AdminPanel\Views\Category\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43037df176561ecbb1fb933d3a3e5ac17582a14b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Category_Detail), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Category/Detail.cshtml")]
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
#line 1 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BakendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BakendProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43037df176561ecbb1fb933d3a3e5ac17582a14b", @"/Areas/AdminPanel/Views/Category/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660a035cbfdd8bc190284b7642210544650f1481", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Category_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Areas\AdminPanel\Views\Category\Detail.cshtml"
  
    ViewData["Title"] = "detail";
    Layout = "~/Areas/AdminPanel/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
         <div class=""col-md-6 d-flex align-items-stretch"">
              <div class=""row"">
                <div class=""col-md-12 grid-margin stretch-card"">
                  <div class=""card"">
                    <div class=""card-body"">
                      <h4 class=""card-title"">");
#nullable restore
#line 13 "C:\Users\Sahil\Desktop\Backend_Layihesi\BakendProject\BakendProject\BakendProject\Areas\AdminPanel\Views\Category\Detail.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    \r\n                    </div>\r\n                  </div>\r\n                </div>\r\n            \r\n              </div>\r\n            </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
