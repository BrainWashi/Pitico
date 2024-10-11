using AxWMPLib;
using Pitico;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Pjt_Pitico
{
    public partial class EscolhaFase : Form
    {
        private bool videoPlayed = false;
        private int currentStage = 1;
        private double aspectRatio = 16.0 / 9.0;
        private TextBox textBoxOverlay;
        public EscolhaFase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;

            foreach (Control control in this.Controls)
            {
                control.KeyDown += new KeyEventHandler(Control_KeyDown);
            }
            textBoxOverlay = new TextBox();
            textBoxOverlay.Multiline = true;
            textBoxOverlay.Dock = DockStyle.Bottom;
            textBoxOverlay.Height = 50;
            textBoxOverlay.BackColor = Color.Black;
            textBoxOverlay.ForeColor = Color.White;
            textBoxOverlay.BorderStyle = BorderStyle.None;
            textBoxOverlay.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(textBoxOverlay);
            textBoxOverlay.BringToFront();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int largura = this.ClientSize.Width;
            int altura = (largura * 9) / 16;
            this.ClientSize = new Size(largura, altura);


            int x = (this.ClientSize.Width - label1.Width) / 2;
            int y = (this.ClientSize.Height - label1.Height) / 2;

            label1.Left = x;
            label1.Top = y;

            pictureBox1.Width = this.ClientSize.Width;
            pictureBox1.Height = this.ClientSize.Height;
            pictureBox2.Height = this.ClientSize.Height;
            pictureBox2.Width = this.ClientSize.Width;   
            pictureBox3.Width = this.ClientSize.Width;
            pictureBox3.Height = this.ClientSize.Height;


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            pictureBox1.Location = new Point(0, 0);
            pictureBox2.Location = new Point(0, 0);
            pictureBox3.Location = new Point(0, 0);

            textBox_Pype.Dock = DockStyle.Bottom;
            textBox_Pype.Width = this.ClientSize.Width - 10;

            if (this.WindowState == FormWindowState.Maximized)
            {

                SetFullScreenVideo();
            }
            else
            {

                AdjustVideoSize();
            }
        }
        private void SetFullScreenVideo()
            {

                int newWidth = this.ClientSize.Width;
                int newHeight = (int)(newWidth / aspectRatio);

                if (newHeight > this.ClientSize.Height)
                {

                    newHeight = this.ClientSize.Height;
                    newWidth = (int)(newHeight * aspectRatio);
                }


                axWindowsMediaPlayer1.Width = newWidth;
                axWindowsMediaPlayer1.Height = newHeight;


                axWindowsMediaPlayer1.Location = new Point((this.ClientSize.Width - newWidth) / 2, (this.ClientSize.Height - newHeight) / 2);
            }

            private void AdjustVideoSize()
            {

                axWindowsMediaPlayer1.Width = this.ClientSize.Width;
                axWindowsMediaPlayer1.Height = this.ClientSize.Height;

            }
    
    private void EscolhaFase_Load(object sender, EventArgs e)
        {
            Form1_Resize(this, EventArgs.Empty);
            PlayVideoFromResources("video4");

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            textBox_Pype.Visible = false;

            if (Config.Ling == true)
            {
                label1.Text = "AJUDE O PITICO!!!!";
                textBox_Pype.Text = "Pype" + Environment.NewLine + Environment.NewLine + "Você foi fisgado, agora terá que responder corretamente";
            }

            else
            {
                label1.Text = "HELP THE PITICO!!!!"; 
                textBox_Pype.Text = "Pype" + Environment.NewLine + Environment.NewLine + "You've been hooked, now you have to respond correctly";
            }
        }

        private void PlayVideoFromResources(string videoName)
        {
            if (Config.Dub == true)
            {

                byte[] video = null;

                switch (videoName)
                {
                    case "video4":
                        video = Pitico.Properties.Resources.video4_dub;
                        textBoxOverlay.Visible = true;
                        break;
                }

                if (video != null)
                {
                    string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.mp4");

                    try
                    {
                        using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                        {
                            fs.Write(video, 0, video.Length);
                        }

                        if (File.Exists(tempFilePath))
                        {
                            axWindowsMediaPlayer1.URL = tempFilePath;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar o arquivo temporário.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao tentar reproduzir o vídeo: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vídeo não encontrado nos recursos.");
                }
            }

            else
            {
                byte[] video = null;

                switch (videoName)
                {
                    case "video4":
                        video = Pitico.Properties.Resources.video4;
                        textBoxOverlay.Visible = true;
                        break;
                }

                if (video != null)
                {
                    string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.mp4");

                    try
                    {
                        using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                        {
                            fs.Write(video, 0, video.Length);
                        }

                        if (File.Exists(tempFilePath))
                        {
                            axWindowsMediaPlayer1.URL = tempFilePath;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar o arquivo temporário.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao tentar reproduzir o vídeo: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vídeo não encontrado nos recursos.");
                }
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                if (!videoPlayed)
                {
                    videoPlayed = true;

                    axWindowsMediaPlayer1.Visible = false;
                    textBoxOverlay.Visible = false;
                    label1.Visible = true;
                    pictureBox1.Visible = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (currentStage)
                {
                    case 1:
                        // Da primeira PictureBox para a segunda
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        currentStage = 2;
                        break;
                    case 2:
                        // Da segunda PictureBox para a terceira
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                        textBox_Pype.Visible = true;
                        currentStage = 3;
                        break;
                    case 3:
                        // Da terceira PictureBox para o próximo formulário
                        this.Hide();
                        Form frm = new Fase1();
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                        break;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Fase1();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
            this.Close();
        }


        private void Control_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
   
                e.SuppressKeyPress = true;


                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}

