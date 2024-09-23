﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private int videoAtual = 1; // Controle do estado do vídeo
        private bool modoJogoIniciado = false; // Controle se o jogo já foi iniciado
        private int videoSequenciaFinal = 1; // Controle da nova sequência de vídeos


        public Fase2()
        {
            InitializeComponent();
        }

        private void Fase2_Load(object sender, EventArgs e)
        {

            btn_next.Visible = false;
            Block.Visible = false;
            batalha.Visible = false;
            this.KeyPreview = true;

            this.KeyDown += new KeyEventHandler(Fase2_KeyDown);

            // Reproduzir o primeiro vídeo ao carregar o form
            ReproduzirVideo("fase2intro1");

            // Adicionar o evento para detectar o fim do vídeo
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(AxWindowsMediaPlayer1_PlayStateChange);

            // Adicionar evento para a tecla Enter
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

                vida++;
                if (vida > vidaMaxima) vida = vidaMaxima; 
            }
            else if (botao == btn_denunciar)
            {

                vidaCshar--;
                if (vidaCshar < 0) vidaCshar = 0; 
                MessageBox.Show("Você denunciou! O adversário perdeu um coração.");
            }
            else if (botao == btn_block)
            {
        
                vidaCshar--;
                vida--;
                if (vida < 0) vida = 0;
                if (vidaCshar < 0) vidaCshar = 0;
            }
            else if (botao == btn_xingar || botao == btn_ignorar)
            {

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

            labelVida.Text = $"Vida: {vida}";
        }

        private void AtualizarCoracoesAdversario()
        {
         
            VidaCshar1.Visible = vidaCshar >= 1;
            VidaCshar2.Visible = vidaCshar >= 2;
            VidaCshar3.Visible = vidaCshar >= 3;
            VidaCshar4.Visible = vidaCshar >= 4;
            VidaCshar5.Visible = vidaCshar >= 5;

            labelVidaCshar.Text = $"Vida Adversário: {vidaCshar}";
        }

        private void VerificarGameOver()
        {
            if (vida <= 0)
            {
                MessageBox.Show("Game Over! Pitico perdeu.");
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

            }
            else if (vidaCshar <= 0)
            {
                MessageBox.Show("Game Over! O adversário perdeu.");
                IniciarSequenciaFinal();
            }
       
    }

        private void IniciarSequenciaFinal()
        {
            // Zerar o vídeo atual para garantir a reprodução correta
            videoSequenciaFinal = 1;

            // Garantir que os elementos de jogo estejam invisíveis
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

            // Exibir o botão de "Próximo" para o controle da sequência de vídeos
            btn_next.Visible = true;

            // Começar a sequência final de vídeos
            ReproduzirVideo("fase2final1");
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_block_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Toma essa! Aquela baranga finalmente foi bloqueada" +
                ", \n fazendo com que Pitico pudesse ter pelo menos um pequeno descanso e paz. Cshar -1 coração ";
            prosseguir1.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;    

        }

        private void prosseguir1_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cria fake news sobre pitico, dizendo que ele não toma banho! -1 coração do pitico. ";
            btn_cont.Visible = true;
            prosseguir1.Visible = false;
        }

        private void btn_xingar_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Reação: Cshar -1 Coração. Ele espalha por todo lugar que o pitico o atacou primeiro, dando um ataque de -1 coração" +
                "\n do pitico ";
            prosseguir2.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir2_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Por mais satisfatório que isso possa parecer," +
                " \n ainda é crime! Pitico deve levar suas questões contra seus inimigos para o Tribunal e não usando agressão.  ";
            btn_cont.Visible = true;
            prosseguir2.Visible = false;
        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Pitico pede ajuda da multidão à sua volta, e os cidadãos lhe dão motivação! +1 coração.";
            prosseguir3.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir3_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cshar fica irritado e começa a juntar bots para ficar mais forte.";
            btn_cont.Visible = true;
            prosseguir3.Visible = false;
        }

        private void btn_ignorar_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Pitico resolveu não bloquear seu assediador, seus dias se passaram de forma extremamente estressante," +
                " \n até chegar ao ponto de simplesmente não sentir mais vontade ou felicidade compartilhando as coisas que gosta," +
                " \n sequer se comunicando com pessoas ao seu redor, ficando apenas cabisbaixo em seu quarto. Tão deprimente. .";
            prosseguir4.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir4_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cshar continua xingando pitico, mandando mensagens de como ele é feio!-1 coração para pitico";
            btn_cont.Visible = true;
            prosseguir4.Visible = false;
        }

        private void btn_denunciar_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Pitico resolve denunciar o perfil do seu hater, diminuindo o alcance de seu perfil.";
            prosseguir5.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir5_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cshar -1 coração. Ele gasta esse turno criando uma conta nova!";
            btn_cont.Visible = true;
            prosseguir5.Visible = false;
        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "O que o pitico fará? ";
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

            // Atualiza a interface gráfica para refletir a nova vida
            AtualizarCoracoes();
            AtualizarCoracoesAdversario();

            game_over.Visible = false;
            btn_recomeçar.Visible = false;
            btn_continuarfase.Visible = false;
            cshar_1.Visible = true;
            pitico_1.Visible = true;
            textBox1.Visible = true;
            lbl_pergunta.Visible = true;
            lbl_pergunta.Text = "O que o pitico fará?";
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
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                // Exibe o botão "Próximo" quando o vídeo termina, tanto na sequência normal quanto na final
                if (vidaCshar > 0 && videoAtual <= 8 && !modoJogoIniciado)
                {
                    btn_next.Visible = true; // Sequência normal de vídeos
                }
                else if (videoSequenciaFinal <= 5 && modoJogoIniciado)
                {
                    btn_next.Visible = true; // Sequência final de vídeos
                }
            }
        }




        private void btn_next_Click(object sender, EventArgs e)
        {
            btn_next.Visible = false; // O botão desaparece ao ser clicado

            // Verificar qual sequência de vídeos está sendo exibida
            if (vidaCshar > 0)
            {
                // Sequência normal de vídeos
                switch (videoAtual)
                {
                    case 1:
                        ReproduzirVideo("fase2intro2");
                        videoAtual++;
                        break;
                    case 2:
                        ReproduzirVideo("fase2intro3");
                        videoAtual++;
                        break;
                    case 3:
                        ReproduzirVideo("fase2intro4");
                        videoAtual++;
                        break;
                    case 4:
                        Block.Visible = true;
                        MostrarBotoesParaProssseguir();
                        videoAtual++;
                        break;
                    case 5:
                        Block.Visible = false;
                        ReproduzirVideo("fase2intro5");
                        videoAtual++;
                        break;
                    case 6:
                        ReproduzirVideo("fase2intro6");
                        videoAtual++;
                        break;
                    case 7:
                        batalha.Visible = true;
                        MostrarBotoesParaProssseguir();
                        videoAtual++;
                        break;
                    case 8:
                        IniciarJogo();
                        break;
                }
            }
            else
            {
                // Sequência final de vídeos após derrotar o Cshar
                switch (videoSequenciaFinal)
                {
                    case 1:
                        ReproduzirVideo("fase2final2");
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
                        // Final da sequência
                        MessageBox.Show("Parabéns! Você venceu o jogo!");
                        break;
                }
            }
        }
        //teste



        private void ReproduzirVideo(string videoNome)
        {
            // Tenta obter os bytes do vídeo dos recursos
            byte[] videoBytes = (byte[])Properties.Resources.ResourceManager.GetObject(videoNome);

            if (videoBytes != null)
            {
                // Ocultar o botão no início do vídeo
                btn_next.Visible = false;

                // Define o caminho temporário
                string videoTempPath = Path.Combine(Path.GetTempPath(), videoNome + ".mp4");

                // Verifica se o arquivo já existe e o exclui
                if (File.Exists(videoTempPath))
                {
                    File.Delete(videoTempPath);
                }

                // Escreve o arquivo de vídeo
                File.WriteAllBytes(videoTempPath, videoBytes);

                // Reproduz o vídeo no Windows Media Player
                axWindowsMediaPlayer1.URL = videoTempPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }





        private void IniciarJogo()
        {
            // Torna todos os elementos invisíveis e começa o jogo
            axWindowsMediaPlayer1.Visible = false;
            btn_next.Visible = false;
            Block.Visible = false;
            batalha.Visible = false;

            // Reproduz o vídeo da batalha, se necessário
            if (vidaCshar > 0)
            {
                ReproduzirVideo("fase2batalha"); // Substitua pelo nome do vídeo que deve ser reproduzido
            }

            modoJogoIniciado = true;
        }


        private void Fase2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && videoAtual == 8) // Verifica se está na última fase
            {
                IniciarJogo();
            }
        }

        private void MostrarBotoesParaProssseguir()
        {
            // Mostra os botões necessários após a exibição da picture box
            btn_ajuda.Visible = true;
            btn_block.Visible = true;
            btn_denunciar.Visible = true;
            btn_xingar.Visible = true;
            btn_ignorar.Visible = true;

            // Adiciona a visibilidade do btn_next caso ele precise ser exibido novamente
            btn_next.Visible = true;
        }

        private void batalha_Click(object sender, EventArgs e)
        {


        }
    }

}


