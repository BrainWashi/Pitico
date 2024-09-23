using AxWMPLib;
using Pitico;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pjt_Pitico
{
    public partial class EscolhaFase : Form
    {
        private bool videoPlayed = false;
        private int currentStage = 1; // Usado para controlar o estágio atual

        public EscolhaFase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }

        private void EscolhaFase_Load(object sender, EventArgs e)
        {
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
            byte[] video = null;

            switch (videoName)
            {
                case "video4":
                    video = Pitico.Properties.Resources.video4;
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

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                if (!videoPlayed)
                {
                    videoPlayed = true;

                    axWindowsMediaPlayer1.Visible = false;

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
        }
    }
}

