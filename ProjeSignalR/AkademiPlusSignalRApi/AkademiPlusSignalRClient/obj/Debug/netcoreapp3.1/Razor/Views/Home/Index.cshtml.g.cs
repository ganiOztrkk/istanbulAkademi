#pragma checksum "C:\Users\gani9\Documents\GitHub\istanbulAkademi\ProjeSignalR\AkademiPlusSignalRApi\AkademiPlusSignalRClient\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e227589b9d495e599058352b3d08ea76cb45af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\ProjeSignalR\AkademiPlusSignalRApi\AkademiPlusSignalRClient\Views\_ViewImports.cshtml"
using AkademiPlusSignalRClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\ProjeSignalR\AkademiPlusSignalRApi\AkademiPlusSignalRClient\Views\_ViewImports.cshtml"
using AkademiPlusSignalRClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e227589b9d495e599058352b3d08ea76cb45af", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e3eda49a3e00a7e75d4b5bb10ca8bda97edf5a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\gani9\Documents\GitHub\istanbulAkademi\ProjeSignalR\AkademiPlusSignalRApi\AkademiPlusSignalRClient\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e227589b9d495e599058352b3d08ea76cb45af3966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(() => {
            var connection = new signalR.HubConnectionBuilder().withAutomaticReconnect([1000, 2000, 3000, 6000]).withUrl(""https://localhost:44360/MyHub"").build();
            function statusshow() {
                $(""#conStatus"").text(connection.connectionState);
            }
            statusshow();

            connection.start().then(() => {
                statusshow();
            });

            connection.invoke(""GetNameByGroup"").then(function (result) {
                if(result.RoomID==1){
                    $(""#tekirdagRoomList"").append(`<li class=""list-group-item"">${result.Users.UserName}</li>`);
                }
                else if(result.RoomID==2){
                    $(""#ankaraRoomList"").append(`<li class=""list-group-item"">${result.Users.UserName}</li>`);
                }
                else{
                    $(""#adanaRoomList"").append(`<li class=""list-group-item"">${result.Users.UserName}</li>`);
              ");
                WriteLiteral(@"  }
            }).catch(function (error) {
                console.log(""Error calling GetNameByGroup method: "" + error);
            });

            connection.on(""receiveName"", (name) => {
                $(""#namesList"").append(`<li class=""list-group-item"">${name}</li>`);
            });
            $(""#btnSave"").click(() => {
                connection.invoke(""SendName"", $(""#txtName"").val());
            });
            connection.on(""receiveClientCount"", (clientCount) => {
                $(""#clientCount"").text(clientCount);
            });
            connection.on(""Notify"", countText => {
                $(""#notify"").html(`<div class=""alert alert-success"">${countText}></div>`);
            });
            connection.on(""Error"", (errorText) => {
                alert(errorText);
            });

            connection.on(""receiveNames"", (Names) => {
                $(""#namesList"").empty();
                Names.forEach((item, index) => {
                    $(""#namesList"").append");
                WriteLiteral(@"(`<li class=""list-group-item"">${item}</li>`);
                });
            });

            $(""#btnRoomName"").click(() => {
                let name = $(""#txtName"").val();
                let roomName = $(""input[type=radio]:checked"").val();
                if (roomName == null) {
                    alert(""Lütfen Oda Seçiniz."");
                    return;
                }
                connection.invoke(""SendNameByGroup"", name, roomName);
            });

            connection.on(""receiveMessageByGroup"", (name, roomID) => {
                let listName;
                if (roomID == 1) {
                    listName = ""tekirdagRoomList"";
                }
                else if (roomID == 2) {
                    listName = ""ankaraRoomList"";
                }
                else {
                    listName = ""adanaRoomList"";
                }
                $(`#${listName}`).append(`<li class=""list-group-item"">${name}</li>`);
            });

            $(""input[type");
                WriteLiteral(@"=radio]"").change(() => {
                let value = $(`input[type=radio]:checked`).val();
                if (value == ""Tekirdag"") {
                    connection.invoke(""AddToGroup"", value);
                    connection.invoke(""RemoveToGroup"", ""Ankara"");
                    connection.invoke(""RemoveToGroup"", ""Adana"");
                }
                else if (value == ""Ankara"") {
                    connection.invoke(""AddToGroup"", value);
                    connection.invoke(""RemoveFromGroup"", ""Tekirdag"");
                    connection.invoke(""RemoveFromGroup"", ""Adana"");
                }
                else {
                    connection.invoke(""AddToGroup"", value);
                    connection.invoke(""RemoveFromGroup"", ""Tekirdag"");
                    connection.invoke(""RemoveFromGroup"", ""Ankara"");
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <input type=""text"" class=""form-control"" id=""txtName"" />
        <hr />
        <button class=""btn btn-warning"" id=""btnSave"">Kaydet</button>
        <button class=""btn btn-primary"" id=""btnRoomName"">Odaya Kişi Ekle</button>
        <div class=""alert alert-info mt-2"">
            <div>
                Bağlantı Durumu: <strong id=""conStatus""></strong>
                Client Sayısı: <strong id=""clientCount""></strong>
            </div>
        </div>
    </div>
    <div class=""col-md-8 offset-2"">
        <ul class=""list-group"" id=""namesList""></ul>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""form-check form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""roomGroup"" value=""Tekirdag"" />
            <label class=""form-check-label"">Tekirdağ Odası</label>
        </div>
        <div class=""form-check form-check-inline"">
            <input class=""form-chec");
            WriteLiteral(@"k-input"" type=""radio"" name=""roomGroup"" value=""Ankara"" />
            <label class=""form-check-label"">Ankara Odası</label>
        </div>
        <div class=""form-check form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""roomGroup"" value=""Adana"" />
            <label class=""form-check-label"">Adana Odası</label>
        </div>
    </div>
    <div class=""col-md-8 offset-2"">
        <div class=""row"">
            <div class=""col-md-4"">
                <h2>Tekirdağ Odası</h2>
                <ul class=""list-group"" id=""tekirdagRoomList""></ul>
            </div>
            <div class=""col-md-4"">
                <h2>Ankara Odası</h2>
                <ul class=""list-group"" id=""ankaraRoomList""></ul>
            </div>
            <div class=""col-md-4"">
                <h2>Adana Odası</h2>
                <ul class=""list-group"" id=""adanaRoomList""></ul>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
