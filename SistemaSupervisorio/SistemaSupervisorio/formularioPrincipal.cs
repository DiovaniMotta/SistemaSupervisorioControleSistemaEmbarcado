using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;


namespace SistemaSupervisorio
{
    /* @autor Diovani Bernardi da Motta
     * Classe responsavel por implementar a interface gráfica de contato com o usuario
     */
    public partial class FormularioPrincipal : Form
    {
        // instacio um objeto do tipo Comunicação serial 
        public ComunicaoSerial serialPorta = new ComunicaoSerial();
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
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + e.Message, "Erro");
            }
        }

        /** Funcao responsavel por configurar a serial
         **/
        private void configureSerial()
        {
            try
            {
                comunicacao.PortName = string.Concat(listaPortas.SelectedItem);
                comunicacao.BaudRate = Convert.ToInt32(listaBitsSegundo.SelectedItem);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + e.Message, "Erro");
            }
        }
        /*
         *  Função invocada durante o processo de carregamento do form para o usuario
         */
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // retorno uma lista de portas seriais configuradas no computador
                String[] retorno = serialPorta.listarPortasSeriais();
                // itero toda a lista de portas instanciadas
                foreach (String port in retorno)
                {
                    // adiciono a lista que será exibida para o usuario com as portas disponiveis na maquina
                    listaPortas.Items.Add(port);
                }

                if (listaPortas.Items.Count > 0)
                {
                    //seleciono a primeira porta serial encontrada
                    listaPortas.SelectedIndex = 0;
                }

                // itero a lista de bits por segundo usado na conexao
                foreach (String bitSegundo in serialPorta.listaBitsSegundos)
                {
                    // adiciono ao combo
                    listaBitsSegundo.Items.Add(bitSegundo);
                }

                // seleciono o primeiro item da lista
                listaBitsSegundo.SelectedIndex = 0;

                // itero a lista de bits de dados usados na transmissap
                foreach (String bitDados in serialPorta.listaBitsDados)
                {
                    // adiciono ao combo
                    listaBitsDados.Items.Add(bitDados);
                }

                // seleciono a primeira posicao
                listaBitsDados.SelectedIndex = 4;

                // adiciono ao combobox todas as opçoes de paridade possivel
                foreach (String paridade in serialPorta.listaParidade)
                {
                    // adiciono a lista
                    listaParidade.Items.Add(paridade);
                }

                // posiciono na primeira opção de paridade
                listaParidade.SelectedIndex = 2;

                //itero todas as opçoes de bit de parada
                foreach (String bitParada in serialPorta.listaBitsParada)
                {
                    // adiciono ao combo
                    listaBitsParada.Items.Add(bitParada);
                }

                // seleciono a primeira posicao
                listaBitsParada.SelectedIndex = 0;

                //itero toda a lista de controle de fluxo
                foreach (String controle in serialPorta.listaControleFluxo)
                {
                    // adiciono ao combo
                    listaControleFluxo.Items.Add(controle);
                }

                // seleciono a primeira opção do combo
                listaControleFluxo.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + ex.Message, "Erro");
            }
        }

        private void btnLigado_Click(object sender, EventArgs e)
        {
            try
            {
                // notifica o usuario, se o mesmo realmente deseja realizar a operação
                if (MessageBox.Show("Deseja realmente se conectar com o Sistema Embarcado,\n com as configurações informadas ? ", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                    System.Windows.Forms.DialogResult.Yes)
                {

                    //chamada a funcao responsavel por configurar a comunicação serial
                    configureSerial();
                    //abro a porta serial 
                    comunicacao.Open();
                    // se for possivel iniciar a comunicação serial
                    if (comunicacao.IsOpen)
                    {
                        //desabilito o botao conectar e habilito o botao desconectar
                        btnDesligado.Enabled = true;
                        btnLigado.Enabled = false;
                        // informo ao usuario que a conexao foi realizada
                        conexao.Text = "Conectado";
                        conexao.BackColor = Color.Green;
                        MessageBox.Show("Conexão realizada com sucesso!", "Confirmação");
                        botaoMotor.Enabled = true;
                        botaoBomba.Enabled = true;
                        botaoAtivar.Enabled = true;
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
            catch(Exception ecv)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + ecv.Message, "Erro");
            }
        }

        private void btnDesligado_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente se desconectar do Sistema Embarcado ? ", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    // envio os comandos para desligar o motor
                    comunicacao.Write(ComunicaoSerial.DESLIGAR_BOMBA);
                    comunicacao.Write(ComunicaoSerial.DESLIGAR_MOTOR);

                    ThreadComunicao.CancelAsync(); // encerro a e
                    // encerro a comunicao serial
                    comunicacao.Close();
                    // se for possivel encerar a comunicação serial
                    if (!comunicacao.IsOpen)
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
                        MessageBox.Show("Comunicação Encerrada!", "Confirmação");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível finalizar a comunicação serial. Verifique!", "Confirmação");
                    }
                }
                else
                {
                    MessageBox.Show("Operação abortada pelo usuário!", "Confirmação");
                }
            }
            catch(Exception cxe)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + cxe.Message, "Erro");
            }
        }

        private void botaoBomba_Click(object sender, EventArgs e)
        {
            try
            {
                if (botaoBomba.BackColor == Color.Red)
                {
                    botaoBomba.Text = "Ligado";
                    botaoBomba.BackColor = Color.Green;
                    comunicacao.Write(ComunicaoSerial.LIGAR_BOMBA);
                }
                else
                {
                    botaoBomba.Text = "Desligado";
                    botaoBomba.BackColor = Color.Red;
                    comunicacao.Write(ComunicaoSerial.DESLIGAR_BOMBA);
                }
            }
            catch(Exception ecx)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + ecx.Message, "Erro");
            }
        }

        private void botaoMotor_Click(object sender, EventArgs e)
        {
            try
            {
                if (botaoMotor.BackColor == Color.Red)
                {
                    botaoMotor.Text = "Ligado";
                    botaoMotor.BackColor = Color.Green;
                    comunicacao.Write(ComunicaoSerial.LIGAR_MOTOR);
                }
                else
                {
                    botaoMotor.Text = "Desligado";
                    botaoMotor.BackColor = Color.Red;
                    comunicacao.Write(ComunicaoSerial.DESLIGAR_MOTOR);
                }
            }
            catch (Exception ece)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + ece.Message, "Erro");
            }
        }

        private void botaoAtualizarSerial_Click(object sender, EventArgs e)
        {
            try
            {
                //capturo todas as portas serias contidas no computador
                String[] portas = serialPorta.listarPortasSeriais();
                //limpo a lista de portas presento no checkbox
                listaPortas.Items.Clear();
                //itero toda a lista
                foreach (String port in portas)
                {
                    // adiciono ao checkbox
                    listaPortas.Items.Add(port);
                }
                //seleciono a primeira posicao do checkbox
                if (listaPortas.Items.Count > 0)
                {
                    listaPortas.SelectedIndex = 0;
                }
                // repinto o checkbox
                listaPortas.Refresh();
            }
            catch(Exception ecc)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + ecc.Message, "Erro");
            
            }
        }

        // funcao executada quando o formulario é fechado
        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch(Exception epx)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + epx.Message, "Erro");
            }
        }

        // funcao executada quando o botao ativar está ativa
        private void botaoAtivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (botaoAtivar.BackColor == Color.Red)
                {
                    botaoAtivar.Text = "Ligado";
                    botaoAtivar.BackColor = Color.Green;
                    if (comunicacao.IsOpen)
                    {
                        comunicacao.Write(ComunicaoSerial.START); // envio o comando para conectar ao pic
                        ThreadComunicao.RunWorkerAsync(); // inicio a thread que irá carregar o nivel da agua
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel efetuar a comunicação.Verifique!", "Configuração");
                    }
                }
                else
                {
                    botaoAtivar.Text = "Desligado";
                    botaoAtivar.BackColor = Color.Red;
                    ThreadComunicao.CancelAsync();
                    comunicacao.Write(ComunicaoSerial.RESET); // envio do comando para desligar o pic
                    comunicacao.Close();
                    if (!comunicacao.IsOpen)
                    {
                        MessageBox.Show("Comunicação serial encerrada com sucesso!", "Configuração");
                        btnLigado.Enabled = true;
                        btnDesligado.Enabled = false;
                        botaoBomba.Enabled = false;
                        botaoMotor.Enabled = false;
                        conexao.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel efetuar a comunicação.Verifique!", "Configuração");
                    }
                }
            }
            catch(Exception xp)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + xp.Message, "Erro");
            }
        }

        // funcao responsavel por setar o texto lido dentro da thread para o campo que informa o nivel de agua no recipiente superior
        public void transfereSuperior(String text)
        {
            try
            {
                if (this.nivelSuperiorText.InvokeRequired)
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
            catch (Exception exx)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + exx.Message, "Erro");
            }
        }

        // funcao responsavel por setar o texto lido dentro da thread para o campo que informa o nivel de agua no recipiente inferior
        public void transfereInferior(String text)
        {
            try
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
            catch(Exception exp)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + exp.Message, "Erro");
            }
        }

        private void ThreadComunicao_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (!ThreadComunicao.CancellationPending)//loop enquanto o componente não for cancelado.
                {
                    if (comunicacao.BytesToRead > 0) // se houverem bits a serem recebidos da serial
                    {
                        string palavra = comunicacao.ReadLine(); // leio a informação do canal serial
                        ThreadComunicao.ReportProgress(0, palavra);//se for ler uma linha inteira.
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + ee.Message, "Erro");
            }
        }

        private void ThreadComunicao_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {

                // repasso o valor lido da serial para a avariavel
                string valorLido = Convert.ToString(e.UserState);
                // se a informação lida contiver o caractere S, que dizer que essa informação é referente ao nivel do reservatorio superior
                if (valorLido.Contains("S"))
                {
                    String valorInteiro;
                    //removo o primeiro caractere lido da informação recebida da porta serial
                    String valor = valorLido.Substring(1, (valorLido.Length - 1));

                    //removo a parte decimal da string;
                    if (valor.IndexOf('.') < -1)
                    {
                        valorInteiro = valor;
                    }
                    else
                    {
                        valorInteiro = valor.Substring(0, valor.IndexOf('.'));
                    }

                    // transformo o valor lido em um inteiro
                    nivelReservatorioSuperior = Convert.ToInt32(valorInteiro);
                    // repasso o valor lido para o objeto verticalProgressBar
                    caixaAguaSuperior.Value = nivelReservatorioSuperior;
                    percentualSuperior = Convert.ToString(nivelReservatorioSuperior);
                    // escrevo no campo de texto
                    transfereSuperior(percentualSuperior + " %");
                }
                // se a informação lida convetiver o caractere I, que dizer que essa informação é referente ao nivel do reservatorio inferior
                else if (valorLido.Contains("I"))
                {
                    String valorInteiro;
                    //removo o primeiro caractere lido da informação recebida da porta serial
                    String valor = valorLido.Substring(1, (valorLido.Length - 1));

                    //removo a parte decimal da string;
                    if (valor.IndexOf('.') < -1)
                    {
                        valorInteiro = valor;
                    }
                    else
                    {
                        valorInteiro = valor.Substring(0, valor.IndexOf('.'));
                    }

                    // transformo o valor lido em um inteiro
                    nivelReservatorioInferior = Convert.ToInt32(valorInteiro);
                    // repasso o valor lido para o objeto verticalProgressBar
                    caixaAguaInferior.Value = nivelReservatorioInferior;
                    percentualInferior = Convert.ToString(nivelReservatorioInferior);
                    // escrevo no campo de texto
                    transfereInferior(percentualInferior + " %");
                }
                else if (valorLido.Contains("B"))
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
                else if (valorLido.Contains("L"))
                {
                    botaoAtivar.Text = "Ligado";
                    botaoAtivar.BackColor = Color.Green;
                }
                else if (valorLido.Contains("l"))
                {
                    botaoAtivar.Text = "Desligado";
                    botaoAtivar.BackColor = Color.Red;
                }
            }catch(Exception xe)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + xe.Message, "Erro");
            }
        }

        private void botaoAtualizarSerial_Click_1(object sender, EventArgs e)
        {
            try
            {
                listaPortas.Refresh();
                // retorno uma lista de portas seriais configuradas no computador
                String[] retorno = SerialPort.GetPortNames();
                // itero toda a lista de portas instanciadas
                foreach (String port in retorno)
                {
                    // adiciono a lista que será exibida para o usuario com as portas disponiveis na maquina
                    listaPortas.Items.Add(port);
                }

                if (listaPortas.Items.Count > 0)
                {
                    //seleciono a primeira porta serial encontrada
                    listaPortas.SelectedIndex = 0;
                }
                listaPortas.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocorreu um erro ao executar a função. Erro retornado :" + exc.Message, "Erro");
            } 
        }
    }
}
