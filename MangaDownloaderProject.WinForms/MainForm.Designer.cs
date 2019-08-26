namespace MangaDownloaderProject.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.labelSaveTo = new System.Windows.Forms.Label();
            this.pathToSaveTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.firstChapterLinkTextBox = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.chaptersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfChapters = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chaptersNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(832, 501);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Visible = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // logTextBox
            // 
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTextBox.Location = new System.Drawing.Point(12, 84);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(808, 352);
            this.logTextBox.TabIndex = 1;
            this.logTextBox.Text = "There will be information on the progress of the download.\n";
            // 
            // labelSaveTo
            // 
            this.labelSaveTo.AutoSize = true;
            this.labelSaveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSaveTo.Location = new System.Drawing.Point(11, 17);
            this.labelSaveTo.Name = "labelSaveTo";
            this.labelSaveTo.Size = new System.Drawing.Size(78, 20);
            this.labelSaveTo.TabIndex = 2;
            this.labelSaveTo.Text = "Save to:";
            // 
            // pathToSaveTextBox
            // 
            this.pathToSaveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathToSaveTextBox.Location = new System.Drawing.Point(103, 14);
            this.pathToSaveTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathToSaveTextBox.Name = "pathToSaveTextBox";
            this.pathToSaveTextBox.Size = new System.Drawing.Size(664, 26);
            this.pathToSaveTextBox.TabIndex = 3;
            // 
            // folderBrowserDialogButton
            // 
            this.folderBrowserDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderBrowserDialogButton.Location = new System.Drawing.Point(779, 14);
            this.folderBrowserDialogButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folderBrowserDialogButton.Name = "folderBrowserDialogButton";
            this.folderBrowserDialogButton.Size = new System.Drawing.Size(43, 27);
            this.folderBrowserDialogButton.TabIndex = 4;
            this.folderBrowserDialogButton.Text = "...";
            this.folderBrowserDialogButton.UseVisualStyleBackColor = true;
            this.folderBrowserDialogButton.Click += new System.EventHandler(this.CallFileSystemWatcherButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\Users\\User\\Pictures";
            // 
            // firstChapterLinkTextBox
            // 
            this.firstChapterLinkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstChapterLinkTextBox.Location = new System.Drawing.Point(71, 47);
            this.firstChapterLinkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstChapterLinkTextBox.Name = "firstChapterLinkTextBox";
            this.firstChapterLinkTextBox.Size = new System.Drawing.Size(477, 26);
            this.firstChapterLinkTextBox.TabIndex = 5;
            this.firstChapterLinkTextBox.Text = "Link to the first downloadable chapter.";
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLink.Location = new System.Drawing.Point(11, 50);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(50, 20);
            this.labelLink.TabIndex = 6;
            this.labelLink.Text = "Link:";
            // 
            // chaptersNumericUpDown
            // 
            this.chaptersNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chaptersNumericUpDown.Location = new System.Drawing.Point(759, 47);
            this.chaptersNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.chaptersNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.chaptersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chaptersNumericUpDown.Name = "chaptersNumericUpDown";
            this.chaptersNumericUpDown.Size = new System.Drawing.Size(63, 26);
            this.chaptersNumericUpDown.TabIndex = 7;
            this.chaptersNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumberOfChapters
            // 
            this.labelNumberOfChapters.AutoSize = true;
            this.labelNumberOfChapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfChapters.Location = new System.Drawing.Point(556, 50);
            this.labelNumberOfChapters.Name = "labelNumberOfChapters";
            this.labelNumberOfChapters.Size = new System.Drawing.Size(181, 20);
            this.labelNumberOfChapters.TabIndex = 8;
            this.labelNumberOfChapters.Text = "Number of chapters:";
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadButton.Location = new System.Drawing.Point(12, 443);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(809, 53);
            this.downloadButton.TabIndex = 9;
            this.downloadButton.Text = "Download!";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.labelNumberOfChapters);
            this.Controls.Add(this.chaptersNumericUpDown);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.firstChapterLinkTextBox);
            this.Controls.Add(this.folderBrowserDialogButton);
            this.Controls.Add(this.pathToSaveTextBox);
            this.Controls.Add(this.labelSaveTo);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 548);
            this.MinimumSize = new System.Drawing.Size(850, 548);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manga downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chaptersNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Label labelSaveTo;
        private System.Windows.Forms.Button folderBrowserDialogButton;
        private System.Windows.Forms.TextBox pathToSaveTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox firstChapterLinkTextBox;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.NumericUpDown chaptersNumericUpDown;
        private System.Windows.Forms.Label labelNumberOfChapters;
        private System.Windows.Forms.Button downloadButton;
    }
}

