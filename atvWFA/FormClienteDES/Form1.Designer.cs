namespace FormClienteDES
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
            this.GPB_dados = new System.Windows.Forms.GroupBox();
            this.TB_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_telRes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RB_fem = new System.Windows.Forms.RadioButton();
            this.RB_masc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_bairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_logr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_cep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.limparFoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_insta = new System.Windows.Forms.TextBox();
            this.LB_insta = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TB_email = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CB_email = new System.Windows.Forms.CheckBox();
            this.CB_insta = new System.Windows.Forms.CheckBox();
            this.GPB_dados.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPB_dados
            // 
            this.GPB_dados.Controls.Add(this.TB_tel);
            this.GPB_dados.Controls.Add(this.label6);
            this.GPB_dados.Controls.Add(this.TB_telRes);
            this.GPB_dados.Controls.Add(this.label5);
            this.GPB_dados.Controls.Add(this.TB_cpf);
            this.GPB_dados.Controls.Add(this.label4);
            this.GPB_dados.Controls.Add(this.TB_rg);
            this.GPB_dados.Controls.Add(this.label3);
            this.GPB_dados.Controls.Add(this.TB_nome);
            this.GPB_dados.Controls.Add(this.label2);
            this.GPB_dados.Controls.Add(this.TB_codigo);
            this.GPB_dados.Controls.Add(this.label1);
            this.GPB_dados.Location = new System.Drawing.Point(7, 13);
            this.GPB_dados.Name = "GPB_dados";
            this.GPB_dados.Size = new System.Drawing.Size(839, 199);
            this.GPB_dados.TabIndex = 0;
            this.GPB_dados.TabStop = false;
            this.GPB_dados.Text = "Dados Pessoais";
            this.GPB_dados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TB_tel
            // 
            this.TB_tel.Location = new System.Drawing.Point(496, 130);
            this.TB_tel.Name = "TB_tel";
            this.TB_tel.Size = new System.Drawing.Size(337, 20);
            this.TB_tel.TabIndex = 11;
            this.TB_tel.Tag = "codigo";
            this.TB_tel.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tel:";
            // 
            // TB_telRes
            // 
            this.TB_telRes.Location = new System.Drawing.Point(121, 130);
            this.TB_telRes.Name = "TB_telRes";
            this.TB_telRes.Size = new System.Drawing.Size(301, 20);
            this.TB_telRes.TabIndex = 9;
            this.TB_telRes.Tag = "codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tel. Residencial:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TB_cpf
            // 
            this.TB_cpf.Location = new System.Drawing.Point(496, 104);
            this.TB_cpf.Name = "TB_cpf";
            this.TB_cpf.Size = new System.Drawing.Size(337, 20);
            this.TB_cpf.TabIndex = 7;
            this.TB_cpf.Tag = "codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // TB_rg
            // 
            this.TB_rg.Location = new System.Drawing.Point(77, 104);
            this.TB_rg.Name = "TB_rg";
            this.TB_rg.Size = new System.Drawing.Size(337, 20);
            this.TB_rg.TabIndex = 5;
            this.TB_rg.Tag = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TB_nome
            // 
            this.TB_nome.Location = new System.Drawing.Point(77, 78);
            this.TB_nome.Name = "TB_nome";
            this.TB_nome.Size = new System.Drawing.Size(534, 20);
            this.TB_nome.TabIndex = 3;
            this.TB_nome.Tag = "codigo";
            this.TB_nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_codigo
            // 
            this.TB_codigo.Location = new System.Drawing.Point(77, 52);
            this.TB_codigo.Name = "TB_codigo";
            this.TB_codigo.Size = new System.Drawing.Size(337, 20);
            this.TB_codigo.TabIndex = 1;
            this.TB_codigo.Tag = "codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RB_fem);
            this.groupBox4.Controls.Add(this.RB_masc);
            this.groupBox4.Location = new System.Drawing.Point(7, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1146, 68);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo";
            // 
            // RB_fem
            // 
            this.RB_fem.AutoSize = true;
            this.RB_fem.Location = new System.Drawing.Point(109, 29);
            this.RB_fem.Name = "RB_fem";
            this.RB_fem.Size = new System.Drawing.Size(67, 17);
            this.RB_fem.TabIndex = 1;
            this.RB_fem.TabStop = true;
            this.RB_fem.Text = "Feminino";
            this.RB_fem.UseVisualStyleBackColor = true;
            // 
            // RB_masc
            // 
            this.RB_masc.AutoSize = true;
            this.RB_masc.Location = new System.Drawing.Point(30, 29);
            this.RB_masc.Name = "RB_masc";
            this.RB_masc.Size = new System.Drawing.Size(73, 17);
            this.RB_masc.TabIndex = 0;
            this.RB_masc.TabStop = true;
            this.RB_masc.Text = "Masculino";
            this.RB_masc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_cidade);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TB_bairro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TB_numero);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TB_logr);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.TB_cep);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1146, 86);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // TB_cidade
            // 
            this.TB_cidade.Location = new System.Drawing.Point(632, 51);
            this.TB_cidade.Name = "TB_cidade";
            this.TB_cidade.Size = new System.Drawing.Size(229, 20);
            this.TB_cidade.TabIndex = 11;
            this.TB_cidade.Tag = "codigo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(583, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade:";
            // 
            // TB_bairro
            // 
            this.TB_bairro.Location = new System.Drawing.Point(262, 51);
            this.TB_bairro.Name = "TB_bairro";
            this.TB_bairro.Size = new System.Drawing.Size(311, 20);
            this.TB_bairro.TabIndex = 9;
            this.TB_bairro.Tag = "codigo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bairro:";
            // 
            // TB_numero
            // 
            this.TB_numero.Location = new System.Drawing.Point(87, 51);
            this.TB_numero.Name = "TB_numero";
            this.TB_numero.Size = new System.Drawing.Size(91, 20);
            this.TB_numero.TabIndex = 7;
            this.TB_numero.Tag = "codigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número:";
            // 
            // TB_logr
            // 
            this.TB_logr.Location = new System.Drawing.Point(384, 25);
            this.TB_logr.Name = "TB_logr";
            this.TB_logr.Size = new System.Drawing.Size(477, 20);
            this.TB_logr.TabIndex = 5;
            this.TB_logr.Tag = "codigo";
            this.TB_logr.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Logradouro:";
            // 
            // TB_cep
            // 
            this.TB_cep.Location = new System.Drawing.Point(87, 25);
            this.TB_cep.Name = "TB_cep";
            this.TB_cep.Size = new System.Drawing.Size(169, 20);
            this.TB_cep.TabIndex = 3;
            this.TB_cep.Tag = "codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CEP:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1114, 131);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Extras";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(659, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "constitucional";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(659, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "E-mail";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(128, 45);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(524, 20);
            this.textBox13.TabIndex = 7;
            this.textBox13.Tag = "codigo";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "E-mail constitucional:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(60, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(592, 20);
            this.textBox12.TabIndex = 5;
            this.textBox12.Tag = "codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "E-mail:";
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(7, 568);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(186, 58);
            this.buttonIncluir.TabIndex = 16;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.ButtonIncluir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 58);
            this.button2.TabIndex = 17;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(391, 568);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(186, 58);
            this.buttonConsultar.TabIndex = 18;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.ButtonConsultar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(775, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 58);
            this.button4.TabIndex = 19;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(583, 568);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(186, 58);
            this.buttonLimpar.TabIndex = 20;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(967, 568);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(186, 58);
            this.buttonSair.TabIndex = 21;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.Button6_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackgroundImage = global::FormClienteDES.Properties.Resources.furia;
            this.pcbFoto.Location = new System.Drawing.Point(918, 13);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(209, 199);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 22;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.Click += new System.EventHandler(this.PcbFoto_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(871, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 58);
            this.button7.TabIndex = 23;
            this.button7.Text = "Carregar imagem";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // limparFoto
            // 
            this.limparFoto.Location = new System.Drawing.Point(1002, 232);
            this.limparFoto.Name = "limparFoto";
            this.limparFoto.Size = new System.Drawing.Size(132, 58);
            this.limparFoto.TabIndex = 24;
            this.limparFoto.Text = "Limpar Imagem";
            this.limparFoto.UseVisualStyleBackColor = true;
            this.limparFoto.Click += new System.EventHandler(this.LimparFoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_insta);
            this.groupBox1.Controls.Add(this.CB_email);
            this.groupBox1.Controls.Add(this.TB_insta);
            this.groupBox1.Controls.Add(this.LB_insta);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.TB_email);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(7, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados extras ";
            // 
            // TB_insta
            // 
            this.TB_insta.Location = new System.Drawing.Point(87, 51);
            this.TB_insta.Name = "TB_insta";
            this.TB_insta.Size = new System.Drawing.Size(701, 20);
            this.TB_insta.TabIndex = 7;
            this.TB_insta.Tag = "codigo";
            // 
            // LB_insta
            // 
            this.LB_insta.AutoSize = true;
            this.LB_insta.Location = new System.Drawing.Point(16, 54);
            this.LB_insta.Name = "LB_insta";
            this.LB_insta.Size = new System.Drawing.Size(56, 13);
            this.LB_insta.TabIndex = 6;
            this.LB_insta.Text = "Instagram:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(6, 208);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1114, 131);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dados Extras";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(659, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "constitucional";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(659, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "E-mail";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(524, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Tag = "codigo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "E-mail constitucional:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(60, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(592, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Tag = "codigo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "E-mail:";
            // 
            // TB_email
            // 
            this.TB_email.Location = new System.Drawing.Point(87, 25);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(701, 20);
            this.TB_email.TabIndex = 3;
            this.TB_email.Tag = "codigo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Email:";
            // 
            // CB_email
            // 
            this.CB_email.AutoSize = true;
            this.CB_email.Location = new System.Drawing.Point(809, 27);
            this.CB_email.Name = "CB_email";
            this.CB_email.Size = new System.Drawing.Size(51, 17);
            this.CB_email.TabIndex = 16;
            this.CB_email.Text = "Email";
            this.CB_email.UseVisualStyleBackColor = true;
            this.CB_email.CheckedChanged += new System.EventHandler(this.CB_email_CheckedChanged);
            // 
            // CB_insta
            // 
            this.CB_insta.AutoSize = true;
            this.CB_insta.Location = new System.Drawing.Point(809, 51);
            this.CB_insta.Name = "CB_insta";
            this.CB_insta.Size = new System.Drawing.Size(72, 17);
            this.CB_insta.TabIndex = 17;
            this.CB_insta.Text = "Instagram";
            this.CB_insta.UseVisualStyleBackColor = true;
            this.CB_insta.CheckedChanged += new System.EventHandler(this.CB_insta_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limparFoto);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GPB_dados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GPB_dados.ResumeLayout(false);
            this.GPB_dados.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPB_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_codigo;
        private System.Windows.Forms.TextBox TB_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_telRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RB_fem;
        private System.Windows.Forms.RadioButton RB_masc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_bairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_logr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_cep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button limparFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_insta;
        private System.Windows.Forms.Label LB_insta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox CB_insta;
        private System.Windows.Forms.CheckBox CB_email;
    }
}

