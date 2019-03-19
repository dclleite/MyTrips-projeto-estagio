#pragma checksum "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d7ada62234f7eb83bc2cae7670e1c2afca84cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\_ViewImports.cshtml"
using MyTrips;

#line default
#line hidden
#line 2 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\_ViewImports.cshtml"
using MyTrips.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7ada62234f7eb83bc2cae7670e1c2afca84cb2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1347d7917797f07afb9d4eb92084d32c4a7bae16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Host>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 904, true);
            WriteLiteral(@"
<main class=""container"">

    <header class=""content_top "">
        <div class=""cabecalho"">
            <h1>my trips</h1>
        </div>
    </header>

    <section class=""seção"">
        <div class=""infos"">
            <div class=""divInfos"">
                <p id=""city""><i class=""fas fa-map-marker-alt""></i> Dubai, UAE</p>
            </div>
            <div class=""divInfos"">
                <p id=""date""><i class=""far fa-calendar-alt""></i> 2019-03-17</p>
            </div>
            <div class=""divInfos"">
                <p id=""guest""><i class=""far fa-user""></i> 1 Guets</p>
            </div>
            <div class=""divInfos"">
                <p id=""class""><i class=""fas fa-crown""></i> First Class</p>
            </div>
            <div class=""divInfos"">
                <p id=""price""><i class=""far fa-credit-card""></i> 800$</p>
            </div>
        </div>

");
            EndContext();
#line 34 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
          
            DateTime dataHoje = DateTime.Today;
            

#line default
#line hidden
            BeginContext(1046, 17, true);
            WriteLiteral("            <div>");
            EndContext();
            BeginContext(1064, 8, false);
#line 37 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
            Write(dataHoje);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 38 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
            foreach (var hotel in Model)
            {
                DateTime dataHotel = DateTime.Parse(hotel.date);
                int result = DateTime.Compare(dataHotel, dataHoje);
                if (hotel.cityId == 132 && result >= 0)
                {

#line default
#line hidden
            BeginContext(1348, 126, true);
            WriteLiteral("                    <div class=\"card-teste\">\r\n                        <div class=\"card-img\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1474, "\"", 1492, 1);
#line 46 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
WriteAttributeValue("", 1480, hotel.thumb, 1480, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1493, 509, true);
            WriteLiteral(@">
                        </div>
                        <div class=""card-infos"">
                            <div class=""card-infos-interno"">
                                <p class=""stars""><i class=""fas fa-star colorStar""></i><i class=""fas fa-star colorStar""></i><i class=""fas fa-star colorStar""></i><i class=""fas fa-star colorStar""></i></p>
                            </div>
                            <div class=""card-infos-interno nomeHotel"">
                                <h3 id=""nomeHotel"">");
            EndContext();
            BeginContext(2003, 15, false);
#line 53 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
                                              Write(hotel.hotelName);

#line default
#line hidden
            EndContext();
            BeginContext(2018, 167, true);
            WriteLiteral("</h3>\r\n                            </div>\r\n                            <div class=\"card-infos-interno localHotel\">\r\n                                <p id=\"localHotel\">");
            EndContext();
            BeginContext(2187, 14, false);
#line 56 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
                                               Write(hotel.location);

#line default
#line hidden
            EndContext();
            BeginContext(2202, 173, true);
            WriteLiteral(", Dubai</p>\r\n                            </div>\r\n                            <div class=\"card-infos-interno precoHotel\">\r\n                                <p id=\"precoHotel\">");
            EndContext();
            BeginContext(2377, 11, false);
#line 59 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
                                               Write(hotel.price);

#line default
#line hidden
            EndContext();
            BeginContext(2389, 103, true);
            WriteLiteral("€</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 63 "C:\Users\natacha.leite\Desktop\MyTrips_projetoEstagio\MyTrips\MyTrips\Views\Home\Index.cshtml"
                }

            }
        

#line default
#line hidden
            BeginContext(2539, 29, true);
            WriteLiteral("\r\n\r\n    </section>\r\n</main>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2591, 127, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function MostraDadosHotel() {\r\n            debugger;\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Host>> Html { get; private set; }
    }
}
#pragma warning restore 1591
