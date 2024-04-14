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
    public partial class FrmCadastroFuncionario : Form
    {
        private int _IdFuncionario;
        private int _IdCargo;
        private int _IdCidade;
        private FuncionarioBO ObjFuncionarioBO;

        public FrmCadastroFuncionario(int parIdFuncionario)
        {
            InitializeComponent();
            _IdFuncionario = parIdFuncionario;
            SetTela();
        }

        private void SetTela()
        {
            try
            {
                if (_IdFuncionario == 0)
                {
                    CbbStatus.Visible = false;
                    LblStatus.Visible = false;

                    TxbCargo.Clear();
                    TxbCargo.Enabled = false;
                    _IdCargo = 0;
                    TxbCidade.Clear();
                    TxbCidade.Enabled = false;
                    _IdCidade = 0;

                    CbbStatus.SelectedItem = "Ativo";
                    CbbSexo.SelectedItem = "Masculino";

                    TxbNomeFuncionario.Clear();
                    TxbEndereco.Clear();
                    TxbTelefone.Clear();
                    TxbCpf.Clear();
                    TxbRg.Clear();
                    TxbEmail.Clear();
                    TxbNascimento.Clear();
                    TxbSalario.Clear();
                }
                else
                {
                    CbbStatus.Visible = true;
                    LblStatus.Visible = true;

                    ObterDados obter = new ObterDados();
                    ObjFuncionarioBO = obter.GetFuncionarioByID(_IdFuncionario);

                    TxbCargo.Text = ObjFuncionarioBO.NomeCargo;
                    TxbCargo.Enabled = false;
                    _IdCargo = ObjFuncionarioBO.IdCargo;
                    TxbCidade.Text = ObjFuncionarioBO.NomeCidade;
                    TxbCidade.Enabled = false;
                    _IdCidade = ObjFuncionarioBO.IdCidade;

                    CbbStatus.SelectedItem = ObjFuncionarioBO.StatusFuncionario;
                    CbbSexo.SelectedItem = ObjFuncionarioBO.SexoFuncionario;

                    TxbNomeFuncionario.Text = ObjFuncionarioBO.NomeFuncionario;
                    TxbEndereco.Text = ObjFuncionarioBO.EnderecoFuncionario;
                    TxbTelefone.Text = ObjFuncionarioBO.FoneFuncionario;
                    TxbCpf.Text = ObjFuncionarioBO.CPFFuncionario;
                    TxbRg.Text = ObjFuncionarioBO.RGFuncionario;
                    TxbEmail.Text = ObjFuncionarioBO.EmailFuncionario;
                    TxbNascimento.Text = ObjFuncionarioBO.DataNascimentoFuncionario;
                    TxbSalario.Text = ObjFuncionarioBO.Salario.ToString();
                }

                TxbNomeFuncionario.MaxLength = 120;
                TxbEndereco.MaxLength = 120;
                TxbEmail.MaxLength = 120;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConsultaCargo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConCargo Consulta = new FrmConCargo();
                Consulta.ShowDialog();
                _IdCargo = Consulta.IdCargo;
                TxbCargo.Text = Consulta.NomeCargo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConsultaCidade_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConCidade Consulta = new FrmConCidade();
                Consulta.ShowDialog();
                _IdCidade = Consulta.IdCidade;
                TxbCidade.Text = Consulta.NomeCidade;
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
                Cadastro cadastrar = new Cadastro();

                if (string.IsNullOrEmpty(TxbNomeFuncionario.Text))
                {
                    MessageBox.Show("Nome do Funcionário é obrigatório");
                    TxbNomeFuncionario.Focus();
                }
                else if (string.IsNullOrEmpty(TxbTelefone.Text))
                {
                    MessageBox.Show("Telefone é obrigatório");
                    TxbTelefone.Focus();
                }
                else if (string.IsNullOrEmpty(TxbCargo.Text))
                {
                    MessageBox.Show("Cargo é obrigatório");
                    BtnConsultaCargo.Focus();
                }
                else if (string.IsNullOrEmpty(TxbCidade.Text))
                {
                    MessageBox.Show("Cidade é obrigatório");
                    BtnConsultaCidade.Focus();
                }
                else if (string.IsNullOrEmpty(TxbCpf.Text))
                {
                    MessageBox.Show("CPF é obrigatório");
                    TxbCpf.Focus();
                }
                else if (string.IsNullOrEmpty(TxbRg.Text))
                {
                    MessageBox.Show("RG é obrigatório");
                    TxbRg.Focus();
                }
                else if (string.IsNullOrEmpty(TxbNascimento.Text))
                {
                    MessageBox.Show("Data Nascimento é obrigatório");
                    TxbNascimento.Focus();
                }
                else if (string.IsNullOrEmpty(TxbSalario.Text))
                {
                    MessageBox.Show("Salário é obrigatório");
                    TxbSalario.Focus();
                }
                else if (string.IsNullOrEmpty(TxbEndereco.Text))
                {
                    MessageBox.Show("Endereço é obrigatório");
                    TxbSalario.Focus();
                }
                else if (Convert.ToDateTime(TxbNascimento.Text) <= Convert.ToDateTime("1/1/1753 12:00:00") || Convert.ToDateTime(TxbNascimento.Text) >= Convert.ToDateTime("31/12/9999 12:59:59"))
                {
                    MessageBox.Show("Data Invalida");
                    TxbSalario.Focus();
                }
                else if (cadastrar.SalvarFuncionario(_IdFuncionario,
                                                        _IdCargo,
                                                        _IdCidade,
                                                        TxbNomeFuncionario.Text,
                                                        TxbEndereco.Text,
                                                        TxbTelefone.Text,
                                                        TxbCpf.Text,
                                                        TxbRg.Text,
                                                        TxbEmail.Text,
                                                        Convert.ToDateTime(TxbNascimento.Text),
                                                        Convert.ToDecimal(TxbSalario.Text),
                                                        CbbStatus.SelectedItem.ToString(),
                                                        CbbSexo.SelectedItem.ToString()) > 0) // cadastrar
                {
                    if (_IdFuncionario == 0)
                    {
                        CbbStatus.SelectedItem = "Ativo";
                        CbbSexo.SelectedItem = "Masculino";

                        TxbNomeFuncionario.Clear();
                        TxbEndereco.Clear();
                        TxbTelefone.Clear();
                        TxbCpf.Clear();
                        TxbRg.Clear();
                        TxbEmail.Clear();
                        TxbNascimento.Clear();
                        TxbSalario.Clear();
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
    }
}
