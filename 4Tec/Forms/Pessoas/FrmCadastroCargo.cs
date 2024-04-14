using _4Tec.Classes.BancoDados;
using _4Tec.Classes.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms.Pessoas
{
    public partial class FrmCadastroCargo : Form
    {
        private int IdCargo;
        private CargoBO ObjCargoBO;

        public FrmCadastroCargo(int parIdCargo)
        {
            InitializeComponent();
            IdCargo = parIdCargo;
            SetTela();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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
                Cadastro cadastrar = new Cadastro();
                if (string.IsNullOrEmpty(TxbNomeCargo.Text))
                {
                    MessageBox.Show("Informar Nome do Cargo");
                }
                else if (TxbNomeCargo.Text.Length < 2)
                {
                    MessageBox.Show("Informar pelo menos 2 caracteres");
                }
                else if (cadastrar.SalvarCargo(TxbNomeCargo.Text, CbbStatus.SelectedItem.ToString(), IdCargo) > 0)
                {
                    if (IdCargo == 0)
                    {
                        TxbNomeCargo.Clear();
                        TxbNomeCargo.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Algum erro aconteceu ao cadastrar, tente novamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void SetTela()
        {
            try
            {
                if (IdCargo == 0)
                {
                    CbbStatus.Visible = false;
                    LblStatus.Visible = false;

                    CbbStatus.SelectedItem = "Ativo";
                    TxbNomeCargo.Clear();
                }
                else
                {
                    CbbStatus.Visible = true;
                    LblStatus.Visible = true;

                    ObterDados obter = new ObterDados();
                    ObjCargoBO = obter.GetCargoByID(IdCargo);

                    TxbNomeCargo.Text = ObjCargoBO.NomeCargo;
                    CbbStatus.SelectedItem = ObjCargoBO.StatusCargo;
                }
                TxbNomeCargo.MaxLength = 15;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
