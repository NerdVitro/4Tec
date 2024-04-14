using System;
using System.Collections.Generic;
using System.Text;

namespace _4Tec.Classes.BO
{
    public class CidadeBO
    {
        private string _NomeEstado;
        private int _IdEstado;
        private string _NomeCidade;
        private string _Status;
        private int _IdCidade;

        public string NomeEstado { get => _NomeEstado; set => _NomeEstado = value; }
        public int IdEstado { get => _IdEstado; set => _IdEstado = value; }
        public string NomeCidade { get => _NomeCidade; set => _NomeCidade = value; }
        public string Status { get => _Status; set => _Status = value; }
        public int IdCidade { get => _IdCidade; set => _IdCidade = value; }
    }
}
