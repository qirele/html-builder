using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    public class Html
    {

        public  string title;
        public  string stylesheetFile;
        public  int headerImportance;
        public  string header;
        public  string paraTxt;
        public  string imgSrc;
        public  string imgAltTxt;
        public  string scriptSrc;

        public override string ToString()
        {
            return @$"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <title>{title}</title>
    <link rel=""stylesheet"" href=""{stylesheetFile}"">
</head>
<body>
    <h{headerImportance}>{header}</h{headerImportance}>
    <p>{paraTxt}</p>
    <img src=""{imgSrc}"" alt=""{imgAltTxt}"">
    <script src=""{scriptSrc}""></script>
</body>
</html>
";
        }
    }

    public interface IWithTitle { IAppendStyle WithTitle(string title); }
    public interface IAppendStyle { IAppendHeader AppendStyle(string styleFile); }
    public interface IAppendHeader { IAppendParagraph AppendHeader(int importance, string txt); }
    public interface IAppendParagraph { IAppendImage AppendParagraph(string txt); }
    public interface IAppendImage { IAppendScript AppendImage(string src, string altTxt); }
    public interface IAppendScript { IHtmlBuilder AppendScript(string src); }
    public interface IHtmlBuilder { Html Build(); }



    public class Html_Builder :IWithTitle, IAppendStyle, IAppendHeader, IAppendParagraph, IAppendImage, IAppendScript, IHtmlBuilder
    {
        private readonly Html _html = new Html();
        
        

        private Html_Builder() { }

        public static IWithTitle Create()
        {
            return new Html_Builder();
        }

        public IAppendStyle WithTitle(string title)
        {
            _html.title = title;
            return this;
        }

        public IAppendHeader AppendStyle(string styleFile)
        {
            _html.stylesheetFile = styleFile;
            return this;
        }
        public IAppendParagraph AppendHeader(int importance, string txt)
        {
            _html.header = txt;
            _html.headerImportance = importance;
            return this;
        }

        public IAppendImage AppendParagraph(string txt)
        {
            _html.paraTxt = txt;
            return this;
        }
        public IAppendScript AppendImage(string src, string altTxt)
        {
            _html.imgSrc = src;
            _html.imgAltTxt = altTxt;
            return this;
        }
        public IHtmlBuilder AppendScript(string src)
        {
            _html.scriptSrc = src;
            return this;
        }




        public Html Build()
        {
            return _html;
        }

        
    }

}
