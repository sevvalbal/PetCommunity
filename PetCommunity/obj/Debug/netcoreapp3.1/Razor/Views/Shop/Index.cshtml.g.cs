#pragma checksum "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a24cdf1864352c9283de6fe381a26ce360f08e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a24cdf1864352c9283de6fe381a26ce360f08e", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce863d7ba7204addf69698ef75e0e52b0bba9c9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PetCommunity.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Shop Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br>
<main>
    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col-6"">

            <h1 style=""text-align: center;"">Alışverişe Başla!</h1>
            <hr>
            <div class=""row"">
                <div class=""col-6"">
                    <p style=""font-size: 10px;"">(16 Ürün Görüntülenmekte)</p>
                </div>
                <div class=""col-6"">
                    <div style=""text-align: right;"">
                    </div>
                </div>

            </div>

");
#nullable restore
#line 28 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\r\n                <div class=\"shop\">\r\n                    <h5 style=\"color: hotpink;\"> ");
#nullable restore
#line 34 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h5>
                    <hr>
                    <!--
        <div class=""row"">
            <div class=""col-6"">
                <img style=""border: white 5px solid;"" src="""" alt="""">
            </div>
            <div class=""col-6"">

            </div>
        </div>
    -->
                    <div class=""row"">
                        <div class=""col-12"">
                            <h5 style=""color: hotpink;"">   ");
#nullable restore
#line 48 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            ");
#nullable restore
#line 49 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <br>\r\n                            <h5 style=\"color: cornflowerblue;\">");
#nullable restore
#line 51 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("TL</h5>\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 57 "C:\Users\sevva\Desktop\ASP.NET Project\PetCommunity\PetCommunity\Views\Shop\Index.cshtml"



            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PetCommunity.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591