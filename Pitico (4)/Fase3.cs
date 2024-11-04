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
    public partial class Fase3 : Form
    {
        public Fase3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true; 
        }

        private void Fase3_Load(object sender, EventArgs e)
        {
           
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    pitico.Image = Image.FromFile("pitico andando de costas (1).gif");
                    break;
                case Keys.A:
                    pitico.Image = Image.FromFile("pitico andando pra esquerda (1)1.gif");
                    break;
                case Keys.S:
                    pitico.Image = Image.FromFile("pitico andando pra direita (1).gif");
                    break;
                case Keys.D:
                    pitico.Image = Image.FromFile("pitico walk (1).gif");
                    break;
            }
        }
    }
}
