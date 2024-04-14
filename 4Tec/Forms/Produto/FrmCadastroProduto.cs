using _4Tec.Classes.BancoDados;
using _4Tec.Classes.BO;
using _4Tec.Forms.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms.Produto
{
    public partial class FrmCadastroProduto : Form
    {
        private int IdProduto;
        private int IdMarca;
        private ProdutoBO ObjProdutoBO;

        public FrmCadastroProduto(int parIdProduto)
        {
            InitializeComponent();
            IdProduto = parIdProduto;
            SetTela();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

        }
        private void BtnConsultaMarca_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConMarca consulta = new FrmConMarca();
                consulta.ShowDialog();
                IdMarca = consulta.IdMarca;
                TxbMarca.Text = consulta.NomeMarca;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetTela()
        {
            try
            {
                if (IdProduto == 0)
                {
                    CbbStatus.Visible = false;
                    LblStatus.Visible = false;
                    CbbStatus.SelectedItem = "Ativo";

                    TxbMarca.Clear();
                    TxbNomeProduto.Clear();
                    TxbQuantidade.Clear();
                }
                else
                {
                    CbbStatus.Visible = true;
                    LblStatus.Visible = true;

                    ObterDados obter = new ObterDados();
                    //ObjProdutoBO = obter.GetMarcaByID(IdProduto);

                    TxbMarca.Text = "";
                    TxbNomeProduto.Text = "";
                    TxbQuantidade.Text = "";
                }
                BtnConsultaMarca.Focus();
                TxbMarca.Enabled = false;
                TxbNomeProduto.MaxLength = 40;
                TxbQuantidade.MaxLength = 9;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LblStatus_Click(object sender, EventArgs e)
        {

        }

        private void CbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxbQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
