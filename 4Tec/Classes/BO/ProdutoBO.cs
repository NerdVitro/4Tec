using System;
using System.Collections.Generic;
using System.Text;

namespace _4Tec.Classes.BO
{
    public class ProdutoBO
    {
        private int _IdProduto;
        private string _NomeMarca;
        private int _IdMarca;
        private string _NomeProduto;
        private string _Status;
        private int _Quantidade;

        public int IdProduto { get => _IdProduto; set => _IdProduto = value; }
        public string NomeMarca { get => _NomeMarca; set => _NomeMarca = value; }
        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }
        public string NomeProduto { get => _NomeProduto; set => _NomeProduto = value; }
        public string Status { get => _Status; set => _Status = value; }
        public int Quantidade { get => _Quantidade; set => _Quantidade = value; }
    }
}
