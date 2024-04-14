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
    public partial class FrmConEstado : Form
    {
        public int IdEstado;
        public string NomeEstado;

        public FrmConEstado()
        {
            InitializeComponent();
            AtualidarGrid();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            AtualidarGrid();
        }
        private void DgvEstado_DoubleClick(object sender, EventArgs e)
        {
            SelecionarRegistro();
        }
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarRegistro();
        }

        private void AtualidarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvEstado.DataSource = obter.Estado(TxbFiltrarEstado.Text);
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
                IdEstado = Convert.ToInt32(DgvEstado.SelectedRows[0].Cells[3].Value);
                NomeEstado = Convert.ToString(DgvEstado.SelectedRows[0].Cells[0].Value);
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
