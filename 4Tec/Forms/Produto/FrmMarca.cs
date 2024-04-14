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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvMarca.DataSource = obter.Marca(TxbNomeMarca.Text);
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
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroMarca cadatro = new FrmCadastroMarca(0);
                cadatro.ShowDialog();
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
                if (DgvMarca.Rows.Count > 0)
                {
                    FrmCadastroMarca cadatro = new FrmCadastroMarca(Convert.ToInt32(DgvMarca.SelectedRows[0].Cells[2].Value));
                    cadatro.ShowDialog();
                }
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
                    if (cadastrar.ExcluirMarca(Convert.ToInt32(DgvMarca.SelectedRows[0].Cells[2].Value)) > 0)
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
