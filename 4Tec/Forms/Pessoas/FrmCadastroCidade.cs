using _4Tec.Classes.BancoDados;
using _4Tec.Classes.BO;
using _4Tec.Forms.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Forms.Pessoas
{
    public partial class FrmCadastroCidade : Form
    {
        private int _IdCidade;
        private int _IdEstado;
        private CidadeBO ObjCidadeBO;

        public FrmCadastroCidade(int parIdCidae)
        {
            InitializeComponent();
            _IdCidade = parIdCidae;
            SetTela();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConsultaEstado_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConEstado conEstado = new FrmConEstado();
                conEstado.ShowDialog();
                _IdEstado = conEstado.IdEstado;
                TxbEstado.Text = conEstado.NomeEstado;
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
                if (_IdCidade == 0)
                {
                    CbbStatus.Visible = false;
                    LblStatus.Visible = false;

                    TxbEstado.Enabled = false;

                    CbbStatus.SelectedItem = "Ativo";
                    TxbNomeCidade.Clear();
                    TxbEstado.Clear();
                }
                else
                {
                    CbbStatus.Visible = true;
                    LblStatus.Visible = true;

                    TxbEstado.Enabled = false;

                    ObterDados obter = new ObterDados();
                    ObjCidadeBO = obter.GetCidadeByID(_IdCidade);

                    TxbNomeCidade.Text = ObjCidadeBO.NomeEstado;
                    TxbEstado.Text = ObjCidadeBO.NomeEstado;
                    _IdEstado = ObjCidadeBO.IdEstado;
                    CbbStatus.SelectedItem = ObjCidadeBO.Status;
                }
                TxbNomeCidade.MaxLength = 25;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastro cadastrar = new Cadastro();


                if (string.IsNullOrEmpty(TxbEstado.Text))
                {
                    MessageBox.Show("Estado é obrigatório");
                    BtnConsultaEstado.Focus();
                }
                else if (string.IsNullOrEmpty(TxbNomeCidade.Text))
                {
                    MessageBox.Show("Nome Cidade é obrigatório");
                    TxbNomeCidade.Focus();
                }
                else if (TxbNomeCidade.Text.Length < 4)
                {
                    MessageBox.Show("Para cadastrar no mínimo 4 caracteres no nome do cidade");
                    TxbNomeCidade.Focus();
                }
                else if (cadastrar.SalvarCidade(TxbNomeCidade.Text, _IdEstado, CbbStatus.SelectedItem.ToString(), _IdCidade) > 0)
                {
                    if (_IdCidade == 0)
                    {
                        CbbStatus.SelectedItem = "Ativo";
                        TxbNomeCidade.Clear();
                        TxbEstado.Clear();
                        BtnConsultaEstado.Focus();
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
    }
}
