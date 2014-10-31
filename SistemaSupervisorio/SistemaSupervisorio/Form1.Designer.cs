namespace WindowsFormsApplication1
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.btnLigado = new System.Windows.Forms.Button();
            this.btnDesligado = new System.Windows.Forms.Button();
            this.painelConfiguracaoSerial = new System.Windows.Forms.GroupBox();
            this.painelStatus = new System.Windows.Forms.GroupBox();
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
            this.painelConfiguracaoSerial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.painelParidade.SuspendLayout();
            this.painelBitsDados.SuspendLayout();
            this.painelBitSegundos.SuspendLayout();
            this.painelPortaSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLigado
            // 
            this.btnLigado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLigado.BackgroundImage")));
            this.btnLigado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLigado.Image = ((System.Drawing.Image)(resources.GetObject("btnLigado.Image")));
            this.btnLigado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLigado.ImageKey = "(none)";
            this.btnLigado.Location = new System.Drawing.Point(33, 471);
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
            this.painelConfiguracaoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.painelStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.painelStatus.Location = new System.Drawing.Point(6, 380);
            this.painelStatus.Name = "painelStatus";
            this.painelStatus.Size = new System.Drawing.Size(342, 63);
            this.painelStatus.TabIndex = 11;
            this.painelStatus.TabStop = false;
            this.painelStatus.Text = "Conexão";
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
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 559);
            this.Controls.Add(this.painelConfiguracaoSerial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPrincipal";
            this.Text = "Sistema Supervisório  Controle de Nível  de Àgua - Sistemas Embarcados - Engenhar" +
                "ia da Computação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.painelConfiguracaoSerial.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLigado;
        private System.Windows.Forms.Button btnDesligado;
        private System.Windows.Forms.GroupBox painelConfiguracaoSerial;
        private System.Windows.Forms.ComboBox listaPortas;
        private System.Windows.Forms.GroupBox painelPortaSerial;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.GroupBox painelBitsDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listaBitsDados;
        private System.Windows.Forms.GroupBox painelBitSegundos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaBitsSegundo;
        private System.Windows.Forms.GroupBox painelParidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox listaParidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listaBitsParada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listaControleFluxo;
        private System.Windows.Forms.GroupBox painelStatus;
    }
}

