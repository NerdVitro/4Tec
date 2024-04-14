using _4Tec.Classes.BancoDados;
using _4Tec.Classes.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms.Produto
{
    public partial class FrmCadastroMarca : Form
    {
        private int _idMarca;
        private MarcaBo ObjMarcaBo;

        public FrmCadastroMarca(int parIdMarca)
        {
            InitializeComponent();
            _idMarca = parIdMarca;
            SetTela();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastro cadastrar = new Cadastro();


                if (string.IsNullOrEmpty(TxbNomeMarca.Text))
                {
                    MessageBox.Show("Nome do Marca é obrigatório");
                    TxbNomeMarca.Focus();
                }
                else if (cadastrar.SalvarMarca(TxbNomeMarca.Text, CbbStatus.SelectedItem.ToString(), _idMarca) > 0)
                {
                    if (_idMarca == 0)
                    {
                        CbbStatus.Visible = false;
                        LblStatus.Visible = false;
                        CbbStatus.SelectedItem = "Ativo";
                        TxbNomeMarca.Clear();
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
            }
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

        private void SetTela()
        {
            try
            {
                if (_idMarca == 0)
                {
                    CbbStatus.Visible = false;
                    LblStatus.Visible = false;
                    CbbStatus.SelectedItem = "Ativo";
                    TxbNomeMarca.Clear();
                }
                else
                {
                    CbbStatus.Visible = true;
                    LblStatus.Visible = true;

                    ObterDados obter = new ObterDados();
                    ObjMarcaBo = obter.GetMarcaByID(_idMarca);

                    TxbNomeMarca.Text = ObjMarcaBo.NomeMarca;
                    CbbStatus.SelectedItem = ObjMarcaBo.StatusMarca;
                }
                TxbNomeMarca.MaxLength = 120;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
