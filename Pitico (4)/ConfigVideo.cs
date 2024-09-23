using Pitico;
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
    public partial class ConfigVideo : Form
    {
        public ConfigVideo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void rdb_ligado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ligado.Checked)
            {
                Config.Leg = true;
            }
        }

        private void rdb_desligado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_desligado.Checked) { 
                Config.Leg = false;
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Configurações();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void ConfigVideo_Load(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_titulo.Text = "Opções de Vídeo";
                lbl_legendas.Text = "Legendas";
                lbl_daltonico.Text = "Modo Daltônico";
                lbl_altocontraste.Text = "Alto Contraste";
                lbl_brilho.Text = "Brilho";
                Btn_voltar.Text = "Voltar";
                rdb_desligado.Text = "Desligar";
                rdb_ligado.Text = "Ligar";

            }
            else
            {
                lbl_titulo.Text = "Video Settings";
                lbl_legendas.Text = "Subtitles";
                lbl_daltonico.Text = "Colorblind Mode";
                lbl_altocontraste.Text = "High Contrast";
                lbl_brilho.Text = "Brightness";
                Btn_voltar.Text = "Return";
                rdb_desligado.Text = "Off";
                rdb_ligado.Text = "On";
            }

            rdb_desligado.Checked = false;
            rdb_ligado.Checked = false;
        }
    }
}
