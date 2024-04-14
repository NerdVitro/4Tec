using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _4Tec.Classes.BancoDados
{
    public class Conexao
    {
        readonly SqlConnection sqlConnection;
        public bool EstaConectado { get => sqlConnection.State == System.Data.ConnectionState.Open; }

        public Conexao()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Constantes.ConnectionString;
        }


        public SqlConnection Conectar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }

        public void Desconectar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
