using System;
using System.Collections.Generic;
using System.Text;

namespace _4Tec.Classes.BO
{
    public class MarcaBo
    {
        private string _NomeMarca;
        private string _StatusMarca;
        private int _idMarca;

        public string NomeMarca { get => _NomeMarca; set => _NomeMarca = value; }
        public string StatusMarca { get => _StatusMarca; set => _StatusMarca = value; }
        public int IdMarca { get => _idMarca; set => _idMarca = value; }
    }
}
