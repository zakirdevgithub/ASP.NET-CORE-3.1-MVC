﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y_Partial_View_Multiple_Images_Pdf_Upload.Helpers
{
    [HtmlTargetElement("big")]
    [HtmlTargetElement(Attributes ="big")]
    public class BigTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Attributes.RemoveAll("big");
            output.Attributes.SetAttribute("class", "display-4");
        }
    }
}
