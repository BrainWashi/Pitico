// FormANUNCIO.cs
using Pitico;
using System;
using System.Windows.Forms;

namespace Pjt_Pitico
{
    public partial class FormAnuncio : Form
    {
        private Timer blinkTimer;
        private Timer durationTimer;
        private int blinkDuration = 5000;
        private Timer timer;
        private bool shouldOpenNewForm = false;

        public FormAnuncio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Inicializa o Timer para fechar o formulário
            timer1 = new Timer();
            timer1.Interval = 5000; // Intervalo em milissegundos (5000 ms = 5 segundos)
            timer1.Tick += timer1_Tick;

            // Inicializa o Timer para piscar
            blinkTimer = new Timer();
            blinkTimer.Interval = 500; // Intervalo em milissegundos (500 ms = 0.5 segundos)
            blinkTimer.Tick += BlinkTimer_Tick;

            // Inicializa o Timer para controlar a duração do piscar
            durationTimer = new Timer();
            durationTimer.Interval = blinkDuration;
            durationTimer.Tick += DurationTimer_Tick;

            // Associa o evento VisibleChanged da PictureBox
            pictureBox3.VisibleChanged += PictureBox3_VisibleChanged;

            if (Config.Ling == true)
            {
                btn_clicar.Text = "VOCÊ ACABA DE GANHAR 10 MIL REAIS!   CLIQUE NO LINK ABAIXO AGORA!";
                btn_email.Text = "VOCÊ RECEBEU UM EMAIL!";
            }

            else
            {
                btn_email.Text = "YOU RECEIVED AN EMAIL!";
                btn_clicar.Text = "YOU JUST WON 10 THOUSAND DOLLARS!   CLICK THE LINK BELOW NOW!";
            }
        }




        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (!this.IsDisposed)
            {
                // Alterna a visibilidade do formulário
                this.Visible = !this.Visible;
            }
        }

        private void DurationTimer_Tick(object sender, EventArgs e)
        {
            if (!this.IsDisposed)
            {
                // Para os timers quando a duração é atingida
                blinkTimer.Stop();
                durationTimer.Stop();
                this.Visible = true; // Certifica-se de que o formulário esteja visível ao parar de piscar
                shouldOpenNewForm = true;
                this.Close();
            }
        }

        private void PictureBox3_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.IsDisposed)
            {
                if (pictureBox3.Visible)
                {
                    // Inicia o Timer para fechar o formulário quando a PictureBox se torna visível
                    timer1.Start();

                    // Inicia os timers para piscar
                    blinkTimer.Start();
                    durationTimer.Start();
                }
                else
                {
                    // Para os timers se a PictureBox se tornar invisível
                    timer1.Stop();
                    blinkTimer.Stop();
                    durationTimer.Stop();
                    this.Visible = true; // Certifica-se de que o formulário esteja visível ao parar de piscar
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.IsDisposed)
            {
                // Para o Timer após a primeira execução (se quiser um timer de execução única)
                timer1.Stop();

                // Fechar o formulário
                this.Close();
            }
        }

        private void Btn_email_Click(object sender, EventArgs e)
        {
            btn_email.Visible = false;
            pictureBox1.Visible = true;
            btn_clicar.Visible = true;



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Implementação para o clique da pictureBox3 (se necessário)
        }

        private void btn_clicar_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            btn_clicar.Visible = false;
            pictureBox3.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Implementação para o segundo timer (se necessário)
        }



        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (shouldOpenNewForm)
            {
                Form proximoFormulario = new CutscenePiticoPuxado();
                proximoFormulario.Show();
            }
        }

        private void FormANUNCIO_Load(object sender, EventArgs e)
        {

        }
    }

}