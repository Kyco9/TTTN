#pragma checksum "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5fdf5c5bed7d3f50b16922f86e1b57b13ffacdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Partial__DiscountVoice), @"mvc.1.0.view", @"/Views/Admin/Partial/_DiscountVoice.cshtml")]
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
#line 1 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml"
using BT2MWG.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5fdf5c5bed7d3f50b16922f86e1b57b13ffacdd", @"/Views/Admin/Partial/_DiscountVoice.cshtml")]
    public class Views_Admin_Partial__DiscountVoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml"
  
    db dbo = new db();
    var listDoChoi = dbo.layTatCaDoChoiV3();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"add-km-item\">\r\n    <label>Tên đồ chơi KM: </label>\r\n    <select class=\"toys\">\r\n");
#nullable restore
#line 10 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml"
         foreach(var item in listDoChoi)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option data-id=\"");
#nullable restore
#line 12 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml"
                        Write(item.MaDoChoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 289, "\"", 311, 1);
#nullable restore
#line 12 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml"
WriteAttributeValue("", 297, item.MaDoChoi, 297, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml"
                                                               Write(item.TenDoChoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 13 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BT2MWG\Views\Admin\Partial\_DiscountVoice.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\r\n    <span>\r\n        &emsp;\r\n        <label>Phần trăm giảm giá: </label>\r\n        <input class=\"ptgiamgia\" placeholder=\"Nhập phẩn trăm giảm giá\" />\r\n    </span>\r\n</div>");
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
