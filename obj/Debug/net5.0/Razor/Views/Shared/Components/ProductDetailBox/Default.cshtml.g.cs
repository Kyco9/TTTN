#pragma checksum "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16477f7debc2809d75f307d1ea90d202f551e647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductDetailBox_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductDetailBox/Default.cshtml")]
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
#line 4 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16477f7debc2809d75f307d1ea90d202f551e647", @"/Views/Shared/Components/ProductDetailBox/Default.cshtml")]
    public class Views_Shared_Components_ProductDetailBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BT2MWG.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
  
    String i = (String)Url.ActionContext.RouteData.Values["id"];
    int j = Int32.Parse(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""info__item spec_article"">
    <p class=""info-title"">Thông tin chi tiết</p>
    <div class=""info-content"">
        <ul class=""info-article "">
            <li>
                <p class=""txt01"">Thương hiệu</p>
                <p class=""txt02"">");
#nullable restore
#line 17 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                            Write(Model[j].Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n\r\n            <li>\r\n                <p class=\"txt01\">Loại</p>\r\n                <p class=\"txt02\">\r\n");
#nullable restore
#line 23 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                     foreach (var item in Model[j].Kind)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"dot\">");
#nullable restore
#line 25 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                                     Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 26 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n            </li>\r\n            <li>\r\n                <p class=\"txt01\">Độ tuổi</p>\r\n                <p class=\"txt02\">");
#nullable restore
#line 31 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                            Write(Model[j].AgeLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p class=\"txt01\">Chất liệu</p>\r\n                <p class=\"txt02\">");
#nullable restore
#line 35 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                            Write(Model[j].Material);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p class=\"txt01\">Kích thước hộp</p>\r\n                <p class=\"txt02\">");
#nullable restore
#line 39 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                            Write(Model[j].Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm</p>\r\n            </li>\r\n            <li>\r\n                <p class=\"txt01\">Trọng lượng</p>\r\n                <p class=\"txt02\">");
#nullable restore
#line 43 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                            Write(Model[j].Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" g</p>\r\n            </li>\r\n            <li>\r\n                <p class=\"txt01\">Lưu ý khi sử dụng</p>\r\n                <p class=\"txt02\">");
#nullable restore
#line 47 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                            Write(Model[j].Warn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p class=\"txt01\">Nơi sản xuất</p>\r\n                <p class=\"txt02\">");
#nullable restore
#line 51 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Shared\Components\ProductDetailBox\Default.cshtml"
                            Write(Model[j].Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BT2MWG.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
