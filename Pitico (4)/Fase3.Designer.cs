namespace Pitico
{
    partial class Fase3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fase3));
            this.Pitico_walk = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_pressione = new System.Windows.Forms.Label();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.Spyware = new System.Windows.Forms.PictureBox();
            this.lbl_vida = new System.Windows.Forms.Label();
            this.VidaPitico1 = new System.Windows.Forms.PictureBox();
            this.VidaPitico2 = new System.Windows.Forms.PictureBox();
            this.VidaPitico3 = new System.Windows.Forms.PictureBox();
            this.VidaPitico4 = new System.Windows.Forms.PictureBox();
            this.VidaPitico5 = new System.Windows.Forms.PictureBox();
            this.Informativo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pitico_walk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spyware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico5)).BeginInit();
            this.SuspendLayout();
            // 
            // Pitico_walk
            // 
            this.Pitico_walk.BackColor = System.Drawing.Color.Transparent;
            this.Pitico_walk.Image = ((System.Drawing.Image)(resources.GetObject("Pitico_walk.Image")));
            this.Pitico_walk.Location = new System.Drawing.Point(71, 62);
            this.Pitico_walk.Name = "Pitico_walk";
            this.Pitico_walk.Size = new System.Drawing.Size(224, 222);
            this.Pitico_walk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pitico_walk.TabIndex = 0;
            this.Pitico_walk.TabStop = false;
            this.Pitico_walk.Click += new System.EventHandler(this.pitico_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(640, 82);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(801, 492);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // lbl_pressione
            // 
            this.lbl_pressione.AutoSize = true;
            this.lbl_pressione.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_pressione.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pressione.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pressione.Location = new System.Drawing.Point(202, 213);
            this.lbl_pressione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pressione.Name = "lbl_pressione";
            this.lbl_pressione.Size = new System.Drawing.Size(396, 25);
            this.lbl_pressione.TabIndex = 51;
            this.lbl_pressione.Text = "PRESSIONE ENTER PARA CONTINUAR";
            this.lbl_pressione.Visible = false;
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(10, 25);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(0, 16);
            this.lblCoordenadas.TabIndex = 52;
            // 
            // Spyware
            // 
            this.Spyware.BackColor = System.Drawing.Color.Transparent;
            this.Spyware.Enabled = false;
            this.Spyware.Image = global::Pitico.Properties.Resources.vírus_1;
            this.Spyware.Location = new System.Drawing.Point(566, 14);
            this.Spyware.Name = "Spyware";
            this.Spyware.Size = new System.Drawing.Size(120, 224);
            this.Spyware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Spyware.TabIndex = 53;
            this.Spyware.TabStop = false;
            this.Spyware.Tag = "Spyware";
            this.Spyware.Visible = false;
            this.Spyware.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_vida
            // 
            this.lbl_vida.AutoSize = true;
            this.lbl_vida.Location = new System.Drawing.Point(10, 10);
            this.lbl_vida.Name = "lbl_vida";
            this.lbl_vida.Size = new System.Drawing.Size(38, 16);
            this.lbl_vida.TabIndex = 54;
            this.lbl_vida.Text = "Vida:";
            // 
            // VidaPitico1
            // 
            this.VidaPitico1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VidaPitico1.Image = global::Pitico.Properties.Resources._10528948_pixel_coracao_icone_gratis_vetor;
            this.VidaPitico1.Location = new System.Drawing.Point(21, 10);
            this.VidaPitico1.Margin = new System.Windows.Forms.Padding(4);
            this.VidaPitico1.Name = "VidaPitico1";
            this.VidaPitico1.Size = new System.Drawing.Size(36, 28);
            this.VidaPitico1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VidaPitico1.TabIndex = 55;
            this.VidaPitico1.TabStop = false;
            // 
            // VidaPitico2
            // 
            this.VidaPitico2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VidaPitico2.Image = global::Pitico.Properties.Resources._10528948_pixel_coracao_icone_gratis_vetor;
            this.VidaPitico2.Location = new System.Drawing.Point(71, 10);
            this.VidaPitico2.Margin = new System.Windows.Forms.Padding(4);
            this.VidaPitico2.Name = "VidaPitico2";
            this.VidaPitico2.Size = new System.Drawing.Size(36, 28);
            this.VidaPitico2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VidaPitico2.TabIndex = 56;
            this.VidaPitico2.TabStop = false;
            // 
            // VidaPitico3
            // 
            this.VidaPitico3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VidaPitico3.Image = global::Pitico.Properties.Resources._10528948_pixel_coracao_icone_gratis_vetor;
            this.VidaPitico3.Location = new System.Drawing.Point(120, 10);
            this.VidaPitico3.Margin = new System.Windows.Forms.Padding(4);
            this.VidaPitico3.Name = "VidaPitico3";
            this.VidaPitico3.Size = new System.Drawing.Size(36, 28);
            this.VidaPitico3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VidaPitico3.TabIndex = 57;
            this.VidaPitico3.TabStop = false;
            // 
            // VidaPitico4
            // 
            this.VidaPitico4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VidaPitico4.Image = global::Pitico.Properties.Resources._10528948_pixel_coracao_icone_gratis_vetor;
            this.VidaPitico4.Location = new System.Drawing.Point(170, 10);
            this.VidaPitico4.Margin = new System.Windows.Forms.Padding(4);
            this.VidaPitico4.Name = "VidaPitico4";
            this.VidaPitico4.Size = new System.Drawing.Size(36, 28);
            this.VidaPitico4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VidaPitico4.TabIndex = 58;
            this.VidaPitico4.TabStop = false;
            // 
            // VidaPitico5
            // 
            this.VidaPitico5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VidaPitico5.Image = global::Pitico.Properties.Resources._10528948_pixel_coracao_icone_gratis_vetor;
            this.VidaPitico5.Location = new System.Drawing.Point(220, 10);
            this.VidaPitico5.Margin = new System.Windows.Forms.Padding(4);
            this.VidaPitico5.Name = "VidaPitico5";
            this.VidaPitico5.Size = new System.Drawing.Size(38, 28);
            this.VidaPitico5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VidaPitico5.TabIndex = 59;
            this.VidaPitico5.TabStop = false;
            // 
            // Informativo
            // 
            this.Informativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Informativo.BackColor = System.Drawing.Color.Black;
            this.Informativo.ForeColor = System.Drawing.SystemColors.Control;
            this.Informativo.Location = new System.Drawing.Point(68, 118);
            this.Informativo.Name = "Informativo";
            this.Informativo.Size = new System.Drawing.Size(433, 73);
            this.Informativo.TabIndex = 60;
            this.Informativo.Text = "Pressione Enter em frente aos Professores para buscar ajuda!";
            this.Informativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Informativo.Click += new System.EventHandler(this.Informativo_Click);
            // 
            // Fase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Informativo);
            this.Controls.Add(this.VidaPitico5);
            this.Controls.Add(this.VidaPitico4);
            this.Controls.Add(this.VidaPitico3);
            this.Controls.Add(this.VidaPitico2);
            this.Controls.Add(this.VidaPitico1);
            this.Controls.Add(this.lbl_vida);
            this.Controls.Add(this.Spyware);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.lbl_pressione);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Pitico_walk);
            this.DoubleBuffered = true;
            this.Name = "Fase3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fase3";
            this.Load += new System.EventHandler(this.Fase3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pitico_walk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spyware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaPitico5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pitico_walk;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lbl_pressione;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.PictureBox Spyware;
        private System.Windows.Forms.Label lbl_vida;
        private System.Windows.Forms.PictureBox VidaPitico1;
        private System.Windows.Forms.PictureBox VidaPitico2;
        private System.Windows.Forms.PictureBox VidaPitico3;
        private System.Windows.Forms.PictureBox VidaPitico4;
        private System.Windows.Forms.PictureBox VidaPitico5;
        private System.Windows.Forms.Label Informativo;
    }
}