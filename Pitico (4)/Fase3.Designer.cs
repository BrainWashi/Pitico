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
            this.pitico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pitico)).BeginInit();
            this.SuspendLayout();
            // 
            // pitico
            // 
            this.pitico.BackColor = System.Drawing.Color.Transparent;
            this.pitico.Image = global::Pitico.Properties.Resources.pitico_walk__1_;
            this.pitico.Location = new System.Drawing.Point(71, 62);
            this.pitico.Name = "pitico";
            this.pitico.Size = new System.Drawing.Size(283, 224);
            this.pitico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pitico.TabIndex = 0;
            this.pitico.TabStop = false;
            // 
            // Fase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pitico.Properties.Resources.fase3_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pitico);
            this.DoubleBuffered = true;
            this.Name = "Fase3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fase3";
            this.Load += new System.EventHandler(this.Fase3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pitico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pitico;
    }
}