﻿using AxWMPLib;
using Pitico;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WMPLib;
using Pitico.Properties;
using System.Diagnostics.Eventing.Reader;

namespace Pjt_Pitico
{
    public partial class História : Form
    {
        private bool videoPlayed = false;
        private string legendaAtual = "";
        private string videoAtivo;
        private int legendaIndex = 0;
        private Timer legendaTimer;
        private int sequenceStep = 0;
        private bool isFinalState = false;
        private double aspectRatio = 16.0 / 9.0;
        private TextBox textBoxOverlay;
        private WindowsMediaPlayer player = new WindowsMediaPlayer(); // Instância do player

        public História()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;

            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            btn_avancar.Visible = false;
            btn_avancar.Click += button1_Click;

            legendaTimer = new Timer();
            legendaTimer.Interval = 500;
            legendaTimer.Tick += LegendaTimer_Tick;

            this.Resize += new EventHandler(Form1_Resize);

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

            pic_mae1.Width = this.ClientSize.Width;
            pic_mae1.Height = this.ClientSize.Height;
            pic_mae2.Width = this.ClientSize.Width;
            pic_mae2.Height = this.ClientSize.Height;
            pitico_1.Width = this.ClientSize.Width;
            pitico_1.Height = this.ClientSize.Height;
            pitico_2.Width = this.ClientSize.Width;
            pitico_2.Height = this.ClientSize.Height;
            telapreta1.Width = this.ClientSize.Width;
            telapreta1.Height = this.ClientSize.Height;
          telapreta2.Width = this.ClientSize.Width;
            telapreta2.Height = this.ClientSize.Height;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mae1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mae2.SizeMode = PictureBoxSizeMode.StretchImage;
            pitico_1.SizeMode = PictureBoxSizeMode.StretchImage;
            pitico_2.SizeMode = PictureBoxSizeMode.StretchImage;
            telapreta1.SizeMode = PictureBoxSizeMode.StretchImage;
            telapreta2.SizeMode = PictureBoxSizeMode.StretchImage;

