using HtmlTags;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.InteropServices;
using System.Text;

namespace WebTeknolojileriveProgramlama.Extensions
{
    public static class MyHtmlExtensions //Extensionlar static olmak zorunda // this kullanmak zorunlu
    {
        public static bool IsNullOrEmpty(this string text)
        {
              return string.IsNullOrEmpty(text);
        }

        public static IHtmlContent MyTextBox(this IHtmlHelper helper,
            string labelTExt, string expression, object value, object htmlAttributes )
        {
            //StringBuilder sb = new StringBuilder();
            //sb Append("<input type= 'text' ") // böyle de yazabilirdik ancak bazı değişkenleri unutabilirdik
            //https://formsflow.ai/try-it-now/


            var labelTagBuilder = new TagBuilder("label");
            labelTagBuilder.AddCssClass("col-md-4 form-label");
            //labelTagBuilder.Attributes.Add("for", "ad");
            //labelTagBuilder.InnerHtml.Append("Lütfen Adınızı Girin");

            labelTagBuilder.Attributes.Add("for", expression);
            labelTagBuilder.InnerHtml.Append(labelTExt);

            //Dışarda bir div oluşturup içine label koyup bir tane input 
            var mainDiv = new TagBuilder("div");
            mainDiv.AddCssClass("form-group");
            mainDiv.InnerHtml.AppendHtml(labelTagBuilder);

            var colDivTagBuilder = new TagBuilder("div");
            colDivTagBuilder.AddCssClass("col-md-8");

            //var textBoxTag = helper.TextBox("ad", null, new { @class = "form-control"});
            = colDivTagBuilder.InnerHtml.AppendHtml(TextboxTag);

            mainDiv.InnerHtml.AppendHtml(colDivTagBuilder);

            return mainDiv;



        }
    }
}
