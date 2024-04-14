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
    public partial class FrmEstado : Form
    {
        public FrmEstado()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvEstado.DataSource = obter.Estado(TxbNomeEstado.Text);
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
                FrmCadastroEstado Cadastro = new FrmCadastroEstado(0);
                Cadastro.ShowDialog();
                AtualizarGrid();
            }
            catch (Exception)
            {
                throw;
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
                    if (cadastrar.ExcluirEstado(Convert.ToInt32(DgvEstado.SelectedRows[0].Cells[3].Value)) > 0)
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
                if (DgvEstado.Rows.Count > 0)
                {
                    FrmCadastroEstado Cadastro = new FrmCadastroEstado(Convert.ToInt32(DgvEstado.SelectedRows[0].Cells[3].Value));
                    Cadastro.ShowDialog();
                }
                AtualizarGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
