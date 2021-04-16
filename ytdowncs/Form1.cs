using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace ytdowncs
{
    public partial class YTDownloader : Form
    {
        string savepath;
        YouTube youtube = YouTube.Default;
        public YTDownloader()
        {
            InitializeComponent();
            savepath = savefolder.SelectedPath;
        }

        private void GetVideoResolution(string url)
        {
            var videos = youtube.GetAllVideos(url).OrderByDescending(v=>v.Resolution);
            videosbox.Items.Clear();
            videoitems.Items.Clear();
            foreach(var v in videos)
            {
                if(v.Resolution>0 && !v.FullName.Contains("webm"))
                {
                    videosbox.Items.Add(v.FullName+" "+v.Resolution+"p");
                    videoitems.Items.Add(v.Resolution);
                }
            }
            videosbox.SelectedIndex = 0;
            videoitems.SelectedIndex = 0;
        }

        private void Download(string url, string path)
        {
            string vidname = videosbox.SelectedItem.ToString();
            var videores = Convert.ToInt32(videoitems.SelectedItem.ToString());
            var video = youtube.GetAllVideos(url).Select(v => v).Where(v => v.Resolution == videores).First();

            byte[] bytes = video.GetBytes();

            File.WriteAllBytes(path + "\\" + video.FullName, video.GetBytes());
            //FileStream file = new FileStream(, FileMode.OpenOrCreate, FileAccess.Write);
            //BinaryWriter writer = new BinaryWriter(file);
            //writer.Write(bytes);
            //writer.Close();
        }
        private void urlbox_TextChanged(object sender, EventArgs e)
        {
            if(urlbox.Text.Contains("www.youtube.com/watch"))
            {
                GetVideoResolution(Convert.ToString(urlbox.Text));
            }
        }

        private void selectfolder_Click(object sender, EventArgs e)
        {
            
            savefolder.ShowDialog();
            savepath = savefolder.SelectedPath;
        }

        private void downloadbtn_Click(object sender, EventArgs e)
        {
            Download(Convert.ToString(urlbox.Text), savepath);
        }

        private void videosbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoitems.SelectedIndex = videosbox.SelectedIndex;
        }
    }
}
