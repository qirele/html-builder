using System;

namespace HtmlBuilder
{

    class Program
    {
        static void Main(string[] args)
        {

            var html = Html_Builder.Create()
                .WithTitle("HTML Builder that is impossible to mess up c#")
                .AppendStyle("styles.css")
                .AppendHeader(1, "Very awesome heading")
                .AppendParagraph("Really engaging paragraph lorem ipsum")
                .AppendImage("bbq_bacon_burger.jpg", "a picture of")
                .AppendScript("script.js")
                .Build();

            Console.WriteLine(html);

            
        }
    }
}
