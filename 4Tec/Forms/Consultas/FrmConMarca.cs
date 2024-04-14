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
    public partial class FrmConMarca : Form
    {
        public int IdMarca;
        public string NomeMarca;

        public FrmConMarca()
        {
            InitializeComponent();
            AtualidarGrid();
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
        private void DgvMarca_DoubleClick(object sender, EventArgs e)
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

        private void AtualidarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvMarca.DataSource = obter.Marca(TxbFiltrarMarca.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SelecionarRegistro()
        {
            try
            {
                IdMarca = Convert.ToInt32(DgvMarca.SelectedRows[0].Cells[2].Value);
                NomeMarca = Convert.ToString(DgvMarca.SelectedRows[0].Cells[0].Value);
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
