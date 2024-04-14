
namespace _4Tec.Forms.Pessoas
{
    partial class FrmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFuncionario));
            this.TxbCargo = new System.Windows.Forms.TextBox();
            this.TxbCidade = new System.Windows.Forms.TextBox();
            this.TxbNomeFuncionario = new System.Windows.Forms.TextBox();
            this.TxbEndereco = new System.Windows.Forms.TextBox();
            this.CbbSexo = new System.Windows.Forms.ComboBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CbbStatus = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnConsultaCidade = new System.Windows.Forms.Button();
            this.BtnConsultaCargo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TxbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.TxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.TxbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TxbRg = new System.Windows.Forms.MaskedTextBox();
            this.TxbSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxbCargo
            // 
            this.TxbCargo.Location = new System.Drawing.Point(82, 39);
            this.TxbCargo.Name = "TxbCargo";
            this.TxbCargo.Size = new System.Drawing.Size(100, 23);
            this.TxbCargo.TabIndex = 0;
            // 
            // TxbCidade
            // 
            this.TxbCidade.Location = new System.Drawing.Point(82, 133);
            this.TxbCidade.Name = "TxbCidade";
            this.TxbCidade.Size = new System.Drawing.Size(100, 23);
            this.TxbCidade.TabIndex = 1;
            // 
            // TxbNomeFuncionario
            // 
            this.TxbNomeFuncionario.Location = new System.Drawing.Point(82, 86);
            this.TxbNomeFuncionario.Name = "TxbNomeFuncionario";
            this.TxbNomeFuncionario.Size = new System.Drawing.Size(397, 23);
            this.TxbNomeFuncionario.TabIndex = 2;
            // 
            // TxbEndereco
            // 
            this.TxbEndereco.Location = new System.Drawing.Point(82, 180);
            this.TxbEndereco.Name = "TxbEndereco";
            this.TxbEndereco.Size = new System.Drawing.Size(396, 23);
            this.TxbEndereco.TabIndex = 3;
            // 
            // CbbSexo
            // 
            this.CbbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbSexo.FormattingEnabled = true;
            this.CbbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.CbbSexo.Location = new System.Drawing.Point(266, 368);
            this.CbbSexo.Name = "CbbSexo";
            this.CbbSexo.Size = new System.Drawing.Size(99, 23);
            this.CbbSexo.TabIndex = 9;
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(82, 321);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(399, 23);
            this.TxbEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome do Funcionário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número de telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "RG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data de nascimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "E-mail";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(383, 350);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 15);
            this.LblStatus.TabIndex = 21;
            this.LblStatus.Text = "Status";
            // 
            // CbbStatus
            // 
            this.CbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbStatus.FormattingEnabled = true;
            this.CbbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.CbbStatus.Location = new System.Drawing.Point(380, 368);
            this.CbbStatus.Name = "CbbStatus";
            this.CbbStatus.Size = new System.Drawing.Size(99, 23);
            this.CbbStatus.TabIndex = 10;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(266, 443);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(403, 443);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 12;
            this.BtnCadastrar.Text = "Salvar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnConsultaCidade
            // 
            this.BtnConsultaCidade.Location = new System.Drawing.Point(188, 132);
            this.BtnConsultaCidade.Name = "BtnConsultaCidade";
            this.BtnConsultaCidade.Size = new System.Drawing.Size(17, 23);
            this.BtnConsultaCidade.TabIndex = 2;
            this.BtnConsultaCidade.Text = ">";
            this.BtnConsultaCidade.UseVisualStyleBackColor = true;
            this.BtnConsultaCidade.Click += new System.EventHandler(this.BtnConsultaCidade_Click);
            // 
            // BtnConsultaCargo
            // 
            this.BtnConsultaCargo.Location = new System.Drawing.Point(188, 38);
            this.BtnConsultaCargo.Name = "BtnConsultaCargo";
            this.BtnConsultaCargo.Size = new System.Drawing.Size(17, 23);
            this.BtnConsultaCargo.TabIndex = 0;
            this.BtnConsultaCargo.Text = ">";
            this.BtnConsultaCargo.UseVisualStyleBackColor = true;
            this.BtnConsultaCargo.Click += new System.EventHandler(this.BtnConsultaCargo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Salário";
            // 
            // TxbNascimento
            // 
            this.TxbNascimento.Location = new System.Drawing.Point(82, 368);
            this.TxbNascimento.Mask = "00/00/0000";
            this.TxbNascimento.Name = "TxbNascimento";
            this.TxbNascimento.Size = new System.Drawing.Size(178, 23);
            this.TxbNascimento.TabIndex = 8;
            this.TxbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // TxbCpf
            // 
            this.TxbCpf.Location = new System.Drawing.Point(82, 274);
            this.TxbCpf.Mask = "999.999.999-99";
            this.TxbCpf.Name = "TxbCpf";
            this.TxbCpf.Size = new System.Drawing.Size(193, 23);
            this.TxbCpf.TabIndex = 5;
            // 
            // TxbTelefone
            // 
            this.TxbTelefone.Location = new System.Drawing.Point(82, 227);
            this.TxbTelefone.Mask = "(99) 99999-9999";
            this.TxbTelefone.Name = "TxbTelefone";
            this.TxbTelefone.Size = new System.Drawing.Size(193, 23);
            this.TxbTelefone.TabIndex = 4;
            // 
            // TxbRg
            // 
            this.TxbRg.Location = new System.Drawing.Point(285, 274);
            this.TxbRg.Mask = "99.999.999-9";
            this.TxbRg.Name = "TxbRg";
            this.TxbRg.Size = new System.Drawing.Size(193, 23);
            this.TxbRg.TabIndex = 6;
            // 
            // TxbSalario
            // 
            this.TxbSalario.Location = new System.Drawing.Point(82, 415);
            this.TxbSalario.Name = "TxbSalario";
            this.TxbSalario.Size = new System.Drawing.Size(178, 23);
            this.TxbSalario.TabIndex = 11;
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 514);
            this.Controls.Add(this.TxbSalario);
            this.Controls.Add(this.TxbRg);
            this.Controls.Add(this.TxbTelefone);
            this.Controls.Add(this.TxbCpf);
            this.Controls.Add(this.TxbNascimento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnConsultaCargo);
            this.Controls.Add(this.BtnConsultaCidade);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.CbbStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.CbbSexo);
            this.Controls.Add(this.TxbEndereco);
            this.Controls.Add(this.TxbNomeFuncionario);
            this.Controls.Add(this.TxbCidade);
            this.Controls.Add(this.TxbCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbCargo;
        private System.Windows.Forms.TextBox TxbCidade;
        private System.Windows.Forms.TextBox TxbNomeFuncionario;
        private System.Windows.Forms.TextBox TxbEndereco;
        private System.Windows.Forms.ComboBox CbbSexo;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ComboBox CbbStatus;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnConsultaCidade;
        private System.Windows.Forms.Button BtnConsultaCargo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox TxbNascimento;
        private System.Windows.Forms.MaskedTextBox TxbCpf;
        private System.Windows.Forms.MaskedTextBox TxbTelefone;
        private System.Windows.Forms.MaskedTextBox TxbRg;
        private System.Windows.Forms.TextBox TxbSalario;
    }
}