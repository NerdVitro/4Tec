using System;
using System.Collections.Generic;
using System.Text;

namespace _4Tec.Classes.BO
{
    public class FuncionarioBO
    {
        private int _IdFuncionario;
        private int _idCargo;
        private string _NomeCargo;
        private int _idCidade;
        private string _NomeCidade;
        private string _NomeFuncionario;
        private string _EnderecoFuncionario;
        private string _SexoFuncionario;
        private string _FoneFuncionario;
        private string _CPFFuncionario;
        private string _RGFuncionario;
        private string _DataNascimentoFuncionario;
        private string _EmailFuncionario;
        private decimal _Salario;
        private string _StatusFuncionario;

        public int IdFuncionario { get => _IdFuncionario; set => _IdFuncionario = value; }
        public int IdCargo { get => _idCargo; set => _idCargo = value; }
        public string NomeCargo { get => _NomeCargo; set => _NomeCargo = value; }
        public int IdCidade { get => _idCidade; set => _idCidade = value; }
        public string NomeCidade { get => _NomeCidade; set => _NomeCidade = value; }
        public string NomeFuncionario { get => _NomeFuncionario; set => _NomeFuncionario = value; }
        public string EnderecoFuncionario { get => _EnderecoFuncionario; set => _EnderecoFuncionario = value; }
        public string SexoFuncionario { get => _SexoFuncionario; set => _SexoFuncionario = value; }
        public string FoneFuncionario { get => _FoneFuncionario; set => _FoneFuncionario = value; }
        public string CPFFuncionario { get => _CPFFuncionario; set => _CPFFuncionario = value; }
        public string RGFuncionario { get => _RGFuncionario; set => _RGFuncionario = value; }
        public string DataNascimentoFuncionario { get => _DataNascimentoFuncionario; set => _DataNascimentoFuncionario = value; }
        public string EmailFuncionario { get => _EmailFuncionario; set => _EmailFuncionario = value; }
        public decimal Salario { get => _Salario; set => _Salario = value; }
        public string StatusFuncionario { get => _StatusFuncionario; set => _StatusFuncionario = value; }
    }
}
