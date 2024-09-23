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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(100, 100);
        
    

if (Config.Ling == true)
            {
                lbl_título.Text = "Segurança Confiscada";
                btn_créditos.Text = "Créditos";
                btn_iniciar.Text = "Iniciar";
                btn_opções.Text = "Opções";
                btn_sair.Text = "Sair";
            }
            else
            {
                lbl_título.Text = "Security Confiscated";
                btn_créditos.Text = "Credits";
                btn_iniciar.Text = "Start";
                btn_opções.Text = "Settings";
                btn_sair.Text = "Exit";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Inicio();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn_opções_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formm = new Configurações();
            formm.Closed += (s, args) => this.Close();
            formm.Show();
            
        }

        private void btn_créditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Créditos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form proximoFormulario = new Fase1();
            proximoFormulario.Show();
            this.Close();
        }
    }
}
