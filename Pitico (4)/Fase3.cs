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
            this.KeyDown += new KeyEventHandler(Movimento_Pitico);
            this.KeyPreview = true; 
        }

        private void Fase3_Load(object sender, EventArgs e)
        {
            
        }

        
        private void Movimento_Pitico (object sender, KeyEventArgs e)
        {
            int moveStep = 10; // Define a quantidade de pixels que o personagem se moverá

            switch (e.KeyCode)
            {
                case Keys.W: // Cima
                    Pitico_walk.Top -= moveStep;
                    Pitico_walk.Image = Image.FromFile("caminho/para/pitico andando de costas (1).gif");
                    break;
                case Keys.A: // Esquerda
                    Pitico_walk.Left -= moveStep; // Move para a esquerda
                    Pitico_walk.Image = Image.FromFile("caminho/para/pitico andando pra esquerda (1)1.gif");
                    break;
                case Keys.S: // Baixo
                    Pitico_walk.Top += moveStep; // Move para baixo
                    Pitico_walk.Image = Image.FromFile("caminho/para/pitico walk (1).gif");
                    break;
                case Keys.D: // Direita
                    Pitico_walk.Left += moveStep; // Move para a direita
                    Pitico_walk.Image = Image.FromFile("caminho/para/pitico andando pra direita (1).gif");
                    break;
            }

            // Impede que o personagem saia da tela
            Pitico_walk.Top = Math.Max(0, Pitico_walk.Top);
            Pitico_walk.Left = Math.Max(0, Pitico_walk.Left);
            Pitico_walk.Top = Math.Min(this.ClientSize.Height - Pitico_walk.Height, Pitico_walk.Top);
            Pitico_walk.Left = Math.Min(this.ClientSize.Width - Pitico_walk.Width, Pitico_walk.Left);
        
        }

        private void pitico_Click(object sender, EventArgs e)
        {

        }
    }
}
