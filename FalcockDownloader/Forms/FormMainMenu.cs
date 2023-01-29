using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalcockDownloader
{
    public partial class Menu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private bool mover;
        private int cX, cY;

        public Menu()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;

            
        }
        #region moveWindow
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }
        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panelTitleBar.Left);
                this.Top += e.Y - (cY - panelTitleBar.Top);
            }
        }
        #endregion
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    //PanelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                    using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Windows Navigation Start.wav"))
                    {
                        soundPlayer.Play();
                    }

                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in PanelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 39, 42);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMP4Converter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MP4Download(), sender);
        }

        private void btnMp3Converter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMP3Download(), sender);
        }

        private void btnAbaout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbout(), sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            PanelLogo.BackColor = Color.FromArgb(35, 39, 42);
            currentButton = null;
            btnClose.Visible = false;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
