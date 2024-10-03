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
            this.btn_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_email.BackColor = System.Drawing.Color.Transparent;
            this.btn_email.BackgroundImage = global::Pitico.Properties.Resources.email1;
            this.btn_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_email.Location = new System.Drawing.Point(96, 365);
            this.btn_email.Margin = new System.Windows.Forms.Padding(2);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(79, 78);
            this.btn_email.TabIndex = 0;
            this.btn_email.UseVisualStyleBackColor = false;
            this.btn_email.Click += new System.EventHandler(this.Btn_email_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Pitico.Properties.Resources.email;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1063, 666);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_clicar
            // 
            this.btn_clicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clicar.BackColor = System.Drawing.Color.Salmon;
            this.btn_clicar.BackgroundImage = global::Pitico.Properties.Resources.Cifrão;
            this.btn_clicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clicar.Location = new System.Drawing.Point(452, 320);
            this.btn_clicar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clicar.Name = "btn_clicar";
            this.btn_clicar.Size = new System.Drawing.Size(202, 67);
            this.btn_clicar.TabIndex = 2;
            this.btn_clicar.UseVisualStyleBackColor = false;
            this.btn_clicar.Visible = false;
            this.btn_clicar.Click += new System.EventHandler(this.btn_clicar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = global::Pitico.Properties.Resources.erro;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1044, 623);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pitico.Properties.Resources.desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_clicar);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAnuncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormANUNCIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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