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
    public partial class FrmConCargo : Form
    {
        public int IdCargo;
        public string NomeCargo;

        public FrmConCargo()
        {
            InitializeComponent();
            AtualidarGrid();
        }

        private void DgvCargo_DoubleClick(object sender, EventArgs e)
        {
            SelecionarRegistro();
        }
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarRegistro();
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            AtualidarGrid();
        }

        private void SelecionarRegistro()
        {
            try
            {
                IdCargo = Convert.ToInt32(DgvCargo.SelectedRows[0].Cells[2].Value);
                NomeCargo = Convert.ToString(DgvCargo.SelectedRows[0].Cells[0].Value);
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
                DgvCargo.DataSource = obter.Cargo(TxbFiltrarCargo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
