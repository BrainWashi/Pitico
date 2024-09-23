namespace Pjt_Pitico
{
    partial class FormAnuncio
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                // Parar e descartar os timers
                if (timer1 != null)
                {
                    timer1.Stop();
                    timer1.Dispose();
                }
                if (blinkTimer != null)
                {
                    blinkTimer.Stop();
                    blinkTimer.Dispose();
                }
                if (durationTimer != null)
                {
                    durationTimer.Stop();
                    durationTimer.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            this.btn_email = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clicar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(170, 372);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(105, 96);
            this.btn_email.TabIndex = 0;
            this.btn_email.Text = "VOCÊ RECEBEU UM EMAIL!";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.Btn_email_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Pitico.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1417, 820);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btn_clicar
            // 
            this.btn_clicar.Location = new System.Drawing.Point(634, 401);
            this.btn_clicar.Name = "btn_clicar";
            this.btn_clicar.Size = new System.Drawing.Size(269, 83);
            this.btn_clicar.TabIndex = 2;
            this.btn_clicar.Text = "“Você acaba de ganhar 10 mil reais!  Clique no link abaixo agora!” ";
            this.btn_clicar.UseVisualStyleBackColor = true;
            this.btn_clicar.Visible = false;
            this.btn_clicar.Click += new System.EventHandler(this.btn_clicar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pitico.Properties.Resources.erro;
            this.pictureBox3.Location = new System.Drawing.Point(-13, -13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1392, 662);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pitico.Properties.Resources.desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1399, 773);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_clicar);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAnuncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormANUNCIO";
            this.Load += new System.EventHandler(this.FormANUNCIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clicar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}