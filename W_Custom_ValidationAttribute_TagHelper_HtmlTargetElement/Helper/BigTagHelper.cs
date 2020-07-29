﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Helper
{
    [HtmlTargetElement("big")]
    [HtmlTargetElement(Attributes ="big")]

    public class BigTagHelper : TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Attributes.RemoveAll("big");
            output.Attributes.SetAttribute("class", "display-1");

        }
    }
}
