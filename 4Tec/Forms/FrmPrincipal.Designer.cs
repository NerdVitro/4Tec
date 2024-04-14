
namespace _4Tec.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlMenuButoes = new System.Windows.Forms.Panel();
            this.BtnPessoas = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnContas = new System.Windows.Forms.Button();
            this.BtnMovimentacao = new System.Windows.Forms.Button();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.PnlPessoas = new System.Windows.Forms.Panel();
            this.BtnCidade = new System.Windows.Forms.Button();
            this.BtnEstado = new System.Windows.Forms.Button();
            this.BtnCargo = new System.Windows.Forms.Button();
            this.BtnFuncionario = new System.Windows.Forms.Button();
            this.BtnFornecedor = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.PnlProdutos = new System.Windows.Forms.Panel();
            this.BtnProduto = new System.Windows.Forms.Button();
            this.BtnLote = new System.Windows.Forms.Button();
            this.BtnMarca = new System.Windows.Forms.Button();
            this.PnlContas = new System.Windows.Forms.Panel();
            this.BtnRecebimento = new System.Windows.Forms.Button();
            this.BtnPagamento = new System.Windows.Forms.Button();
            this.BtnReceber = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.PnlMovimentacao = new System.Windows.Forms.Panel();
            this.BtnDescarte = new System.Windows.Forms.Button();
            this.BtnCaixa = new System.Windows.Forms.Button();
            this.BtnCompra = new System.Windows.Forms.Button();
            this.BtnVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PnlMenuButoes.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlFormulario.SuspendLayout();
            this.PnlPessoas.SuspendLayout();
            this.PnlProdutos.SuspendLayout();
            this.PnlContas.SuspendLayout();
            this.PnlMovimentacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PnlMenuButoes);
            this.panel1.Controls.Add(this.PnlMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 729);
            this.panel1.TabIndex = 0;
            // 
            // PnlMenuButoes
            // 
            this.PnlMenuButoes.BackColor = System.Drawing.Color.White;
            this.PnlMenuButoes.Controls.Add(this.BtnPessoas);
            this.PnlMenuButoes.Controls.Add(this.BtnProdutos);
            this.PnlMenuButoes.Controls.Add(this.BtnContas);
            this.PnlMenuButoes.Controls.Add(this.BtnMovimentacao);
            this.PnlMenuButoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMenuButoes.Location = new System.Drawing.Point(0, 96);
            this.PnlMenuButoes.Name = "PnlMenuButoes";
            this.PnlMenuButoes.Size = new System.Drawing.Size(217, 633);
            this.PnlMenuButoes.TabIndex = 1;
            // 
            // BtnPessoas
            // 
            this.BtnPessoas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPessoas.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPessoas.Location = new System.Drawing.Point(0, 156);
            this.BtnPessoas.Name = "BtnPessoas";
            this.BtnPessoas.Size = new System.Drawing.Size(217, 52);
            this.BtnPessoas.TabIndex = 9;
            this.BtnPessoas.Text = "Pessoa";
            this.BtnPessoas.UseVisualStyleBackColor = true;
            this.BtnPessoas.Click += new System.EventHandler(this.BtnPessoas_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProdutos.Location = new System.Drawing.Point(0, 104);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(217, 52);
            this.BtnProdutos.TabIndex = 7;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnContas
            // 
            this.BtnContas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContas.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnContas.Location = new System.Drawing.Point(0, 52);
            this.BtnContas.Name = "BtnContas";
            this.BtnContas.Size = new System.Drawing.Size(217, 52);
            this.BtnContas.TabIndex = 1;
            this.BtnContas.Text = "Contas";
            this.BtnContas.UseVisualStyleBackColor = true;
            this.BtnContas.Click += new System.EventHandler(this.BtnContas_Click);
            // 
            // BtnMovimentacao
            // 
            this.BtnMovimentacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovimentacao.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMovimentacao.Location = new System.Drawing.Point(0, 0);
            this.BtnMovimentacao.Name = "BtnMovimentacao";
            this.BtnMovimentacao.Size = new System.Drawing.Size(217, 52);
            this.BtnMovimentacao.TabIndex = 0;
            this.BtnMovimentacao.Text = "Movimentação";
            this.BtnMovimentacao.UseVisualStyleBackColor = true;
            this.BtnMovimentacao.Click += new System.EventHandler(this.BtnMovimentacao_Click);
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.pictureBox1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(217, 96);
            this.PnlMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::_4Tec.Properties.Resources.Logo_chocolataria_vanilla_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.BackColor = System.Drawing.Color.DimGray;
            this.PnlFormulario.Controls.Add(this.PnlPessoas);
            this.PnlFormulario.Controls.Add(this.PnlProdutos);
            this.PnlFormulario.Controls.Add(this.PnlContas);
            this.PnlFormulario.Controls.Add(this.PnlMovimentacao);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(217, 0);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(1047, 729);
            this.PnlFormulario.TabIndex = 1;
            // 
            // PnlPessoas
            // 
            this.PnlPessoas.BackColor = System.Drawing.Color.White;
            this.PnlPessoas.Controls.Add(this.BtnCidade);
            this.PnlPessoas.Controls.Add(this.BtnEstado);
            this.PnlPessoas.Controls.Add(this.BtnCargo);
            this.PnlPessoas.Controls.Add(this.BtnFuncionario);
            this.PnlPessoas.Controls.Add(this.BtnFornecedor);
            this.PnlPessoas.Controls.Add(this.BtnCliente);
            this.PnlPessoas.Location = new System.Drawing.Point(2, 252);
            this.PnlPessoas.Name = "PnlPessoas";
            this.PnlPessoas.Size = new System.Drawing.Size(195, 319);
            this.PnlPessoas.TabIndex = 11;
            // 
            // BtnCidade
            // 
            this.BtnCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCidade.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCidade.Location = new System.Drawing.Point(3, 263);
            this.BtnCidade.Name = "BtnCidade";
            this.BtnCidade.Size = new System.Drawing.Size(189, 52);
            this.BtnCidade.TabIndex = 6;
            this.BtnCidade.Text = "Cidade";
            this.BtnCidade.UseVisualStyleBackColor = true;
            this.BtnCidade.Click += new System.EventHandler(this.BtnCidade_Click);
            // 
            // BtnEstado
            // 
            this.BtnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstado.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEstado.Location = new System.Drawing.Point(3, 211);
            this.BtnEstado.Name = "BtnEstado";
            this.BtnEstado.Size = new System.Drawing.Size(189, 52);
            this.BtnEstado.TabIndex = 5;
            this.BtnEstado.Text = "Estado";
            this.BtnEstado.UseVisualStyleBackColor = true;
            this.BtnEstado.Click += new System.EventHandler(this.BtnEstado_Click);
            // 
            // BtnCargo
            // 
            this.BtnCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargo.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCargo.Location = new System.Drawing.Point(3, 159);
            this.BtnCargo.Name = "BtnCargo";
            this.BtnCargo.Size = new System.Drawing.Size(189, 52);
            this.BtnCargo.TabIndex = 4;
            this.BtnCargo.Text = "Cargo";
            this.BtnCargo.UseVisualStyleBackColor = true;
            this.BtnCargo.Click += new System.EventHandler(this.BtnCargo_Click);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionario.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFuncionario.Location = new System.Drawing.Point(3, 107);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Size = new System.Drawing.Size(189, 52);
            this.BtnFuncionario.TabIndex = 3;
            this.BtnFuncionario.Text = "Funcionário";
            this.BtnFuncionario.UseVisualStyleBackColor = true;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // BtnFornecedor
            // 
            this.BtnFornecedor.AccessibleDescription = "";
            this.BtnFornecedor.AllowDrop = true;
            this.BtnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFornecedor.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFornecedor.Location = new System.Drawing.Point(3, 55);
            this.BtnFornecedor.Name = "BtnFornecedor";
            this.BtnFornecedor.Size = new System.Drawing.Size(189, 52);
            this.BtnFornecedor.TabIndex = 2;
            this.BtnFornecedor.Text = "Fornecedor";
            this.BtnFornecedor.UseVisualStyleBackColor = true;
            this.BtnFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCliente.Location = new System.Drawing.Point(3, 3);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(189, 52);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // PnlProdutos
            // 
            this.PnlProdutos.BackColor = System.Drawing.Color.White;
            this.PnlProdutos.Controls.Add(this.BtnProduto);
            this.PnlProdutos.Controls.Add(this.BtnLote);
            this.PnlProdutos.Controls.Add(this.BtnMarca);
            this.PnlProdutos.Location = new System.Drawing.Point(2, 198);
            this.PnlProdutos.Name = "PnlProdutos";
            this.PnlProdutos.Size = new System.Drawing.Size(195, 161);
            this.PnlProdutos.TabIndex = 9;
            // 
            // BtnProduto
            // 
            this.BtnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduto.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnProduto.Location = new System.Drawing.Point(3, 3);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(189, 52);
            this.BtnProduto.TabIndex = 3;
            this.BtnProduto.Text = "Produto";
            this.BtnProduto.UseVisualStyleBackColor = true;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // BtnLote
            // 
            this.BtnLote.AccessibleDescription = "";
            this.BtnLote.AllowDrop = true;
            this.BtnLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLote.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLote.Location = new System.Drawing.Point(3, 107);
            this.BtnLote.Name = "BtnLote";
            this.BtnLote.Size = new System.Drawing.Size(189, 52);
            this.BtnLote.TabIndex = 2;
            this.BtnLote.Text = "Lotes";
            this.BtnLote.UseVisualStyleBackColor = true;
            this.BtnLote.Click += new System.EventHandler(this.BtnLote_Click);
            // 
            // BtnMarca
            // 
            this.BtnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarca.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMarca.Location = new System.Drawing.Point(3, 55);
            this.BtnMarca.Name = "BtnMarca";
            this.BtnMarca.Size = new System.Drawing.Size(189, 52);
            this.BtnMarca.TabIndex = 1;
            this.BtnMarca.Text = "Marca";
            this.BtnMarca.UseVisualStyleBackColor = true;
            this.BtnMarca.Click += new System.EventHandler(this.BtnMarca_Click);
            // 
            // PnlContas
            // 
            this.PnlContas.BackColor = System.Drawing.Color.White;
            this.PnlContas.Controls.Add(this.BtnRecebimento);
            this.PnlContas.Controls.Add(this.BtnPagamento);
            this.PnlContas.Controls.Add(this.BtnReceber);
            this.PnlContas.Controls.Add(this.BtnPagar);
            this.PnlContas.Location = new System.Drawing.Point(1, 148);
            this.PnlContas.Name = "PnlContas";
            this.PnlContas.Size = new System.Drawing.Size(197, 215);
            this.PnlContas.TabIndex = 8;
            // 
            // BtnRecebimento
            // 
            this.BtnRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecebimento.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRecebimento.Location = new System.Drawing.Point(4, 107);
            this.BtnRecebimento.Name = "BtnRecebimento";
            this.BtnRecebimento.Size = new System.Drawing.Size(189, 52);
            this.BtnRecebimento.TabIndex = 5;
            this.BtnRecebimento.Text = "Recebimentos";
            this.BtnRecebimento.UseVisualStyleBackColor = true;
            this.BtnRecebimento.Click += new System.EventHandler(this.BtnRecebimento_Click);
            // 
            // BtnPagamento
            // 
            this.BtnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagamento.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPagamento.Location = new System.Drawing.Point(4, 159);
            this.BtnPagamento.Name = "BtnPagamento";
            this.BtnPagamento.Size = new System.Drawing.Size(189, 52);
            this.BtnPagamento.TabIndex = 4;
            this.BtnPagamento.Text = "Pagamentos";
            this.BtnPagamento.UseVisualStyleBackColor = true;
            this.BtnPagamento.Click += new System.EventHandler(this.BtnPagamento_Click);
            // 
            // BtnReceber
            // 
            this.BtnReceber.AccessibleDescription = "";
            this.BtnReceber.AllowDrop = true;
            this.BtnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceber.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReceber.Location = new System.Drawing.Point(4, 55);
            this.BtnReceber.Name = "BtnReceber";
            this.BtnReceber.Size = new System.Drawing.Size(189, 52);
            this.BtnReceber.TabIndex = 2;
            this.BtnReceber.Text = "Contas A Receber";
            this.BtnReceber.UseVisualStyleBackColor = true;
            this.BtnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPagar.Location = new System.Drawing.Point(4, 3);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(189, 52);
            this.BtnPagar.TabIndex = 1;
            this.BtnPagar.Text = "Contas A Pagar";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // PnlMovimentacao
            // 
            this.PnlMovimentacao.BackColor = System.Drawing.Color.White;
            this.PnlMovimentacao.Controls.Add(this.BtnDescarte);
            this.PnlMovimentacao.Controls.Add(this.BtnCaixa);
            this.PnlMovimentacao.Controls.Add(this.BtnCompra);
            this.PnlMovimentacao.Controls.Add(this.BtnVenda);
            this.PnlMovimentacao.Location = new System.Drawing.Point(0, 96);
            this.PnlMovimentacao.Name = "PnlMovimentacao";
            this.PnlMovimentacao.Size = new System.Drawing.Size(197, 215);
            this.PnlMovimentacao.TabIndex = 6;
            // 
            // BtnDescarte
            // 
            this.BtnDescarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescarte.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDescarte.Location = new System.Drawing.Point(4, 159);
            this.BtnDescarte.Name = "BtnDescarte";
            this.BtnDescarte.Size = new System.Drawing.Size(189, 52);
            this.BtnDescarte.TabIndex = 4;
            this.BtnDescarte.Text = "Descarte";
            this.BtnDescarte.UseVisualStyleBackColor = true;
            this.BtnDescarte.Click += new System.EventHandler(this.BtnDescarte_Click);
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaixa.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCaixa.Location = new System.Drawing.Point(4, 107);
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Size = new System.Drawing.Size(189, 52);
            this.BtnCaixa.TabIndex = 3;
            this.BtnCaixa.Text = "Caixa";
            this.BtnCaixa.UseVisualStyleBackColor = true;
            this.BtnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // BtnCompra
            // 
            this.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompra.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCompra.Location = new System.Drawing.Point(4, 55);
            this.BtnCompra.Name = "BtnCompra";
            this.BtnCompra.Size = new System.Drawing.Size(189, 52);
            this.BtnCompra.TabIndex = 2;
            this.BtnCompra.Text = "Compra";
            this.BtnCompra.UseVisualStyleBackColor = true;
            this.BtnCompra.Click += new System.EventHandler(this.BtnCompra_Click);
            // 
            // BtnVenda
            // 
            this.BtnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVenda.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVenda.Location = new System.Drawing.Point(4, 3);
            this.BtnVenda.Name = "BtnVenda";
            this.BtnVenda.Size = new System.Drawing.Size(189, 52);
            this.BtnVenda.TabIndex = 1;
            this.BtnVenda.Text = "Venda";
            this.BtnVenda.UseVisualStyleBackColor = true;
            this.BtnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.PnlFormulario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4Tec";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.PnlMenuButoes.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlFormulario.ResumeLayout(false);
            this.PnlPessoas.ResumeLayout(false);
            this.PnlProdutos.ResumeLayout(false);
            this.PnlContas.ResumeLayout(false);
            this.PnlMovimentacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlMenuButoes;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.Button BtnMovimentacao;
        private System.Windows.Forms.Button BtnContas;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnPessoas;
        private System.Windows.Forms.Panel PnlMovimentacao;
        private System.Windows.Forms.Button BtnDescarte;
        private System.Windows.Forms.Button BtnCaixa;
        private System.Windows.Forms.Button BtnCompra;
        private System.Windows.Forms.Button BtnVenda;
        private System.Windows.Forms.Panel PnlContas;
        private System.Windows.Forms.Button BtnRecebimento;
        private System.Windows.Forms.Button BtnPagamento;
        private System.Windows.Forms.Button BtnReceber;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Panel PnlPessoas;
        private System.Windows.Forms.Button BtnFuncionario;
        private System.Windows.Forms.Button BtnFornecedor;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Panel PnlProdutos;
        private System.Windows.Forms.Button BtnProduto;
        private System.Windows.Forms.Button BtnLote;
        private System.Windows.Forms.Button BtnMarca;
        private System.Windows.Forms.Button BtnCargo;
        private System.Windows.Forms.Button BtnCidade;
        private System.Windows.Forms.Button BtnEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}