            lbl_fala2.Width = this.ClientSize.Width - 20;
            lbl_fala1.Width = this.ClientSize.Width;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox2.Dock = DockStyle.Bottom;
            textBox1.Width = this.ClientSize.Width - 20;
            textBox1.Dock = DockStyle.Top;
            pic_mae1.Location = new Point(0, 0); 
            pic_mae2.Location = new Point(0, 0); 
            pitico_1.Location = new Point(0, 0); 
            pitico_2.Location = new Point(0, 0); 
          telapreta1.Location = new Point(0, 0); 
            telapreta2.Location = new Point(0, 0); 


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
        private void PositionLabelAtBottom()
        {
            pictureBox1.Controls.Add(lbl_fala1);
            pictureBox1.Controls.Add(btn_passar_mae1);
            pictureBox1.Controls.Add(btn_passar_pitico1);
            pictureBox1.Controls.Add(btn_passar_mae2);
            pictureBox1.Controls.Add(btn_passar_pra_cutscene);
            pictureBox1.Controls.Add(btn_telapreta1);
            pictureBox1.Controls.Add(btn_telapreta2);
            lbl_fala2.Controls.Add(btn_avancar);

            int buttonWidth = 100;
            int buttonHeight = 40;
            int margemDireita = 10;
            int alturaBotao = 20;
            int margemInferior = 10;




            foreach (Button btn in new Button[] { btn_passar_mae1, btn_passar_pitico1, btn_passar_mae2, btn_passar_pra_cutscene, btn_telapreta1, btn_telapreta2 })
            {
                btn.Size = new Size(buttonWidth, buttonHeight);
                btn.Left = pictureBox1.Width - btn.Width - margemDireita;
                btn.Top = pictureBox1.Height - buttonHeight - alturaBotao;
            }

            foreach (Button btn in new Button[] { btn_avancar })
            {
                btn_avancar.Size = new Size(buttonWidth, buttonHeight);
                btn.Left = lbl_fala2.Width - btn.Width - margemDireita;
                btn.Top = lbl_fala2.Height - buttonHeight - alturaBotao;
            }
            lbl_fala2.Resize += (s, e) =>
            {
                foreach (Button btn in new Button[] { btn_avancar })
                {
                    btn_avancar.Size = new Size(buttonWidth, buttonHeight);
                    btn.Left = lbl_fala2.Width - btn.Width - margemDireita;
                    btn.Top = lbl_fala2.Height - buttonHeight - alturaBotao;
                }
            };




                lbl_fala1.Left = (pictureBox1.Width - lbl_fala1.Width) / 2;
                lbl_fala1.Top = (pictureBox1.Height - lbl_fala1.Height) / 2;

    
            pictureBox1.Resize += (s, e) =>
            {
                foreach (Button btn in new Button[] { btn_passar_mae1, btn_passar_pitico1, btn_passar_mae2, btn_passar_pra_cutscene, btn_telapreta1, btn_telapreta2 })
                {
                    btn.Left = pictureBox1.Width - btn.Width - margemDireita;
                    btn.Top = pictureBox1.Height - buttonHeight - alturaBotao;
                }


                lbl_fala1.Left = (pictureBox1.Width - lbl_fala1.Width) / 2;
                lbl_fala1.Top = (pictureBox1.Height - lbl_fala1.Height) / 2;

                lbl_fala2.Left = (this.ClientSize.Width - lbl_fala2.Width) / 2;
                lbl_fala2.Top = this.ClientSize.Height - lbl_fala2.Height - margemInferior;

 
                pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
                pictureBox1.Top = this.ClientSize.Height - pictureBox1.Height - margemInferior;

                pictureBox2.Left = (this.ClientSize.Width - pictureBox2.Width) / 2;
                pictureBox2.Top = this.ClientSize.Height - pictureBox2.Height - margemInferior;




            }; 
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

            axWindowsMediaPlayer1.Width = this.ClientSize.Width;
            axWindowsMediaPlayer1.Height = this.ClientSize.Height - textBoxOverlay.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PositionLabelAtBottom();
            Form1_Resize(this, EventArgs.Empty);
            CenterButton();

            PlayVideoFromResources("video");

            if (Config.Leg == true)
            {
                lbl_fala2.Visible = true;
                legendaTimer.Start(); 
            }
            else
            {
                lbl_fala2.Visible = false;
            }

            if (Config.Ling == true)
            {
                btn_avancar.Text = "AVANÇAR";
                btn_passar_mae1.Text = "Prosseguir";
                btn_passar_mae2.Text = "Prosseguir";
                btn_passar_pitico1.Text = "Prosseguir";
            }
            else
            {
                btn_avancar.Text = "NEXT";

                btn_passar_mae1.Text = "Proceed";
                btn_passar_mae2.Text = "Proceed";
                btn_passar_pitico1.Text = "Proceed";
            }

        }

        private void ExibirLegenda()
        {
            switch (legendaIndex)
            {
                case 0:  
                    if (Config.Ling == true)
                    {
                        legendaAtual = "Pitico o jovem guaxinim chega em casa cansado depois de um longo dia estudando e vai direto a cozinha conversar com sua mãe, que está preparando o almoço.";
                    }
                    else
                    {
                        legendaAtual = "Pitico, the young raccoon comes home tired after a long day of studying and goes straight to the kitchen to talk to his mother, who is preparing lunch.";
                    }
                    break;

                case 1:  
                    if (Config.Ling == true)
                    {
                        legendaAtual = "Após o almoço, Pitico se dirige ao seu quarto, deixando as suas coisas de lado e indo ligar seu computador.";
                    }
                    else
                    {
                        legendaAtual = "After lunch, Pitico goes to his room, leaving his things aside and going to turn on his computer.";
                    }
                    break;

                default:
                    break;
            }

            lbl_fala2.Text = legendaAtual; 
        }

