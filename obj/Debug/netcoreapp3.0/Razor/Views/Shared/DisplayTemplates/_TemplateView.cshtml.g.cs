#pragma checksum "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5075aa663d51ee36ac7eab32beed0f12b4bf6f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates__TemplateView), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/_TemplateView.cshtml")]
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
#line 1 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\_ViewImports.cshtml"
using WebApplication_Core_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\_ViewImports.cshtml"
using WebApplication_Core_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5075aa663d51ee36ac7eab32beed0f12b4bf6f48", @"/Views/Shared/DisplayTemplates/_TemplateView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebcf2760eb489d6d56ecc6c0f4c5587dbefcde74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates__TemplateView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication_Core_mvc.Models.ViewModel1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table-bordered\">\r\n    <tr>\r\n        <th>\r\n            Id\r\n        </th>\r\n        <th>\r\n            Name\r\n        </th>\r\n        <th>\r\n            MyValue\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 23 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml"
             if(item.IsDisplayable)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml"
               Write(Html.DisplayFor(model => item.MyValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 28 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Shared\DisplayTemplates\_TemplateView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication_Core_mvc.Models.ViewModel1>> Html { get; private set; }
    }
}
#pragma warning restore 1591
