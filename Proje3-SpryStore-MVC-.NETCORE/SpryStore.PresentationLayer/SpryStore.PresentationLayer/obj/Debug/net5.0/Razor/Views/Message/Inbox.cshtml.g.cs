#pragma checksum "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Message\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae335345905e31e4134012e7766b748b0d9a2f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Inbox), @"mvc.1.0.view", @"/Views/Message/Inbox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae335345905e31e4134012e7766b748b0d9a2f92", @"/Views/Message/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e3c4da9e3b8bf8a4842de529a09f62fed93dff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Message\Inbox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/AdminLayout/Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Kutusu</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Gönderen</th>\r\n        <th>Konu</th>\r\n        <th>Mesajı Aç</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Message\Inbox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Message\Inbox.cshtml"
           Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Message\Inbox.cshtml"
           Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Message\Inbox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-dark\">Mesajı Aç</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\Proje3-SpryStore-MVC-.NETCORE\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Views\Message\Inbox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Message/SendMessage/\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591