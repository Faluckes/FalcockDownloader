using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Media;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace FalcockDownloader.Forms
{
    public partial class MP4Download : Form
    {

        public MP4Download()
        {
            InitializeComponent();
            LoadTheme();
            btnDownload.Enabled = false;
            lblStatusDownload.Text = "";

        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void MP4Download_Load(object sender, EventArgs e)
        {

        }
        private async void button1_Click(object sender, EventArgs e)
        {

        }
        //public IVideoStreamInfo GetWithSpecificQaulity(IEnumerable<IVideoStreamInfo> streamInfos, string videoQuality)
        //{
        //    var test = streamInfos.FirstOrDefault();
        //    var test2 = test.VideoQuality.ToString();
        //    return streamInfos.Where(s => s.VideoQuality.ToString() == videoQuality).FirstOrDefault();

        //}
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {

                

                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(txtBoxURL.Text);
                var titleAutor = video.Author.ChannelTitle;
                var title = video.Title.Replace("|", "");
                var duration = video.Duration;
                var streamMainifest = await youtube.Videos.Streams.GetManifestAsync(txtBoxURL.Text);
                var streamInfo = streamMainifest.GetMuxedStreams().GetWithHighestVideoQuality();
                
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                lblStatusDownload.Text = "Baixando...";
                
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $@"c:\Users\Faluckes\Downloads\{title}.{streamInfo.Container}");

                
                for (int load = 0; load < 100; load++)
                {
                    Thread.Sleep(50);
                    loadBar.Value = load;
                }

                using (var soundPlayer = new SoundPlayer(@"D:\Program\FalcockDownloader\FalcockDownloader\bin\Debug\Sucesso.wav"))
                {
                    lblStatusDownload.Text = "Baixado com sucesso!";
                    soundPlayer.Play();
                    MessageBox.Show($"O vídeo ''{title}'' foi baixada com sucesso", "Video baixado com sucesso", MessageBoxButtons.OK);
                    loadBar.Value = 0;
                }


            }
            catch (Exception ex)
            {

                using (var soundPlayer = new SoundPlayer(@"D:\Program\FalcockDownloader\FalcockDownloader\bin\Debug\American.wav"))
                {
                    if (txtBoxURL.Text == "")
                    {
                        lblStatusDownload.Text = "URL vazia";
                        lblStatusDownload.ForeColor = Color.Red;

                    }
                    else
                    {
                        lblStatusDownload.Text = "URL inválido";
                        lblStatusDownload.ForeColor = Color.Red;
                    }
                    soundPlayer.Play();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatusDownload.Text = "";
                    soundPlayer.Stop();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxURL_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                YoutubePlayerWindow();
            }
        }
        private void picEnter_Click(object sender, EventArgs e)
        {
            YoutubePlayerWindow();

        }
        private void LoadBar_Click(object sender, EventArgs e)
        {

        }
        private void YoutubePlayerWindow()
        {
            try
            {
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='100%' heigh='100%' marginheight='0' marginwidth='0' frameborder='0' allowfullscreen scrolling='auto'></iframe>";
                html += "</head></html>";
                this.youtubePlayer.DocumentText = string.Format(html, txtBoxURL.Text.Split('=')[1]);
                youtubePlayer.Visible = true;
                btnDownload.Enabled = true;
            }
            catch (Exception ex)
            {
                using (var soundPlayer = new SoundPlayer(@"D:\Program\FalcockDownloader\FalcockDownloader\bin\Debug\American.wav"))
                {
                    if (txtBoxURL.Text == "")
                    {
                        lblStatusDownload.Text = "URL vazia";
                        lblStatusDownload.ForeColor = Color.Red;

                    }
                    else
                    {
                        lblStatusDownload.Text = "URL inválido";
                        lblStatusDownload.ForeColor = Color.Red;
                    }
                    youtubePlayer.Visible = false;
                    btnDownload.Enabled = false;
                    soundPlayer.Play();
                    MessageBox.Show(lblStatusDownload.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatusDownload.Text = "";
                    soundPlayer.Stop();

                }
            }
        }


    }
}
