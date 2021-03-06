#pragma checksum "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19878abfe8ccd7bfc0a2f25d4129fec9b0fa485c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#line 1 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\_ViewImports.cshtml"
using PetCommunity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\_ViewImports.cshtml"
using PetCommunity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19878abfe8ccd7bfc0a2f25d4129fec9b0fa485c", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce863d7ba7204addf69698ef75e0e52b0bba9c9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Forum";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <br>
    <h1 style=""text-align: center;"">Forum</h1>
    <p>Di??er kullan??c??lar ile buradan ileti??ime ge??ebilirsiniz.</p>
    <hr>
</div>

<div class=""shop"">
    <div class=""container"">
        <div id=""userinfo"" class="" row"">
            <label for=""username"">Kullan??c?? ad??n??z?? giriniz :</label>
            <input type=""text"" class=""form-control"" id=""username"" name=""username"" autocomplete=""off"" />
            <button type=""button"" class="" =btn btn-block"" onclick=""SetUsername();"">Kat??l</button>
        </div>
        <div id=""messagearea"" class=""row"" style=""display: none;"">
            <div>Olarak giri?? yap??ld?? : <b><span id=""username1"">Not Set</span></b></div>
            <hr />
            <div class=""row"">
                <div class=""col-6"">
                    <ul id=""messageList""></ul>
                </div>
            </div>
            <hr />
            <input type=""text"" id=""message"" autocomplete=""off"" />
            <input type=""button"" id=""sendBut");
            WriteLiteral("ton\" value=\"Mesaj?? G??nder\" />\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19878abfe8ccd7bfc0a2f25d4129fec9b0fa485c5111", async() => {
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
            WriteLiteral(@"
    <script>
        ""use strict"";
        var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();
        var username = """";
        document.getElementById(""sendButton"").disabled = true;
        connection.on(""ReceiveMessage"", function (user, message) {
            var msg = message.replace(/&/g, ""&amp;"").replace(/</g, ""&lt;"").replace(/>/g, ""&gt;"");
            var encodedMsg = user + "":"" + "" "" + msg;
            var li = document.createElement(""li"");
            li.textContent = encodedMsg;
            document.getElementById(""messageList"").appendChild(li);
        });
        connection.start().then(function () {
            document.getElementById(""sendButton"").disabled = false;
        }).catch(function (err) {
            return console.error(err.toString());
        });

        document.getElementById(""sendButton"").addEventListener(""click"", function (event) {
            var message = document.getElementById(""message"").value;
            connection.invok");
            WriteLiteral(@"e(""SendMessage"", username, message).then(function () {
                document.getElementById(""message"").value = """";

            }).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();
        });

        function SetUsername() {
            var usernameinput = document.getElementById(""username"").value;
            if (usernameinput == """") {
                alert(""L??tfen ad??n??z?? girin"");
                return;
            }
            username = usernameinput;
            document.getElementById(""userinfo"").style.display = 'none';
            document.getElementById(""messagearea"").style.display = 'block';
            document.getElementById(""username1"").innerText = usernameinput;
        }
    </script>
    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
