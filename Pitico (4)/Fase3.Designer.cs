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
            ((System.ComponentModel.ISupportInitialize)(this.Pitico_walk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pitico_walk
            // 
            this.Pitico_walk.BackColor = System.Drawing.Color.Transparent;
            this.Pitico_walk.Image = global::Pitico.Properties.Resources.pitico_walk__1_;
            this.Pitico_walk.Location = new System.Drawing.Point(71, 62);
            this.Pitico_walk.Name = "Pitico_walk";
            this.Pitico_walk.Size = new System.Drawing.Size(283, 224);
            this.Pitico_walk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pitico_walk.TabIndex = 0;
            this.Pitico_walk.TabStop = false;
            this.Pitico_walk.Click += new System.EventHandler(this.pitico_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(71, 292);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(801, 492);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
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
            // Fase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pitico.Properties.Resources.fase3_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pitico_walk;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lbl_pressione;
    }
}