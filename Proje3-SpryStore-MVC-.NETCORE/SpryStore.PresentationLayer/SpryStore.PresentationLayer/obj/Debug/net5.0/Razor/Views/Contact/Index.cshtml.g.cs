#pragma checksum "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4995e3f1a40593799ed49ce3f2dc1d132d7151da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4995e3f1a40593799ed49ce3f2dc1d132d7151da", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e3c4da9e3b8bf8a4842de529a09f62fed93dff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>İletişi Sayfası Gelen Mesajlar</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Ad Soyad</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n        <th>Mesajı Aç</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml"
           Write(item.ContactID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml"
           Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml"
            Write(((DateTime)item.Date).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-dark\">Mesajı Aç</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Contact\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
