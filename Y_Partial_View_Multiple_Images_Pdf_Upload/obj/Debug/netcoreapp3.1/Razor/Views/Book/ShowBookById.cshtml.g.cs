#pragma checksum "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e46312cf7548fea3a62f64cb7a29dcc3a2eeb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_ShowBookById), @"mvc.1.0.view", @"/Views/Book/ShowBookById.cshtml")]
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
#line 1 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
using Y_Partial_View_Multiple_Images_Pdf_Upload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e46312cf7548fea3a62f64cb7a29dcc3a2eeb1", @"/Views/Book/ShowBookById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e320bf799d6f8a044d9832ad747ca72c9b4640e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_ShowBookById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
  
    ViewData["Title"] = "ShowBookById";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container m-4"">
    <div class=""row"">
        <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12 col-12"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">

");
#nullable restore
#line 14 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 16 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 572, "\"", 602, 1);
#nullable restore
#line 16 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
WriteAttributeValue("", 580, i==0? "active" : "", 580, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 17 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ol>\r\n                <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 22 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 828, "\"", 884, 1);
#nullable restore
#line 24 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
WriteAttributeValue("", 836, i==0? "carousel-item active": "carousel-item", 836, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 920, "\"", 947, 1);
#nullable restore
#line 25 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
WriteAttributeValue("", 926, Model.Gallery[i].Url, 926, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 970, "\"", 998, 1);
#nullable restore
#line 25 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
WriteAttributeValue("", 976, Model.Gallery[i].Name, 976, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 27 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>

        </div>

        <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12 col-12"">
            <div class=""container"">
                <h2 class=""text-success"">");
#nullable restore
#line 43 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                                    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h3>By: ");
#nullable restore
#line 44 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                   Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p>");
#nullable restore
#line 45 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 1984, 1);
#nullable restore
#line 46 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
WriteAttributeValue("", 1967, Model.BookPdfURL, 1967, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\" target=\"_blank\">Read Now</a>\r\n\r\n            </div>\r\n            <br /><br />\r\n\r\n            <div class=\"container\">\r\n                <ul class=\"list-group\">\r\n                    <li class=\"list-group-item\">Category:");
#nullable restore
#line 53 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                                                    Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">Pages:");
#nullable restore
#line 54 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                                                 Write(Model.TotalPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">Language:");
#nullable restore
#line 55 "H:\New Asp.Net Core\Y_Partial_View_Multiple_Images_Pdf_Upload\Views\Book\ShowBookById.cshtml"
                                                    Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul><br /><br />\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
