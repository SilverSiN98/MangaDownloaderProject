using System;
using System.Collections.Generic;
using System.IO;
using MangaDownloaderProject.Business.Parsers.Contracts;

namespace MangaDownloaderProject.Business.Models
{
    public class Chapter
    {
        public string PathToSave { get; set; }

        public int TotalPages { get; }

        public string ChapterName { get; }

        public string NextChapterLink { get; }

        public static event EventHandler<MangaEventArgs> SuccessMessage;

        public List<Page> pages;

        public Chapter(IMangaSiteAdvancedParser parserData, string path)
        {
            TotalPages = parserData.TotalPages;
            ChapterName = parserData.ChapterName;
            NextChapterLink = parserData.NextChapterLink;
            PathToSave = path;
            CreateFolder();
            pages = new List<Page>();
        }

        public void AddPage(int num, string link)
        {
            Page newPage = new Page(num, link, PathToSave);
            pages.Add(newPage);
        }

        private void CreateFolder()
        {
            PathToSave += "\\" + ChapterName;
            Directory.CreateDirectory(PathToSave);
            SuccessMessage(this, new MangaEventArgs("Folder " + ChapterName + " is created!"));
        }

        public bool IsCompleted()
        {
            if (pages.Count < TotalPages)
                return false;
            SuccessMessage(this, new MangaEventArgs("The download of the chapter " + ChapterName + " is completed!"));
            return true;
        }
    }
}
