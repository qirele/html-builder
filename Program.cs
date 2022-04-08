using System;

namespace HtmlBuilder
{

    

    class Program
    {
        static void Main(string[] args)
        {
            var html = Html.New()
                .WithDOCTYPE()
                .OpenHtml()
                .OpenHead()
                .WithTitle("Builder of html c# awesome")
                .AppendLink("styler.css")
                .CloseHead()
                .OpenBody()
                .AppendHeading("Some nice heading", 1)
                .AppendPara("Very amazing paragraph")
                .CloseBody()
                .CloseHtml()
                .Build();

            Console.WriteLine(html.htmlRaw);
        }
    }
}
