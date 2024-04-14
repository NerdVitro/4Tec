using _4Tec.Classes.BancoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms.Pessoas
{
    public partial class FrmCidade : Form
    {
        public FrmCidade()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
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
            try
            {
                FrmCadastroCidade Cadastro = new FrmCadastroCidade(0);
                Cadastro.ShowDialog();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvCidade.DataSource = obter.Cidade(TxbNomeCidade.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem Certeza Que Deseja Excluir o Registro ?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cadastro cadastrar = new Cadastro();
                    if (cadastrar.ExcluirCidade(Convert.ToInt32(DgvCidade.SelectedRows[0].Cells[3].Value)) > 0)
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvCidade.Rows.Count > 0)
                {
                    FrmCadastroCidade Cadastro = new FrmCadastroCidade(Convert.ToInt32(DgvCidade.SelectedRows[0].Cells[3].Value));
                    Cadastro.ShowDialog();
                }
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
