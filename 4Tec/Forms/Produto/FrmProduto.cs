using _4Tec.Classes.BancoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms.Produto
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvProduto.DataSource = obter.Produto(TxbNomeProduto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroProduto cadastro = new FrmCadastroProduto(0);
                cadastro.ShowDialog();
                AtualizarGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroProduto cadastro = new FrmCadastroProduto(Convert.ToInt32(DgvProduto.SelectedRows[0].Cells[3].Value));
                cadastro.ShowDialog();
                AtualizarGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem Certeza Que Deseja Excluir o Registro ?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cadastro cadastrar = new Cadastro();
                    if (cadastrar.ExcluirProduto(Convert.ToInt32(DgvProduto.SelectedRows[0].Cells[3].Value)) > 0)
                    {
                        MessageBox.Show("Exluido Com Sucesso");
                    }
                }
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
