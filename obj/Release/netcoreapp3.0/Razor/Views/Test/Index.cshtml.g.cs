#pragma checksum "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c04507de713a0f0bb41e474fb2802f1af9d382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c04507de713a0f0bb41e474fb2802f1af9d382", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebcf2760eb489d6d56ecc6c0f4c5587dbefcde74", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication_Core_mvc.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<table id=""tblCustomers"" class=""table"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse:collapse;text-align:center"" border=""1"">
    <tr>
        <th style=""width:100px"">Id</th>
        <th style=""width:150px"">Name</th>
        <th style=""width:150px"">Amount</th>
    </tr>
");
#nullable restore
#line 13 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
     foreach (var customer in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <span>");
#nullable restore
#line 17 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
                 Write(customer.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td>\r\n\r\n                <span>");
#nullable restore
#line 21 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
                 Write(customer.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td>\r\n\r\n                <span>");
#nullable restore
#line 25 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
                 Write(customer.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<ul>\r\n");
#nullable restore
#line 32 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
     for (int i = 0; i < 5; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>List item ");
#nullable restore
#line 34 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 35 "C:\Users\yongqy\source\repos\WebApplication_Core_mvc\WebApplication_Core_mvc\Views\Test\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication_Core_mvc.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591