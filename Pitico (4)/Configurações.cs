using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitico
{
    public partial class Configurações : Form
    {

        public Configurações()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Menu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Rdb_português_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_português.Checked)
            {
                Config.Ling = true;
                    lbl_titulo.Text = "Opcões";
                    lbl_idioma.Text = "Idioma";
                    Btn_audio.Text = "Opções de Áudio";
                    Btn_voltar.Text = "Voltar";
                    Btn_video.Text = "Opções de Vídeo";
                    Btn_controles.Text = "Controles";
                    Rdb_inglês.Text = "Inglês";
                    Rdb_português.Text = "Português";
            }
        }

        private void Rdb_inglês_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_inglês.Checked)
            {
                Config.Ling = false;
                    lbl_titulo.Text = "Settings";
                    lbl_idioma.Text = "Language";
                    Btn_audio.Text = "Audio Settings";
                    Btn_voltar.Text = "Return";
                    Btn_video.Text = "Video Settings";
                    Btn_controles.Text = "Controls";
                    Rdb_português.Text = "Portuguese";
                    Rdb_inglês.Text = "English";
            }
        }

        private void Btn_audio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new ConfigAudio();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Btn_video_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new ConfigVideo();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Configurações_Load(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                Rdb_português.Checked = true;
                Rdb_inglês.Checked = false;
            }

            else
            {
                Rdb_português.Checked = false;
                Rdb_inglês.Checked= true;
            }
        }
    }
}
