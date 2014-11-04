﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace SistemaSupervisorio
{
    /* @autor Diovani Bernardi da Motta
     * Classe responsavel por implementar a interface gráfica de contato com o usuario
     */
    public partial class FormularioPrincipal : Form
    {
        // instacio um objeto do tipo Comunicação serial 
        public ComunicaoSerial comunicacao = new ComunicaoSerial();
        public int nivelReservatorioSuperior = 0;
        public int nivelReservatorioInferior = 0;
        public String percentualSuperior = "0 %";
        public String percentualInferior = "0 %";
        public Thread thread;
        public Boolean serial = false;

        /* Construtor da classe, responsavel por inicializar os componentes visuais da classe
         */
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        /*
         *  Função invocada durante o processo de carregamento do form para o usuario
         */
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            // retorno uma lista de portas seriais configuradas no computador
            String[] retorno = comunicacao.listarPortasSeriais();
            // itero toda a lista de portas instanciadas
            foreach(String port in retorno){
                // adiciono a lista que será exibida para o usuario com as portas disponiveis na maquina
                listaPortas.Items.Add(port);
            }

            if(listaPortas.Items.Count > 0)
            {
                //seleciono a primeira porta serial encontrada
                listaPortas.SelectedIndex = 0;
            }
            // itero a lista de bits por segundo usado na conexao
            foreach(String bitSegundo in comunicacao.listaBitsSegundos)
            {    
                // adiciono ao combo
                listaBitsSegundo.Items.Add(bitSegundo);
            }

            // seleciono o primeiro item da lista
            listaBitsSegundo.SelectedIndex = 0;

            // itero a lista de bits de dados usados na transmissap
            foreach(String bitDados in comunicacao.listaBitsDados)
            {
                // adiciono ao combo
                listaBitsDados.Items.Add(bitDados);
            }
            // seleciono a primeira posicao
            listaBitsDados.SelectedIndex = 0;

            // adiciono ao combobox todas as opçoes de paridade possivel
            foreach(String paridade in comunicacao.listaParidade)
            {
                // adiciono a lista
                listaParidade.Items.Add(paridade);
            }

            // posiciono na primeira opção de paridade
            listaParidade.SelectedIndex = 0;

            //itero todas as opçoes de bit de parada
            foreach(String bitParada in comunicacao.listaBitsParada)
            {
                // adiciono ao combo
                listaBitsParada.Items.Add(bitParada);
            }

            // seleciono a primeira posicao
            listaBitsParada.SelectedIndex = 0;

            //itero toda a lista de controle de fluxo
            foreach(String controle in comunicacao.listaControleFluxo)
            {
                // adiciono ao combo
                listaControleFluxo.Items.Add(controle);
            }

            // seleciono a primeira opção do combo
            listaControleFluxo.SelectedIndex = 0;
        }

        private void btnLigado_Click(object sender, EventArgs e)
        {
            // notifica o usuario, se o mesmo realmente deseja realizar a operação
            if (MessageBox.Show("Deseja realmente se conectar com o Sistema Embarcado,\n com as configurações informadas ? ", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                 //repasso os dados selecionados para a classe responsavel por configurar a conexao serial
                comunicacao.setBitsDadosSelecionado(string.Concat(listaBitsDados.SelectedItem));
                comunicacao.setBitsParadaSelecionada(string.Concat(listaBitsParada.SelectedItem));
                comunicacao.setBitsSegundoSelecionado(string.Concat(listaBitsSegundo.SelectedItem));
                comunicacao.setControleFluxoSelecionado(string.Concat(listaControleFluxo.SelectedItem));
                comunicacao.setParidadeSelecionado(string.Concat(listaParidade.SelectedItem));
                comunicacao.setPortaSerialSelecionada(string.Concat(listaPortas.SelectedItem));

                //chamada a funcao responsavel por configurar a comunicação serial
                comunicacao.configureSerial();
                // se for possivel iniciar a comunicação serial
                serial = comunicacao.initializeSerial();
                // se o retorno for verdadeiro
                if (serial)
                {
                    //desabilito o botao conectar e habilito o botao desconectar
                    btnDesligado.Enabled = true;
                    btnLigado.Enabled = false;
                    // informo ao usuario que a conexao foi realizada
                    conexao.Text = "Conectado";
                    conexao.BackColor = Color.Green;
                    MessageBox.Show("Conexão realizada com sucesso!","Confirmação");
                    botaoMotor.Enabled = true;
                    botaoBomba.Enabled = true;
                    botaoAtivar.Enabled = true;
                    //encerro a comunicacao serial
                    comunicacao.closedSerial();             
                }
                else
                {
                    MessageBox.Show(" Não foi possivel iniciar a comunicação serial. Verifique as configurações!", "Confirmação");
                }
            }
            else
            {
                MessageBox.Show("Operação abortada pelo usuário!", "Confirmação");
            }
        }

        private void btnDesligado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente se desconectar do Sistema Embarcado ? ", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                // envio os comandos para desligar o motor
                comunicacao.sendConfigure(ComunicaoSerial.DESLIGAR_BOMBA);
                Thread.Sleep(20);
                comunicacao.sendConfigure(ComunicaoSerial.DESLIGAR_MOTOR);
                   
                 // se for possivel encerar a comunicação serial
                 serial = !comunicacao.closedSerial();
                if (!serial)
                {
                    //desabilito o botao desconectar e habilito o botao conectar
                    btnDesligado.Enabled = false;
                    btnLigado.Enabled = true;
                    conexao.Text = "Desconectado";
                    conexao.BackColor = Color.Red;
                    // encerro a execução da conexao
                    // desabilito os botoes da bomba e motor
                    botaoBomba.Enabled = false;
                    botaoMotor.Enabled = false;
                    botaoAtivar.Enabled = false;

                    botaoMotor.BackColor = Color.Red;
                    botaoBomba.BackColor = Color.Red;
                    botaoAtivar.BackColor = Color.Red;
                    botaoBomba.Text = "Desligado";
                    botaoMotor.Text = "Desligado";
                    botaoAtivar.Text = "Desligado";
                    MessageBox.Show("Comunicação Encerrada!","Confirmação");
                }
                else
                {
                    MessageBox.Show("Não foi possível finalizar a comunicação serial. Verifique!","Confirmação");
                }
            }
            else
            {
                MessageBox.Show("Operação abortada pelo usuário!","Confirmação");
            }
        }

        private void botaoBomba_Click(object sender, EventArgs e)
        {
            if(botaoBomba.BackColor == Color.Red)
            {
                botaoBomba.Text = "Ligado";
                botaoBomba.BackColor = Color.Green;
                comunicacao.sendConfigure(ComunicaoSerial.LIGAR_BOMBA);
            }
            else 
            {
                botaoBomba.Text = "Desligado";
                botaoBomba.BackColor = Color.Red;
                comunicacao.sendConfigure(ComunicaoSerial.DESLIGAR_BOMBA);
            }
        }

        private void botaoMotor_Click(object sender, EventArgs e)
        {
            if (botaoMotor.BackColor == Color.Red)
            {
                botaoMotor.Text = "Ligado";
                botaoMotor.BackColor = Color.Green;
                comunicacao.sendConfigure(ComunicaoSerial.LIGAR_MOTOR);
            }
            else 
            {
                botaoMotor.Text = "Desligado";
                botaoMotor.BackColor = Color.Red;
                comunicacao.sendConfigure(ComunicaoSerial.DESLIGAR_MOTOR);
            }
        }

        private void botaoAtualizarSerial_Click(object sender, EventArgs e)
        {
            //capturo todas as portas serias contidas no computador
            String[] portas = comunicacao.listarPortasSeriais();
            //limpo a lista de portas presento no checkbox
            listaPortas.Items.Clear();
            //itero toda a lista
            foreach(String port in portas)
            {
                // adiciono ao checkbox
                listaPortas.Items.Add(port);
            }
            //seleciono a primeira posicao do checkbox
            if(listaPortas.Items.Count > 0)
            {
              listaPortas.SelectedIndex = 0;
            }
            // repinto o checkbox
            listaPortas.Refresh();
        }
            /*
             *  Função responsavel por efetuar a leitura do nivel de águal contido em  cada um dos recipientes
             */
            public void loadNivel()
            {

                // enquanto a comunicação serial estiver ativa.    
                while (serial)
                {
                    comunicacao.initializeSerial();
                    // efetuo a leitura da porta serial
                    String valorLido = comunicacao.readSerial();
                    // se a informação lida contiver o caractere S, que dizer que essa informação é referente ao nivel do reservatorio superior
                    if (valorLido.Contains("S"))
                    {
                        String valorInteiro;
                        //removo o primeiro caractere lido da informação recebida da porta serial
                        String valor = valorLido.Substring(1, (valorLido.Length - 1));
                        //removo a parte decimal da string;
                        if (valor.IndexOf('.') > -1)
                        {
                          valorInteiro = valor.Substring(0, valor.IndexOf('.'));
                        }
                        else {
                           valorInteiro = valor.Substring(0,(valor.Length - 1));
                        }
                        // transformo o valor lido em um inteiro
                        nivelReservatorioSuperior = int.Parse(valorInteiro);
                        // repasso o valor lido para o objeto verticalProgressBar
                        caixaAguaSuperior.Value = nivelReservatorioSuperior;
                        percentualSuperior = Convert.ToString(nivelReservatorioSuperior);
                        // escrevo no campo de texto
                        transfereSuperior(percentualSuperior+" %");
                    }
                    // se a informação lida convetiver o caractere I, que dizer que essa informação é referente ao nivel do reservatorio inferior
                    else if (valorLido.Contains("I"))
                    {
                        String valorInteiro;
                        //removo o primeiro caractere lido da informação recebida da porta serial
                        String valor = valorLido.Substring(1, (valorLido.Length - 1));
                        //removo a parte decimal da string;
                        if (valor.IndexOf('.') > -1)
                        {
                            valorInteiro = valor.Substring(0, valor.IndexOf('.'));
                        }
                        else
                        {
                            valorInteiro = valor.Substring(0,(valor.Length - 1));
                        }
                         
                        // transformo o valor lido em um inteiro
                        nivelReservatorioInferior = int.Parse(valorInteiro);
                        // repasso o valor lido para o objeto verticalProgressBar
                        caixaAguaInferior.Value = nivelReservatorioInferior;
                        percentualInferior = Convert.ToString(nivelReservatorioInferior);
                        // escrevo no campo de texto
                        transfereInferior(percentualInferior+" %");
                    }
                    else if(valorLido.Contains("B"))
                    {
                        botaoBomba.Text = "Ligado";
                        botaoBomba.BackColor = Color.Green;
                    }
                    else if (valorLido.Contains("b"))
                    {
                        botaoBomba.Text = "Desligado";
                        botaoBomba.BackColor = Color.Red;
                    }
                    else if (valorLido.Contains("M"))
                    {
                        botaoMotor.Text = "Ligado";
                        botaoMotor.BackColor = Color.Green;
                    }
                    else if (valorLido.Contains("m"))
                    {
                        botaoMotor.Text = "Desligado";
                        botaoMotor.BackColor = Color.Red;
                    }
                    else if(valorLido.Contains("L"))
                    {
                        botaoAtivar.Text = "Ligado";
                        botaoAtivar.BackColor = Color.Green;
                    }
                    else if (valorLido.Contains("l"))
                    {
                        botaoAtivar.Text = "Desligado";
                        botaoAtivar.BackColor = Color.Red;
                    }
                    // paro a execução da thread por 1s
                    //Thread.Sleep(100);
                    // encerro a execução da thread
                    comunicacao.closedSerial();
                }
            }

            /* Funcao responsavel por encerrar a execução de uma thread
             */
            public void closed()
            {
                if (thread != null)
                {
                    try
                    {
                        if (thread.IsAlive)
                        {
                            thread.Interrupt(); // encerro a execução da thread
                            Thread.Sleep(20);
                            thread.Abort();
                        }
                    }
                    catch (Exception e)
                    {
                        if (thread.IsAlive)
                        {
                            thread.Abort();
                            thread.Interrupt();
                        }
                    }
                }
                else
                {
                    try
                    {
                        Application.Exit();
                    }catch(Exception e){
                        
                    }
                }
            }

            // funcao executada quando o formulario é fechado
            private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
            {
                Application.Exit();
                this.closed();
                comunicacao.closedSerial();
            }

           // funcao executada quando o botao ativar está ativa
            private void botaoAtivar_Click(object sender, EventArgs e)
            {
                if (botaoAtivar.BackColor == Color.Red)
                {
                    botaoAtivar.Text = "Ligado";
                    botaoAtivar.BackColor = Color.Green;
                    serial = comunicacao.initializeSerial();
                    if (serial)
                    {
                        //inicializo a execução da thread
                        thread = new Thread(new ThreadStart(loadNivel));
                        thread.Start();
                        comunicacao.sendConfigure(ComunicaoSerial.START);
                        comunicacao.closedSerial();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel efetuar a comunicação.Verifique!","Configuração");
                    }
                }
                else
                {
                    botaoAtivar.Text = "Desligado";
                    botaoAtivar.BackColor = Color.Red;
                    serial = !comunicacao.closedSerial();
                    
                    if (!serial)
                    {
                          comunicacao.sendConfigure(ComunicaoSerial.RESET);
                          comunicacao.closedSerial();
                          serial = false;
                          this.closed();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel efetuar a comunicação.Verifique!", "Configuração");
                    }
                }
            }

            // funcao responsavel por setar o texto lido dentro da thread para o campo que informa o nivel de agua no recipiente superior
           public void transfereSuperior(String text)
           {
               if(this.nivelSuperiorText.InvokeRequired)
               {
                   this.nivelSuperiorText.Invoke((MethodInvoker)delegate()
                   {
                       transfereSuperior(text);
                   });
               }
               else 
               {
                   this.nivelSuperiorText.Text = text;
               }
           }

           // funcao responsavel por setar o texto lido dentro da thread para o campo que informa o nivel de agua no recipiente inferior
           public void transfereInferior(String text)
           {
               if (this.nivelInferiorText.InvokeRequired)
               {
                   this.nivelInferiorText.Invoke((MethodInvoker)delegate()
                   {
                       transfereInferior(text);
                   });
               }
               else
               {
                   this.nivelInferiorText.Text = text;
               }
           }

      }
}
