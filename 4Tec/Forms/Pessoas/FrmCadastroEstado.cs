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
    public partial class FrmCadastroEstado : Form
    {
        private int _idEstado;
        private EstadoBO ObjEstadoBO;
        public FrmCadastroEstado(int idEstado)
        {
            InitializeComponent();
            _idEstado = idEstado;
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


                if (string.IsNullOrEmpty(TxbNomeEsatdo.Text))
                {
                    MessageBox.Show("Nome do Estado é obrigatório");
                    TxbNomeEsatdo.Focus();
                }
                else if (string.IsNullOrEmpty(TxbSiglaEstado.Text))
                {
                    MessageBox.Show("Sigla do Esatdo é obrigatório");
                    TxbSiglaEstado.Focus();
                }
                else if(TxbNomeEsatdo.Text.Length < 4)
                {
                    MessageBox.Show("Para cadastrar no mínimo 4 caracteres no nome do estado");
                    TxbNomeEsatdo.Focus();
                }
                else if (TxbSiglaEstado.Text.Length < 2)
                {
                    MessageBox.Show("Para cadastrar no mínimo 2 para a sigla do estado");
                    TxbSiglaEstado.Focus();
                }
                else if (cadastrar.SalvarEstado(TxbNomeEsatdo.Text,TxbSiglaEstado.Text, CbbStatus.SelectedItem.ToString(), _idEstado) > 0)
                {
                    if (_idEstado == 0)
                    {
                        TxbNomeEsatdo.Clear();
                        TxbSiglaEstado.Clear();
                        TxbSiglaEstado.Focus(); 
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

        private void SetTela()
        {
            try
            {
                if (_idEstado == 0)
                {
                    CbbStatus.Visible = false;
                    LblStatus.Visible = false;
                    CbbStatus.SelectedItem = "Ativo";
                    TxbNomeEsatdo.Clear();
                    TxbSiglaEstado.Clear();
                }
                else
                {
                    CbbStatus.Visible = true;
                    LblStatus.Visible = true;

                    ObterDados obter = new ObterDados();
                    ObjEstadoBO = obter.GetEstadoByID(_idEstado);

                    TxbNomeEsatdo.Text = ObjEstadoBO.NomeEstado;
                    TxbSiglaEstado.Text = ObjEstadoBO.SiglaEstado;
                    CbbStatus.SelectedItem = ObjEstadoBO.Status;
                    _idEstado = ObjEstadoBO.IdEstado;
                }
                TxbNomeEsatdo.MaxLength = 25;
                TxbSiglaEstado.MaxLength = 2;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
