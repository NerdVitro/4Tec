
namespace _4Tec.Forms.Pessoas
{
    partial class FrmCadastroCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCidade));
            this.LblStatus = new System.Windows.Forms.Label();
            this.CbbStatus = new System.Windows.Forms.ComboBox();
            this.TxbEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxbNomeCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConsultaEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(89, 108);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 15);
            this.LblStatus.TabIndex = 19;
            this.LblStatus.Text = "Status";
            // 
            // CbbStatus
            // 
            this.CbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbStatus.FormattingEnabled = true;
            this.CbbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.CbbStatus.Location = new System.Drawing.Point(89, 126);
            this.CbbStatus.Name = "CbbStatus";
            this.CbbStatus.Size = new System.Drawing.Size(99, 23);
            this.CbbStatus.TabIndex = 2;
            // 
            // TxbEstado
            // 
            this.TxbEstado.Location = new System.Drawing.Point(89, 42);
            this.TxbEstado.MaxLength = 15;
            this.TxbEstado.Name = "TxbEstado";
            this.TxbEstado.Size = new System.Drawing.Size(187, 23);
            this.TxbEstado.TabIndex = 99999;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome Estado";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(89, 158);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(226, 158);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "Salvar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxbNomeCidade
            // 
            this.TxbNomeCidade.Location = new System.Drawing.Point(89, 82);
            this.TxbNomeCidade.MaxLength = 15;
            this.TxbNomeCidade.Name = "TxbNomeCidade";
            this.TxbNomeCidade.Size = new System.Drawing.Size(212, 23);
            this.TxbNomeCidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome da Cidade";
            // 
            // BtnConsultaEstado
            // 
            this.BtnConsultaEstado.Location = new System.Drawing.Point(282, 42);
            this.BtnConsultaEstado.Name = "BtnConsultaEstado";
            this.BtnConsultaEstado.Size = new System.Drawing.Size(19, 23);
            this.BtnConsultaEstado.TabIndex = 0;
            this.BtnConsultaEstado.Text = ">";
            this.BtnConsultaEstado.UseVisualStyleBackColor = true;
            this.BtnConsultaEstado.Click += new System.EventHandler(this.BtnConsultaEstado_Click);
            // 
            // FrmCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 204);
            this.Controls.Add(this.BtnConsultaEstado);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.CbbStatus);
            this.Controls.Add(this.TxbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxbNomeCidade);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ComboBox CbbStatus;
        private System.Windows.Forms.TextBox TxbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxbNomeCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultaEstado;
    }
}