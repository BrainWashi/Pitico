using System;
using System.Drawing;
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
            this.KeyDown += new KeyEventHandler(Menu_KeyDown);
            this.KeyPreview = true;

            //testeandoooooo

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


        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                ToggleFullScreen();
            }
        }

        private void ToggleFullScreen()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Inicio();
            frm.Closed += (s, args) => this.Close(); // Fecha o Menu quando o formulário Inicio for fechado
            frm.Show();
        }

        private void btn_opções_Click(object sender, EventArgs e)
        {
            Form formm = new Configurações();
            formm.Closed += (s, args) => this.Close(); // Fecha o Menu quando Configurações for fechado
            formm.Show(); // Mostra o novo formulário
            this.Hide(); // Oculte o Menu
        }

        private void btn_créditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Créditos();
            f.Closed += (s, args) => this.Close(); // Fecha o Menu quando Créditos for fechado
            f.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form proximoFormulario = new Fase1();
            proximoFormulario.Show(); // Mostra o próximo formulário
            this.Close(); // Fecha o Menu
        }
    }
}
