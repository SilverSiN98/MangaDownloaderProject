using System;

namespace MangaDownloaderProject.Business.Models
{
    public class MangaEventArgs : EventArgs
    {
        public readonly string message;
        public MangaEventArgs(string msg)
        {
            message = msg;
        }
    }
}
