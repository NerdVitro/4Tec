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
    public partial class FrmLote : Form
    {
        public FrmLote()
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

                AtualizarGrid();
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

        private void AtualizarGrid()
        {
            try
            {
                ObterDados obter = new ObterDados();
                DgvLote.DataSource = obter.Lote(TxbLote.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
