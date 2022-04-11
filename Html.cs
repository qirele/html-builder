using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    public class Html
    {

        public string htmlRaw;

        public static Html_Builder New()
        {
            return new Html_Builder();
        }
    }

    public class Html_Builder
    {
        private readonly Html html = new Html();
        public Html_Builder WithDOCTYPE()
        {
            if (html.htmlRaw == null)
            {
                html.htmlRaw = "<!DOCTYPE html>\n";
            }else
            {
                html.htmlRaw += "<!DOCTYPE html>\n";
            }

            return this;
        }

        public Html_Builder OpenHtml()
        {
            html.htmlRaw += "<html>\n";
            return this;
        }
        public Html_Builder CloseHtml()
        {
            html.htmlRaw += "</html>\n";
            return this;
        }


        public Html_Builder OpenHead()
        {
            html.htmlRaw += "<head>\n";
            return this;
        }
        public Html_Builder CloseHead()
        {
            html.htmlRaw += "</head>\n";
            return this;
        }

        public Html_Builder WithTitle(string title)
        {
            html.htmlRaw += $"<title>{title}</title>\n";
            return this;
        }

        public Html_Builder AppendLink(string src)
        {
            html.htmlRaw += $@"<link rel=""stylesheet"" src=""{src}"">" + "\n";
            return this;
        }

        public Html_Builder OpenBody()
        {
            html.htmlRaw += $"<body>\n";
            return this;
        }
        public Html_Builder CloseBody()
        {
            html.htmlRaw += $"</body>\n";
            return this;
        }
        public Html_Builder AppendHeading(string text, int power)
        {
            html.htmlRaw += $"<h{power}>{text}</h{power}>\n";
            return this;
        }

        public Html_Builder AppendPara(string text)
        {
            html.htmlRaw += $"<p>{text}</p>\n";
            return this;
        }

        public Html Build()
        {
            return html;
        }

    }

}
