using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports; // biblioteca responsavel por realizar a comunicação com a API do Windows


namespace WindowsFormsApplication1
{
    /*
     * @autor Diovani Bernardi da Motta
     **/
    class ComunicaoSerial
    {
        //Objeto responsavel por selecionar as configurações da porta serial
        private SerialPort portaSerial = new SerialPort();
        // Objeto responsavel por armazenar a lista de portas seriais disponiveis na maquina
        private String[] portasSeriais;
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

        //Objeto responsavel por armazenar a porta serial selecionada pelo usuario
        private String portaSerialSelecionada;
        //Objeto responsavel por armazenar o baudrate da transmissao
        private String bitsSegundoSelecionado;
        //Objeto responsavel por armazenar os bits de dados que serao usados para transferencia
        private String bitsDadosSelecionado;
        //Objeto responsavel por armazenar a paridade usada na comunicaçao serial
        private String paridadeSelecionado;
        //Objeto responsavel por armazenar os bits de parada selecionado
        private String bitsParadaSelecionada;
        //Objeto responsavel por armazenar o controle de fluxo usado na porta serial
        private String controleFluxoSelecionado;


        public ComunicaoSerial()
        {
            try
            {
                this.configuracao();

            }
            catch(Exception e){}
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
            catch(Exception e){}
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
            catch(Exception e){
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
                if (this.initializeSerial())
                {
                    //Objeto responsavel por converter uma string em um array de bytes
                    System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                    //transformo a string em um array de bayte
                    byte[] streamByte = encoding.GetBytes(escrita);
                    // escrevo o array de byte no canal serial
                    portaSerial.Write(streamByte, 0, streamByte.Length);
                    //fecho a comunicação serial
                    this.closedSerial();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e){
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
                if(this.initializeSerial())
                {
                  leitura = portaSerial.ReadExisting();
                }
            }
            catch(Exception e){}
            
            return leitura;
        }

        /* Funcao responsavel por configurar os valores que serão exibidos na tela para o usuario selecionar
         */
        private void configuracao()
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
            catch (Exception e) { }
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
                if(portaSerial.IsOpen)
                {
                    return true;
                }
            }
            catch(Exception e){
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
                if(!portaSerial.IsOpen)
                {
                    return true;
                }

            }
            catch(Exception e){
                return false;
            }
            return false;
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
    }
}
