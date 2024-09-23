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
    public partial class ConfigAudio : Form
    {
        public ConfigAudio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Rdb_LigarDublagem_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_LigarDublagem.Checked)
            {
                Config.Dub = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_ligarNar.Checked)
            {
                Config.DescAudi = true;
            }
        }

        private void Rdb_DesligarNarração_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_DesligarNarração.Checked)
            {
                Config.DescAudi = false;
            }
        }

        private void Rdb_DesligarDublagem_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_DesligarDublagem.Checked)
            {
                Config.Dub = false;
            }
        }

        private void ConfigAudio_Load(object sender, EventArgs e)
        {
            if (Config.Ling & Config.Dub & Config.DescAudi == true)
            {
                lbl_titulo.Text = "Opções de Áudio";
                lbl_narracao.Text = "Descrição de áudio (narração):";
                lbl_dublagem.Text = "Dublagem:";
                lbl_geral.Text = "Volume Geral:";
                lbl_vozes.Text = "Volume Vozes:";
                lbl_ambiente.Text = "Volume Ambiente:";
                Rdb_LigarDublagem.Text = "Ligar";
                Rdb_DesligarDublagem.Text = "Desligar";
                Rdb_DesligarNarração.Text = "Desligar";
                Rdb_ligarNar.Text = "Ligar";
                Rdb_ligarNar.Checked = true;
                Rdb_LigarDublagem.Checked = true;
            }
            else
            {
                lbl_titulo.Text = "Audio Settings";
                lbl_narracao.Text = "Audio Description (narration):";
                lbl_dublagem.Text = "Dubbing:";
                lbl_geral.Text = "Overall Volume:";
                lbl_vozes.Text = "Voices Volume:";
                lbl_ambiente.Text = "Ambient Volume:";
                Rdb_LigarDublagem.Text = "On";
                Rdb_DesligarDublagem.Text = "Off";
                Rdb_DesligarNarração.Text = "Off";
                Rdb_ligarNar.Text = "On";
                Rdb_LigarDublagem.Checked = false;
                Rdb_DesligarNarração.Checked = false;
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Configurações();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
