#pragma checksum "H:\New Asp.Net Core\Q_Anchor_Tag_Helper\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb5169a489eaaa650a42f6e3e220de46f7fb7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "H:\New Asp.Net Core\Q_Anchor_Tag_Helper\Views\_ViewImports.cshtml"
using Q_Anchor_Tag_Helper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb5169a489eaaa650a42f6e3e220de46f7fb7e2", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d98ee1d6cbeedb6d158196e5bdefb0bbac825d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\New Asp.Net Core\Q_Anchor_Tag_Helper\Views\Home\About.cshtml"
   
    ViewData["Title"] = "About Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "H:\New Asp.Net Core\Q_Anchor_Tag_Helper\Views\Home\About.cshtml"
   
    var book = ViewData["Book"] as Book;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "H:\New Asp.Net Core\Q_Anchor_Tag_Helper\Views\Home\About.cshtml"
Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 10 "H:\New Asp.Net Core\Q_Anchor_Tag_Helper\Views\Home\About.cshtml"
Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
