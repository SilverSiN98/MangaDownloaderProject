using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MangaDownloaderProject.Business.Parsers.Contracts;

namespace MangaDownloaderProject.Business.Parsers
{
    public class FanFoxMangaAdvancedParser : FanFoxMangaParser, IMangaSiteAdvancedParser
    {
        public int TotalPages { get; }

        public string NextChapterLink { get; }

        public string ChapterName { get; }

        public FanFoxMangaAdvancedParser(string str, int page) : base(str, page)
        {
            TotalPages = DefineNumberOfPages(str);
            NextChapterLink = DefineNextChapterLink(str);
            ChapterName = DefineChapterName(str);
        }

        private int DefineNumberOfPages(string str)
        {
            string pattern = @"<a href=""\S*"" data-page=""\d+""( jQuery\d+=""\d+"")?>\d+</a>";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(str);
            string findedString = matches[matches.Count - 1].Value;
            findedString = findedString.Substring(findedString.IndexOf('>') + 1);
            findedString = findedString.Substring(0, findedString.IndexOf('<'));
            return Int32.Parse(findedString);
        }

        private string DefineNextChapterLink(string str)
        {
            string pattern = @"<a [^<]*>Next Chapter</a>";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(str);
            try
            {
                string findedString = matches[0].Value;
                regex = new Regex(@"href="".*""", RegexOptions.IgnoreCase);
                matches = regex.Matches(findedString);
                findedString = matches[0].Value;
                findedString = findedString.Replace("href=\"", "").Replace("\"", "");
                findedString = "http://fanfox.net" + findedString;
                return findedString;
            }
            catch
            {
                return null;
            }
        }

        private string DefineChapterName(string str)
        {
            string pattern = @"<p class=""?reader-header-title-2""?>[^<]*</p>";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(str);
            string findedString = matches[0].Value;
            findedString = findedString.Substring(findedString.IndexOf('>') + 1);
            findedString = findedString.Substring(0, findedString.IndexOf('<'));
            return findedString;
        }
    }
}
