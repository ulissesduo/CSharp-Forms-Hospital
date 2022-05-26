namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.paciente = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPrivado = new System.Windows.Forms.RadioButton();
            this.rdbParticular = new System.Windows.Forms.RadioButton();
            this.rdbSus = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExames = new System.Windows.Forms.Label();
            this.lblInternacao = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.ckbexames = new System.Windows.Forms.CheckBox();
            this.ckbInternacao = new System.Windows.Forms.CheckBox();
            this.ckbConsulta = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalFormaPG = new System.Windows.Forms.Label();
            this.rdbAPrazo = new System.Windows.Forms.RadioButton();
            this.rdbAVista = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalPlanoConvenio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalServ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // paciente
            // 
            this.paciente.Location = new System.Drawing.Point(102, 25);
            this.paciente.Name = "paciente";
            this.paciente.Size = new System.Drawing.Size(580, 20);
            this.paciente.TabIndex = 0;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(102, 57);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(580, 20);
            this.telefone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paciente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.telefone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do paciente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPrivado);
            this.groupBox2.Controls.Add(this.rdbParticular);
            this.groupBox2.Controls.Add(this.rdbSus);
            this.groupBox2.Location = new System.Drawing.Point(31, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 58);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plano de saúde";
            // 
            // rdbPrivado
            // 
            this.rdbPrivado.AutoSize = true;
            this.rdbPrivado.Location = new System.Drawing.Point(190, 25);
            this.rdbPrivado.Name = "rdbPrivado";
            this.rdbPrivado.Size = new System.Drawing.Size(61, 17);
            this.rdbPrivado.TabIndex = 6;
            this.rdbPrivado.TabStop = true;
            this.rdbPrivado.Text = "Privado";
            this.rdbPrivado.UseVisualStyleBackColor = true;
            this.rdbPrivado.CheckedChanged += new System.EventHandler(this.rdbPrivado_CheckedChanged);
            // 
            // rdbParticular
            // 
            this.rdbParticular.AutoSize = true;
            this.rdbParticular.Location = new System.Drawing.Point(106, 25);
            this.rdbParticular.Name = "rdbParticular";
            this.rdbParticular.Size = new System.Drawing.Size(69, 17);
            this.rdbParticular.TabIndex = 5;
            this.rdbParticular.TabStop = true;
            this.rdbParticular.Text = "Particular";
            this.rdbParticular.UseVisualStyleBackColor = true;
            this.rdbParticular.CheckedChanged += new System.EventHandler(this.rdbParticular_CheckedChanged);
            // 
            // rdbSus
            // 
            this.rdbSus.AutoSize = true;
            this.rdbSus.Location = new System.Drawing.Point(15, 25);
            this.rdbSus.Name = "rdbSus";
            this.rdbSus.Size = new System.Drawing.Size(47, 17);
            this.rdbSus.TabIndex = 4;
            this.rdbSus.TabStop = true;
            this.rdbSus.Text = "SUS";
            this.rdbSus.UseVisualStyleBackColor = true;
            this.rdbSus.CheckedChanged += new System.EventHandler(this.rdbSus_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExames);
            this.groupBox3.Controls.Add(this.lblInternacao);
            this.groupBox3.Controls.Add(this.lblConsulta);
            this.groupBox3.Controls.Add(this.ckbexames);
            this.groupBox3.Controls.Add(this.ckbInternacao);
            this.groupBox3.Controls.Add(this.ckbConsulta);
            this.groupBox3.Location = new System.Drawing.Point(31, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 112);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.Location = new System.Drawing.Point(187, 70);
            this.lblExames.Name = "lblExames";
            this.lblExames.Size = new System.Drawing.Size(54, 13);
            this.lblExames.TabIndex = 6;
            this.lblExames.Text = "lblExames";
            this.lblExames.Visible = false;
            // 
            // lblInternacao
            // 
            this.lblInternacao.AutoSize = true;
            this.lblInternacao.Location = new System.Drawing.Point(187, 47);
            this.lblInternacao.Name = "lblInternacao";
            this.lblInternacao.Size = new System.Drawing.Size(68, 13);
            this.lblInternacao.TabIndex = 5;
            this.lblInternacao.Text = "lblInternacao";
            this.lblInternacao.Visible = false;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(187, 24);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(58, 13);
            this.lblConsulta.TabIndex = 4;
            this.lblConsulta.Text = "lblConsulta";
            this.lblConsulta.Visible = false;
            // 
            // ckbexames
            // 
            this.ckbexames.AutoSize = true;
            this.ckbexames.Location = new System.Drawing.Point(15, 66);
            this.ckbexames.Name = "ckbexames";
            this.ckbexames.Size = new System.Drawing.Size(126, 17);
            this.ckbexames.TabIndex = 2;
            this.ckbexames.Text = "Exames Laboratoriais";
            this.ckbexames.UseVisualStyleBackColor = true;
            this.ckbexames.CheckedChanged += new System.EventHandler(this.ckbexames_CheckedChanged);
            // 
            // ckbInternacao
            // 
            this.ckbInternacao.AutoSize = true;
            this.ckbInternacao.Location = new System.Drawing.Point(15, 43);
            this.ckbInternacao.Name = "ckbInternacao";
            this.ckbInternacao.Size = new System.Drawing.Size(77, 17);
            this.ckbInternacao.TabIndex = 1;
            this.ckbInternacao.Text = "Internação";
            this.ckbInternacao.UseVisualStyleBackColor = true;
            this.ckbInternacao.CheckedChanged += new System.EventHandler(this.ckbInternacao_CheckedChanged);
            // 
            // ckbConsulta
            // 
            this.ckbConsulta.AutoSize = true;
            this.ckbConsulta.Location = new System.Drawing.Point(15, 20);
            this.ckbConsulta.Name = "ckbConsulta";
            this.ckbConsulta.Size = new System.Drawing.Size(67, 17);
            this.ckbConsulta.TabIndex = 0;
            this.ckbConsulta.Text = "Consulta";
            this.ckbConsulta.UseVisualStyleBackColor = true;
            this.ckbConsulta.CheckedChanged += new System.EventHandler(this.ckbConsulta_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalFormaPG);
            this.groupBox4.Controls.Add(this.rdbAPrazo);
            this.groupBox4.Controls.Add(this.rdbAVista);
            this.groupBox4.Location = new System.Drawing.Point(25, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 58);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forma de Pagamento";
            // 
            // lblTotalFormaPG
            // 
            this.lblTotalFormaPG.AutoSize = true;
            this.lblTotalFormaPG.Location = new System.Drawing.Point(187, 27);
            this.lblTotalFormaPG.Name = "lblTotalFormaPG";
            this.lblTotalFormaPG.Size = new System.Drawing.Size(85, 13);
            this.lblTotalFormaPG.TabIndex = 9;
            this.lblTotalFormaPG.Text = "lblTotalFormaPG";
            this.lblTotalFormaPG.Visible = false;
            // 
            // rdbAPrazo
            // 
            this.rdbAPrazo.AutoSize = true;
            this.rdbAPrazo.Enabled = false;
            this.rdbAPrazo.Location = new System.Drawing.Point(106, 25);
            this.rdbAPrazo.Name = "rdbAPrazo";
            this.rdbAPrazo.Size = new System.Drawing.Size(60, 17);
            this.rdbAPrazo.TabIndex = 5;
            this.rdbAPrazo.TabStop = true;
            this.rdbAPrazo.Text = "à prazo";
            this.rdbAPrazo.UseVisualStyleBackColor = true;
            this.rdbAPrazo.CheckedChanged += new System.EventHandler(this.rdbAPazo_CheckedChanged);
            // 
            // rdbAVista
            // 
            this.rdbAVista.AutoSize = true;
            this.rdbAVista.Enabled = false;
            this.rdbAVista.Location = new System.Drawing.Point(15, 25);
            this.rdbAVista.Name = "rdbAVista";
            this.rdbAVista.Size = new System.Drawing.Size(56, 17);
            this.rdbAVista.TabIndex = 4;
            this.rdbAVista.TabStop = true;
            this.rdbAVista.Text = "à vista";
            this.rdbAVista.UseVisualStyleBackColor = true;
            this.rdbAVista.CheckedChanged += new System.EventHandler(this.rdbAVista_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalPlanoConvenio);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lblTotalPagar);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lblTotalServ);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Location = new System.Drawing.Point(372, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(373, 230);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Forma de Pagamento";
            // 
            // lblTotalPlanoConvenio
            // 
            this.lblTotalPlanoConvenio.AutoSize = true;
            this.lblTotalPlanoConvenio.Location = new System.Drawing.Point(22, 205);
            this.lblTotalPlanoConvenio.Name = "lblTotalPlanoConvenio";
            this.lblTotalPlanoConvenio.Size = new System.Drawing.Size(118, 13);
            this.lblTotalPlanoConvenio.TabIndex = 12;
            this.lblTotalPlanoConvenio.Text = "lblTotalPlano/Convenio";
            this.lblTotalPlanoConvenio.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor total de Serviços:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(187, 136);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(69, 13);
            this.lblTotalPagar.TabIndex = 10;
            this.lblTotalPagar.Text = "lblTotalPagar";
            this.lblTotalPagar.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total a pagar:";
            // 
            // lblTotalServ
            // 
            this.lblTotalServ.AutoSize = true;
            this.lblTotalServ.Location = new System.Drawing.Point(187, 26);
            this.lblTotalServ.Name = "lblTotalServ";
            this.lblTotalServ.Size = new System.Drawing.Size(63, 13);
            this.lblTotalServ.TabIndex = 8;
            this.lblTotalServ.Text = "lblTotalServ";
            this.lblTotalServ.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor total de Serviços:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnEncerrar);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.btnCalcular);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(31, 392);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(714, 46);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Operações";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(556, 17);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(119, 23);
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.Text = "&Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Calculadora";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(251, 17);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "C&alcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox paciente;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPrivado;
        private System.Windows.Forms.RadioButton rdbParticular;
        private System.Windows.Forms.RadioButton rdbSus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExames;
        private System.Windows.Forms.Label lblInternacao;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.CheckBox ckbexames;
        private System.Windows.Forms.CheckBox ckbInternacao;
        private System.Windows.Forms.CheckBox ckbConsulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalFormaPG;
        private System.Windows.Forms.RadioButton rdbAPrazo;
        private System.Windows.Forms.RadioButton rdbAVista;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotalPlanoConvenio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalServ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
    }
}

