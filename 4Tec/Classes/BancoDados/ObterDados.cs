using _4Tec.Classes.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace _4Tec.Classes.BancoDados
{
    public class ObterDados
    {
        readonly private Conexao conexao = new Conexao();
        readonly private SqlCommand sqlcmd = new SqlCommand();
        readonly private CultureInfo cultureInfo = new CultureInfo(Constantes.Cultureinfo);
        private SqlDataReader sqldr;

        public DataTable Estado(string parNomeEstado = "")
        {
            sqldr = null;
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Clear();
                dataTable.Columns.Clear();

                sqlcmd.CommandText =
                    @"Select 
                        NomeEstado
                        ,Sigla
	                    ,StatusEstado
                        ,idEstado 
                    FROM ESTADO";

                if (!string.IsNullOrEmpty(parNomeEstado))
                {
                    sqlcmd.CommandText += " WHERE NomeEstado like @NomeEstado";
                }

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NomeEstado", "%" + parNomeEstado + "%");

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    dataTable.Columns.Add("Nome Estado", typeof(string));
                    dataTable.Columns.Add("Sigla", typeof(string));
                    dataTable.Columns.Add("Status", typeof(string));
                    dataTable.Columns.Add("Código", typeof(string));

                    while (sqldr.Read())
                    {
                        dataTable.Rows.Add
                            (
                                sqldr["NomeEstado"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeEstado"], cultureInfo),
                                sqldr["Sigla"] == DBNull.Value ? "" : Convert.ToString(sqldr["Sigla"], cultureInfo),
                                sqldr["StatusEstado"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusEstado"], cultureInfo),
                                sqldr["idEstado"] == DBNull.Value ? "" : Convert.ToString(sqldr["idEstado"], cultureInfo)
                            );
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }
        public DataTable Cidade(string parNomeCidade = "")
        {
            sqldr = null;
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Clear();
                dataTable.Columns.Clear();

                sqlcmd.CommandText =
                    @"Select 
                        cit.idCidade
	                    ,EST.Sigla
                        ,cit.NomeCidade
                        ,cit.StatusCidade
                    FROM cidade cit
                    INNER JOIN Estado EST ON EST.idEstado = CIT.idEstado";

                if (!string.IsNullOrEmpty(parNomeCidade))
                {
                    sqlcmd.CommandText += " WHERE NomeCidade like @NomeCidade";
                }

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NomeCidade", "%" + parNomeCidade + "%");

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    dataTable.Columns.Add("Nome Cidade", typeof(string));
                    dataTable.Columns.Add("Estado", typeof(string));
                    dataTable.Columns.Add("Status", typeof(string));
                    dataTable.Columns.Add("Código", typeof(string));

                    while (sqldr.Read())
                    {
                        dataTable.Rows.Add
                            (
                                sqldr["NomeCidade"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeCidade"], cultureInfo),
                                sqldr["Sigla"] == DBNull.Value ? "" : Convert.ToString(sqldr["Sigla"], cultureInfo),
                                sqldr["StatusCidade"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusCidade"], cultureInfo),
                                sqldr["idCidade"] == DBNull.Value ? "" : Convert.ToString(sqldr["idCidade"], cultureInfo)
                            );
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }
        public DataTable Cargo(string parNomeCargo = "")
        {
            sqldr = null;
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Clear();
                dataTable.Columns.Clear();

                sqlcmd.CommandText =
                    @"SELECT idCargo,NomeCargo,StatusCargo FROM Cargo ";

                if (!string.IsNullOrEmpty(parNomeCargo))
                {
                    sqlcmd.CommandText += " WHERE NomeCargo like @NomeCidade";
                }

                sqlcmd.Parameters.Clear();
                if (!string.IsNullOrEmpty(parNomeCargo))
                {
                    sqlcmd.Parameters.AddWithValue("@NomeCidade", "%" + parNomeCargo + "%");
                }

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    dataTable.Columns.Add("Nome Cargo", typeof(string));
                    dataTable.Columns.Add("Status", typeof(string));
                    dataTable.Columns.Add("Código", typeof(string));

                    while (sqldr.Read())
                    {
                        dataTable.Rows.Add
                            (
                                sqldr["NomeCargo"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeCargo"], cultureInfo),
                                sqldr["StatusCargo"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusCargo"], cultureInfo),
                                sqldr["idCargo"] == DBNull.Value ? "" : Convert.ToString(sqldr["idCargo"], cultureInfo)
                            );
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }
        public DataTable Funcionario(string parNomeFuncionario = "")
        {
            sqldr = null;
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Clear();
                dataTable.Columns.Clear();

                sqlcmd.CommandText =
                    @"SELECT 
                        FUN.idfuncionario
                        ,CARG.NomeCargo
                        ,FUN.NomeFuncionario 
                        ,FUN.StatusFuncionario
                        FROM Funcionario FUN
                        INNER JOIN CARGO CARG ON CARG.idCargo = FUN.idCargo";

                if (!string.IsNullOrEmpty(parNomeFuncionario))
                {
                    sqlcmd.CommandText += " WHERE NomeFuncionario like @NomeFuncionario";
                }

                sqlcmd.Parameters.Clear();
                if (!string.IsNullOrEmpty(parNomeFuncionario))
                {
                    sqlcmd.Parameters.AddWithValue("@NomeFuncionario", "%" + parNomeFuncionario + "%");
                }

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    dataTable.Columns.Add("Nome Funcionario", typeof(string));
                    dataTable.Columns.Add("Cargo", typeof(string));
                    dataTable.Columns.Add("Status", typeof(string));
                    dataTable.Columns.Add("Código", typeof(string));

                    while (sqldr.Read())
                    {
                        dataTable.Rows.Add
                            (
                                sqldr["NomeFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeFuncionario"], cultureInfo),
                                sqldr["NomeCargo"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeCargo"], cultureInfo),
                                sqldr["StatusFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusFuncionario"], cultureInfo),
                                sqldr["idfuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["idfuncionario"], cultureInfo)
                            );
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }
        public DataTable Lote(string parLote = "")
        {
            sqldr = null;
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Clear();
                dataTable.Columns.Clear();

                sqlcmd.CommandText =
                    @"Select lot.NumeroLote
                        ,pro.NomeProduto
                        ,lot.StatusLote 
                        ,lot.idLote
                from lote as lot
                inner join Produto as pro on pro.idProduto = lot.idProduto";

                if (!string.IsNullOrEmpty(parLote))
                {
                    sqlcmd.CommandText += " WHERE NumeroLote like @NumeroLote";
                }

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NumeroLote", "%" + parLote + "%");

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    dataTable.Columns.Add("Numero Lote", typeof(string));
                    dataTable.Columns.Add("Produto", typeof(string));
                    dataTable.Columns.Add("Status Lote", typeof(string));
                    dataTable.Columns.Add("Código", typeof(string));

                    while (sqldr.Read())
                    {
                        dataTable.Rows.Add
                            (
                                sqldr["NumeroLote"] == DBNull.Value ? "" : Convert.ToString(sqldr["NumeroLote"], cultureInfo),
                                sqldr["NomeProduto"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeProduto"], cultureInfo),
                                sqldr["StatusLote"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusLote"], cultureInfo),
                                sqldr["idLote"] == DBNull.Value ? "" : Convert.ToString(sqldr["idLote"], cultureInfo)
                            );
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }
        public DataTable Marca(string parNomeMarca = "")
        {
            sqldr = null;
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Clear();
                dataTable.Columns.Clear();

                sqlcmd.CommandText =
                    @" Select idMarca,NomeMarca,StatusMarca from marca ";

                if (!string.IsNullOrEmpty(parNomeMarca))
                {
                    sqlcmd.CommandText += " WHERE NomeMarca like @NomeMarca";
                }

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NomeMarca", "%" + parNomeMarca + "%");

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    dataTable.Columns.Add("Nome Marca", typeof(string));
                    dataTable.Columns.Add("Status", typeof(string));
                    dataTable.Columns.Add("Código", typeof(string));

                    while (sqldr.Read())
                    {
                        dataTable.Rows.Add
                            (
                                sqldr["NomeMarca"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeMarca"], cultureInfo),
                                sqldr["StatusMarca"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusMarca"], cultureInfo),
                                sqldr["idMarca"] == DBNull.Value ? "" : Convert.ToString(sqldr["idMarca"], cultureInfo)
                            );
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }
        public DataTable Produto(string parNomeProduto = "")
        {
            sqldr = null;
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Clear();
                dataTable.Columns.Clear();

                sqlcmd.CommandText =
                    @" SELECT pro.NomeProduto
                            ,mar.NomeMarca
                            ,pro.StatusProduto
                            ,pro.idProduto 
                    FROM Produto as pro
                    inner join marca as mar on mar.idMarca = pro.idMarca";

                if (!string.IsNullOrEmpty(parNomeProduto))
                {
                    sqlcmd.CommandText += " WHERE NomeProduto like @NomeProduto";
                }

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NomeProduto", "%" + parNomeProduto + "%");

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    dataTable.Columns.Add("Nome Produto", typeof(string));
                    dataTable.Columns.Add("Marca", typeof(string));
                    dataTable.Columns.Add("Status", typeof(string));
                    dataTable.Columns.Add("Código", typeof(int));

                    while (sqldr.Read())
                    {
                        dataTable.Rows.Add
                            (
                                sqldr["NomeProduto"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeProduto"], cultureInfo),
                                sqldr["NomeMarca"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeMarca"], cultureInfo),
                                sqldr["StatusProduto"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusProduto"], cultureInfo),
                                sqldr["idProduto"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["idProduto"], cultureInfo)
                            );
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }

        public EstadoBO GetEstadoByID(int parIdEstado)
        {
            try
            {
                EstadoBO ObjEstado = new EstadoBO();

                sqlcmd.CommandText =
                    @"Select 
                        NomeEstado
                        ,Sigla
	                    ,StatusEstado
                        ,idEstado 
                    FROM ESTADO";

                sqlcmd.CommandText += " WHERE idEstado = @IdEstado";
                

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IdEstado", parIdEstado);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    if(sqldr.Read())
                    {
                        ObjEstado.NomeEstado = sqldr["NomeEstado"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeEstado"], cultureInfo);
                        ObjEstado.SiglaEstado = sqldr["Sigla"] == DBNull.Value ? "" : Convert.ToString(sqldr["Sigla"], cultureInfo);
                        ObjEstado.Status = sqldr["StatusEstado"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusEstado"], cultureInfo);
                        ObjEstado.IdEstado = sqldr["idEstado"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["idEstado"], cultureInfo);
                    }
                }
                
                return ObjEstado;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public CidadeBO GetCidadeByID(int parIdCidade)
        {
            try
            {
                CidadeBO ObjCidadeBO = new CidadeBO();

                sqlcmd.CommandText =
                    @"Select 
                        cit.idCidade
                        ,EST.NomeEstado
                        ,EST.idEstado
                        ,cit.NomeCidade
                        ,cit.StatusCidade
                    FROM cidade cit
                    INNER JOIN Estado EST ON EST.idEstado = CIT.idEstado
                    where cit.idCidade = @idCidade";


                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@idCidade", parIdCidade);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    if (sqldr.Read())
                    {
                        ObjCidadeBO.NomeEstado = sqldr["NomeEstado"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeEstado"], cultureInfo);
                        ObjCidadeBO.NomeCidade = sqldr["NomeCidade"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeCidade"], cultureInfo);
                        ObjCidadeBO.IdEstado = sqldr["idEstado"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["idEstado"], cultureInfo);
                        ObjCidadeBO.Status = sqldr["StatusCidade"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusCidade"], cultureInfo);
                    }
                }

                return ObjCidadeBO;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public CargoBO GetCargoByID(int parIdCargo)
        {
            try
            {
                CargoBO ObjCargoBO = new CargoBO();

                sqlcmd.CommandText =
                    @"select NomeCargo, StatusCargo from cargo";

                sqlcmd.CommandText += " WHERE idCargo = @idCargo";


                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@idCargo", parIdCargo);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    if (sqldr.Read())
                    {
                        ObjCargoBO.NomeCargo = sqldr["NomeCargo"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeCargo"], cultureInfo);
                        ObjCargoBO.StatusCargo = sqldr["StatusCargo"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusCargo"], cultureInfo);
                    }
                }

                return ObjCargoBO;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public FuncionarioBO GetFuncionarioByID(int parIdFuncionario)
        {

            sqldr = null;
            try
            {
                FuncionarioBO ObjFuncionarioBO = new FuncionarioBO();

                sqlcmd.CommandText =
                    @"SELECT 
                        FUN.IdFuncionario
                        ,FUN.idCargo 
                        ,CARG.NomeCargo
                        ,FUN.idCidade 
                        ,CIT.NomeCidade
                        ,FUN.NomeFuncionario 
                        ,FUN.EnderecoFuncionario 
                        ,FUN.SexoFuncionario 
                        ,FUN.FoneFuncionario 
                        ,FUN.CPFFuncionario 
                        ,FUN.RGFuncionario 
                        ,FUN.DataNascimentoFuncionario
                        ,FUN.EmailFuncionario
                        ,FUN.FoneFuncionario
                        ,FUN.Salario 
                        ,FUN.StatusFuncionario
                        FROM Funcionario FUN
                        INNER JOIN Cidade CIT ON CIT.idCidade = FUN.idCidade
                        INNER JOIN CARGO CARG ON CARG.idCargo = FUN.idCargo
                        WHERE IdFuncionario = @IdFuncionario";


                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IdFuncionario", parIdFuncionario);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    if (sqldr.Read())
                    {
                        ObjFuncionarioBO.IdFuncionario = sqldr["IdFuncionario"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IdFuncionario"], cultureInfo);
                        ObjFuncionarioBO.IdCargo = sqldr["idCargo"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["idCargo"], cultureInfo);
                        ObjFuncionarioBO.NomeCargo = sqldr["NomeCargo"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeCargo"], cultureInfo);
                        ObjFuncionarioBO.IdCidade = sqldr["idCidade"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["idCidade"], cultureInfo);
                        ObjFuncionarioBO.NomeCidade = sqldr["NomeCidade"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeCidade"], cultureInfo);
                        ObjFuncionarioBO.NomeFuncionario = sqldr["NomeFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeFuncionario"], cultureInfo);
                        ObjFuncionarioBO.EnderecoFuncionario = sqldr["EnderecoFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["EnderecoFuncionario"], cultureInfo);
                        ObjFuncionarioBO.SexoFuncionario = sqldr["SexoFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["SexoFuncionario"], cultureInfo);
                        ObjFuncionarioBO.FoneFuncionario = sqldr["FoneFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["FoneFuncionario"], cultureInfo);
                        ObjFuncionarioBO.CPFFuncionario = sqldr["CPFFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["CPFFuncionario"], cultureInfo);
                        ObjFuncionarioBO.RGFuncionario = sqldr["RGFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["RGFuncionario"], cultureInfo);
                        ObjFuncionarioBO.DataNascimentoFuncionario = sqldr["DataNascimentoFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["DataNascimentoFuncionario"], cultureInfo);
                        ObjFuncionarioBO.EmailFuncionario = sqldr["EmailFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["EmailFuncionario"], cultureInfo);
                        ObjFuncionarioBO.Salario = sqldr["Salario"] == DBNull.Value ? 0 : Convert.ToDecimal(sqldr["Salario"], cultureInfo);
                        ObjFuncionarioBO.StatusFuncionario = sqldr["StatusFuncionario"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusFuncionario"], cultureInfo);
                    }
                }

                return ObjFuncionarioBO;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqldr?.Close();
            }
        }
        public MarcaBo GetMarcaByID(int paridMarca)
        {
            try
            {
                MarcaBo ObjMarcaBo = new MarcaBo();

                sqlcmd.CommandText =
                    @"Select idMarca,NomeMarca,StatusMarca from marca ";

                sqlcmd.CommandText += " WHERE idMarca = @idMarca";


                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@idMarca", paridMarca);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    if (sqldr.Read())
                    {
                        ObjMarcaBo.NomeMarca = sqldr["NomeMarca"] == DBNull.Value ? "" : Convert.ToString(sqldr["NomeMarca"], cultureInfo);
                        ObjMarcaBo.StatusMarca = sqldr["StatusMarca"] == DBNull.Value ? "" : Convert.ToString(sqldr["StatusMarca"], cultureInfo);
                        ObjMarcaBo.IdMarca = sqldr["idMarca"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["idMarca"], cultureInfo);
                    }
                }

                return ObjMarcaBo;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
