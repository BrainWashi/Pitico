namespace Pjt_Pitico
{
    partial class História
    {
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(História));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_avancar = new System.Windows.Forms.Button();
            this.lbl_legenda = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pitico_1 = new System.Windows.Forms.PictureBox();
            this.pitico_2 = new System.Windows.Forms.PictureBox();
            this.pic_mae1 = new System.Windows.Forms.PictureBox();
            this.pic_mae2 = new System.Windows.Forms.PictureBox();
            this.passar_mae1 = new System.Windows.Forms.Button();
            this.passar_pitico1 = new System.Windows.Forms.Button();
            this.passar_mae2 = new System.Windows.Forms.Button();
            this.passar_pra_cutscene = new System.Windows.Forms.Button();
            this.lbl_legenda2 = new System.Windows.Forms.Label();
            this.telapreta2 = new System.Windows.Forms.PictureBox();
            this.telapreta1 = new System.Windows.Forms.PictureBox();
            this.btn_telapreta2 = new System.Windows.Forms.Button();
            this.btn_telapreta1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitico_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitico_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mae1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mae2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telapreta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telapreta1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 540);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "aaaaaaaaaaaaa";
            this.textBox1.Visible = false;
            // 
            // btn_avancar
            // 
            this.btn_avancar.Location = new System.Drawing.Point(937, 388);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.Size = new System.Drawing.Size(81, 44);
            this.btn_avancar.TabIndex = 2;
            this.btn_avancar.Text = "AVANÇAR";
            this.btn_avancar.UseVisualStyleBackColor = true;
            this.btn_avancar.Visible = false;
            this.btn_avancar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_legenda
            // 
            this.lbl_legenda.BackColor = System.Drawing.Color.Black;
            this.lbl_legenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_legenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legenda.ForeColor = System.Drawing.Color.White;
            this.lbl_legenda.Location = new System.Drawing.Point(-166, 522);
            this.lbl_legenda.Name = "lbl_legenda";
            this.lbl_legenda.Size = new System.Drawing.Size(1052, 94);
            this.lbl_legenda.TabIndex = 3;
            this.lbl_legenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1067, 675);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // pitico_1
            // 
            this.pitico_1.BackgroundImage = global::Pitico.Properties.Resources.dialogo1;
            this.pitico_1.Location = new System.Drawing.Point(0, 0);
            this.pitico_1.Name = "pitico_1";
            this.pitico_1.Size = new System.Drawing.Size(1067, 665);
            this.pitico_1.TabIndex = 7;
            this.pitico_1.TabStop = false;
            this.pitico_1.Visible = false;
            // 
            // pitico_2
            // 
            this.pitico_2.BackgroundImage = global::Pitico.Properties.Resources.dialogo2;
            this.pitico_2.Location = new System.Drawing.Point(0, 0);
            this.pitico_2.Name = "pitico_2";
            this.pitico_2.Size = new System.Drawing.Size(1067, 665);
            this.pitico_2.TabIndex = 6;
            this.pitico_2.TabStop = false;
            this.pitico_2.Visible = false;
            // 
            // pic_mae1
            // 
            this.pic_mae1.BackgroundImage = global::Pitico.Properties.Resources.mãe2;
            this.pic_mae1.Location = new System.Drawing.Point(0, -37);
            this.pic_mae1.Name = "pic_mae1";
            this.pic_mae1.Size = new System.Drawing.Size(1067, 665);
            this.pic_mae1.TabIndex = 5;
            this.pic_mae1.TabStop = false;
            this.pic_mae1.Visible = false;
            // 
            // pic_mae2
            // 
            this.pic_mae2.Image = global::Pitico.Properties.Resources.mãe;
            this.pic_mae2.Location = new System.Drawing.Point(-4, -20);
            this.pic_mae2.Name = "pic_mae2";
            this.pic_mae2.Size = new System.Drawing.Size(1067, 665);
            this.pic_mae2.TabIndex = 4;
            this.pic_mae2.TabStop = false;
            this.pic_mae2.Visible = false;
            // 
            // passar_mae1
            // 
            this.passar_mae1.Location = new System.Drawing.Point(943, 562);
            this.passar_mae1.Name = "passar_mae1";
            this.passar_mae1.Size = new System.Drawing.Size(75, 23);
            this.passar_mae1.TabIndex = 8;
            this.passar_mae1.Text = "Prosseguir";
            this.passar_mae1.UseVisualStyleBackColor = true;
            this.passar_mae1.Visible = false;
            this.passar_mae1.Click += new System.EventHandler(this.passar_mae1_Click);
            // 
            // passar_pitico1
            // 
            this.passar_pitico1.Location = new System.Drawing.Point(943, 562);
            this.passar_pitico1.Name = "passar_pitico1";
            this.passar_pitico1.Size = new System.Drawing.Size(75, 23);
            this.passar_pitico1.TabIndex = 9;
            this.passar_pitico1.Text = "Prosseguir";
            this.passar_pitico1.UseVisualStyleBackColor = true;
            this.passar_pitico1.Visible = false;
            this.passar_pitico1.Click += new System.EventHandler(this.passar_pitico1_Click);
            // 
            // passar_mae2
            // 
            this.passar_mae2.Location = new System.Drawing.Point(943, 562);
            this.passar_mae2.Name = "passar_mae2";
            this.passar_mae2.Size = new System.Drawing.Size(75, 23);
            this.passar_mae2.TabIndex = 10;
            this.passar_mae2.Text = "Prosseguir";
            this.passar_mae2.UseVisualStyleBackColor = true;
            this.passar_mae2.Visible = false;
            this.passar_mae2.Click += new System.EventHandler(this.passar_mae2_Click);
            // 
            // passar_pra_cutscene
            // 
            this.passar_pra_cutscene.Location = new System.Drawing.Point(943, 562);
            this.passar_pra_cutscene.Name = "passar_pra_cutscene";
            this.passar_pra_cutscene.Size = new System.Drawing.Size(75, 23);
            this.passar_pra_cutscene.TabIndex = 11;
            this.passar_pra_cutscene.Text = "Prosseguir";
            this.passar_pra_cutscene.UseVisualStyleBackColor = true;
            this.passar_pra_cutscene.Visible = false;
            this.passar_pra_cutscene.Click += new System.EventHandler(this.passar_pra_cutscene_Click);
            // 
            // lbl_legenda2
            // 
            this.lbl_legenda2.BackColor = System.Drawing.Color.Black;
            this.lbl_legenda2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_legenda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legenda2.ForeColor = System.Drawing.Color.White;
            this.lbl_legenda2.Location = new System.Drawing.Point(0, 534);
            this.lbl_legenda2.Name = "lbl_legenda2";
            this.lbl_legenda2.Size = new System.Drawing.Size(1052, 94);
            this.lbl_legenda2.TabIndex = 12;
            this.lbl_legenda2.Text = "Oi filho, chegou cedo em casa hoje";
            this.lbl_legenda2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_legenda2.Visible = false;
            // 
            // telapreta2
            // 
            this.telapreta2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telapreta2.Location = new System.Drawing.Point(-236, -97);
            this.telapreta2.Name = "telapreta2";
            this.telapreta2.Size = new System.Drawing.Size(1432, 653);
            this.telapreta2.TabIndex = 13;
            this.telapreta2.TabStop = false;
            this.telapreta2.Visible = false;
            // 
            // telapreta1
            // 
            this.telapreta1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telapreta1.Location = new System.Drawing.Point(0, -72);
            this.telapreta1.Name = "telapreta1";
            this.telapreta1.Size = new System.Drawing.Size(1052, 628);
            this.telapreta1.TabIndex = 14;
            this.telapreta1.TabStop = false;
            this.telapreta1.Visible = false;
            // 
            // btn_telapreta2
            // 
            this.btn_telapreta2.Location = new System.Drawing.Point(943, 562);
            this.btn_telapreta2.Name = "btn_telapreta2";
            this.btn_telapreta2.Size = new System.Drawing.Size(75, 23);
            this.btn_telapreta2.TabIndex = 15;
            this.btn_telapreta2.Text = "Prosseguir";
            this.btn_telapreta2.UseVisualStyleBackColor = true;
            this.btn_telapreta2.Visible = false;
            this.btn_telapreta2.Click += new System.EventHandler(this.btn_telapreta2_Click);
            // 
            // btn_telapreta1
            // 
            this.btn_telapreta1.Location = new System.Drawing.Point(943, 562);
            this.btn_telapreta1.Name = "btn_telapreta1";
            this.btn_telapreta1.Size = new System.Drawing.Size(75, 23);
            this.btn_telapreta1.TabIndex = 16;
            this.btn_telapreta1.Text = "Prosseguir";
            this.btn_telapreta1.UseVisualStyleBackColor = true;
            this.btn_telapreta1.Visible = false;
            this.btn_telapreta1.Click += new System.EventHandler(this.btn_telapreta1_Click);
            // 
            // História
            // 
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.passar_pitico1);
            this.Controls.Add(this.passar_mae2);
            this.Controls.Add(this.passar_mae1);
            this.Controls.Add(this.btn_telapreta1);
            this.Controls.Add(this.btn_telapreta2);
            this.Controls.Add(this.passar_pra_cutscene);
            this.Controls.Add(this.lbl_legenda2);
            this.Controls.Add(this.telapreta1);
            this.Controls.Add(this.telapreta2);
            this.Controls.Add(this.btn_avancar);
            this.Controls.Add(this.lbl_legenda);
            this.Controls.Add(this.pitico_1);
            this.Controls.Add(this.pitico_2);
            this.Controls.Add(this.pic_mae1);
            this.Controls.Add(this.pic_mae2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "História";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitico_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitico_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mae1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mae2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telapreta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telapreta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_avancar;
        private System.Windows.Forms.Label lbl_legenda;
        private System.Windows.Forms.PictureBox pic_mae2;
        private System.Windows.Forms.PictureBox pic_mae1;
        private System.Windows.Forms.PictureBox pitico_2;
        private System.Windows.Forms.PictureBox pitico_1;
        private System.Windows.Forms.Button passar_mae1;
        private System.Windows.Forms.Button passar_pitico1;
        private System.Windows.Forms.Button passar_mae2;
        private System.Windows.Forms.Button passar_pra_cutscene;
        private System.Windows.Forms.Label lbl_legenda2;
        private System.Windows.Forms.PictureBox telapreta2;
        private System.Windows.Forms.PictureBox telapreta1;
        private System.Windows.Forms.Button btn_telapreta2;
        private System.Windows.Forms.Button btn_telapreta1;
    }
}