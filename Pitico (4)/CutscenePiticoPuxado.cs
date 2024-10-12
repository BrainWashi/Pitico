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
    public partial class CutscenePiticoPuxado : Form
    {
        private bool video3Played = false;
        private double aspectRatio = 16.0 / 9.0;
        private TextBox textBoxOverlay;
        public CutscenePiticoPuxado()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.KeyDown += new KeyEventHandler(Control_KeyDown);
            }

            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;

            this.Resize += new EventHandler(Form1_Resize);

            this.Load += new EventHandler(CutscenePiticoPuxado_Load);

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

        private void CutscenePiticoPuxado_Load(object sender, EventArgs e)
        {
            PlayVideoFromResources("video3");
            Form1_Resize(this, EventArgs.Empty);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int largura = this.ClientSize.Width;
            int altura = (largura * 9) / 16;
            this.ClientSize = new Size(largura, altura);


            if (this.WindowState == FormWindowState.Maximized)
            {

                SetFullScreenVideo();
            }
            else
            {

                AdjustVideoSize();
            }
            textBoxOverlay.Width = this.ClientSize.Width;
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


            axWindowsMediaPlayer2.Width = newWidth;
            axWindowsMediaPlayer2.Height = newHeight;


            axWindowsMediaPlayer2.Location = new Point((this.ClientSize.Width - newWidth) / 2, (this.ClientSize.Height - newHeight) / 2);
        }

        private void AdjustVideoSize()
        {

            axWindowsMediaPlayer2.Width = this.ClientSize.Width;
            axWindowsMediaPlayer2.Height = this.ClientSize.Height;

            axWindowsMediaPlayer2.Width = this.ClientSize.Width;
            axWindowsMediaPlayer2.Height = this.ClientSize.Height - textBoxOverlay.Height;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !video3Played)
            {
                PlayVideoFromResources("video3");
                video3Played = true;
            }
        }

        private void PlayVideoFromResources(string videoName)
        {
            if (Config.Dub == true)
            {
                byte[] video = null;

                switch (videoName)
                {
                    case "video3":
                        video = Pitico.Properties.Resources.cutintro3_dub;
                        break;
                    default:
                        throw new ArgumentException("Nome do vídeo inválido");
                }

                if (video == null || video.Length == 0)
                {
                    MessageBox.Show("Erro: O vídeo não foi encontrado nos recursos.");
                    return;
                }

                // Gere um nome de arquivo temporário único
                string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.mp4");

                // Escreva o vídeo dos recursos para o arquivo temporário
                using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(video, 0, video.Length);
                }

                // Configure o AxWindowsMediaPlayer para reproduzir o vídeo
                axWindowsMediaPlayer2.URL = tempFilePath;
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else
            {
                if (Config.Dub == true)
                {
                    byte[] video = null;

                    switch (videoName)
                    {
                        case "video3":
                            video = Pitico.Properties.Resources.video3;
                            break;
                        default:
                            throw new ArgumentException("Nome do vídeo inválido");
                    }

                    if (video == null || video.Length == 0)
                    {
                        MessageBox.Show("Erro: O vídeo não foi encontrado nos recursos.");
                        return;
                    }

                    // Gere um nome de arquivo temporário único
                    string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.mp4");

                    // Escreva o vídeo dos recursos para o arquivo temporário
                    using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(video, 0, video.Length);
                    }

                    // Configure o AxWindowsMediaPlayer para reproduzir o vídeo
                    axWindowsMediaPlayer2.URL = tempFilePath;
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                }
            }
        }

        // Verifique se o estado é 'MediaEnded'
        private void axWindowsMediaPlayer2_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Verifique se o estado é 'MediaEnded'
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Vídeo terminou, abra o próximo formulário
                Form proximoFormulario = new EscolhaFase();
                proximoFormulario.Show();
                this.Close();
            }
        }

        private void CutscenePiticoPuxado_Load_1(object sender, EventArgs e)
        {

        }


        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Impede o som do 'bip' padrão
                e.SuppressKeyPress = true;

                // Move o foco para o próximo controle no formulário
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
