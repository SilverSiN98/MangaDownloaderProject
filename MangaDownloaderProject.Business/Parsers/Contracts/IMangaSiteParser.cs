using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaDownloaderProject.Business.Parsers.Contracts
{
    public interface IMangaSiteParser
    {
        string LinkToImage { get; }
        int CurrentPage { get; }
    }
}
