
namespace _4Tec.Forms.Pessoas
{
    partial class FrmCadastroEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEstado));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxbNomeEsatdo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbSiglaEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbbStatus = new System.Windows.Forms.ComboBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(89, 139);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(226, 139);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "Salvar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxbNomeEsatdo
            // 
            this.TxbNomeEsatdo.Location = new System.Drawing.Point(89, 100);
            this.TxbNomeEsatdo.MaxLength = 15;
            this.TxbNomeEsatdo.Name = "TxbNomeEsatdo";
            this.TxbNomeEsatdo.Size = new System.Drawing.Size(212, 23);
            this.TxbNomeEsatdo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Estado";
            // 
            // TxbSiglaEstado
            // 
            this.TxbSiglaEstado.Location = new System.Drawing.Point(89, 60);
            this.TxbSiglaEstado.MaxLength = 15;
            this.TxbSiglaEstado.Name = "TxbSiglaEstado";
            this.TxbSiglaEstado.Size = new System.Drawing.Size(92, 23);
            this.TxbSiglaEstado.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sigla Estado";
            // 
            // CbbStatus
            // 
            this.CbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbStatus.FormattingEnabled = true;
            this.CbbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.CbbStatus.Location = new System.Drawing.Point(202, 60);
            this.CbbStatus.Name = "CbbStatus";
            this.CbbStatus.Size = new System.Drawing.Size(99, 23);
            this.CbbStatus.TabIndex = 10;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(202, 42);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 15);
            this.LblStatus.TabIndex = 11;
            this.LblStatus.Text = "Status";
            // 
            // FrmCadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 204);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.CbbStatus);
            this.Controls.Add(this.TxbSiglaEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxbNomeEsatdo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxbNomeEsatdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbSiglaEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbbStatus;
        private System.Windows.Forms.Label LblStatus;
    }
}