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
    }
}
