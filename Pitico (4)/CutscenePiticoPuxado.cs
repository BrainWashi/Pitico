using AxWMPLib;
using Pitico;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
        private Timer timer;
        private int currentSecond;

        public CutscenePiticoPuxado()
        {
            InitializeComponent();

            this.FormClosed += new FormClosedEventHandler(CutscenePiticoPuxado_FormClosed);
            timer = new Timer();
            timer.Interval = 1000; // Intervalo de 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();

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
            PositionLegenda();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o controle está acessível
                if (axWindowsMediaPlayer2 != null && axWindowsMediaPlayer2.Ctlcontrols != null)
                {
                    currentSecond = (int)axWindowsMediaPlayer2.Ctlcontrols.currentPosition;

                    if (Config.Leg)
                    {
                        // Verifica o tempo decorrido e atualiza a label
                        if (currentSecond >= 0 && currentSecond < 9)
                        {
                            if (Config.Ling == true)
                            {
                                lbl_legenda.Text = "Pitico escuta uma risada vindo do PC e um portal se abre a sua frente, surgindo um anzol de pesca o agarrando pela camisa e o jogando para dentro";
                            }
                            else
                            {
                                lbl_legenda.Text = "Pitico hears a laugh coming from the PC and a portal opens in front of him, with a fishing hook appearing, grabbing him by the shirt and throwing him inside.";
                            }
                        }
                        else if (currentSecond >= 9 && currentSecond < 14)
                        {
                            if (Config.Ling == true)
                            {
                                lbl_legenda.Text = "HAAHAHAHAHAH Você realmente caiu nessa? Como você é ingênuo garoto...";
                            }

                            else
                            {
                                lbl_legenda.Text = "HAAHAHAHAHAH Did you really fall for that? How naive you are boy...";
                            }
                        }
                        else
                        {
                            lbl_legenda.Text = ""; // Limpa a legenda após 14 segundos
                            timer.Stop(); // Para o temporizador
                        }
                    }
                }
            }
            catch (InvalidComObjectException ex)
            {
                // Lidar com o erro, por exemplo, registrar ou mostrar uma mensagem
                MessageBox.Show("Erro ao acessar o reprodutor de mídia: " + ex.Message);
                timer.Stop(); // Para o temporizador se ocorrer um erro
            }
        }

        private void PositionLegenda()
        {
           
            lbl_legenda.Left = (this.ClientSize.Width - lbl_legenda.Width) / 2; 
            lbl_legenda.Top = this.ClientSize.Height - lbl_legenda.Height - 10; 

      
            this.Resize += (s, e) =>
            {
                lbl_legenda.Left = (this.ClientSize.Width - lbl_legenda.Width) / 2; 
                lbl_legenda.Top = this.ClientSize.Height - lbl_legenda.Height - 10; 
            };
        }


        private void CutscenePiticoPuxado_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop(); // Para o temporizador quando o formulário é fechado
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
                        video = Pitico.Properties.Resources.cutintro3Dub;
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
                byte[] video = null;

                switch (videoName)
                {
                    case "video3":
                        video = Pitico.Properties.Resources.cut_3;
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
