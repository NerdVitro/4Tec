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
    public partial class FrmCargo : Form
    {
        public FrmCargo()
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroCargo Cadastro = new FrmCadastroCargo(0);
                Cadastro.ShowDialog();
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
                if (DgvCargo.Rows.Count > 0)
                {
                    FrmCadastroCargo Cadastro = new FrmCadastroCargo(Convert.ToInt32(DgvCargo.SelectedRows[0].Cells[2].Value));
                    Cadastro.ShowDialog();
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
                    if (cadastrar.ExcluirCargo(Convert.ToInt32(DgvCargo.SelectedRows[0].Cells[2].Value)) > 0)
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

        private void AtualizarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvCargo.DataSource = obter.Cargo(TxbNomeCargo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
