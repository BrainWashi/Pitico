﻿using AxWMPLib;
using Pjt_Pitico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitico
{
    public partial class Fase2 : Form
    {
        private int vida = 5;
        private const int vidaMaxima = 5;
        private int vidaCshar = 5;
        private double aspectRatio = 16.0 / 9.0;
        private int videoAtualDub = 1;
        private int videoAtual = 1;
        private bool modoJogoIniciado = false;
        private int videoSequenciaFinal = 1;
        private int videoSequenciaFinalDub = 1;
        private TextBox textBoxOverlay;

        public Fase2()
        {
            InitializeComponent();

            btn_xingar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_denunciar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ajuda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ignorar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_block.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            this.Resize += new EventHandler(Form1_Resize);
            AjustarControles();

            textBoxOverlay = new TextBox();
            textBoxOverlay.Multiline = true;
            textBoxOverlay.Dock = DockStyle.Bottom;
            textBoxOverlay.Height = 50;
            textBoxOverlay.BackColor = Color.Black;
            textBoxOverlay.ForeColor = Color.White;
            textBoxOverlay.BorderStyle = BorderStyle.None;
            textBoxOverlay.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(textBoxOverlay);
            textBoxOverlay.BringToFront();
        }


        private void AjustarControles()
        {

            int margemLateral = 10;
            textBox1.Width = this.ClientSize.Width - 2 * margemLateral;
            textBox1.Height = 100;
            textBox1.Location = new Point(margemLateral, this.ClientSize.Height - textBox1.Height - 10);

            lbl_pergunta.AutoSize = true;
            lbl_pergunta.Location = new Point(textBox1.Left, textBox1.Top - lbl_pergunta.Height - 5);

            int buttonWidth = 180;
            int buttonHeight = 90;
            int margemEntreBotoes = 10;


            int posicaoYBotoes = textBox1.Bottom - buttonHeight;
            int posicaoXBotoes = textBox1.Right - (buttonWidth * 5 + margemEntreBotoes * 4);


            btn_ajuda.Size = new Size(buttonWidth, buttonHeight);
            btn_ajuda.Location = new Point(posicaoXBotoes, posicaoYBotoes);


            btn_denunciar.Size = new Size(buttonWidth, buttonHeight);
            btn_denunciar.Location = new Point(posicaoXBotoes + buttonWidth + margemEntreBotoes, posicaoYBotoes);


            btn_ignorar.Size = new Size(buttonWidth, buttonHeight);
            btn_ignorar.Location = new Point(posicaoXBotoes + 2 * (buttonWidth + margemEntreBotoes), posicaoYBotoes);


            btn_block.Size = new Size(buttonWidth, buttonHeight);
            btn_block.Location = new Point(posicaoXBotoes + 3 * (buttonWidth + margemEntreBotoes), posicaoYBotoes);


            btn_xingar.Size = new Size(buttonWidth, buttonHeight);
            btn_xingar.Location = new Point(posicaoXBotoes + 4 * (buttonWidth + margemEntreBotoes), posicaoYBotoes);
        }

        private void CenterButton()
        {
            lbl_pressione.Left = (this.ClientSize.Width - lbl_pressione.Width) / 2;
            lbl_pressione.Top = (this.ClientSize.Height - lbl_pressione.Height) / 2;
        }

        private void Fase2_Load(object sender, EventArgs e)
        {
            AjustarControles();
            Form1_Resize(this, EventArgs.Empty);
            CenterButton();
            btn_next.Visible = false;
            Block.Visible = false;
            batalha.Visible = false;
            cosenjo_1.Visible = false;
            cosenjo_2.Visible = false;
            info_cosenjo.Visible = false;
            this.KeyPreview = true;

            this.KeyPreview = true; // Permite que o formulário receba eventos de tecla
            this.KeyDown += new KeyEventHandler(Faase2_KeyDown);
            this.KeyDown += new KeyEventHandler(Fase2_KeyDown);

            if (Config.Dub == true)
            {
                ReproduzirVideo("fase2intro1Dub");
            }

            else
            {
                ReproduzirVideo("fase2intro1");
            }

            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "O QUE O PITICO FARÁ?";
                lbl_pressione.Text = "PRESSIONE ENTER PARA CONTINUAR";
                btn_ajuda.Text = "Pedir Ajuda";
                btn_block.Text = "Bloquear";
                btn_denunciar.Text = "Denunciar";
                btn_ignorar.Text = "Ignorar";
                btn_xingar.Text = "Xingar";
                btn_recomeçar.Text = "RECOMEÇAR";
                label1.Text = "FASE 2";
                btn_cont.Text = "continuar";
                btn_continuarfase.Text = "Continuar";
            }
            else
            {
                lbl_pergunta.Text = "WHAT PITICO WILL DO";
                lbl_pressione.Text = "PRESS ENTER TO CONTINUE";
                btn_ajuda.Text = "Ask for help";
                btn_block.Text = "Block";
                btn_denunciar.Text = "Report";
                btn_ignorar.Text = "Ignore";
                btn_xingar.Text = "To curse";
                btn_recomeçar.Text = "RESTART";
                label1.Text = "PHASE 2";
                btn_cont.Text = "continue";
                btn_continuarfase.Text = "Continue";
            }
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(AxWindowsMediaPlayer1_PlayStateChange);


            this.KeyDown += new KeyEventHandler(Fase2_KeyDown);

            btn_ajuda.Click += SelecionarOpcao;
            btn_block.Click += SelecionarOpcao;
            btn_denunciar.Click += SelecionarOpcao;
            btn_xingar.Click += SelecionarOpcao;
            btn_ignorar.Click += SelecionarOpcao;

            AtualizarCoracoes();
            AtualizarCoracoesAdversario();
        }

        private void SelecionarOpcao(object sender, EventArgs e)
        {
            Button botao = sender as Button;



            if (botao == btn_ajuda)
            {
                VidaCshar1.BringToFront();
                VidaCshar2.BringToFront();
                VidaCshar3.BringToFront();
                VidaCshar4.BringToFront();
                VidaCshar5.BringToFront();
                VidaPitico1.BringToFront();
                VidaPitico2.BringToFront();
                VidaPitico3.BringToFront();
                VidaPitico4.BringToFront();
                VidaPitico5.BringToFront();
                label1.BringToFront();
                vida++;
                if (vida > vidaMaxima) vida = vidaMaxima;
            }
            else if (botao == btn_denunciar)
            {
                pitico_1.Visible = false;
                pitico_2.Visible = false;
                pitico_3.Visible = true;
                VidaCshar1.BringToFront();
                VidaCshar2.BringToFront();
                VidaCshar3.BringToFront();
                VidaCshar4.BringToFront();
                VidaCshar5.BringToFront();
                VidaPitico1.BringToFront();
                VidaPitico2.BringToFront();
                VidaPitico3.BringToFront();
                VidaPitico4.BringToFront();
                VidaPitico5.BringToFront();
                label1.BringToFront();
                //pitico_3.BringToFront();
                cshar_1.Visible = false;
                cshar_2.Visible = true;
                cshar_3.Visible = false;
                //cshar_2.BringToFront();
                vidaCshar--;
                if (vidaCshar < 0) vidaCshar = 0;
            }
            else if (botao == btn_block)
            {
                cshar_1.Visible = false;
                cshar_2.Visible = true;
                cshar_3.Visible = false;
                //cshar_2.BringToFront();
                pitico_1.Visible = false;
                pitico_2.Visible = true;
                pitico_3.Visible = false;
                //pitico_2.BringToFront();
                VidaCshar1.BringToFront();
                VidaCshar2.BringToFront();
                VidaCshar3.BringToFront();
                VidaCshar4.BringToFront();
                VidaCshar5.BringToFront();
                VidaPitico1.BringToFront();
                VidaPitico2.BringToFront();
                VidaPitico3.BringToFront();
                VidaPitico4.BringToFront();
                VidaPitico5.BringToFront();
                label1.BringToFront();
                vidaCshar--;
                vida--;
                if (vida < 0) vida = 0;
                if (vidaCshar < 0) vidaCshar = 0;
            }
            else if (botao == btn_xingar || botao == btn_ignorar)
            {
                cshar_1.Visible = false;
                cshar_2.Visible = false;
                cshar_3.Visible = true;
                //cshar_3.BringToFront();
                pitico_1.Visible = false;
                pitico_2.Visible = true;
                pitico_3.Visible = false;
                // pitico_2.BringToFront();
                VidaCshar1.BringToFront();
                VidaCshar2.BringToFront();
                VidaCshar3.BringToFront();
                VidaCshar4.BringToFront();
                VidaCshar5.BringToFront();
                VidaPitico1.BringToFront();
                VidaPitico2.BringToFront();
                VidaPitico3.BringToFront();
                VidaPitico4.BringToFront();
                VidaPitico5.BringToFront();
                label1.BringToFront();
                vida--;
                if (vida < 0) vida = 0;
            }


            AtualizarCoracoes();
            AtualizarCoracoesAdversario();
            VerificarGameOver();
        }

        private void AtualizarCoracoes()
        {

            VidaPitico1.Visible = vida >= 1;
            VidaPitico2.Visible = vida >= 2;
            VidaPitico3.Visible = vida >= 3;
            VidaPitico4.Visible = vida >= 4;
            VidaPitico5.Visible = vida >= 5;

        }

        private void AtualizarCoracoesAdversario()
        {

            VidaCshar1.Visible = vidaCshar >= 1;
            VidaCshar2.Visible = vidaCshar >= 2;
            VidaCshar3.Visible = vidaCshar >= 3;
            VidaCshar4.Visible = vidaCshar >= 4;
            VidaCshar5.Visible = vidaCshar >= 5;

        }

        private void VerificarGameOver()
        {
            if (vida <= 0)
            {
                if (Config.Ling == true)
                {
                    MessageBox.Show("Game Over! Pitico perdeu.");
                }
                else
                {
                    MessageBox.Show("Game Over! Pitico lost.");
                }
                btn_recomeçar.Visible = true;
                btn_continuarfase.Visible = true;
                game_over.Visible = true;
                cshar_1.Visible = false;
                pitico_1.Visible = false;
                textBox1.Visible = false;
                lbl_pergunta.Visible = false;
                VidaPitico1.Visible = false;
                VidaPitico2.Visible = false;
                VidaPitico3.Visible = false;
                VidaPitico4.Visible = false;
                VidaPitico5.Visible = false;
                VidaCshar1.Visible = false;
                VidaCshar2.Visible = false;
                VidaCshar3.Visible = false;
                VidaCshar4.Visible = false;
                VidaCshar5.Visible = false;
                btn_ajuda.Visible = false;
                btn_block.Visible = false;
                btn_denunciar.Visible = false;
                btn_xingar.Visible = false;
                btn_ignorar.Visible = false;
                prosseguir1.Visible = false;
                prosseguir2.Visible = false;
                prosseguir3.Visible = false;
                prosseguir4.Visible = false;
                prosseguir5.Visible = false;
                btn_cont.Visible = false;
                pictureBox1.Visible = false;
                pitico_1.Visible = false;
                pitico_2.Visible = false;
                pitico_3.Visible = false;
                cshar_1.Visible = false;
                cshar_2.Visible = false;
                cshar_3.Visible = false;

            }
            else if (vidaCshar <= 0)
            {
                if (Config.Ling == true)
                {
                    MessageBox.Show("Game Over! O adversário perdeu");
                }
                else
                {
                    MessageBox.Show("Game Over! The Opponente lost.");
                }
                pitico_1.Visible = false;
                pitico_2.Visible = false;
                pitico_3.Visible = false;
                cshar_1.Visible = false;
                cshar_2.Visible = false;
                cshar_3.Visible = false;
                IniciarSequenciaFinal();
            }

        }

        private void IniciarSequenciaFinal()
        {

            videoSequenciaFinal = 1;

            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
            batalha.Visible = false;
            game_over.Visible = false;
            btn_recomeçar.Visible = false;
            btn_continuarfase.Visible = false;
            cshar_1.Visible = false;
            pitico_1.Visible = false;
            textBox1.Visible = false;
            lbl_pergunta.Visible = false;
            lbl_pergunta.Text = "";
            VidaPitico1.Visible = false;
            VidaPitico2.Visible = false;
            VidaPitico3.Visible = false;
            VidaPitico4.Visible = false;
            VidaPitico5.Visible = false;
            VidaCshar1.Visible = false;
            VidaCshar2.Visible = false;
            VidaCshar3.Visible = false;
            VidaCshar4.Visible = false;
            VidaCshar5.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            axWindowsMediaPlayer1.Visible = true;


            btn_next.Visible = false;

            if (Config.Dub == true)
            {
                ReproduzirVideo("fase2final1Dub");
            }
            else
            {
                ReproduzirVideo("fase2final1");
            }
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }



        private void btn_block_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Toma essa! Aquela baranga finalmente foi bloqueada" +
                ", \n fazendo com que Pitico pudesse ter pelo menos um pequeno descanso e paz. Cshar -1 coração ";

            }
            else
            {
                lbl_pergunta.Text = "Take this! That shit was finally blocked" +
                    ", \n allowing Pitico to have at least a little rest and peace. Cshar -1 heart";
            }
            prosseguir1.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir1_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Cshar Cria fake news sobre pitico, dizendo que ele não toma banho! -1 coração do pitico. ";
            }
            else
            {
                lbl_pergunta.Text = "Cshar creates fake news about Pitico, saying that he doesn't take a shower! -1 pitico heart.";
            }
            btn_cont.Visible = true;
            prosseguir1.Visible = false;
            pitico_3.Visible = false;
            pitico_2.Visible = false;
            pitico_1.Visible = true;
            cshar_3.Visible = false;
            cshar_2.Visible = false;
            cshar_1.Visible = true;
        }

        private void btn_xingar_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Chsar espalha por todo lugar que o pitico o atacou primeiro... -1 coração pitico e cshar";
            }
            else
            {
                lbl_pergunta.Text = "Chsar spreads everywhere that the pitico attacked him first... -1 pitico heart and cshar";
            }
            prosseguir2.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir2_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Por mais satisfatório que isso possa parecer," +
                " \n ainda é crime! Pitico deve levar suas questões contra seus inimigos para o Tribunal e não usando agressão.";
            }
            else
            {
                lbl_pergunta.Text = "As satisfying as this may seem," +
                    "\n It's still a crime! Pitico must take his issues against his enemies to court and not using aggression.";
            }
            btn_cont.Visible = true;
            prosseguir2.Visible = false;
            pitico_3.Visible = false;
            pitico_2.Visible = false;
            pitico_1.Visible = true;
            cshar_3.Visible = false;
            cshar_2.Visible = false;
            cshar_1.Visible = true;
        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Pitico pede ajuda da multidão à sua volta, e os cidadãos lhe dão motivação! +1 coração.";
            }
            else
            {
                lbl_pergunta.Text = "Pitico asks for help from the crowd around him, and the citizens give him motivation! + 1 heart.";
            }
            prosseguir3.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir3_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Cshar fica irritado e começa a juntar bots para ficar mais forte.";
            }
            else
            {
                lbl_pergunta.Text = "Cshar gets angry and starts gathering bots to get stronger";
            }
            btn_cont.Visible = true;
            prosseguir3.Visible = false;
            pitico_3.Visible = false;
            pitico_2.Visible = false;
            pitico_1.Visible = true;
            cshar_3.Visible = false;
            cshar_2.Visible = false;
            cshar_1.Visible = true;
        }

        private void btn_ignorar_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Pitico resolveu não bloquear seu assediador, seus dias se passaram de forma extremamente estressante," +
                " \n até chegar ao ponto de simplesmente não sentir mais vontade ou felicidade compartilhando as coisas que gosta," +
                " \n sequer se comunicando com pessoas ao seu redor, ficando apenas cabisbaixo em seu quarto. Tão deprimente. .";
            }
            else
            {
                lbl_pergunta.Text = "Pitico decided not to block his harasser, his days passed in an extremely stressful way," +
                    "\n until you get to the point where you simply no longer feel like sharing the things you like," +
                    "\n not even communicating with people around him, just staying with his head down in his room. So depressing...";
            }
            prosseguir4.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
            pitico_2.Visible = false;
            cshar_3.Visible = false;
        }

        private void prosseguir4_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Cshar continua xingando pitico, mandando mensagens de como ele é feio!-1 coração para pitico";
            }
            else
            {
                lbl_pergunta.Text = "Cshar keeps cursing Pitico, sending messages about how ugly he is !-1 heart for Pitico";
            }
            btn_cont.Visible = true;
            prosseguir4.Visible = false;
            pitico_3.Visible = false;
            pitico_2.Visible = false;
            pitico_1.Visible = true;
            cshar_3.Visible = false;
            cshar_2.Visible = false;
            cshar_1.Visible = true;
        }

        private void btn_denunciar_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Pitico resolve denunciar o perfil do seu hater, diminuindo o alcance de seu perfil.";
            }
            else
            {
                lbl_pergunta.Text = "Pitico decides to report his hater's profile, reducing the reach of his profile.";
            }
            prosseguir5.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir5_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "Ele gasta esse turno criando uma conta nova! -1 coração cshar";
            }
            else
            {
                lbl_pergunta.Text = "He spends this turn creating a new account! -1 cshar heart";
            }
            btn_cont.Visible = true;
            prosseguir5.Visible = false;
            pitico_3.Visible = false;
            pitico_2.Visible = false;
            pitico_1.Visible = true;
            cshar_3.Visible = false;
            cshar_2.Visible = false;
            cshar_1.Visible = true;

        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "O que o pitico fará? ";
            }
            else
            {
                lbl_pergunta.Text = "What will the pitico do?";
            }
            btn_cont.Visible = false;
            btn_ajuda.Visible = true;
            btn_block.Visible = true;
            btn_denunciar.Visible = true;
            btn_xingar.Visible = true;
            btn_ignorar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vida = 5;
            vidaCshar = 5;


            AtualizarCoracoes();
            AtualizarCoracoesAdversario();

            game_over.Visible = false;
            textBoxOverlay.Visible = false;
            btn_recomeçar.Visible = false;
            btn_continuarfase.Visible = false;
            cshar_1.Visible = true;
            pitico_1.Visible = true;
            textBox1.Visible = true;
            lbl_pergunta.Visible = true;
            if (Config.Ling == true)
            {
                lbl_pergunta.Text = "O que o pitico fará?";
            }
            else
            {
                lbl_pergunta.Text = "What will the pitico do?";
            }
            VidaPitico1.Visible = true;
            VidaPitico2.Visible = true;
            VidaPitico3.Visible = true;
            VidaPitico4.Visible = true;
            VidaPitico5.Visible = true;
            VidaCshar1.Visible = true;
            VidaCshar2.Visible = true;
            VidaCshar3.Visible = true;
            VidaCshar4.Visible = true;
            VidaCshar5.Visible = true;
            btn_ajuda.Visible = true;
            btn_block.Visible = true;
            btn_denunciar.Visible = true;
            btn_xingar.Visible = true;
            btn_ignorar.Visible = true;
            pictureBox1.Visible = true;
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbl_pressione.Visible = false;
            }
            else if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                if (vidaCshar > 0 && videoAtual <= 8 && !modoJogoIniciado)
                {
                    lbl_pressione.Visible = true;
                    btn_next.Visible = false;
                }
                else if (videoSequenciaFinal <= 5 && modoJogoIniciado)
                {
                    lbl_pressione.Visible = true;
                    btn_next.Visible = false;
                }
            }
        }




        private void AdvanceVideo()
        {
            btn_next.Visible = false;

            if (vidaCshar > 0)
            {
                if (Config.Dub == true)
                {
                    switch (videoAtualDub)
                    {
                        case 1:
                            ReproduzirVideo("fase2intro2Dub");
                            videoAtualDub++;
                            break;
                        case 2:
                            MostrarBotoesParaProssseguir();
                            videoAtualDub++;
                            break;
                        case 3:
                            Block.Visible = false;
                            ReproduzirVideo("fase2intro3Dub");
                            videoAtualDub++;
                            break;
                        case 4:
                            ReproduzirVideo("fase2intro4Dub");
                            videoAtualDub++;
                            break;
                        case 5:
                            ReproduzirVideo("fase2intro5Dub");
                            videoAtualDub++;
                            break;
                        case 6:
                            batalha.Visible = true;
                            MostrarBotoesParaProssseguir();
                            videoAtualDub++;
                            break;
                        case 7:
                            textBoxOverlay.Visible = false;
                            IniciarJogo();
                            break;
                    }
                }
                else
                {
                    switch (videoAtual)
                    {
                        case 1:
                            ReproduzirVideo("fase2intro2");
                            videoAtual++;
                            break;
                        case 2:
                            lbl_pressione.Visible = false;
                            MostrarBotoesParaProssseguir();
                            videoAtual++;
                            break;
                        case 3:
                            Block.Visible = false;
                            ReproduzirVideo("fase2intro3");
                            videoAtual++;
                            break;
                        case 4:
                            ReproduzirVideo("fase2intro4");
                            videoAtual++;
                            break;
                        case 5:
                            ReproduzirVideo("fase2intro5");
                            videoAtual++;
                            break;
                        case 6:
                            batalha.Visible = true;
                            MostrarBotoesParaProssseguir();
                            videoAtual++;
                            break;
                        case 7:
                            textBoxOverlay.Visible = false;
                            IniciarJogo();
                            break;
                    }
                }
            }
            else
            {
                if (Config.Dub == true)
                {
                    switch (videoSequenciaFinalDub)
                    {
                        case 1:
                            ReproduzirVideo("fase2final2Dub");
                            textBoxOverlay.Visible = true;
                            videoSequenciaFinalDub++;
                            break;
                        case 2:
                            ReproduzirVideo("fase2final3Dub");
                            videoSequenciaFinalDub++;
                            break;
                        case 3:
                            ReproduzirVideo("fase2final4Dub");
                            videoSequenciaFinalDub++;
                            break;
                        case 4:
                            ReproduzirVideo("fase2final5Dub");
                            videoSequenciaFinalDub++;
                            break;
                        case 5:
                            cosenjo_1.Visible = true;
                            info_cosenjo.Visible = true;
                            videoSequenciaFinalDub++;
                            break;
                        case 6:
                            cosenjo_1.Visible = false;
                            info_cosenjo.Visible = false;
                            cosenjo_2.Visible = true;
                            videoSequenciaFinalDub++;
                            break;
                        case 7:
                            cosenjo_2.Visible = false;
                            Form proximoFormulario = new Fase3();
                            proximoFormulario.Show();
                            break;
                    }
                }
                else
                {
                    switch (videoSequenciaFinal)
                    {
                        case 1:
                            ReproduzirVideo("fase2final2");
                            textBoxOverlay.Visible = true;
                            videoSequenciaFinal++;
                            break;
                        case 2:
                            ReproduzirVideo("fase2final3");
                            videoSequenciaFinal++;
                            break;
                        case 3:
                            ReproduzirVideo("fase2final4");
                            videoSequenciaFinal++;
                            break;
                        case 4:
                            ReproduzirVideo("fase2final5");
                            videoSequenciaFinal++;
                            break;
                        case 5:
                            cosenjo_1.Visible = true;
                            info_cosenjo.Visible = true;
                            videoSequenciaFinal++;
                            break;
                        case 6:
                            cosenjo_1.Visible = false;
                            info_cosenjo.Visible = false;
                            cosenjo_2.Visible = true;
                            videoSequenciaFinal++;
                            break;
                        case 7:
                            cosenjo_2.Visible = false;
                            Form proximoFormulario = new Fase3();
                            proximoFormulario.Show();
                            break;
                    }
                }
            }
        }



        private void ReproduzirVideo(string videoNome)
        {

            byte[] videoBytes = (byte[])Properties.Resources.ResourceManager.GetObject(videoNome);

            if (videoBytes != null)
            {
                lbl_pressione.Visible = false;
                btn_next.Visible = false;


                string videoTempPath = Path.Combine(Path.GetTempPath(), videoNome + ".mp4");


                if (File.Exists(videoTempPath))
                {
                    File.Delete(videoTempPath);
                }


                File.WriteAllBytes(videoTempPath, videoBytes);


                axWindowsMediaPlayer1.URL = videoTempPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            int largura = this.ClientSize.Width;
            int altura = (largura * 9) / 16;
            this.ClientSize = new Size(largura, altura);


            pictureBox1.Width = this.ClientSize.Width;
            pictureBox1.Height = this.ClientSize.Height;

            game_over.Width = this.ClientSize.Width;
            game_over.Height = this.ClientSize.Height;
            Block.Width = this.ClientSize.Width;
            Block.Height = this.ClientSize.Height;
            batalha.Width = this.ClientSize.Width;
            batalha.Height = this.ClientSize.Height;
            cosenjo_1.Width = this.ClientSize.Width;
            cosenjo_1.Height = this.ClientSize.Height;
            cosenjo_2.Width = this.ClientSize.Width;
            cosenjo_2.Height = this.ClientSize.Height;


            cshar_1.SizeMode = PictureBoxSizeMode.StretchImage;
            cshar_2.SizeMode = PictureBoxSizeMode.StretchImage;
            cshar_3.SizeMode = PictureBoxSizeMode.StretchImage;
            pitico_1.SizeMode = PictureBoxSizeMode.StretchImage;
            pitico_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pitico_3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            game_over.SizeMode = PictureBoxSizeMode.StretchImage;
            Block.SizeMode = PictureBoxSizeMode.StretchImage;
            batalha.SizeMode = PictureBoxSizeMode.StretchImage;
            cosenjo_1.SizeMode = PictureBoxSizeMode.StretchImage;
            cosenjo_2.SizeMode = PictureBoxSizeMode.StretchImage;

            if (this.WindowState == FormWindowState.Maximized)
            {

                SetFullScreenVideo();
            }
            else
            {

                AdjustVideoSize();
            }
        }

        private void SetFullScreenVideo()
        {

            int newWidth = this.ClientSize.Width;
            int newHeight = (int)(newWidth / aspectRatio);

            if (newHeight > this.ClientSize.Height)
            {

                newHeight = this.ClientSize.Height;
                newWidth = (int)(newHeight * aspectRatio);
            }


            axWindowsMediaPlayer1.Width = newWidth;
            axWindowsMediaPlayer1.Height = newHeight;


            axWindowsMediaPlayer1.Location = new Point((this.ClientSize.Width - newWidth) / 2, (this.ClientSize.Height - newHeight) / 2);
        }

        private void AdjustVideoSize()
        {

            axWindowsMediaPlayer1.Width = this.ClientSize.Width;
            axWindowsMediaPlayer1.Height = this.ClientSize.Height;

        }

        private void IniciarJogo()
        {

            axWindowsMediaPlayer1.Visible = false;
            btn_next.Visible = false;
            Block.Visible = false;
            batalha.Visible = false;
            lbl_pressione.Visible = false;


            if (vidaCshar > 0)
            {
                ReproduzirVideo("fase2batalha");
            }

            modoJogoIniciado = true;
        }


        private void Fase2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && videoAtual == 8)
            {
                IniciarJogo();
            }
        }

        private void MostrarBotoesParaProssseguir()
        {
            btn_ajuda.Visible = true;
            btn_block.Visible = true;
            btn_denunciar.Visible = true;
            btn_xingar.Visible = true;
            btn_ignorar.Visible = true;
            btn_next.Visible = false;
        }

        private void batalha_Click(object sender, EventArgs e)
        {


        }

        private void Faase2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdvanceVideo();
                e.Handled = true; // Impede o tratamento padrão da tecla
            }
        }

        private void info_cosenjo_Click(object sender, EventArgs e)
        {

        }
    }

}
