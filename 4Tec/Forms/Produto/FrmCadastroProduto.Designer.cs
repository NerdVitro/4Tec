
namespace _4Tec.Forms.Produto
{
    partial class FrmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProduto));
            this.BtnConsultaMarca = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CbbStatus = new System.Windows.Forms.ComboBox();
            this.TxbMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxbNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnConsultaMarca
            // 
            this.BtnConsultaMarca.Location = new System.Drawing.Point(282, 53);
            this.BtnConsultaMarca.Name = "BtnConsultaMarca";
            this.BtnConsultaMarca.Size = new System.Drawing.Size(19, 23);
            this.BtnConsultaMarca.TabIndex = 0;
            this.BtnConsultaMarca.Text = ">";
            this.BtnConsultaMarca.UseVisualStyleBackColor = true;
            this.BtnConsultaMarca.Click += new System.EventHandler(this.BtnConsultaMarca_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(89, 169);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 15);
            this.LblStatus.TabIndex = 100007;
            this.LblStatus.Text = "Status";
            this.LblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            // 
            // CbbStatus
            // 
            this.CbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbStatus.FormattingEnabled = true;
            this.CbbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.CbbStatus.Location = new System.Drawing.Point(89, 187);
            this.CbbStatus.Name = "CbbStatus";
            this.CbbStatus.Size = new System.Drawing.Size(99, 23);
            this.CbbStatus.TabIndex = 2;
            this.CbbStatus.SelectedIndexChanged += new System.EventHandler(this.CbbStatus_SelectedIndexChanged);
            // 
            // TxbMarca
            // 
            this.TxbMarca.Location = new System.Drawing.Point(89, 53);
            this.TxbMarca.MaxLength = 15;
            this.TxbMarca.Name = "TxbMarca";
            this.TxbMarca.Size = new System.Drawing.Size(187, 23);
            this.TxbMarca.TabIndex = 100008;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 100006;
            this.label2.Text = "Nome Marca";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(89, 228);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(226, 228);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 4;
            this.BtnCadastrar.Text = "Salvar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxbNomeProduto
            // 
            this.TxbNomeProduto.Location = new System.Drawing.Point(89, 93);
            this.TxbNomeProduto.MaxLength = 15;
            this.TxbNomeProduto.Name = "TxbNomeProduto";
            this.TxbNomeProduto.Size = new System.Drawing.Size(212, 23);
            this.TxbNomeProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 100005;
            this.label1.Text = "Nome da Produto";
            // 
            // TxbQuantidade
            // 
            this.TxbQuantidade.Location = new System.Drawing.Point(203, 187);
            this.TxbQuantidade.MaxLength = 15;
            this.TxbQuantidade.Name = "TxbQuantidade";
            this.TxbQuantidade.Size = new System.Drawing.Size(98, 23);
            this.TxbQuantidade.TabIndex = 3;
            this.TxbQuantidade.TextChanged += new System.EventHandler(this.TxbQuantidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 100010;
            this.label3.Text = "Quantidade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 100012;
            this.label4.Text = "Data de Validade";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(89, 137);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(212, 23);
            this.maskedTextBox1.TabIndex = 100013;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 286);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnConsultaMarca);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.CbbStatus);
            this.Controls.Add(this.TxbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxbNomeProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultaMarca;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ComboBox CbbStatus;
        private System.Windows.Forms.TextBox TxbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxbNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}