        private void LegendaTimer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1 != null && !axWindowsMediaPlayer1.IsDisposed)
            {
                double currentTime = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                
                if (videoAtivo == "video")
                {
                    if (currentTime >= 0 && currentTime < 12)  
                    {
                        legendaIndex = 0;  
                        ExibirLegenda();
                    }
                }
                else if (videoAtivo == "cut2")
                {
                    if (currentTime >= 0 && currentTime < 12)  
                    {
                        legendaIndex = 1;  
                        ExibirLegenda();
                    }
                }
            }
        }

        private void PlayVideoFromResources(string videoName)
        {
            videoAtivo = videoName;

            if (Config.Dub == false)
            {
                byte[] video = null;

                switch (videoName)
                {
                    case "video":
                        video = Resources.cut1;
                        lbl_fala2.Visible = true;
                        legendaIndex = 0;
                        break;
                    case "cut2":
                        video = Resources.cut2;
                        lbl_fala2.Visible = true;
                        legendaIndex = 1;

               
                        break;
               
                    default:
                        throw new ArgumentException("Nome do vídeo inválido");
                }

                if (video != null)
                {
                    try
                    {
                        string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.mp4");

                        using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                        {
                            fs.Write(video, 0, video.Length);
                        }

                        axWindowsMediaPlayer1.uiMode = "none";
                        axWindowsMediaPlayer1.URL = tempFilePath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao reproduzir o vídeo: {ex.Message}");
                    }
                }
            }

            else if(Config.Dub == true) 
            {
                byte[] video = null;

                switch (videoName)
                {
                    case "video":
                        video = Resources.cutintro1_dub;
                        lbl_fala2.Visible = true;
                        legendaIndex = 0;
                        break;
                    case "cut2":
                        video = Resources.cutintro2_dub;
                        lbl_fala2.Visible = true;
                        legendaIndex = 1;
                        break;
                    default:
                        throw new ArgumentException("Nome do vídeo inválido");
                }

                if (video != null)
                {
                    try
                    {
                        string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.mp4");

                        using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                        {
                            fs.Write(video, 0, video.Length);
                        }

                        axWindowsMediaPlayer1.uiMode = "none";
                        axWindowsMediaPlayer1.URL = tempFilePath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao reproduzir o vídeo: {ex.Message}");
                    }

                    }
                }
            }



        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Quando o vídeo terminar (estado 8 é "Stopped")
            if (e.newState == 8)
            {
                legendaIndex = 1;
                textBoxOverlay.Visible = false;
                sequenceStep++;
                ControlFlow();

                axWindowsMediaPlayer1.Focus();
            }

            // Verifica se o vídeo atual é o "cut2.mp4" ou "cuintro2Dub" e se terminou
            if (e.newState == 8 && (axWindowsMediaPlayer1.URL.Contains("cut2.mp4") || axWindowsMediaPlayer1.URL.Contains("cuintro2Dub")))
            {
                axWindowsMediaPlayer1.uiMode = "none";
                textBoxOverlay.Visible = true;
                btn_avancar.Visible = false;
                axWindowsMediaPlayer1.Visible = false;
                lbl_pressione.BringToFront();
                lbl_pressione.Visible = true;  // Exibe o lbl_pressione quando o vídeo 2 termina

                isFinalState = true;  // Flag que será usada no KeyDown para mudar de form
            }
            
        }


        private void CenterButton()
        {
            lbl_pressione.Left = (this.ClientSize.Width - lbl_pressione.Width) / 2;
            lbl_pressione.Top = (this.ClientSize.Height - lbl_pressione.Height) / 2;
        }
            private void ControlFlow()
            {
            if (isFinalState) return;

            switch (sequenceStep)
            { 
                
                case 1:
                    pictureBox1.Visible = true;
                    lbl_fala1.Visible = true;
                    pic_mae1.Visible = true;
                    btn_passar_mae1.Visible = true;
                    if (Config.Ling == true)
                    {
                        lbl_fala1.Text = "Oi filho, chegou cedo em casa hoje!";
                    }
                    else
                    {
                        lbl_fala1.Text = "Hi son, you came home early today!";
                    }
                    lbl_fala2.Visible = false;
                    break;

                case 2:
                    pic_mae1.Visible = false;
                    pitico_1.Visible = true;
                    if (Config.Ling == true)
                    {
                        lbl_fala1.Text = "Sim, o professor liberou a gente mais cedo hoje";
                    }
                    else
                    {
                        lbl_fala1.Text = "Yes, the teacher let us out earlier today.";
                    }
                    btn_passar_pitico1.Visible = true;
                    break;

                case 3:
                    pitico_1.Visible = false;
                    pic_mae2.Visible = true;
                    if (Config.Ling == true)
                    {
                        lbl_fala1.Text = "Que bom meu filho. Cadê seu irmão, ele não veio com você?";
                    }
                    else
                    {
                        lbl_fala1.Text = "That's good, my son. Where is your brother? Didn't he come with you?";
                    }
                    btn_passar_mae2.Visible = true;
                    break;

                case 4:
                    pic_mae2.Visible = false;
                    pitico_2.Visible = true;
                    btn_passar_pra_cutscene.Visible = true;
                    if (Config.Ling == true)
                    {
                        lbl_fala1.Text = "Ele disse que ia na casa de um amigo dele e depois voltava pra casa";
                    }
                    else
                    {
                        lbl_fala1.Text = "He said he was going to a friend's house and would come back home later.";
                    }
                    break;

                case 5:
                    pitico_2.Visible = false;
                    btn_passar_pra_cutscene.Visible = false;
                    PlayVideoFromResources("cut2");
                    textBoxOverlay.Visible = true;
                    break;
            }
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isFinalState)
                {
                    this.Hide(); // Esconde o formulário atual
                    Form proximoForm = new FormAnuncio(); // Troca pelo próximo formulário
                    proximoForm.Show(); // Mostra o próximo formulário
                }
                else if (Config.Leg == true && legendaIndex < 2) // Continua a troca de legendas apenas se o vídeo não terminou
                {
                    legendaIndex++;
                    ExibirLegenda();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is FormAnuncio)
                {
                    form.BringToFront(); 
                    return; 
                }
            }

        
            Form proximoFormulario = new FormAnuncio();
            proximoFormulario.Show();
        
}
   
    
    private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void passar_pra_cutscene_Click(object sender, EventArgs e)
        {
            PlayVideoFromResources("cut2");
            textBoxOverlay.Visible = true;
            pictureBox1.Visible = false;
            lbl_fala1.Visible = false;
            telapreta2.Visible = false;
            btn_avancar.Visible = false;
            isFinalState = true;
            btn_passar_pra_cutscene.Visible = false;
            pitico_2.Visible = false;
            pitico_1.Visible = false;

}
   
        private void passar_mae2_Click(object sender, EventArgs e)
        {
            if(Config.Ling == true)
            {
                lbl_fala1.Text = "Ele disse que ia na casa de um amigo dele e depois iria voltar pra casa";
            }
            else
            {
                lbl_fala1.Text = "He said he was going to a friend's house and would come back home later.";
            }
            pic_mae2.Visible = false;
            btn_passar_mae2.Visible = false;
            pitico_2.Visible = true;
            pitico_1.Visible = false;
            btn_telapreta1.Visible = true;


        }

        private void passar_pitico1_Click(object sender, EventArgs e)
        {

            if (Config.Ling == true)
            {
                lbl_fala1.Text = "Que bom meu filho, mas cadê seu irmão? Ele não veio com você?";
            }
            else
            {
                lbl_fala1.Text = "That's good, my son. Where is your brother? Didn't he come with you?";
            }
            pitico_1.Visible = false;
            btn_passar_pitico1.Visible = false;
            pic_mae2.Visible = true;
            btn_passar_mae2.Visible = true;
        }

        private void passar_mae1_Click(object sender, EventArgs e)
        {
            if (btn_passar_mae1.CanSelect);
            {
                if (Config.Ling == true)
                {
                    lbl_fala1.Text = "Sim, o professor Ivaldo liberou a gente mais cedo hoje!";
                }
                else
                {
                    lbl_fala1.Text = "Yes, the teacher let us out earlier today.";
                }
                pic_mae1.Visible = false;
                btn_passar_mae1.Visible = false;
                pitico_1.Visible = true;
                btn_passar_pitico1.Visible = true;
            }
        }

        private void pitico_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_telapreta2_Click(object sender, EventArgs e)
        {
            btn_passar_pra_cutscene.Visible = true;
            telapreta2.Visible = true;
            telapreta1.Visible = false;
            btn_telapreta2.Visible = false;
            lbl_fala1.Visible = true;

            if (Config.Ling == true)
            {
                lbl_fala1.Text = "Pode deixar mãe, vou mexer um pouco no computador agora tá? Obrigado pelo almoço.";
            }
            else
            {
                lbl_fala1.Text = "Don't worry mom, I'm going to play with the computer a little now, okay? Thanks for lunch.";
            }
        }

        private void btn_telapreta1_Click(object sender, EventArgs e)
        {

            pitico_2.Visible = false;
            telapreta1.Visible = true;
            btn_telapreta2.Visible = true;
            lbl_fala1.Visible = true;
            btn_telapreta1.Visible = false;
            if (Config.Ling == true)
            {
                lbl_fala1.Text = "Ah ok, preste atenção nele. Seu irmão está meio… mal… Você deve cuidar dele, ta bom?";
            }
            else
            {
                lbl_fala1.Text = "Ah ok, pay attention to him. Your brother is a little... bad... You should take care of him, okay";
            }
        }


        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
   
            if (e.KeyCode == Keys.Enter)
            {
     

         
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void telapreta1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_legenda2_Click(object sender, EventArgs e)
        {

        }

       
        private void pitico_2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_legenda_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
