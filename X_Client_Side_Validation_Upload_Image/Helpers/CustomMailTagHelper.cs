using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_Client_Side_Validation_Upload_Image.Helpers
{
    public class CustomMailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:zakirsoftdev@gmail.com");
            output.Content.SetContent("Email");
        }
    }
}
