using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _4Tec.Classes.BancoDados
{
    public class Cadastro
    {
        readonly private Conexao conexao;
        readonly private SqlCommand sqlcmd;

        public Cadastro()
        {
            conexao = new Conexao();
            sqlcmd = new SqlCommand();
        }

        public int SalvarCargo(string parNomeCargo,string parStatus, int parIdCargo)
        {
            try
            {
                if(parIdCargo == 0)
                {
                    sqlcmd.CommandText = @"INSERT INTO 
                        CARGO (NomeCargo
                                ,StatusCargo) 
                        VALUES ( @NomeCargo
                                ,'Ativo')";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeCargo", parNomeCargo);
                }
                else
                {
                    sqlcmd.CommandText = @"UPDATE Cargo 
                            SET NomeCargo = @NomeCargo
                            ,StatusCargo = @StatusCargo
                            WHERE idCargo = @idCargo";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeCargo", parNomeCargo);
                    sqlcmd.Parameters.AddWithValue("@StatusCargo", parStatus);
                    sqlcmd.Parameters.AddWithValue("@idCargo", parIdCargo);
                }

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int SalvarEstado(string parNomeEstado, string parSiglaEstado, string parStatus, int parIdEstado)
        {
            try
            {

                if (parIdEstado == 0)
                {
                    sqlcmd.CommandText = @"INSERT INTO 
                        Estado (NomeEstado
                                ,Sigla
                                ,StatusEstado
                                ) 
                        VALUES ( @NomeEstado
                                ,@SiglaEstado
                                ,'Ativo'
                                )";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeEstado", parNomeEstado);
                    sqlcmd.Parameters.AddWithValue("@SiglaEstado", parSiglaEstado);
                }
                else
                {
                    sqlcmd.CommandText = @"UPDATE Estado 
                            SET NomeEstado = @NomeEstado
                            ,Sigla = @Sigla 
                            ,StatusEstado = @StatusEstado
                            WHERE IdEstado = @IdEstado";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeEstado", parNomeEstado);
                    sqlcmd.Parameters.AddWithValue("@Sigla", parSiglaEstado);
                    sqlcmd.Parameters.AddWithValue("@StatusEstado", parStatus);
                    sqlcmd.Parameters.AddWithValue("@IdEstado", parIdEstado);
                }

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int SalvarCidade(string parNomeCidade, int parIdEstado, string parStatus, int parIdCidade)
        {
            try
            {
                if (parIdCidade == 0)
                {
                    sqlcmd.CommandText = @"INSERT INTO 
                        cidade (NomeCidade
                                ,idEstado
                                ,StatusCidade
                                ) 
                        VALUES ( @NomeCidade
                                ,@idEstado
                                ,'Ativo'
                                )";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeCidade", parNomeCidade);
                    sqlcmd.Parameters.AddWithValue("@idEstado", parIdEstado);
                }
                else
                {
                    sqlcmd.CommandText = @"UPDATE Cidade 
                            SET NomeCidade = @NomeCidade
                            ,idEstado = @idEstado
                            ,StatusCidade = @StatusCidade
                            WHERE idCidade = @idCidade";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeCidade", parNomeCidade);
                    sqlcmd.Parameters.AddWithValue("@idEstado", parIdEstado);
                    sqlcmd.Parameters.AddWithValue("@StatusCidade", parStatus);
                    sqlcmd.Parameters.AddWithValue("@idCidade", parIdCidade);
                }

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int SalvarFuncionario(int parIdFuncionario, int parIdCargo, int parIdCidade, string parNomeFuncionario, string parEndereco, string parTelefone, string parCpf, string parRg, string parEmail, DateTime parNascimento, decimal parSalario, string Status,string parSexoFuncionario)
        {
            try
            {
                if (parIdFuncionario == 0)
                {
                    sqlcmd.CommandText = @"
                        INSERT INTO 
                            Funcionario
                                (
                                idCargo 
                                ,idCidade 
                                ,NomeFuncionario 
                                ,EnderecoFuncionario 
                                ,SexoFuncionario 
                                ,FoneFuncionario 
                                ,CPFFuncionario 
                                ,RGFuncionario 
                                ,DataNascimentoFuncionario
                                ,EmailFuncionario
                                ,Salario 
                                ,StatusFuncionario
                                )
                            VALUES 
                                (
                                @idCargo 
                                ,@idCidade 
                                ,@NomeFuncionario 
                                ,@EnderecoFuncionario 
                                ,@SexoFuncionario 
                                ,@FoneFuncionario 
                                ,@CPFFuncionario 
                                ,@RGFuncionario 
                                ,@DataNascimentoFuncionario
                                ,@EmailFuncionario
                                ,@Salario 
                                ,'Ativo'
                                )";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@idCargo", parIdCargo);
                    sqlcmd.Parameters.AddWithValue("@idCidade", parIdCidade);
                    sqlcmd.Parameters.AddWithValue("@NomeFuncionario", parNomeFuncionario);
                    sqlcmd.Parameters.AddWithValue("@EnderecoFuncionario", parEndereco);
                    sqlcmd.Parameters.AddWithValue("@SexoFuncionario", parSexoFuncionario);
                    sqlcmd.Parameters.AddWithValue("@FoneFuncionario", parTelefone);
                    sqlcmd.Parameters.AddWithValue("@CPFFuncionario", parCpf.Replace(",", "").Replace("-", ""));
                    sqlcmd.Parameters.AddWithValue("@RGFuncionario", parRg);
                    sqlcmd.Parameters.AddWithValue("@DataNascimentoFuncionario", parNascimento);
                    sqlcmd.Parameters.AddWithValue("@EmailFuncionario", parEmail);
                    sqlcmd.Parameters.AddWithValue("@Salario", parSalario);

                }
                else
                {
                    sqlcmd.CommandText = @"
                            UPDATE Funcionario
                                SET idCargo = @idCargo
                                    ,idCidade = @idCidade
                                    ,NomeFuncionario = @NomeFuncionario
                                    ,EnderecoFuncionario = @EnderecoFuncionario
                                    ,SexoFuncionario = @SexoFuncionario
                                    ,FoneFuncionario = @FoneFuncionario
                                    ,CPFFuncionario = @CPFFuncionario
                                    ,RGFuncionario = @RGFuncionario
                                    ,DataNascimentoFuncionario = @DataNascimentoFuncionario
                                    ,EmailFuncionario = @EmailFuncionario
                                    ,Salario = @Salario
                                    ,StatusFuncionario = @StatusFuncionario
                                WHERE IdFuncionario = @IdFuncionario";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@idCargo", parIdCargo);
                    sqlcmd.Parameters.AddWithValue("@idCidade", parIdCidade);
                    sqlcmd.Parameters.AddWithValue("@NomeFuncionario", parNomeFuncionario);
                    sqlcmd.Parameters.AddWithValue("@EnderecoFuncionario", parEndereco);
                    sqlcmd.Parameters.AddWithValue("@FoneFuncionario", parTelefone);
                    sqlcmd.Parameters.AddWithValue("@CPFFuncionario", parCpf);
                    sqlcmd.Parameters.AddWithValue("@RGFuncionario", parRg);
                    sqlcmd.Parameters.AddWithValue("@DataNascimentoFuncionario", parNascimento);
                    sqlcmd.Parameters.AddWithValue("@EmailFuncionario", parEmail);
                    sqlcmd.Parameters.AddWithValue("@Salario", parSalario);
                    sqlcmd.Parameters.AddWithValue("@SexoFuncionario", parSexoFuncionario);
                    sqlcmd.Parameters.AddWithValue("@StatusFuncionario", Status);
                    sqlcmd.Parameters.AddWithValue("@IdFuncionario", parIdFuncionario);

                }

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int SalvarMarca(string parNomeMarca, string parStatus, int parIdMarca)
        {
            try
            {

                if (parIdMarca == 0)
                {
                    sqlcmd.CommandText = @"
                    INSERT INTO 
                        marca (NomeMarca
                                ,StatusMarca
                                ) 
                        VALUES ( @NomeMarca
                                ,'Ativo'
                                )";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeMarca", parNomeMarca);
                }
                else
                {
                    sqlcmd.CommandText = @"
                        UPDATE marca 
                            SET NomeMarca = @NomeMarca
                            ,StatusMarca = @StatusMarca
                            WHERE idMarca = @idMarca";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NomeMarca", parNomeMarca);
                    sqlcmd.Parameters.AddWithValue("@StatusMarca", parStatus);
                    sqlcmd.Parameters.AddWithValue("@idMarca", parIdMarca);
                }

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public int ExcluirCargo(int parIdCargo)
        {
            try
            {

                sqlcmd.CommandText = "DELETE cargo WHERE idCargo = @idCargo";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@idCargo", parIdCargo);

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int ExcluirEstado(int parIdEstado)
        {
            try
            {

                sqlcmd.CommandText = "DELETE Estado WHERE idEstado = @IdEstado";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IdEstado", parIdEstado);

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int ExcluirCidade(int parIdCidade)
        {
            try
            {

                sqlcmd.CommandText = "DELETE cidade WHERE idCidade = @idCidade";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@idCidade", parIdCidade);

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int ExcluirFuncionario(int parIdFuncionario)
        {
            try
            {

                sqlcmd.CommandText = "DELETE Funcionario WHERE IdFuncionario = @IdFuncionario";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IdFuncionario", parIdFuncionario);

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int ExcluirMarca(int paridMarca)
        {
            try
            {

                sqlcmd.CommandText = "DELETE marca WHERE idMarca = @idMarca";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@idMarca", paridMarca);

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public int ExcluirProduto(int paridProduto)
        {
            try
            {

                sqlcmd.CommandText = "DELETE Produto WHERE idProduto = @idProduto";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@idProduto", paridProduto);

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
