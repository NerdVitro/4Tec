using System;
using System.Collections.Generic;
using System.Text;

namespace _4Tec.Classes.BO
{
    public class EstadoBO
    {
        private int _IdEstado;
        private string _NomeEstado;
        private string _SiglaEstado;
        private string _Status;

        public int IdEstado { get => _IdEstado; set => _IdEstado = value; }
        public string NomeEstado { get => _NomeEstado; set => _NomeEstado = value; }
        public string SiglaEstado { get => _SiglaEstado; set => _SiglaEstado = value; }
        public string Status { get => _Status; set => _Status = value; }

        public EstadoBO()
        {

        }

        public EstadoBO(int idEstado, string nomeEstado, string siglaEstado, string status)
        {
            _IdEstado = idEstado;
            _NomeEstado = nomeEstado;
            _SiglaEstado = siglaEstado;
            _Status = status;
        }
    }
}
