#pragma checksum "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369587e35d0de7448c7dab79a30dd36865fcb2ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
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
#line 1 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\_ViewImports.cshtml"
using O_ViewBag_ViewData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369587e35d0de7448c7dab79a30dd36865fcb2ba", @"/Views/Book/GetAllBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cc9f5bc97d87a2b98e35ad81e2e4ce2bce78888", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Mountain.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml"
  
    ViewData["Title"] = "All Books";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 14 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-xl-4 col-lg-4 col-md-4 col-sm-12 col-12\">\r\n                <div class=\"card shadow-sm\">\r\n\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "369587e35d0de7448c7dab79a30dd36865fcb2ba4351", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title text-center\">");
#nullable restore
#line 24 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml"
                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p class=\"card-text text-center\">");
#nullable restore
#line 25 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml"
                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-footer\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-6\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 802, "\"", 835, 2);
            WriteAttributeValue("", 809, "/Book/GetBookById/", 809, 18, true);
#nullable restore
#line 30 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml"
WriteAttributeValue("", 827, item.Id, 827, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">View Details</a>\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n                                <p class=\"text-right\">");
#nullable restore
#line 33 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml"
                                                 Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 40 "H:\New Asp.Net Core\O_ViewBag_ViewData\Views\Book\GetAllBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591