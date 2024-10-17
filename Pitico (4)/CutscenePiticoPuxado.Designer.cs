using System;

namespace Pjt_Pitico
{
    partial class CutscenePiticoPuxado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutscenePiticoPuxado));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_legenda = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_legenda
            // 
            this.lbl_legenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_legenda.AutoSize = true;
            this.lbl_legenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legenda.Location = new System.Drawing.Point(361, 704);
            this.lbl_legenda.Name = "lbl_legenda";
            this.lbl_legenda.Size = new System.Drawing.Size(492, 25);
            this.lbl_legenda.TabIndex = 2;
            this.lbl_legenda.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.lbl_legenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(-142, -8);
            this.axWindowsMediaPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(1420, 802);
            this.axWindowsMediaPlayer2.TabIndex = 1;
            this.axWindowsMediaPlayer2.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer2_PlayStateChange);
            // 
            // CutscenePiticoPuxado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 738);
            this.Controls.Add(this.lbl_legenda);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CutscenePiticoPuxado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CutscenePiticoPuxado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CutscenePiticoPuxado_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_legenda;
    }
}