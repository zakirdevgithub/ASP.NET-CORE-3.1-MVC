#pragma checksum "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "767626641556185a47fbb2656231b1ca5730f7a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\_ViewImports.cshtml"
using P_ViewData_Attribute.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767626641556185a47fbb2656231b1ca5730f7a8", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21a0bccb1831f3d85a7f1ddb6dd728e942ac9656", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 3 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 4 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
Write(ViewData["Number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 5 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
 foreach (var item in ViewData["Numbers"] as int[])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 7 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
  Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 11 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
 foreach (var item in ViewData["Friends"] as List<string>)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 13 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
  Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
  
    dynamic data = ViewData["obj"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dynamic Id: ");
#nullable restore
#line 20 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
           Write(data.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Dynamic Title: ");
#nullable restore
#line 21 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
              Write(data.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 23 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
   
    var classData = ViewData["Book"] as Book;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Book Class Id: ");
#nullable restore
#line 27 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
              Write(classData.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Book Class Title: ");
#nullable restore
#line 28 "H:\New Asp.Net Core\P_ViewData_Attribute\Views\Home\Contact.cshtml"
                 Write(classData.Title);

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
