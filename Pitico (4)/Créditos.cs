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
    public partial class Créditos : Form
    {
        public Créditos()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.KeyDown += new KeyEventHandler(Control_KeyDown);
            }
            this.StartPosition = FormStartPosition.CenterScreen;

            if (Config.Ling == true )
            {
                lbl_titulo.Text = "Créditos";
                btn_voltar.Text = "Voltar";
            }
            else
            {
                lbl_titulo.Text = "Credits";
                btn_voltar.Text = "Return";
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Créditos_Load(object sender, EventArgs e)
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
