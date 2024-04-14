using _4Tec.Classes;
using _4Tec.Forms.Movimentacao;
using _4Tec.Forms.Pessoas;
using _4Tec.Forms.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms
{
    public partial class FrmPrincipal : Form
    {
        readonly private Color ColorForm = Constantes.ColorForm;
        readonly private Color ColorLogo = Constantes.ColorLogo;
        readonly private Color Colorbuton = Constantes.ColorButonSelect;
        readonly private Color ColorPanel = Constantes.ColorPanel;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                PnlMovimentacao.Visible = false;
                PnlContas.Visible = false;
                PnlProdutos.Visible = false;
                PnlPessoas.Visible = false;

                PnlMovimentacao.BackColor = ColorForm;
                PnlContas.BackColor = ColorForm;
                PnlProdutos.BackColor = ColorForm;
                PnlPessoas.BackColor = ColorForm;

                PnlMenu.BackColor = ColorForm;
                PnlMenuButoes.BackColor = ColorForm;
                PnlFormulario.BackColor = ColorPanel;
                pictureBox1.BackColor = ColorLogo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Movimentação
        private void BtnMovimentacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnlMovimentacao.Visible == true)
                {
                    PnlMovimentacao.Visible = false;
                    BtnMovimentacao.BackColor = ColorForm;
                }
                else
                {
                    BtnMovimentacao.BackColor = Colorbuton;
                    BtnContas.BackColor = ColorForm;
                    BtnProdutos.BackColor = ColorForm;
                    BtnPessoas.BackColor = ColorForm;

                    PnlMovimentacao.Visible = true;                    
                    PnlContas.Visible = false;
                    PnlProdutos.Visible = false;
                    PnlPessoas.Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnVenda_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVenda venda = new FrmVenda();
                SetPageLimpa();
                venda.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnCompra_Click(object sender, EventArgs e)
        {

        }
        private void BtnCaixa_Click(object sender, EventArgs e)
        {

        }
        private void BtnDescarte_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Contas
        private void BtnContas_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnlContas.Visible == true)
                {
                    PnlContas.Visible = false;
                    BtnContas.BackColor = ColorForm;
                }
                else
                {
                    BtnContas.BackColor = Colorbuton;
                    BtnMovimentacao.BackColor = ColorForm;
                    BtnProdutos.BackColor = ColorForm;
                    BtnPessoas.BackColor = ColorForm;

                    PnlContas.Visible = true;
                    PnlMovimentacao.Visible = false;
                    PnlProdutos.Visible = false;
                    PnlPessoas.Visible = false;
                }
            }
            catch (Exception) 
            {
                throw; 
            }
        }
        private void BtnPagar_Click(object sender, EventArgs e)
        {

        }
        private void BtnReceber_Click(object sender, EventArgs e)
        {

        }
        private void BtnRecebimento_Click(object sender, EventArgs e)
        {

        }
        private void BtnPagamento_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Produtos
        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnlProdutos.Visible == true)
                {
                    PnlProdutos.Visible = false;
                    BtnProdutos.BackColor = ColorForm;
                }
                else
                {
                    BtnProdutos.BackColor = Colorbuton;
                    BtnContas.BackColor = ColorForm;
                    BtnMovimentacao.BackColor = ColorForm;
                    BtnPessoas.BackColor = ColorForm;

                    PnlProdutos.Visible = true;
                    PnlContas.Visible = false;
                    PnlMovimentacao.Visible = false;
                    PnlPessoas.Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnMarca_Click(object sender, EventArgs e)
        {
            try
            {
                SetPageLimpa();
                FrmMarca marca = new FrmMarca();
                marca.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnLote_Click(object sender, EventArgs e)
        {
            try
            {
                SetPageLimpa();
                FrmLote lote = new FrmLote();
                lote.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            try
            {
                SetPageLimpa();
                FrmProduto produto = new FrmProduto();
                produto.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Pessoas
        private void BtnPessoas_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnlPessoas.Visible == true)
                {
                    PnlPessoas.Visible = false;
                    BtnPessoas.BackColor = ColorForm;
                }
                else
                {
                    BtnPessoas.BackColor = Colorbuton;
                    BtnProdutos.BackColor = ColorForm;
                    BtnContas.BackColor = ColorForm;
                    BtnMovimentacao.BackColor = ColorForm;

                    PnlPessoas.Visible = true;
                    PnlProdutos.Visible = false;
                    PnlContas.Visible = false;
                    PnlMovimentacao.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {

        }
        private void BtnFornecedor_Click(object sender, EventArgs e)
        {

        }
        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                SetPageLimpa();
                FrmFuncionario funcionario = new FrmFuncionario();
                funcionario.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnCargo_Click(object sender, EventArgs e)
        {
            try
            {
                SetPageLimpa();
                FrmCargo cargo = new FrmCargo();
                cargo.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                SetPageLimpa();
                FrmEstado estado = new FrmEstado();
                estado.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnCidade_Click(object sender, EventArgs e)
        {
            try
            {
                SetPageLimpa();
                FrmCidade cidade = new FrmCidade();
                cidade.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        private void SetPageLimpa()
        {
            try
            {
                BtnPessoas.BackColor = ColorForm;
                BtnProdutos.BackColor = ColorForm;
                BtnContas.BackColor = ColorForm;
                BtnMovimentacao.BackColor = ColorForm;

                PnlPessoas.Visible = false;
                PnlProdutos.Visible = false;
                PnlContas.Visible = false;
                PnlMovimentacao.Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
