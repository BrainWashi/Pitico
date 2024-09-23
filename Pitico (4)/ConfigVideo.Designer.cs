namespace Pitico
{
    partial class ConfigVideo
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
            this.lbl_legendas = new System.Windows.Forms.Label();
            this.rdb_ligado = new System.Windows.Forms.RadioButton();
            this.rdb_desligado = new System.Windows.Forms.RadioButton();
            this.lbl_brilho = new System.Windows.Forms.Label();
            this.lbl_altocontraste = new System.Windows.Forms.Label();
            this.lbl_daltonico = new System.Windows.Forms.Label();
            this.Btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_titulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_titulo.Location = new System.Drawing.Point(423, 144);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(472, 60);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Opções de Vídeo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // lbl_legendas
            // 
            this.lbl_legendas.AutoSize = true;
            this.lbl_legendas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_legendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_legendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legendas.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_legendas.Location = new System.Drawing.Point(316, 258);
            this.lbl_legendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_legendas.Name = "lbl_legendas";
            this.lbl_legendas.Size = new System.Drawing.Size(141, 31);
            this.lbl_legendas.TabIndex = 7;
            this.lbl_legendas.Text = "Legendas:";
            // 
            // rdb_ligado
            // 
            this.rdb_ligado.AutoSize = true;
            this.rdb_ligado.BackColor = System.Drawing.Color.Transparent;
            this.rdb_ligado.Checked = true;
            this.rdb_ligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.rdb_ligado.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_ligado.Location = new System.Drawing.Point(497, 255);
            this.rdb_ligado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_ligado.Name = "rdb_ligado";
            this.rdb_ligado.Size = new System.Drawing.Size(91, 38);
            this.rdb_ligado.TabIndex = 15;
            this.rdb_ligado.TabStop = true;
            this.rdb_ligado.Text = "Ligar";
            this.rdb_ligado.UseCompatibleTextRendering = true;
            this.rdb_ligado.UseVisualStyleBackColor = false;
            this.rdb_ligado.CheckedChanged += new System.EventHandler(this.rdb_ligado_CheckedChanged);
            // 
            // rdb_desligado
            // 
            this.rdb_desligado.AutoSize = true;
            this.rdb_desligado.BackColor = System.Drawing.Color.Transparent;
            this.rdb_desligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.rdb_desligado.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_desligado.Location = new System.Drawing.Point(641, 258);
            this.rdb_desligado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_desligado.Name = "rdb_desligado";
            this.rdb_desligado.Size = new System.Drawing.Size(135, 35);
            this.rdb_desligado.TabIndex = 18;
            this.rdb_desligado.Text = "Desligar";
            this.rdb_desligado.UseVisualStyleBackColor = false;
            this.rdb_desligado.CheckedChanged += new System.EventHandler(this.rdb_desligado_CheckedChanged);
            // 
            // lbl_brilho
            // 
            this.lbl_brilho.AutoSize = true;
            this.lbl_brilho.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_brilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brilho.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_brilho.Location = new System.Drawing.Point(316, 511);
            this.lbl_brilho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brilho.Name = "lbl_brilho";
            this.lbl_brilho.Size = new System.Drawing.Size(83, 31);
            this.lbl_brilho.TabIndex = 21;
            this.lbl_brilho.Text = "Brilho";
            // 
            // lbl_altocontraste
            // 
            this.lbl_altocontraste.AutoSize = true;
            this.lbl_altocontraste.BackColor = System.Drawing.Color.Transparent;
            this.lbl_altocontraste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_altocontraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altocontraste.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_altocontraste.Location = new System.Drawing.Point(316, 427);
            this.lbl_altocontraste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_altocontraste.Name = "lbl_altocontraste";
            this.lbl_altocontraste.Size = new System.Drawing.Size(187, 31);
            this.lbl_altocontraste.TabIndex = 20;
            this.lbl_altocontraste.Text = "Alto Contraste";
            // 
            // lbl_daltonico
            // 
            this.lbl_daltonico.AutoSize = true;
            this.lbl_daltonico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_daltonico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_daltonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daltonico.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_daltonico.Location = new System.Drawing.Point(316, 342);
            this.lbl_daltonico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_daltonico.Name = "lbl_daltonico";
            this.lbl_daltonico.Size = new System.Drawing.Size(202, 31);
            this.lbl_daltonico.TabIndex = 19;
            this.lbl_daltonico.Text = "Modo Daltônico";
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_voltar.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_voltar.Location = new System.Drawing.Point(1007, 616);
            this.Btn_voltar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(201, 46);
            this.Btn_voltar.TabIndex = 22;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = false;
            this.Btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // ConfigVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pitico.Properties.Resources.Configurações1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 773);
            this.Controls.Add(this.Btn_voltar);
            this.Controls.Add(this.lbl_brilho);
            this.Controls.Add(this.lbl_altocontraste);
            this.Controls.Add(this.lbl_daltonico);
            this.Controls.Add(this.rdb_desligado);
            this.Controls.Add(this.rdb_ligado);
            this.Controls.Add(this.lbl_legendas);
            this.Controls.Add(this.lbl_titulo);
            this.DoubleBuffered = true;
            this.Name = "ConfigVideo";
            this.Text = "ConfigVideo";
            this.Load += new System.EventHandler(this.ConfigVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_legendas;
        private System.Windows.Forms.RadioButton rdb_ligado;
        private System.Windows.Forms.RadioButton rdb_desligado;
        private System.Windows.Forms.Label lbl_brilho;
        private System.Windows.Forms.Label lbl_altocontraste;
        private System.Windows.Forms.Label lbl_daltonico;
        private System.Windows.Forms.Button Btn_voltar;
    }
}