using Pjt_Pitico;
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
    public partial class Inicio : Form 
    {
        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if (Config.Ling == true)
            {
                lbl_titulo.Text = "O IFSP APRESENTA";
            }
            else
            {
                lbl_titulo.Text = "THE IFSP PRESENTS";
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        { }
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.Hide();
                Form form = new História();
                form.Closed += (s, args) => this.Close();
                form.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
