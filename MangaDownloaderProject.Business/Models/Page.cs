using System;
using System.IO;
using System.Net;

namespace MangaDownloaderProject.Business.Models
{
    public class Page
    {
        public string PathToSave { get; }

        public int PageNumber { get; }

        public string LinkToImage { get; }

        public static event EventHandler<MangaEventArgs> SuccessMessage;

        public Page(int num, string link, string path)
        {
            PageNumber = num;
            LinkToImage = link;
            PathToSave = path + string.Format("\\Page{0}.jpg", PageNumber);
            DownloadImage();
        }

        private void DownloadImage()
        {
            using (WebClient client = new WebClient())
            {
                var fstream = new FileStream(PathToSave, FileMode.Create);
                fstream.Close();
                fstream.Dispose();
                client.DownloadFile(LinkToImage, PathToSave);
                SuccessMessage(this, new MangaEventArgs("Page number " + PageNumber + " is downloaded!"));
            }
        }
    }
}
