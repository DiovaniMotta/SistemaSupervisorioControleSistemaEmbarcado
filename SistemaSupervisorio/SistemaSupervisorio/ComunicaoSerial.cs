using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports; // biblioteca responsavel por realizar a comunicação com a API do Windows


namespace SistemaSupervisorio
{
    /*
     * @autor Diovani Bernardi da Motta
     **/
    public class ComunicaoSerial
    {
        //Objeto responsavel por selecionar as configurações da porta serial
        public SerialPort portaSerial = new SerialPort();
        // Objeto responsavel por armazenar a lista de portas seriais disponiveis na maquina
        public String[] portasSeriais;
        //Objeto responsavel por armazenar uma lista os bits por segundo que serão usados na comunicação
        public List<String> listaBitsSegundos = new List<String>();
        //Objeto responsavel por armazenar uma lista de bits de dados que serão transmitidos
        public List<String> listaBitsDados = new List<String>();
        //Objeto responsavel por armazenar os valores possiveis para a paridade com a comunicação serial
        public List<String> listaParidade = new List<String>();
        //Objeto responsavel por armazenar os valores possiveis para os bits de parada da serial
        public List<String> listaBitsParada = new List<String>();
        //Objeto responsavel por armazenar os valores possivel para o controle do fluxo da comunicação serial
        public List<String> listaControleFluxo = new List<String>();
        //variavel que controla se está ou nao conectado a serial
        public Boolean conectado = false;

        //Objeto responsavel por armazenar a porta serial selecionada pelo usuario
        public String portaSerialSelecionada;
        //Objeto responsavel por armazenar o baudrate da transmissao
        public String bitsSegundoSelecionado;
        //Objeto responsavel por armazenar os bits de dados que serao usados para transferencia
        public String bitsDadosSelecionado;
        //Objeto responsavel por armazenar a paridade usada na comunicaçao serial
        public String paridadeSelecionado;
        //Objeto responsavel por armazenar os bits de parada selecionado
        public String bitsParadaSelecionada;
        //Objeto responsavel por armazenar o controle de fluxo usado na porta serial
        public String controleFluxoSelecionado;
        // constantes responsavel por informar ao dispositivo serial que sera aberto ou fechada a comunicação
        public static String ABRIR_COMUNICACAO = "A";
        public static String FECHAR_COMUNICACAO = "F";
        public static String START = "L";
        public static String RESET = "l";
        // constantes responsaveis por representar se a instrução a seguir será enviada para o motor ou para a bomba
        public static String LIGAR_BOMBA = "B";
        public static String LIGAR_MOTOR = "M";
        public static String DESLIGAR_BOMBA = "b";
        public static String DESLIGAR_MOTOR = "m";
        //constante responsavel por informar ao microcontrolador que será enviada informaçoes para configurar a usar
        public static String CONFIGURACAO_SUPEVISORIO = "C";
        
        public ComunicaoSerial()
        {
            try
            {
                this.configuracao();

            }
            catch{}
        }

        /* Função responsavel por retornar o nome de todas as protas seriais disponiveis na maquina
         **/
        public String[] listarPortasSeriais()
        {
            try
            {
                // retorno a lista com os nomes das portas COM disponiveis no computador
                portasSeriais = SerialPort.GetPortNames();
                // retorna a lista de portas seriais
            }
            catch{}
               return portasSeriais;
        }

        /* Função responsavel pro configurar a comunicação serial
         * 
         **/
        public Boolean configureSerial()
        {
            try
            {
                portaSerial.PortName = portaSerialSelecionada;
                portaSerial.BaudRate = int.Parse(bitsSegundoSelecionado);
                portaSerial.DataBits = int.Parse(bitsDadosSelecionado);
                
                if(bitsParadaSelecionada.Equals("1"))
                {
                    portaSerial.StopBits = StopBits.One;

                }
                else if (bitsParadaSelecionada.Equals("1,5"))
                {
                    portaSerial.StopBits = StopBits.OnePointFive;
                }
                else if (bitsParadaSelecionada.Equals("Nenhum"))
                {
                    portaSerial.StopBits = StopBits.None;
                }
                else{
                   portaSerial.StopBits = StopBits.Two;
                }



                if(listaParidade.Equals("Even"))
                {
                    portaSerial.Parity = Parity.Even;
                }
                else if (listaParidade.Equals("Mark"))
                {
                    portaSerial.Parity = Parity.Mark;
                }
                else if(listaParidade.Equals("Nenhum"))
                {
                    portaSerial.Parity = Parity.None;
                }
                else if (listaParidade.Equals("Odd"))
                {
                    portaSerial.Parity = Parity.Odd;
                }
                else
                {
                    portaSerial.Parity = Parity.Space;
                }
            }
            catch{
                return false;
            }

            return true;
        }


