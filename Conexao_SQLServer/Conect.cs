using System;
using System.Data;
using System.Data.SqlClient;
using Conexao_SQLServer.Properties;

// Classe DAL:

namespace Conexao_SQLServer
{
    public class Conect
    {
        public String sql = (Settings.Default.String);
                                                                
        public SqlConnection Conexao()
        {
            return new SqlConnection(sql);
        }
        
        public void FecharConexao()
        {
            SqlConnection conn = Conexao();
            conn.Close();
        }

        // Parâmetros que vão para o Banco
        private SqlParameterCollection colecao = new SqlCommand().Parameters;

        public void LimpaParametros()
        {
            colecao.Clear();
        }

        public void AddParametros(String nome, Object valor)
        {
            colecao.Add(new SqlParameter(nome, valor));
        }

        // Persistência - Inserir, Alterar, Excluir.
        public Object ExecutaManipulacao(CommandType commandType, String Sp_Ou_Texto)
        {
            try
            {
                SqlConnection conn = Conexao();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = Sp_Ou_Texto;
                cmd.CommandTimeout = 3600;

                foreach (SqlParameter param in colecao)
                {
                    cmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
                }

                return cmd.ExecuteScalar();
            }

            catch (Exception ex)
            {
                throw new Exception("ERRO, Detalhe :" + ex.Message);
            }
        }
        // Consultar Registro do Banco de Dados
        public DataTable ExecutaConsulta(CommandType commandType, String Sp_Ou_Texto)
        {
            try
            {
                SqlConnection conn = Conexao();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = Sp_Ou_Texto;
                cmd.CommandTimeout = 3600;

                foreach (SqlParameter param in colecao)
                {
                    cmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO, Detalhe :" + ex.Message);
            }
        }
    }
}