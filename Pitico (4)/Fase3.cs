using AxWMPLib;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pitico
{
    public partial class Fase3 : Form
    {
        private double aspectRatio = 16.0 / 9.0;
        private int videoAtual = 1;
        public Fase3()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.KeyDown += new KeyEventHandler(Faase2_KeyDown);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Movimento_Pitico);
            this.KeyPreview = true;
            Controles();

        }

        private void Fase3_Load(object sender, EventArgs e)
        {
            ReproduzirVideo("fase3intro1");

            
            this.KeyPreview = true; // Permite que o formulário receba eventos de tecla
            this.KeyDown += new KeyEventHandler(Faase2_KeyDown);

        }

        private void Controles()
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

        private void Movimento_Pitico(object sender, KeyEventArgs e)
        {
            int moveStep = 10; // Define a quantidade de pixels para cada movimento

            switch (e.KeyCode)
            {
                case Keys.W: // Movimenta para cima
                    Pitico_walk.Top -= moveStep;
                    Pitico_walk.Image = Properties.Resources.pitico_andando_de_costas__1_;
                    break;

                case Keys.A: // Movimenta para a esquerda
                    Pitico_walk.Left -= moveStep;
                    Pitico_walk.Image = Properties.Resources.pitico_andando_pra_esquerda__1_1;
                    break;

                case Keys.S: // Movimenta para baixo
                    Pitico_walk.Top += moveStep;
                    Pitico_walk.Image = Properties.Resources.pitico_walk__1_;
                    break;

                case Keys.D: // Movimenta para a direita
                    Pitico_walk.Left += moveStep;
                    Pitico_walk.Image = Properties.Resources.pitico_andando_pra_direita__1_;
                    break;
            }

            // Impede que o personagem saia da tela
            Pitico_walk.Top = Math.Max(0, Pitico_walk.Top);
            Pitico_walk.Left = Math.Max(0, Pitico_walk.Left);
            Pitico_walk.Top = Math.Min(this.ClientSize.Height - Pitico_walk.Height, Pitico_walk.Top);
            Pitico_walk.Left = Math.Min(this.ClientSize.Width - Pitico_walk.Width, Pitico_walk.Left);

            // Para debug: verificar posição
            Console.WriteLine($"Pitico_walk Position: Top={Pitico_walk.Top}, Left={Pitico_walk.Left}");
        }


        private void pitico_Click(object sender, EventArgs e)
        {

        }

        private void ReproduzirVideo(string videoNome)
        {

            byte[] videoBytes = (byte[])Properties.Resources.ResourceManager.GetObject(videoNome);

            if (videoBytes != null)
            {
                // lbl_pressione.Visible = false;
                // btn_next.Visible = false;


                string videoTempPath = Path.Combine(Path.GetTempPath(), videoNome + ".mp4");


                if (File.Exists(videoTempPath))
                {
                    File.Delete(videoTempPath);
                }


                File.WriteAllBytes(videoTempPath, videoBytes);


                axWindowsMediaPlayer1.URL = videoTempPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbl_pressione.Visible = false;
            }
            else if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                lbl_pressione.Visible = true;

                // Verifica se o vídeo atual é "fase3intro2"
                string currentMediaPath = axWindowsMediaPlayer1.currentMedia?.sourceURL; // Caminho do arquivo de mídia
                if (!string.IsNullOrEmpty(currentMediaPath) && currentMediaPath.Contains("fase3intro2"))
                {
                    axWindowsMediaPlayer1.Visible = false; 
                }
            }
        }



        private void AdvanceVideo()
        {
           
            switch (videoAtual)
            {
                case 1:
                ReproduzirVideo("fase3intro2");
                videoAtual++;
                break;
            }
        }

        private void Faase2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdvanceVideo();
                e.Handled = true; // Impede o tratamento padrão da tecla
            }
        }
    }
}