        /* Funcao responsavel por escrever o conteudo da porta serial
         */
        public Boolean writeSerial(String escrita)
        {
            try
            {
                // se for possivel inicializar a conexao serial
                if (portaSerial.IsOpen)
                {
                    portaSerial.Write(escrita);
                    //fecho a comunicação serial
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch{
                return false;
            }
        }

        /* Funcao responsavel por ler o conteudo recebido da porta serial
         */
        public String readSerial()
        {
            String leitura = "";
            try
            {
                // se for possivel inicializar a comunicaçãos serial
                if(portaSerial.IsOpen)
                {
                  leitura = portaSerial.ReadLine();

                }
            }
            catch{}
            
            return leitura;
        }

        /* Funcao responsavel por configurar os valores que serão exibidos na tela para o usuario selecionar
         */
        public void configuracao()
        {
            try
            {
                listaBitsDados.Add("4");
                listaBitsDados.Add("5");
                listaBitsDados.Add("6");
                listaBitsDados.Add("7");
                listaBitsDados.Add("8");

                listaBitsSegundos.Add("9600");
                listaBitsSegundos.Add("19200");
                listaBitsSegundos.Add("38400");
                listaBitsSegundos.Add("57600");
                listaBitsSegundos.Add("110000");

                listaParidade.Add("Even");
                listaParidade.Add("Odd");
                listaParidade.Add("Nenhum");
                listaParidade.Add("Mark");
                listaParidade.Add("Space");

                listaBitsParada.Add("1");
                listaBitsParada.Add("1,5");
                listaBitsParada.Add("2");
                listaBitsParada.Add("Nenhum");

                listaControleFluxo.Add("Xon/Xoff");
                listaControleFluxo.Add("Hardware");
                listaControleFluxo.Add("Nenhuma");
            }
            catch{ }
          }

        /* Função responsavel por verificar se foi possivel abrir a porta serial
         */
        public Boolean initializeSerial()
        {
            try
            {
                //Abro a porta serial
                portaSerial.Open();
                //se a porta estiver aberta
                if (portaSerial.IsOpen)
                {
                    return true;
                }
            }
            catch{
               return false;
            }
            return false;
        }

        /* Funcao responsavel por verificar se foi possivel fechar a porta serial
         */
        public Boolean closedSerial()
        {
            try
            {
                //finalizo a conexao com a porta serial
                portaSerial.Close();
                // se a porta nao estiver aberta
                if (!portaSerial.IsOpen)
                {
                    return true;
                }
            }
            catch{
                return false;
            }
            return false;
        }

        /*
         *  Função responsavel por enviar informações de configuração ao pic
         **/
        public void sendConfigure(String hardware)
        {
            if(hardware.Equals(ABRIR_COMUNICACAO))
            {
                this.writeSerial(ABRIR_COMUNICACAO);
            }
            else if(hardware.Equals(FECHAR_COMUNICACAO)) 
            {
                this.writeSerial(FECHAR_COMUNICACAO);
            }
            else if(hardware.Equals(CONFIGURACAO_SUPEVISORIO))
            {
                this.writeSerial(CONFIGURACAO_SUPEVISORIO);
                this.writeSerial(bitsSegundoSelecionado);
                this.writeSerial(bitsDadosSelecionado);
            }
            else if(hardware.Equals(DESLIGAR_BOMBA))
            {
                this.writeSerial(DESLIGAR_BOMBA);
            }
            else if (hardware.Equals(LIGAR_BOMBA))
            {
                this.writeSerial(LIGAR_BOMBA);
            }
            else if (hardware.Equals(LIGAR_MOTOR))
            {
                this.writeSerial(LIGAR_MOTOR);
            }
            else if(hardware.Equals(DESLIGAR_MOTOR))
            {
                this.writeSerial(DESLIGAR_MOTOR);
            }
            else if(hardware.Equals(START))
            {
                this.writeSerial(START);
            }
            else if(hardware.Equals(RESET))
            {
                this.writeSerial(RESET);
            }
        }

        public void setPortaSerialSelecionada(String port){
            this.portaSerialSelecionada = port;
        }

        public void setBitsSegundoSelecionado(String bits)
        {
            this.bitsSegundoSelecionado = bits;
        }

        public void setBitsDadosSelecionado(String bits)
        {
            this.bitsDadosSelecionado = bits;
        }

        public void setParidadeSelecionado(String bits)
        {
            this.paridadeSelecionado = bits;
        }

        public void setBitsParadaSelecionada(String bits)
        {
            this.bitsParadaSelecionada = bits;
        }

        public void setControleFluxoSelecionado(String bits)
        {
            this.controleFluxoSelecionado = bits;
        }

        public String getPortaSerialSelecionada()
        {
            return this.portaSerialSelecionada;
        }

        public String getBitsSegundoSelecionado()
        {
            return this.bitsSegundoSelecionado;
        }

        public String setBitsDadosSelecionado()
        {
            return this.bitsDadosSelecionado;
        }

        public String setParidadeSelecionado()
        {
            return this.paridadeSelecionado;
        }

        public String setBitsParadaSelecionada()
        {
            return this.bitsParadaSelecionada;
        }

        public String setControleFluxoSelecionado()
        {
            return this.controleFluxoSelecionado;
        }

        public Boolean isConected()
        {
            return conectado;
        }
    }
}
