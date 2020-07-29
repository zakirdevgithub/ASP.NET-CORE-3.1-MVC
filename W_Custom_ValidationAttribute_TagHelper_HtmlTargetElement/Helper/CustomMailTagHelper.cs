using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Helper
{
    public class CustomMailTagHelper : TagHelper
    {
        public string MyEmail { get; set;}
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            //output.Attributes.SetAttribute("href", "mailto:zakirsoftdev@gmail.com");
            output.Attributes.SetAttribute("href", $"mailto:{MyEmail}");
            output.Attributes.Add("id", "my-id");
            output.Content.SetContent("Email");
        }
    }
}
