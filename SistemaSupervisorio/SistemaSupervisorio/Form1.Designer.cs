namespace WindowsFormsApplication1
{
    public partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.btnLigado = new System.Windows.Forms.Button();
            this.btnDesligado = new System.Windows.Forms.Button();
            this.painelConfiguracaoSerial = new System.Windows.Forms.GroupBox();
            this.painelStatus = new System.Windows.Forms.GroupBox();
            this.conexao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listaControleFluxo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listaBitsParada = new System.Windows.Forms.ComboBox();
            this.painelParidade = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaParidade = new System.Windows.Forms.ComboBox();
            this.painelBitsDados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaBitsDados = new System.Windows.Forms.ComboBox();
            this.painelBitSegundos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaBitsSegundo = new System.Windows.Forms.ComboBox();
            this.painelPortaSerial = new System.Windows.Forms.GroupBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.listaPortas = new System.Windows.Forms.ComboBox();
            this.painelCaixaAguaSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.caixaAguaSuperior = new VerticalProgressBar.VerticalProgressBar();
            this.canoSuperiorPrimario = new System.Windows.Forms.FlowLayoutPanel();
            this.canoSuperiorSecundario = new System.Windows.Forms.FlowLayoutPanel();
            this.roscaCanoSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.canoCentralSecundario = new System.Windows.Forms.FlowLayoutPanel();
            this.roscaCanoInferior = new System.Windows.Forms.FlowLayoutPanel();
            this.painelCaixaAguaInferior = new System.Windows.Forms.FlowLayoutPanel();
            this.caixaAguaInferior = new VerticalProgressBar.VerticalProgressBar();
            this.roscaCentral = new System.Windows.Forms.FlowLayoutPanel();
            this.canoInferiorSecundario = new System.Windows.Forms.FlowLayoutPanel();
            this.canoInferiorPrimario = new System.Windows.Forms.FlowLayoutPanel();
            this.roscaCentralInforior = new System.Windows.Forms.FlowLayoutPanel();
            this.motorDesligamento = new System.Windows.Forms.FlowLayoutPanel();
            this.bombaAgua = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.painelLigarMotor = new System.Windows.Forms.GroupBox();
            this.botaoMotor = new System.Windows.Forms.Button();
            this.painelBomba = new System.Windows.Forms.GroupBox();
            this.botaoBomba = new System.Windows.Forms.Button();
            this.painelNivelRecipienteSuperior = new System.Windows.Forms.GroupBox();
            this.nivelSuperiorText = new System.Windows.Forms.TextBox();
            this.lblNivelSuperior = new System.Windows.Forms.Label();
            this.painelRecipienteInferior = new System.Windows.Forms.GroupBox();
            this.nivelInferiorText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botaoAtivar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.botaoAtualizarSerial = new System.Windows.Forms.Button();
            this.painelConfiguracaoSerial.SuspendLayout();
            this.painelStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.painelParidade.SuspendLayout();
            this.painelBitsDados.SuspendLayout();
            this.painelBitSegundos.SuspendLayout();
            this.painelPortaSerial.SuspendLayout();
            this.painelCaixaAguaSuperior.SuspendLayout();
            this.painelCaixaAguaInferior.SuspendLayout();
            this.painelLigarMotor.SuspendLayout();
            this.painelBomba.SuspendLayout();
            this.painelNivelRecipienteSuperior.SuspendLayout();
            this.painelRecipienteInferior.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLigado
            // 
            this.btnLigado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLigado.BackgroundImage")));
            this.btnLigado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLigado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLigado.ImageKey = "(none)";
            this.btnLigado.Location = new System.Drawing.Point(28, 471);
            this.btnLigado.Name = "btnLigado";
            this.btnLigado.Size = new System.Drawing.Size(145, 38);
            this.btnLigado.TabIndex = 1;
            this.btnLigado.Text = "Conectar";
            this.btnLigado.UseVisualStyleBackColor = true;
            this.btnLigado.Click += new System.EventHandler(this.btnLigado_Click);
            // 
            // btnDesligado
            // 
            this.btnDesligado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesligado.BackgroundImage")));
            this.btnDesligado.Enabled = false;
            this.btnDesligado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesligado.Image = ((System.Drawing.Image)(resources.GetObject("btnDesligado.Image")));
            this.btnDesligado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesligado.Location = new System.Drawing.Point(179, 471);
            this.btnDesligado.Name = "btnDesligado";
            this.btnDesligado.Size = new System.Drawing.Size(145, 38);
            this.btnDesligado.TabIndex = 2;
            this.btnDesligado.Text = "Desconectar";
            this.btnDesligado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesligado.UseVisualStyleBackColor = true;
            this.btnDesligado.Click += new System.EventHandler(this.btnDesligado_Click);
            // 
            // painelConfiguracaoSerial
            // 
            this.painelConfiguracaoSerial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelConfiguracaoSerial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelConfiguracaoSerial.BackgroundImage")));
            this.painelConfiguracaoSerial.Controls.Add(this.painelStatus);
            this.painelConfiguracaoSerial.Controls.Add(this.groupBox2);
            this.painelConfiguracaoSerial.Controls.Add(this.groupBox1);
            this.painelConfiguracaoSerial.Controls.Add(this.painelParidade);
            this.painelConfiguracaoSerial.Controls.Add(this.painelBitsDados);
            this.painelConfiguracaoSerial.Controls.Add(this.painelBitSegundos);
            this.painelConfiguracaoSerial.Controls.Add(this.painelPortaSerial);
            this.painelConfiguracaoSerial.Controls.Add(this.btnLigado);
            this.painelConfiguracaoSerial.Controls.Add(this.btnDesligado);
            this.painelConfiguracaoSerial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.painelConfiguracaoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelConfiguracaoSerial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelConfiguracaoSerial.Location = new System.Drawing.Point(16, 12);
            this.painelConfiguracaoSerial.Name = "painelConfiguracaoSerial";
            this.painelConfiguracaoSerial.Size = new System.Drawing.Size(354, 524);
            this.painelConfiguracaoSerial.TabIndex = 3;
            this.painelConfiguracaoSerial.TabStop = false;
            this.painelConfiguracaoSerial.Text = "Configurações de Comunicação";
            // 
            // painelStatus
            // 
            this.painelStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.painelStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelStatus.BackgroundImage")));
            this.painelStatus.Controls.Add(this.conexao);
            this.painelStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.painelStatus.Location = new System.Drawing.Point(6, 380);
            this.painelStatus.Name = "painelStatus";
            this.painelStatus.Size = new System.Drawing.Size(342, 63);
            this.painelStatus.TabIndex = 11;
            this.painelStatus.TabStop = false;
            this.painelStatus.Text = "Conexão";
            // 
            // conexao
            // 
            this.conexao.BackColor = System.Drawing.Color.Red;
            this.conexao.Enabled = false;
            this.conexao.Location = new System.Drawing.Point(89, 15);
            this.conexao.Name = "conexao";
            this.conexao.Size = new System.Drawing.Size(157, 40);
            this.conexao.TabIndex = 0;
            this.conexao.Text = "Desconectado";
            this.conexao.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listaControleFluxo);
            this.groupBox2.Location = new System.Drawing.Point(6, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 59);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Controle de Fluxo  :";
            // 
            // listaControleFluxo
            // 
            this.listaControleFluxo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaControleFluxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaControleFluxo.FormattingEnabled = true;
            this.listaControleFluxo.Location = new System.Drawing.Point(144, 20);
            this.listaControleFluxo.Name = "listaControleFluxo";
            this.listaControleFluxo.Size = new System.Drawing.Size(124, 23);
            this.listaControleFluxo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listaBitsParada);
            this.groupBox1.Location = new System.Drawing.Point(6, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bits de Parada  :";
            // 
            // listaBitsParada
            // 
            this.listaBitsParada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaBitsParada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaBitsParada.FormattingEnabled = true;
            this.listaBitsParada.Location = new System.Drawing.Point(143, 19);
            this.listaBitsParada.Name = "listaBitsParada";
            this.listaBitsParada.Size = new System.Drawing.Size(124, 23);
            this.listaBitsParada.TabIndex = 3;
            // 
            // painelParidade
            // 
            this.painelParidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelParidade.BackgroundImage")));
            this.painelParidade.Controls.Add(this.label3);
            this.painelParidade.Controls.Add(this.listaParidade);
            this.painelParidade.Location = new System.Drawing.Point(6, 199);
            this.painelParidade.Name = "painelParidade";
            this.painelParidade.Size = new System.Drawing.Size(342, 51);
            this.painelParidade.TabIndex = 8;
            this.painelParidade.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paridade :";
            // 
            // listaParidade
            // 
            this.listaParidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaParidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaParidade.FormattingEnabled = true;
            this.listaParidade.Location = new System.Drawing.Point(143, 20);
            this.listaParidade.Name = "listaParidade";
            this.listaParidade.Size = new System.Drawing.Size(124, 23);
            this.listaParidade.TabIndex = 3;
            // 
            // painelBitsDados
            // 
            this.painelBitsDados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelBitsDados.BackgroundImage")));
            this.painelBitsDados.Controls.Add(this.label2);
            this.painelBitsDados.Controls.Add(this.listaBitsDados);
            this.painelBitsDados.Location = new System.Drawing.Point(6, 136);
            this.painelBitsDados.Name = "painelBitsDados";
            this.painelBitsDados.Size = new System.Drawing.Size(342, 57);
            this.painelBitsDados.TabIndex = 7;
            this.painelBitsDados.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bits de Dados :";
            // 
            // listaBitsDados
            // 
            this.listaBitsDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaBitsDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaBitsDados.FormattingEnabled = true;
            this.listaBitsDados.Location = new System.Drawing.Point(144, 20);
            this.listaBitsDados.Name = "listaBitsDados";
            this.listaBitsDados.Size = new System.Drawing.Size(124, 23);
            this.listaBitsDados.TabIndex = 3;
            // 
            // painelBitSegundos
            // 
            this.painelBitSegundos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelBitSegundos.BackgroundImage")));
            this.painelBitSegundos.Controls.Add(this.label1);
            this.painelBitSegundos.Controls.Add(this.listaBitsSegundo);
            this.painelBitSegundos.Location = new System.Drawing.Point(6, 75);
            this.painelBitSegundos.Name = "painelBitSegundos";
            this.painelBitSegundos.Size = new System.Drawing.Size(342, 55);
            this.painelBitSegundos.TabIndex = 6;
            this.painelBitSegundos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bits por Segundo :";
            // 
            // listaBitsSegundo
            // 
            this.listaBitsSegundo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaBitsSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaBitsSegundo.FormattingEnabled = true;
            this.listaBitsSegundo.Location = new System.Drawing.Point(144, 19);
            this.listaBitsSegundo.Name = "listaBitsSegundo";
            this.listaBitsSegundo.Size = new System.Drawing.Size(124, 23);
            this.listaBitsSegundo.TabIndex = 3;
            // 
            // painelPortaSerial
            // 
            this.painelPortaSerial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelPortaSerial.BackgroundImage")));
            this.painelPortaSerial.Controls.Add(this.botaoAtualizarSerial);
            this.painelPortaSerial.Controls.Add(this.lblPorta);
            this.painelPortaSerial.Controls.Add(this.listaPortas);
            this.painelPortaSerial.Location = new System.Drawing.Point(6, 19);
            this.painelPortaSerial.Name = "painelPortaSerial";
            this.painelPortaSerial.Size = new System.Drawing.Size(342, 50);
            this.painelPortaSerial.TabIndex = 5;
            this.painelPortaSerial.TabStop = false;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPorta.Location = new System.Drawing.Point(12, 19);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(81, 13);
            this.lblPorta.TabIndex = 4;
            this.lblPorta.Text = "Porta Serial :";
            // 
            // listaPortas
            // 
            this.listaPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPortas.FormattingEnabled = true;
            this.listaPortas.Location = new System.Drawing.Point(144, 14);
            this.listaPortas.Name = "listaPortas";
            this.listaPortas.Size = new System.Drawing.Size(124, 23);
            this.listaPortas.TabIndex = 3;
            // 
            // painelCaixaAguaSuperior
            // 
            this.painelCaixaAguaSuperior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.painelCaixaAguaSuperior.Controls.Add(this.caixaAguaSuperior);
            this.painelCaixaAguaSuperior.Location = new System.Drawing.Point(544, 67);
            this.painelCaixaAguaSuperior.Name = "painelCaixaAguaSuperior";
            this.painelCaixaAguaSuperior.Size = new System.Drawing.Size(280, 440);
            this.painelCaixaAguaSuperior.TabIndex = 4;
            // 
            // caixaAguaSuperior
            // 
            this.caixaAguaSuperior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caixaAguaSuperior.BorderStyle = VerticalProgressBar.BorderStyles.None;
            this.caixaAguaSuperior.Color = System.Drawing.Color.Blue;
            this.caixaAguaSuperior.Location = new System.Drawing.Point(3, 3);
            this.caixaAguaSuperior.Maximum = 100;
            this.caixaAguaSuperior.Minimum = 0;
            this.caixaAguaSuperior.Name = "caixaAguaSuperior";
            this.caixaAguaSuperior.Size = new System.Drawing.Size(267, 418);
            this.caixaAguaSuperior.Step = 10;
            this.caixaAguaSuperior.Style = VerticalProgressBar.Styles.Solid;
            this.caixaAguaSuperior.TabIndex = 2;
            this.caixaAguaSuperior.Value = 0;
            // 
            // canoSuperiorPrimario
            // 
            this.canoSuperiorPrimario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.canoSuperiorPrimario.Location = new System.Drawing.Point(405, -1);
            this.canoSuperiorPrimario.Name = "canoSuperiorPrimario";
            this.canoSuperiorPrimario.Size = new System.Drawing.Size(40, 153);
            this.canoSuperiorPrimario.TabIndex = 5;
            // 
            // canoSuperiorSecundario
            // 
            this.canoSuperiorSecundario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.canoSuperiorSecundario.Location = new System.Drawing.Point(405, 111);
            this.canoSuperiorSecundario.Name = "canoSuperiorSecundario";
            this.canoSuperiorSecundario.Size = new System.Drawing.Size(115, 40);
            this.canoSuperiorSecundario.TabIndex = 6;
            // 
            // roscaCanoSuperior
            // 
            this.roscaCanoSuperior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.roscaCanoSuperior.Location = new System.Drawing.Point(508, 96);
            this.roscaCanoSuperior.Name = "roscaCanoSuperior";
            this.roscaCanoSuperior.Size = new System.Drawing.Size(42, 72);
            this.roscaCanoSuperior.TabIndex = 0;
            // 
            // canoCentralSecundario
            // 
            this.canoCentralSecundario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.canoCentralSecundario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.canoCentralSecundario.Location = new System.Drawing.Point(856, 420);
            this.canoCentralSecundario.Name = "canoCentralSecundario";
            this.canoCentralSecundario.Size = new System.Drawing.Size(93, 40);
            this.canoCentralSecundario.TabIndex = 8;
            // 
            // roscaCanoInferior
            // 
            this.roscaCanoInferior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.roscaCanoInferior.Location = new System.Drawing.Point(820, 405);
            this.roscaCanoInferior.Name = "roscaCanoInferior";
            this.roscaCanoInferior.Size = new System.Drawing.Size(40, 72);
            this.roscaCanoInferior.TabIndex = 9;
            // 
            // painelCaixaAguaInferior
            // 
            this.painelCaixaAguaInferior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.painelCaixaAguaInferior.Controls.Add(this.caixaAguaInferior);
            this.painelCaixaAguaInferior.Location = new System.Drawing.Point(955, 67);
            this.painelCaixaAguaInferior.Name = "painelCaixaAguaInferior";
            this.painelCaixaAguaInferior.Size = new System.Drawing.Size(280, 440);
            this.painelCaixaAguaInferior.TabIndex = 10;
            // 
            // caixaAguaInferior
            // 
            this.caixaAguaInferior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caixaAguaInferior.BorderStyle = VerticalProgressBar.BorderStyles.None;
            this.caixaAguaInferior.Color = System.Drawing.Color.Blue;
            this.caixaAguaInferior.Location = new System.Drawing.Point(3, 3);
            this.caixaAguaInferior.Maximum = 100;
            this.caixaAguaInferior.Minimum = 0;
            this.caixaAguaInferior.Name = "caixaAguaInferior";
            this.caixaAguaInferior.Size = new System.Drawing.Size(270, 418);
            this.caixaAguaInferior.Step = 10;
            this.caixaAguaInferior.Style = VerticalProgressBar.Styles.Solid;
            this.caixaAguaInferior.TabIndex = 0;
            this.caixaAguaInferior.Value = 0;
            // 
            // roscaCentral
            // 
            this.roscaCentral.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.roscaCentral.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.roscaCentral.Location = new System.Drawing.Point(919, 405);
            this.roscaCentral.Name = "roscaCentral";
            this.roscaCentral.Size = new System.Drawing.Size(40, 72);
            this.roscaCentral.TabIndex = 11;
            // 
            // canoInferiorSecundario
            // 
            this.canoInferiorSecundario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.canoInferiorSecundario.Location = new System.Drawing.Point(1295, -1);
            this.canoInferiorSecundario.Name = "canoInferiorSecundario";
            this.canoInferiorSecundario.Size = new System.Drawing.Size(40, 461);
            this.canoInferiorSecundario.TabIndex = 12;
            // 
            // canoInferiorPrimario
            // 
            this.canoInferiorPrimario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.canoInferiorPrimario.Location = new System.Drawing.Point(1234, 420);
            this.canoInferiorPrimario.Name = "canoInferiorPrimario";
            this.canoInferiorPrimario.Size = new System.Drawing.Size(101, 40);
            this.canoInferiorPrimario.TabIndex = 13;
            // 
            // roscaCentralInforior
            // 
            this.roscaCentralInforior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.roscaCentralInforior.Location = new System.Drawing.Point(1234, 405);
            this.roscaCentralInforior.Name = "roscaCentralInforior";
            this.roscaCentralInforior.Size = new System.Drawing.Size(40, 72);
            this.roscaCentralInforior.TabIndex = 14;
            // 
            // motorDesligamento
            // 
            this.motorDesligamento.BackColor = System.Drawing.Color.Yellow;
            this.motorDesligamento.Location = new System.Drawing.Point(682, 544);
            this.motorDesligamento.Name = "motorDesligamento";
            this.motorDesligamento.Size = new System.Drawing.Size(165, 100);
            this.motorDesligamento.TabIndex = 16;
            // 
            // bombaAgua
            // 
            this.bombaAgua.BackColor = System.Drawing.Color.Yellow;
            this.bombaAgua.Location = new System.Drawing.Point(1093, 544);
            this.bombaAgua.Name = "bombaAgua";
            this.bombaAgua.Size = new System.Drawing.Size(165, 100);
            this.bombaAgua.TabIndex = 18;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Yellow;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(830, 473);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(17, 75);
            this.flowLayoutPanel4.TabIndex = 19;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Yellow;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(1241, 473);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(17, 75);
            this.flowLayoutPanel5.TabIndex = 20;
            // 
            // painelLigarMotor
            // 
            this.painelLigarMotor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelLigarMotor.BackgroundImage")));
            this.painelLigarMotor.Controls.Add(this.botaoMotor);
            this.painelLigarMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelLigarMotor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelLigarMotor.Location = new System.Drawing.Point(456, 544);
            this.painelLigarMotor.Name = "painelLigarMotor";
            this.painelLigarMotor.Size = new System.Drawing.Size(200, 100);
            this.painelLigarMotor.TabIndex = 21;
            this.painelLigarMotor.TabStop = false;
            this.painelLigarMotor.Text = "Motor ";
            // 
            // botaoMotor
            // 
            this.botaoMotor.BackColor = System.Drawing.Color.Red;
            this.botaoMotor.Enabled = false;
            this.botaoMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMotor.Location = new System.Drawing.Point(16, 34);
            this.botaoMotor.Name = "botaoMotor";
            this.botaoMotor.Size = new System.Drawing.Size(157, 40);
            this.botaoMotor.TabIndex = 22;
            this.botaoMotor.Text = "Desligado";
            this.botaoMotor.UseVisualStyleBackColor = false;
            this.botaoMotor.Click += new System.EventHandler(this.botaoMotor_Click);
            // 
            // painelBomba
            // 
            this.painelBomba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelBomba.BackgroundImage")));
            this.painelBomba.Controls.Add(this.botaoBomba);
            this.painelBomba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelBomba.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelBomba.Location = new System.Drawing.Point(870, 544);
            this.painelBomba.Name = "painelBomba";
            this.painelBomba.Size = new System.Drawing.Size(200, 100);
            this.painelBomba.TabIndex = 22;
            this.painelBomba.TabStop = false;
            this.painelBomba.Text = "Bomba D\'Água";
            // 
            // botaoBomba
            // 
            this.botaoBomba.BackColor = System.Drawing.Color.Red;
            this.botaoBomba.Enabled = false;
            this.botaoBomba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBomba.Location = new System.Drawing.Point(16, 34);
            this.botaoBomba.Name = "botaoBomba";
            this.botaoBomba.Size = new System.Drawing.Size(157, 40);
            this.botaoBomba.TabIndex = 22;
            this.botaoBomba.Text = "Desligado";
            this.botaoBomba.UseVisualStyleBackColor = false;
            this.botaoBomba.Click += new System.EventHandler(this.botaoBomba_Click);
            // 
            // painelNivelRecipienteSuperior
            // 
            this.painelNivelRecipienteSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelNivelRecipienteSuperior.BackgroundImage")));
            this.painelNivelRecipienteSuperior.Controls.Add(this.nivelSuperiorText);
            this.painelNivelRecipienteSuperior.Controls.Add(this.lblNivelSuperior);
            this.painelNivelRecipienteSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelNivelRecipienteSuperior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelNivelRecipienteSuperior.Location = new System.Drawing.Point(544, 6);
            this.painelNivelRecipienteSuperior.Name = "painelNivelRecipienteSuperior";
            this.painelNivelRecipienteSuperior.Size = new System.Drawing.Size(280, 58);
            this.painelNivelRecipienteSuperior.TabIndex = 23;
            this.painelNivelRecipienteSuperior.TabStop = false;
            this.painelNivelRecipienteSuperior.Text = "Recipiente Superior";
            // 
            // nivelSuperiorText
            // 
            this.nivelSuperiorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nivelSuperiorText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nivelSuperiorText.Location = new System.Drawing.Point(112, 22);
            this.nivelSuperiorText.Name = "nivelSuperiorText";
            this.nivelSuperiorText.ReadOnly = true;
            this.nivelSuperiorText.Size = new System.Drawing.Size(100, 26);
            this.nivelSuperiorText.TabIndex = 1;
            this.nivelSuperiorText.Text = "0,00";
            this.nivelSuperiorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNivelSuperior
            // 
            this.lblNivelSuperior.AutoSize = true;
            this.lblNivelSuperior.Location = new System.Drawing.Point(38, 25);
            this.lblNivelSuperior.Name = "lblNivelSuperior";
            this.lblNivelSuperior.Size = new System.Drawing.Size(47, 20);
            this.lblNivelSuperior.TabIndex = 0;
            this.lblNivelSuperior.Text = "Nível";
            // 
            // painelRecipienteInferior
            // 
            this.painelRecipienteInferior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelRecipienteInferior.BackgroundImage")));
            this.painelRecipienteInferior.Controls.Add(this.nivelInferiorText);
            this.painelRecipienteInferior.Controls.Add(this.label6);
            this.painelRecipienteInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelRecipienteInferior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelRecipienteInferior.Location = new System.Drawing.Point(955, 3);
            this.painelRecipienteInferior.Name = "painelRecipienteInferior";
            this.painelRecipienteInferior.Size = new System.Drawing.Size(280, 58);
            this.painelRecipienteInferior.TabIndex = 24;
            this.painelRecipienteInferior.TabStop = false;
            this.painelRecipienteInferior.Text = "Recipiente Inferior";
            // 
            // nivelInferiorText
            // 
            this.nivelInferiorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nivelInferiorText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nivelInferiorText.Location = new System.Drawing.Point(119, 19);
            this.nivelInferiorText.Name = "nivelInferiorText";
            this.nivelInferiorText.ReadOnly = true;
            this.nivelInferiorText.Size = new System.Drawing.Size(100, 26);
            this.nivelInferiorText.TabIndex = 2;
            this.nivelInferiorText.Text = "0,00";
            this.nivelInferiorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nível";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.botaoAtivar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(16, 546);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 72);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ligar Sistema Embarcado";
            // 
            // botaoAtivar
            // 
            this.botaoAtivar.BackColor = System.Drawing.Color.Red;
            this.botaoAtivar.Enabled = false;
            this.botaoAtivar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAtivar.Image")));
            this.botaoAtivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoAtivar.Location = new System.Drawing.Point(106, 25);
            this.botaoAtivar.Name = "botaoAtivar";
            this.botaoAtivar.Size = new System.Drawing.Size(146, 40);
            this.botaoAtivar.TabIndex = 0;
            this.botaoAtivar.Text = "Desligado";
            this.botaoAtivar.UseVisualStyleBackColor = false;
            this.botaoAtivar.Click += new System.EventHandler(this.botaoAtivar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(710, 544);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(23, 100);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(778, 544);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(23, 100);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1120, 544);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(23, 100);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Location = new System.Drawing.Point(1205, 544);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(23, 100);
            this.flowLayoutPanel6.TabIndex = 30;
            // 
            // botaoAtualizarSerial
            // 
            this.botaoAtualizarSerial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAtualizarSerial.BackgroundImage")));
            this.botaoAtualizarSerial.Image = ((System.Drawing.Image)(resources.GetObject("botaoAtualizarSerial.Image")));
            this.botaoAtualizarSerial.Location = new System.Drawing.Point(283, 14);
            this.botaoAtualizarSerial.Name = "botaoAtualizarSerial";
            this.botaoAtualizarSerial.Size = new System.Drawing.Size(44, 30);
            this.botaoAtualizarSerial.TabIndex = 5;
            this.botaoAtualizarSerial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoAtualizarSerial.UseVisualStyleBackColor = true;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 708);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.painelRecipienteInferior);
            this.Controls.Add(this.painelNivelRecipienteSuperior);
            this.Controls.Add(this.painelBomba);
            this.Controls.Add(this.painelLigarMotor);
            this.Controls.Add(this.bombaAgua);
            this.Controls.Add(this.motorDesligamento);
            this.Controls.Add(this.roscaCentralInforior);
            this.Controls.Add(this.canoInferiorPrimario);
            this.Controls.Add(this.canoInferiorSecundario);
            this.Controls.Add(this.roscaCentral);
            this.Controls.Add(this.painelCaixaAguaInferior);
            this.Controls.Add(this.roscaCanoSuperior);
            this.Controls.Add(this.canoSuperiorSecundario);
            this.Controls.Add(this.roscaCanoInferior);
            this.Controls.Add(this.canoCentralSecundario);
            this.Controls.Add(this.canoSuperiorPrimario);
            this.Controls.Add(this.painelCaixaAguaSuperior);
            this.Controls.Add(this.painelConfiguracaoSerial);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPrincipal";
            this.Text = "Sistema Supervisório - Sistemas Embarcados - Engenharia de Computação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.painelConfiguracaoSerial.ResumeLayout(false);
            this.painelStatus.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.painelParidade.ResumeLayout(false);
            this.painelParidade.PerformLayout();
            this.painelBitsDados.ResumeLayout(false);
            this.painelBitsDados.PerformLayout();
            this.painelBitSegundos.ResumeLayout(false);
            this.painelBitSegundos.PerformLayout();
            this.painelPortaSerial.ResumeLayout(false);
            this.painelPortaSerial.PerformLayout();
            this.painelCaixaAguaSuperior.ResumeLayout(false);
            this.painelCaixaAguaInferior.ResumeLayout(false);
            this.painelLigarMotor.ResumeLayout(false);
            this.painelBomba.ResumeLayout(false);
            this.painelNivelRecipienteSuperior.ResumeLayout(false);
            this.painelNivelRecipienteSuperior.PerformLayout();
            this.painelRecipienteInferior.ResumeLayout(false);
            this.painelRecipienteInferior.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnLigado;
        public System.Windows.Forms.Button btnDesligado;
        public System.Windows.Forms.GroupBox painelConfiguracaoSerial;
        public System.Windows.Forms.ComboBox listaPortas;
        public System.Windows.Forms.GroupBox painelPortaSerial;
        public System.Windows.Forms.Label lblPorta;
        public System.Windows.Forms.GroupBox painelBitsDados;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox listaBitsDados;
        public System.Windows.Forms.GroupBox painelBitSegundos;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox listaBitsSegundo;
        public System.Windows.Forms.GroupBox painelParidade;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox listaParidade;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox listaBitsParada;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox listaControleFluxo;
        public System.Windows.Forms.GroupBox painelStatus;
        public System.Windows.Forms.FlowLayoutPanel painelCaixaAguaSuperior;
        public System.Windows.Forms.FlowLayoutPanel canoSuperiorPrimario;
        public System.Windows.Forms.FlowLayoutPanel canoSuperiorSecundario;
        public System.Windows.Forms.FlowLayoutPanel roscaCanoSuperior;
        public System.Windows.Forms.FlowLayoutPanel canoCentralSecundario;
        public System.Windows.Forms.FlowLayoutPanel roscaCanoInferior;
        public System.Windows.Forms.FlowLayoutPanel painelCaixaAguaInferior;
        public System.Windows.Forms.FlowLayoutPanel roscaCentral;
        public System.Windows.Forms.FlowLayoutPanel canoInferiorSecundario;
        public System.Windows.Forms.FlowLayoutPanel canoInferiorPrimario;
        public System.Windows.Forms.FlowLayoutPanel roscaCentralInforior;
        public VerticalProgressBar.VerticalProgressBar caixaAguaSuperior;
        public VerticalProgressBar.VerticalProgressBar caixaAguaInferior;
        public System.Windows.Forms.FlowLayoutPanel motorDesligamento;
        public System.Windows.Forms.FlowLayoutPanel bombaAgua;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        public System.Windows.Forms.Button conexao;
        public System.Windows.Forms.GroupBox painelLigarMotor;
        public System.Windows.Forms.Button botaoMotor;
        public System.Windows.Forms.GroupBox painelBomba;
        public System.Windows.Forms.Button botaoBomba;
        public System.Windows.Forms.GroupBox painelNivelRecipienteSuperior;
        public System.Windows.Forms.GroupBox painelRecipienteInferior;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox nivelSuperiorText;
        public System.Windows.Forms.Label lblNivelSuperior;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox nivelInferiorText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botaoAtivar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button botaoAtualizarSerial;
    }
}

