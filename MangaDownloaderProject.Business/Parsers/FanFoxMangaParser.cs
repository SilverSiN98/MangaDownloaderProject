using System.Text.RegularExpressions;
using MangaDownloaderProject.Business.Parsers.Contracts;

namespace MangaDownloaderProject.Business.Parsers
{
    public class FanFoxMangaParser : IMangaSiteParser
    {
        public string LinkToImage { get; }

        public int CurrentPage { get; }

        public FanFoxMangaParser(string str, int page)
        {
            LinkToImage = DefineLinkToImage(str);
            CurrentPage = page;
        }

        private string DefineLinkToImage(string str)
        {
            string textBefore = @"reader-main-img.*src=""";
            string textAfter = @""" data-loading-img=""//static.fanfox.net/v201906282/mangafox/images/loading.gif""";
            Regex regex = new Regex(textBefore + @".*" + textAfter);
            MatchCollection matches = regex.Matches(str);
            string returnString = matches[0].Value;
            returnString = returnString.Substring(0, returnString.LastIndexOf('?'));
            returnString = returnString.Substring(returnString.LastIndexOf('"') + 1);
            returnString = "http:" + returnString;
            return returnString;
        }
    }
}
