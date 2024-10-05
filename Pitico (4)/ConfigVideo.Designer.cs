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
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_titulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_titulo.Location = new System.Drawing.Point(317, 117);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(381, 48);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Opções de Vídeo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // lbl_legendas
            // 
            this.lbl_legendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_legendas.AutoSize = true;
            this.lbl_legendas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_legendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_legendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legendas.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_legendas.Location = new System.Drawing.Point(237, 210);
            this.lbl_legendas.Name = "lbl_legendas";
            this.lbl_legendas.Size = new System.Drawing.Size(113, 25);
            this.lbl_legendas.TabIndex = 7;
            this.lbl_legendas.Text = "Legendas:";
            // 
            // rdb_ligado
            // 
            this.rdb_ligado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rdb_ligado.AutoSize = true;
            this.rdb_ligado.BackColor = System.Drawing.Color.Transparent;
            this.rdb_ligado.Checked = true;
            this.rdb_ligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.rdb_ligado.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_ligado.Location = new System.Drawing.Point(373, 207);
            this.rdb_ligado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_ligado.Name = "rdb_ligado";
            this.rdb_ligado.Size = new System.Drawing.Size(74, 31);
            this.rdb_ligado.TabIndex = 15;
            this.rdb_ligado.TabStop = true;
            this.rdb_ligado.Text = "Ligar";
            this.rdb_ligado.UseCompatibleTextRendering = true;
            this.rdb_ligado.UseVisualStyleBackColor = false;
            this.rdb_ligado.CheckedChanged += new System.EventHandler(this.rdb_ligado_CheckedChanged);
            // 
            // rdb_desligado
            // 
            this.rdb_desligado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rdb_desligado.AutoSize = true;
            this.rdb_desligado.BackColor = System.Drawing.Color.Transparent;
            this.rdb_desligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.rdb_desligado.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_desligado.Location = new System.Drawing.Point(481, 210);
            this.rdb_desligado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_desligado.Name = "rdb_desligado";
            this.rdb_desligado.Size = new System.Drawing.Size(110, 30);
            this.rdb_desligado.TabIndex = 18;
            this.rdb_desligado.Text = "Desligar";
            this.rdb_desligado.UseVisualStyleBackColor = false;
            this.rdb_desligado.CheckedChanged += new System.EventHandler(this.rdb_desligado_CheckedChanged);
            // 
            // lbl_brilho
            // 
            this.lbl_brilho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_brilho.AutoSize = true;
            this.lbl_brilho.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_brilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brilho.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_brilho.Location = new System.Drawing.Point(237, 415);
            this.lbl_brilho.Name = "lbl_brilho";
            this.lbl_brilho.Size = new System.Drawing.Size(67, 25);
            this.lbl_brilho.TabIndex = 21;
            this.lbl_brilho.Text = "Brilho";
            // 
            // lbl_altocontraste
            // 
            this.lbl_altocontraste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_altocontraste.AutoSize = true;
            this.lbl_altocontraste.BackColor = System.Drawing.Color.Transparent;
            this.lbl_altocontraste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_altocontraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altocontraste.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_altocontraste.Location = new System.Drawing.Point(237, 347);
            this.lbl_altocontraste.Name = "lbl_altocontraste";
            this.lbl_altocontraste.Size = new System.Drawing.Size(148, 25);
            this.lbl_altocontraste.TabIndex = 20;
            this.lbl_altocontraste.Text = "Alto Contraste";
            // 
            // lbl_daltonico
            // 
            this.lbl_daltonico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_daltonico.AutoSize = true;
            this.lbl_daltonico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_daltonico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_daltonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daltonico.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_daltonico.Location = new System.Drawing.Point(237, 278);
            this.lbl_daltonico.Name = "lbl_daltonico";
            this.lbl_daltonico.Size = new System.Drawing.Size(162, 25);
            this.lbl_daltonico.TabIndex = 19;
            this.lbl_daltonico.Text = "Modo Daltônico";
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_voltar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_voltar.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_voltar.Location = new System.Drawing.Point(755, 500);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(151, 37);
            this.Btn_voltar.TabIndex = 22;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = false;
            this.Btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // ConfigVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Pitico.Properties.Resources.Configurações1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.Btn_voltar);
            this.Controls.Add(this.lbl_brilho);
            this.Controls.Add(this.lbl_altocontraste);
            this.Controls.Add(this.lbl_daltonico);
            this.Controls.Add(this.rdb_desligado);
            this.Controls.Add(this.rdb_ligado);
            this.Controls.Add(this.lbl_legendas);
            this.Controls.Add(this.lbl_titulo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConfigVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigVideo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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