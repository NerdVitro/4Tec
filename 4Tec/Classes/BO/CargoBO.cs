using System;
using System.Collections.Generic;
using System.Text;

namespace _4Tec.Classes.BO
{
    public class CargoBO
    {
        private string _NomeCargo;
        private string _StatusCargo;

        public string StatusCargo { get => _StatusCargo; set => _StatusCargo = value; }
        public string NomeCargo { get => _NomeCargo; set => _NomeCargo = value; }
    }
}
