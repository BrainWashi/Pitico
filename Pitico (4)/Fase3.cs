using AxWMPLib;
using Pitico.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pitico
{
    public partial class Fase3 : Form
    {
        private int spywareHealth = 100; // Vida inicial do Spyware
        private int attackRange = 90; // Distância máxima para o ataque funcionar

        private double aspectRatio = 16.0 / 9.0;
        private int videoAtual = 1;
        private Timer timerCoordenadas;
        int xMin = 1359;
        int xMax = 1359;
        int yMin = 270;
        int yMax = 500;

        int yAugusto = 378;
        int xAugusto = 710;

        int yThiago = 378;
        int xThiago = 740;

        private int CenarioAtual = 1;

        private int vida = 5;
        private int spywareVida = 3;
        private Timer timerSpyware;

        public Fase3()
        {
            InitializeComponent();

            timerCoordenadas = new Timer();
            timerCoordenadas.Interval = 100; // Atualiza a cada 100ms (0.1 segundo)
            timerCoordenadas.Tick += TimerCoordenadas_Tick;
            timerCoordenadas.Start();

            
            Spyware.Tag = "Spyware";

            timerSpyware = new Timer();
            timerSpyware.Interval = 50; // Movimento gradual a cada 50ms
            timerSpyware.Tick += TimerSpyware_Tick;
            timerSpyware.Start();

            this.WindowState = FormWindowState.Maximized;
            this.KeyDown += new KeyEventHandler(Faase2_KeyDown);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Movimento_Pitico);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Dialogos);
            this.KeyPreview = true;
            Controles();

            Pitico_walk.Location = new Point((int)(this.ClientSize.Width * 0.10), (int)(this.ClientSize.Height * 0.50));
            Spyware.Location = new Point((int)(this.ClientSize.Width * 0.80), (int)(this.ClientSize.Height * 0.50));
            VidaPitico1.Location = new Point((int)(this.ClientSize.Width * 0.01), (int)(this.ClientSize.Height * 0.01));
            VidaPitico2.Location = new Point((int)(this.ClientSize.Width * 0.06), (int)(this.ClientSize.Height * 0.01));
            VidaPitico3.Location = new Point((int)(this.ClientSize.Width * 0.11), (int)(this.ClientSize.Height * 0.01));
            VidaPitico4.Location = new Point((int)(this.ClientSize.Width * 0.16), (int)(this.ClientSize.Height * 0.01));
            VidaPitico5.Location = new Point((int)(this.ClientSize.Width * 0.21), (int)(this.ClientSize.Height * 0.01));

            Thiago.Location = new Point((int)(this.ClientSize.Width * 0.20), (int)(this.ClientSize.Height * 0.70));
            Augusto.Location = new Point((int)(this.ClientSize.Width * 0.60), (int)(this.ClientSize.Height * 0.70));
        }

        private void AtacarSpyware()
        {
            // Calcula a distância entre o jogador e o Spyware
            int distanciaX = Math.Abs(Pitico_walk.Left - Spyware.Left);
            int distanciaY = Math.Abs(Pitico_walk.Top - Spyware.Top);

            // Verifica se o Spyware está dentro da área de ataque
            if (distanciaX <= attackRange && distanciaY <= attackRange)
            {
                spywareHealth -= 20; // Reduz a vida do Spyware
                MessageBox.Show("Você acertou o Spyware!");

                // Verifica se o Spyware foi derrotado
                if (spywareHealth <= 0)
                {
                    Spyware.Visible = false; // Esconde o Spyware
                    MessageBox.Show("Spyware derrotado!");
                }
            }
            else
            {
                MessageBox.Show("O Spyware está muito longe para atacar!");
            }
        }

        private void TimerSpyware_Tick(object sender, EventArgs e)
        {
            MoverSpyware();
        }

        private void MoverSpyware()
        {
            int movimentoX = 0;
            int movimentoY = 0;

            if (Spyware.Visible == true)
            {
                if (Pitico_walk.Left > Spyware.Left)
                {
                    movimentoX = 1;
                }
                else if (Pitico_walk.Left < Spyware.Left)
                {
                    movimentoX = -1;
                }

                if (Pitico_walk.Top > Spyware.Top)
                {
                    movimentoY = 1;
                }
                else if (Pitico_walk.Top < Spyware.Top)
                {
                    movimentoY = -1;
                }
            }

            int velocidade = 2;

            // Atualizando a posição do Spyware
            Spyware.Left += movimentoX * velocidade;
            Spyware.Top += movimentoY * velocidade;

            if (Spyware.Bounds.IntersectsWith(Pitico_walk.Bounds))
            {
                EmpurrarPersonagem(Spyware);  // Chama o método correto para empurrar o personagem
            }
        }


        private void Fase3_Load(object sender, EventArgs e)
        {
            ReproduzirVideo("fase3intro1");
            VidaPitico1.Visible = false;
            VidaPitico2.Visible = false;
            VidaPitico3.Visible = false;
            VidaPitico4.Visible = false;
            VidaPitico5.Visible = false;
            lblCoordenadas.Visible = false;
            this.KeyPreview = true; // Permite que o formulário receba eventos de tecla
            this.KeyDown += new KeyEventHandler(Faase2_KeyDown);
            AdjustVideoSize();
            Controles();
            axWindowsMediaPlayer1.uiMode = "none"; // Oculta os controles
            this.WindowState = FormWindowState.Maximized;
            SetFullScreenVideo();
        }

        private void TimerCoordenadas_Tick(object sender, EventArgs e)
        {
            // Localiza o Label criado anteriormente
            var lblCoordenadas = this.Controls["lblCoordenadas"] as Label;

            if (lblCoordenadas != null)
            {
                lblCoordenadas.Text = $"X: {Pitico_walk.Left}, Y: {Pitico_walk.Top}";
            }
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
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.stretchToFit = true;
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

            Pitico_walk.Top = Math.Max(0, Pitico_walk.Top);
            Pitico_walk.Left = Math.Max(0, Pitico_walk.Left);
            Pitico_walk.Top = Math.Min(this.ClientSize.Height - Pitico_walk.Height, Pitico_walk.Top);
            Pitico_walk.Left = Math.Min(this.ClientSize.Width - Pitico_walk.Width, Pitico_walk.Left);

            Console.WriteLine($"Pitico_walk Position: Top={Pitico_walk.Top}, Left={Pitico_walk.Left}");
            lblCoordenadas.Text = $"X: {Pitico_walk.Left}, Y: {Pitico_walk.Top}";

            if (Pitico_walk.Left >= xMin && Pitico_walk.Left <= xMax &&
                Pitico_walk.Top >= yMin && Pitico_walk.Top <= yMax)
            {
                AvancarCenario();
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Spyware")
                {
                    if (Pitico_walk.Bounds.IntersectsWith(x.Bounds))
                    {
                        EmpurrarPersonagem(x);
                        break;
                    }
                }
            }
        }

        private void LevouDano()
        {
            if (vida == 5)
            {
                VidaPitico5.Visible = true;
             
                VidaPitico4.Visible = true;
                VidaPitico3.Visible = true;
                VidaPitico2.Visible = true;
                VidaPitico1.Visible = true;
            }

            if (vida == 4)
            {
                VidaPitico5.Visible = false;
                VidaPitico4.Visible = true;
                VidaPitico3.Visible = true;
                VidaPitico2.Visible = true;
                VidaPitico1.Visible = true;
            }

            if (vida == 3)
            {
                VidaPitico5.Visible = false;
                VidaPitico4.Visible = false;
                VidaPitico3.Visible = true;
                VidaPitico2.Visible = true;
                VidaPitico1.Visible = true;
            }

            if (vida == 2)
            {
                VidaPitico5.Visible = false;
                VidaPitico4.Visible = false;
                VidaPitico3.Visible = false;
                VidaPitico2.Visible = true;
                VidaPitico1.Visible = true;
            }

            if (vida == 1)
            {
                VidaPitico5.Visible = false;
                VidaPitico4.Visible = false;
                VidaPitico3.Visible = false;
                VidaPitico2.Visible = false;
                VidaPitico1.Visible = true;
            }

            if (vida == 0)
            {
                VidaPitico5.Visible = false;
                VidaPitico4.Visible = false;
                VidaPitico3.Visible = false;
                VidaPitico2.Visible = false;
                VidaPitico1.Visible = false;

                MessageBox.Show("Você Perdeu!");
                // FimDoJogo();
            }
        }

        private void EmpurrarPersonagem(Control spyware)
        {
            int deslizeVelocidade = 50;

            if (Spyware.Visible == true)
            {
                if (Pitico_walk.Bounds.IntersectsWith(spyware.Bounds))
                {
                    vida--;
                    LevouDano();
                    Console.WriteLine($"Colidiu com o spyware! Vida: {vida}");
                    if (Pitico_walk.Left < spyware.Left)
                        Pitico_walk.Left -= deslizeVelocidade;
                    else if (Pitico_walk.Left > spyware.Left)
                        Pitico_walk.Left += deslizeVelocidade;

                    if (Pitico_walk.Top < spyware.Top)
                        Pitico_walk.Top -= deslizeVelocidade;
                    else if (Pitico_walk.Top > spyware.Top)
                        Pitico_walk.Top += deslizeVelocidade;
                }
            }
        }

        private void AvancarCenario()
        {
            switch (CenarioAtual)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.cenário_com_as_casas_3;
                    Augusto.Visible = false;
                    Thiago.Visible = false;
                    Info_Augusto.Visible = false;
                    Info_Thiago.Visible = false;
                    Spyware.Visible = true;
                    Spyware.Enabled = true;
                    CenarioAtual++;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.cenário_com_as_casas_2;
                    CenarioAtual++;
                    break;
            }
        }

        private void pitico_Click(object sender, EventArgs e)
        {

        }

        private void ReproduzirVideo(string videoNome)
        {
            byte[] videoBytes = (byte[])Properties.Resources.ResourceManager.GetObject(videoNome);

            if (videoBytes != null)
            {
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
     
        private void AdvanceVideo()
        {
            switch (videoAtual)
            {
                case 1:
                    ReproduzirVideo("fase3intro2");
                    axWindowsMediaPlayer1.Visible = true;
                    VidaPitico1.Visible = false;
                    VidaPitico2.Visible = false;
                    VidaPitico3.Visible = false;
                    VidaPitico4.Visible = false;
                    VidaPitico5.Visible = false;
                    lblCoordenadas.Visible = false;
                    Augusto.Visible = false;
                    Thiago.Visible = false;
                    videoAtual++;
                    break;
                case 2:
                    axWindowsMediaPlayer1.Visible = true; // Garante que o player fique invisível
                    VidaPitico1.Visible = false;
                    VidaPitico2.Visible = false;
                    VidaPitico3.Visible = false;
                    VidaPitico4.Visible = false;
                    VidaPitico5.Visible = false;
                    lblCoordenadas.Visible = false;
                    Thiago.Visible = false;
                    Augusto.Visible = false;
                    videoAtual++;
                    break;
                case 3:
                    axWindowsMediaPlayer1.Visible = false;
                    videoAtual++;
                    VidaPitico1.Visible = true;
                    VidaPitico2.Visible = true;
                    VidaPitico3.Visible = true;
                    VidaPitico4.Visible = true;
                    VidaPitico5.Visible = true;
                    lblCoordenadas.Visible = true;
                    Augusto.Visible = true;
                    Thiago.Visible = true;
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

            if (e.KeyCode == Keys.Space)
            {
                AtacarSpyware();
            }
        }

        private void Dialogos(object sender, KeyEventArgs e)
        {
            if (yAugusto == Pitico_walk.Top && xAugusto == Pitico_walk.Left && e.KeyCode == Keys.Enter)
            {
                Info_Augusto.Visible = !Info_Augusto.Visible;
                e.Handled = true;
            }
            if (yThiago == Pitico_walk.Top && xThiago == Pitico_walk.Left && e.KeyCode == Keys.Enter)
            {
                Info_Thiago.Visible = !Info_Thiago.Visible;
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Informativo_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
