using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaDownloaderProject.Business.Parsers.Contracts
{
    public interface IMangaSiteAdvancedParser : IMangaSiteParser
    {
        int TotalPages { get; }
        string NextChapterLink { get; }
        string ChapterName { get; }

    }
}
