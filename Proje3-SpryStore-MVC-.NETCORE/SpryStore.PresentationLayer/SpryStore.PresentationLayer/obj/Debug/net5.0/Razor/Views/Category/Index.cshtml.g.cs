#pragma checksum "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b9c61e32ef9da78b49178d3ce3e5e0cd533ea11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\_ViewImports.cshtml"
using SpryStore.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\_ViewImports.cshtml"
using SpryStore.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\_ViewImports.cshtml"
using SpryStore.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9c61e32ef9da78b49178d3ce3e5e0cd533ea11", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e3c4da9e3b8bf8a4842de529a09f62fed93dff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Kategori Durumu</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
           Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 507, "\"", 555, 2);
            WriteAttributeValue("", 514, "/Category/DeleteCategory/", 514, 25, true);
#nullable restore
#line 21 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
WriteAttributeValue("", 539, item.CategoryID, 539, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 612, "\"", 660, 2);
            WriteAttributeValue("", 619, "/Category/UpdateCategory/", 619, 25, true);
#nullable restore
#line 22 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
WriteAttributeValue("", 644, item.CategoryID, 644, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Category/AddCategory/\" class=\"btn btn-primary\">Yeni Kategori Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
