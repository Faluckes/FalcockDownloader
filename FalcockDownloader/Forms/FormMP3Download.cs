using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace FalcockDownloader.Forms
{
    public partial class FormMP3Download : Form
    {
        public FormMP3Download()
        {
            InitializeComponent();
            btnDownload.Enabled = false;
            lblStatusDownload.Text = "";
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                var youtube = new YoutubeClient();

                var video = await youtube.Videos.GetAsync(txtBoxURL.Text);
                var title = video.Title.Replace("|", "").Replace("🎧", "");
                var duration = video.Duration;

                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(txtBoxURL.Text);

                var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                lblStatusDownload.Text = "Baixando...";


                await youtube.Videos.Streams.DownloadAsync(streamInfo, $@"c:\Users\Faluckes\Downloads\{title}.{streamInfo}.mp3");

                for (int load = 1; load < 100; load++)
                {
                    Thread.Sleep(90);
                    loadBar.Value = load;
                }

                using (var soundPlayer = new SoundPlayer(@"D:\Program\FalcockDownloader\FalcockDownloader\bin\Debug\Sucesso.wav"))
                {
                    soundPlayer.Play();
                    lblStatusDownload.Text = "Baixado com sucesso!";
                    MessageBox.Show($"O Áudio ''{title}'' foi baixada com sucesso", "Video baixado com sucesso", MessageBoxButtons.OK);
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

        private void txtBoxURL_TextChanged(object sender, EventArgs e)
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



        private void YoutubePlayerWindow()
        {
            try
            {
                youtubePlayer.Visible = true;
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
