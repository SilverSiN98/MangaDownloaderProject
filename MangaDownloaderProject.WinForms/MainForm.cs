using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MangaDownloaderProject.Business.Parsers;
using MangaDownloaderProject.Business.Models;

namespace MangaDownloaderProject.WinForms
{
    public partial class MainForm : Form
    {
        private Chapter currChapter;
        private List<Control> listOfComponents;
        private const string SampleString = "src=\"//static.fanfox.net/v201906282/mangafox/images/loading.gif\" data-loading-img=\"//static.fanfox.net/v201906282/mangafox/images/loading.gif\"";
        public string PathToSave { get; set; }
        public string Link { get; set; }
        public uint NumOfChapters { get; set; }
        public int CurrPage { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listOfComponents = new List<Control>();
            listOfComponents.Add(firstChapterLinkTextBox);
            listOfComponents.Add(pathToSaveTextBox);
            listOfComponents.Add(folderBrowserDialogButton);
            listOfComponents.Add(chaptersNumericUpDown);
            listOfComponents.Add(downloadButton);
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("Manga downloader");
            if (key != null)
            {
                folderBrowserDialog.SelectedPath = key.GetValue("Path to save").ToString();
                key.Close();
            }
            pathToSaveTextBox.Text = folderBrowserDialog.SelectedPath;
            Chapter.SuccessMessage += SetTextToTheLog;
            Page.SuccessMessage += SetTextToTheLog;

            webBrowser.ScriptErrorsSuppressed = true;
            //firstChapterLinkTextBox.Text = "http://fanfox.net/manga/3_gatsu_no_lion/v01/c001/1.html";
            CurrPage = 1;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                string result = webBrowser.Document.GetElementsByTagName("html")[0].InnerHtml;
                if (!result.Contains(SampleString) && result.Contains("reader-main-img"))
                {
                    if (CurrPage == 1)
                    {
                        FanFoxMangaAdvancedParser advParser = new FanFoxMangaAdvancedParser(result, CurrPage);
                        currChapter = new Chapter(advParser, PathToSave);
                        currChapter.AddPage(CurrPage, advParser.LinkToImage);
                    }
                    else
                    {
                        FanFoxMangaParser parser = new FanFoxMangaParser(result, CurrPage);
                        currChapter.AddPage(CurrPage, parser.LinkToImage);
                    }

                    CurrPage++;
                    if (currChapter.IsCompleted())
                    {
                        NumOfChapters--;
                        CurrPage = 1;
                        Link = currChapter.NextChapterLink;
                    }
                    else
                        Link = Link.Replace((CurrPage - 1) + ".html", CurrPage + ".html");

                    if (Link != null && NumOfChapters > 0)
                        webBrowser.Navigate(Link);
                    else
                    {
                        foreach (var component in listOfComponents)
                        {
                            component.Enabled = true;
                        }
                        SetTextToTheLog("Download completed!!!");
                    }
                }
                else
                {
                    webBrowser.Navigate(Link);
                }
            }
        }

        private void CallFileSystemWatcherButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathToSaveTextBox.Text = folderBrowserDialog.SelectedPath;
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE", true).CreateSubKey("Manga downloader", true);
                key.SetValue("Path to save", folderBrowserDialog.SelectedPath);
                key.Close();
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            Link = firstChapterLinkTextBox.Text;
            if (Link.Contains("http://fanfox.net/manga/") && Link.Contains("1.html"))
            {
                NumOfChapters = (uint)chaptersNumericUpDown.Value;
                PathToSave = pathToSaveTextBox.Text;
                foreach (var component in listOfComponents)
                {
                    component.Enabled = false;
                }
                SetTextToTheLog("Download started...");
                webBrowser.Navigate(Link);
            }
            else
                MessageBox.Show("Set the correct link to the first downloadable chapter!\n" 
                    + "Link must begin with \"http://fanfox.net/manga/\" and end with \"1.html\"");
        }
        
        public void SetTextToTheLog(object sender, MangaEventArgs args)
        {
            logTextBox.Text += args.message + Environment.NewLine;
            logTextBox.SelectionStart = logTextBox.Text.Length - 1;
        }

        public void SetTextToTheLog(string newText)
        {
            logTextBox.Text += newText + Environment.NewLine;
            logTextBox.SelectionStart = logTextBox.Text.Length - 1;
        }
    }
}
