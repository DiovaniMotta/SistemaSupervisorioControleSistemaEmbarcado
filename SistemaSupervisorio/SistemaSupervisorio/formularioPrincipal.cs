using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /* @autor Diovani Bernardi da Motta
     * Classe responsavel por implementar a interface gráfica de contato com o usuario
     */
    public partial class FormularioPrincipal : Form
    {
        // instacio um objeto do tipo Comunicação serial 
        private ComunicaoSerial comunicacao = new ComunicaoSerial();

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

            //seleciono a primeira porta serial encontrada
            listaPortas.SelectedIndex = 0;

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
                if (comunicacao.initializeSerial())
                {
                    //desabilito o botao conectar e habilito o botao desconectar
                    btnDesligado.Enabled = true;
                    btnLigado.Enabled = false;
                }
                else
                {
                    MessageBox.Show(" Não foi possivel iniciar a comunicação serial. Verifique as configurações!");
                }
            }
            else
            {
                MessageBox.Show("Operação abortada pelo usuário!");
            }
        }

        private void btnDesligado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente se desconectar do Sistema Embarcado ? ", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                 // se for possivel encerar a comunicação serial
                if (comunicacao.closedSerial())
                {
                    //desabilito o botao desconectar e habilito o botao conectar
                    btnDesligado.Enabled = false;
                    btnLigado.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível finalizar a comunicação serial. Verifique!");
                }
            }
            else
            {
                MessageBox.Show("Operação abortada pelo usuário!");
            }
        }
    }
}
