using AxWMPLib;
using Pitico;
using System;
using System.IO;
using System.Windows.Forms;

namespace Pjt_Pitico
{
    public partial class História : Form
    {
        private bool videoPlayed = false;
        private string legendaAtual = "";
        private int legendaIndex = 0; // Controle do índice da legenda atual
        private Timer legendaTimer;
        private int sequenceStep = 0;
        private bool isFinalState = false;

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
            legendaTimer.Interval = 500; // Intervalo em milissegundos para verificar o tempo do vídeo
            legendaTimer.Tick += LegendaTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayVideoFromResources("video");

            if (Config.Leg == true)
            {
                lbl_legenda.Visible = true;
                legendaTimer.Start(); // Inicia o timer para controlar as legendas
            }
            else
            {
                lbl_legenda.Visible = false;
            }

            if (Config.Ling == true)
            {
                btn_avancar.Text = "AVANÇAR";
            }
            else
            {
                btn_avancar.Text = "NEXT";
            }
        }

        private void ExibirLegenda()
        {
            switch (legendaIndex)
            {
                case 0:
                    if (Config.Ling == true)
                    {
                        legendaAtual = "Pitico chega em casa cansado depois de um longo dia estudando e vai direto à cozinha conversar com sua mãe que está preparando o almoço";
                    }
                    else
                    {
                        legendaAtual = "Pitico comes home tired after a long day of studying and goes straight to the kitchen to talk to his mother who is preparing lunch.";
                    }
                    break;

                case 1:
                    if (Config.Ling == true)
                    {
                        legendaAtual = "Após o almoço, Pitico se dirige ao seu quarto, deixando suas coisas ao lado de sua cama e indo ligar seu computador, logo abre suas redes sociais para conversar com seus amigos";
                    }
                    else
                    {
                        legendaAtual = "After lunch, Pitico goes to his room, leaves his things next to his bed, turns on his computer, and quickly opens his social networks to chat with his friends.";
                    }
                    break;

                default:
                    legendaAtual = "";
                    break;
            }

            lbl_legenda.Text = legendaAtual;
        }

        private void LegendaTimer_Tick(object sender, EventArgs e)
        {
            double currentTime = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

           if (currentTime >= 0 && currentTime < 18)
            {
                legendaIndex = 0; 
                ExibirLegenda();
            }
            else if (currentTime >= 18 && currentTime < 40) 
            {
                legendaIndex = 1;
                ExibirLegenda(); 
            }
            else
            {
                lbl_legenda.Text = ""; 
            }
        }

        private void PlayVideoFromResources(string videoName)
        {
            byte[] video = null;

            switch (videoName)
            {
                case "video":
                    video = Pitico.Properties.Resources.cut1;
                    lbl_legenda.Visible = false;
                    break;
                case "cut2":
                    video = Pitico.Properties.Resources.cut2; // Adicione o cut2
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

                    axWindowsMediaPlayer1.URL = tempFilePath;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao reproduzir o vídeo: {ex.Message}");
                }
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {

           
                sequenceStep++;
                ControlFlow();
            }


            if (e.newState == 8)
            {
                if (axWindowsMediaPlayer1.URL.Contains("cut2.mp4"))
            {
                btn_avancar.Visible = true;
                axWindowsMediaPlayer1.Visible = false;

         
            }
            }
        }

        private void ControlFlow()
            {
            if (isFinalState) return;

            switch (sequenceStep)
                {
                    case 1:
                    // Exibe a primeira imagem
                    lbl_legenda2.Visible = true;
                        pic_mae1.Visible = true;
                    passar_mae1.Visible = true;
                    lbl_legenda2.Text = "Oi filho, chegou cedo em casa hoje";
                        break;
                case 2:
                    pic_mae1.Visible = false;
                    pitico_1.Visible = true;
                    lbl_legenda2.Text = "Sim, o professor Ivaldo liberou a gente mais cedo hoje!";
                    passar_pitico1.Visible = true;
                    break;
                case 3:
                    pitico_1.Visible = false;
                    pic_mae2.Visible = true;
                    lbl_legenda2.Text = "Que bom meu filho, mas cadê seu irmão?Ele não veio com você?";
                    passar_mae2.Visible = true;
                    break;
                case 4:
                    pic_mae2.Visible = false;
                    pitico_2.Visible = true;
                    passar_pra_cutscene.Visible = true;
                    lbl_legenda2.Text = "Ele disse que ia na casa de um amigo e depois iria voltar pra casa";
                    break;
                case 5:
             
                    pitico_2.Visible = false;
                    passar_pra_cutscene.Visible = false;
                    PlayVideoFromResources("cut2");
                    break;
            }
            }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Config.Leg == true && legendaIndex < 2)
                {
                    legendaIndex++;
                    ExibirLegenda();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form proximoFormulario = new FormAnuncio();
            proximoFormulario.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void passar_pra_cutscene_Click(object sender, EventArgs e)
        {
            PlayVideoFromResources("cut2");  // Carrega e reproduz cut2
            telapreta2.Visible = false;
            btn_avancar.Visible = true;
            isFinalState = true;
            passar_pra_cutscene.Visible = false;
            pitico_2.Visible = false;
            pitico_1.Visible = false;
            lbl_legenda2.Visible = false;
        }

        private void passar_mae2_Click(object sender, EventArgs e)
        {

            lbl_legenda2.Text = "Ele disse que ia na casa de um amigo e depois iria voltar pra casa";
            pic_mae2.Visible = false;
            passar_mae2.Visible = false;
            pitico_2.Visible = true;
            pitico_1.Visible = false;
            btn_telapreta1.Visible = true;


        }

        private void passar_pitico1_Click(object sender, EventArgs e)
        {
            lbl_legenda2.Text = "Que bom meu filho, mas cadê seu irmão?Ele não veio com você?";
            pitico_1.Visible = false;
            passar_pitico1.Visible = false;
            pic_mae2.Visible = true;
            passar_mae2.Visible = true;
        }

        private void passar_mae1_Click(object sender, EventArgs e)
        {
            if (passar_mae1.CanSelect) ;
            {
                lbl_legenda2.Text = "Sim, o professor Ivaldo liberou a gente mais cedo hoje!";
                pic_mae1.Visible = false;
                passar_mae1.Visible = false;
                pitico_1.Visible = true;
                passar_pitico1.Visible = true;
            }
    }

        private void pitico_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_telapreta2_Click(object sender, EventArgs e)
        {
            passar_pra_cutscene.Visible = true;
            telapreta2.Visible = true;
            telapreta1.Visible = false;
            btn_telapreta2.Visible = false;
            lbl_legenda2.Visible = true;
            lbl_legenda2.Text = "““Pode deixar mãe,… vou mexer um pouco no computador agora tá? Obrigado pelo almoço.””";
        }

        private void btn_telapreta1_Click(object sender, EventArgs e)
        {
            telapreta1.Visible = true;
            btn_telapreta2.Visible = true;
            lbl_legenda2.Visible = true;
            btn_telapreta1.Visible = false;
            lbl_legenda2.Text = "“Ah ok, preste atenção nele. Seu irmão está meio…mal… Você deve cuidar dele, ta bom?”";
        }
    }
}