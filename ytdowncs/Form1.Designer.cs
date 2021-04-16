
namespace ytdowncs
{
    partial class YTDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectfolder = new System.Windows.Forms.Button();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.savefolder = new System.Windows.Forms.FolderBrowserDialog();
            this.downloadbtn = new System.Windows.Forms.Button();
            this.downprogress = new System.Windows.Forms.ProgressBar();
            this.videosbox = new System.Windows.Forms.ComboBox();
            this.videoitems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectfolder
            // 
            this.selectfolder.Location = new System.Drawing.Point(328, 46);
            this.selectfolder.Name = "selectfolder";
            this.selectfolder.Size = new System.Drawing.Size(97, 23);
            this.selectfolder.TabIndex = 0;
            this.selectfolder.Text = "Выбрать папку";
            this.selectfolder.UseVisualStyleBackColor = true;
            this.selectfolder.Click += new System.EventHandler(this.selectfolder_Click);
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(27, 48);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(274, 20);
            this.urlbox.TabIndex = 1;
            this.urlbox.TextChanged += new System.EventHandler(this.urlbox_TextChanged);
            // 
            // savefolder
            // 
            this.savefolder.SelectedPath = "C:\\Users\\Serg\\Downloads\\YTDownload";
            // 
            // downloadbtn
            // 
            this.downloadbtn.Location = new System.Drawing.Point(328, 88);
            this.downloadbtn.Name = "downloadbtn";
            this.downloadbtn.Size = new System.Drawing.Size(97, 23);
            this.downloadbtn.TabIndex = 2;
            this.downloadbtn.Text = "Скачать";
            this.downloadbtn.UseVisualStyleBackColor = true;
            this.downloadbtn.Click += new System.EventHandler(this.downloadbtn_Click);
            // 
            // downprogress
            // 
            this.downprogress.Location = new System.Drawing.Point(27, 144);
            this.downprogress.Name = "downprogress";
            this.downprogress.Size = new System.Drawing.Size(398, 23);
            this.downprogress.TabIndex = 3;
            // 
            // videosbox
            // 
            this.videosbox.FormattingEnabled = true;
            this.videosbox.Location = new System.Drawing.Point(27, 90);
            this.videosbox.Name = "videosbox";
            this.videosbox.Size = new System.Drawing.Size(274, 21);
            this.videosbox.TabIndex = 4;
            this.videosbox.SelectedIndexChanged += new System.EventHandler(this.videosbox_SelectedIndexChanged);
            // 
            // videoitems
            // 
            this.videoitems.FormattingEnabled = true;
            this.videoitems.Location = new System.Drawing.Point(27, 90);
            this.videoitems.Name = "videoitems";
            this.videoitems.Size = new System.Drawing.Size(121, 21);
            this.videoitems.TabIndex = 5;
            this.videoitems.Visible = false;
            // 
            // YTDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(449, 193);
            this.Controls.Add(this.videoitems);
            this.Controls.Add(this.videosbox);
            this.Controls.Add(this.downprogress);
            this.Controls.Add(this.downloadbtn);
            this.Controls.Add(this.urlbox);
            this.Controls.Add(this.selectfolder);
            this.MaximizeBox = false;
            this.Name = "YTDownloader";
            this.Text = "SMPL_YTDonwload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectfolder;
        private System.Windows.Forms.TextBox urlbox;
        private System.Windows.Forms.FolderBrowserDialog savefolder;
        private System.Windows.Forms.Button downloadbtn;
        private System.Windows.Forms.ProgressBar downprogress;
        private System.Windows.Forms.ComboBox videosbox;
        private System.Windows.Forms.ComboBox videoitems;
    }
}

