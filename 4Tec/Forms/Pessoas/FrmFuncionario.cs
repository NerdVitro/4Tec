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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
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
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroFuncionario cadastro = new FrmCadastroFuncionario(0);
                cadastro.ShowDialog();
                AtualizarGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AtualizarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvFuncionario.DataSource = obter.Funcionario(TxbNomeFuncionario.Text);
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
                if(DgvFuncionario.Rows.Count > 0)
                {
                    FrmCadastroFuncionario cadastro = new FrmCadastroFuncionario(Convert.ToInt32(DgvFuncionario.SelectedRows[0].Cells[3].Value));
                    cadastro.ShowDialog();
                    AtualizarGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum Dado Foi Selecionado Para Editar");
                }
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
                    if (cadastrar.ExcluirFuncionario(Convert.ToInt32(DgvFuncionario.SelectedRows[0].Cells[3].Value)) > 0)
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
