using Microsoft.AspNetCore.Razor.TagHelpers;
using ProjectCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCRUD.Helpers
{
    public class AuthorCountTagHelper : TagHelper
    {
        public List<Author> authors;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";
            output.Content.SetContent("Number of authors in database : " + authors.Count);
        }
    }
}
