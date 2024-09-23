namespace Pitico
{
    partial class Configurações
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_idioma = new System.Windows.Forms.Label();
            this.Rdb_inglês = new System.Windows.Forms.RadioButton();
            this.Rdb_português = new System.Windows.Forms.RadioButton();
            this.Btn_video = new System.Windows.Forms.Button();
            this.Btn_audio = new System.Windows.Forms.Button();
            this.Btn_controles = new System.Windows.Forms.Button();
            this.Btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_titulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_titulo.Location = new System.Drawing.Point(541, 106);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(221, 60);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Opções";
            // 
            // lbl_idioma
            // 
            this.lbl_idioma.AutoSize = true;
            this.lbl_idioma.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idioma.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_idioma.Location = new System.Drawing.Point(392, 210);
            this.lbl_idioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idioma.Name = "lbl_idioma";
            this.lbl_idioma.Size = new System.Drawing.Size(103, 31);
            this.lbl_idioma.TabIndex = 5;
            this.lbl_idioma.Text = "Idioma:";
            // 
            // Rdb_inglês
            // 
            this.Rdb_inglês.AutoSize = true;
            this.Rdb_inglês.BackColor = System.Drawing.Color.Transparent;
            this.Rdb_inglês.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Rdb_inglês.ForeColor = System.Drawing.Color.Yellow;
            this.Rdb_inglês.Location = new System.Drawing.Point(736, 210);
            this.Rdb_inglês.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rdb_inglês.Name = "Rdb_inglês";
            this.Rdb_inglês.Size = new System.Drawing.Size(108, 35);
            this.Rdb_inglês.TabIndex = 10;
            this.Rdb_inglês.TabStop = true;
            this.Rdb_inglês.Text = "Inglês";
            this.Rdb_inglês.UseVisualStyleBackColor = false;
            this.Rdb_inglês.CheckedChanged += new System.EventHandler(this.Rdb_inglês_CheckedChanged);
            // 
            // Rdb_português
            // 
            this.Rdb_português.AutoSize = true;
            this.Rdb_português.BackColor = System.Drawing.Color.Transparent;
            this.Rdb_português.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Rdb_português.ForeColor = System.Drawing.Color.Yellow;
            this.Rdb_português.Location = new System.Drawing.Point(537, 210);
            this.Rdb_português.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rdb_português.Name = "Rdb_português";
            this.Rdb_português.Size = new System.Drawing.Size(159, 35);
            this.Rdb_português.TabIndex = 11;
            this.Rdb_português.TabStop = true;
            this.Rdb_português.Text = "Português";
            this.Rdb_português.UseVisualStyleBackColor = false;
            this.Rdb_português.CheckedChanged += new System.EventHandler(this.Rdb_português_CheckedChanged);
            // 
            // Btn_video
            // 
            this.Btn_video.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_video.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_video.Location = new System.Drawing.Point(497, 388);
            this.Btn_video.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_video.Name = "Btn_video";
            this.Btn_video.Size = new System.Drawing.Size(341, 65);
            this.Btn_video.TabIndex = 12;
            this.Btn_video.Text = "Opções de Vídeo";
            this.Btn_video.UseVisualStyleBackColor = false;
            this.Btn_video.Click += new System.EventHandler(this.Btn_video_Click);
            // 
            // Btn_audio
            // 
            this.Btn_audio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_audio.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_audio.Location = new System.Drawing.Point(497, 289);
            this.Btn_audio.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_audio.Name = "Btn_audio";
            this.Btn_audio.Size = new System.Drawing.Size(341, 65);
            this.Btn_audio.TabIndex = 13;
            this.Btn_audio.Text = "Opções de Áudio";
            this.Btn_audio.UseVisualStyleBackColor = false;
            this.Btn_audio.Click += new System.EventHandler(this.Btn_audio_Click);
            // 
            // Btn_controles
            // 
            this.Btn_controles.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_controles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_controles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_controles.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_controles.Location = new System.Drawing.Point(497, 490);
            this.Btn_controles.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_controles.Name = "Btn_controles";
            this.Btn_controles.Size = new System.Drawing.Size(341, 65);
            this.Btn_controles.TabIndex = 14;
            this.Btn_controles.Text = "Controles";
            this.Btn_controles.UseVisualStyleBackColor = false;
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_voltar.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_voltar.Location = new System.Drawing.Point(1008, 623);
            this.Btn_voltar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(201, 46);
            this.Btn_voltar.TabIndex = 15;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = false;
            this.Btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pitico.Properties.Resources.Configurações;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 773);
            this.Controls.Add(this.Btn_voltar);
            this.Controls.Add(this.Btn_controles);
            this.Controls.Add(this.Btn_audio);
            this.Controls.Add(this.Btn_video);
            this.Controls.Add(this.Rdb_português);
            this.Controls.Add(this.Rdb_inglês);
            this.Controls.Add(this.lbl_idioma);
            this.Controls.Add(this.lbl_titulo);
            this.DoubleBuffered = true;
            this.Name = "Configurações";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Configurações_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_idioma;
        private System.Windows.Forms.RadioButton Rdb_inglês;
        private System.Windows.Forms.RadioButton Rdb_português;
        private System.Windows.Forms.Button Btn_video;
        private System.Windows.Forms.Button Btn_audio;
        private System.Windows.Forms.Button Btn_controles;
        private System.Windows.Forms.Button Btn_voltar;
    }
}