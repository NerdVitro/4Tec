using _4Tec.Classes.BancoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms.Consultas
{
    public partial class FrmConCidade : Form
    {
        public int IdCidade;
        public string NomeCidade;

        public FrmConCidade()
        {
            InitializeComponent();
            AtualidarGrid();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                SelecionarRegistro();
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
                AtualidarGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void DgvCidade_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SelecionarRegistro();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SelecionarRegistro()
        {
            try
            {
                IdCidade = Convert.ToInt32(DgvCidade.SelectedRows[0].Cells[3].Value);
                NomeCidade = Convert.ToString(DgvCidade.SelectedRows[0].Cells[0].Value);
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void AtualidarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvCidade.DataSource = obter.Cidade(TxbFiltrarCidade.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
