using AxWMPLib;
using Pitico;
using System;
using System.IO;
using System.Windows.Forms;

namespace Pjt_Pitico
{
    public partial class CutscenePiticoPuxado : Form
    {
        private bool video3Played = false;

        public CutscenePiticoPuxado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;

            // Associe o evento Load do formulário ao método que irá iniciar o vídeo
            this.Load += new EventHandler(CutscenePiticoPuxado_Load);
        }

        private void CutscenePiticoPuxado_Load(object sender, EventArgs e)
        {
            PlayVideoFromResources("video3");
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
    }
}
