namespace Pitico
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_título = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_opções = new System.Windows.Forms.Button();
            this.btn_créditos = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_título
            // 
            this.lbl_título.AutoSize = true;
            this.lbl_título.BackColor = System.Drawing.Color.Transparent;
            this.lbl_título.Font = new System.Drawing.Font("MS PGothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_título.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_título.Location = new System.Drawing.Point(233, 53);
            this.lbl_título.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_título.Name = "lbl_título";
            this.lbl_título.Size = new System.Drawing.Size(795, 80);
            this.lbl_título.TabIndex = 0;
            this.lbl_título.Text = "Segurança Confiscada";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.LightCyan;
            this.btn_iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_iniciar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_iniciar.Location = new System.Drawing.Point(925, 277);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(201, 46);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_opções
            // 
            this.btn_opções.BackColor = System.Drawing.Color.LightCyan;
            this.btn_opções.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_opções.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opções.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_opções.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_opções.Location = new System.Drawing.Point(925, 341);
            this.btn_opções.Name = "btn_opções";
            this.btn_opções.Size = new System.Drawing.Size(201, 46);
            this.btn_opções.TabIndex = 5;
            this.btn_opções.Text = "Opções";
            this.btn_opções.UseVisualStyleBackColor = false;
            this.btn_opções.Click += new System.EventHandler(this.btn_opções_Click);
            // 
            // btn_créditos
            // 
            this.btn_créditos.BackColor = System.Drawing.Color.LightCyan;
            this.btn_créditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_créditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_créditos.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_créditos.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_créditos.Location = new System.Drawing.Point(925, 401);
            this.btn_créditos.Name = "btn_créditos";
            this.btn_créditos.Size = new System.Drawing.Size(201, 46);
            this.btn_créditos.TabIndex = 6;
            this.btn_créditos.Text = "Créditos";
            this.btn_créditos.UseVisualStyleBackColor = false;
            this.btn_créditos.Click += new System.EventHandler(this.btn_créditos_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.LightCyan;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_sair.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_sair.Location = new System.Drawing.Point(925, 465);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(201, 46);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pitico.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 773);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_créditos);
            this.Controls.Add(this.btn_opções);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.lbl_título);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_título;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_opções;
        private System.Windows.Forms.Button btn_créditos;
        private System.Windows.Forms.Button btn_sair;
    }
}

