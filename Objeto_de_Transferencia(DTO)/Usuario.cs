using Conexao_SQLServer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Objeto_de_Transferencia
{
    public class Usuario
    {
        public Int32 IdUsuario { get; set; }
        public String NomeCompleto { get; set; }
        public String LoginUsuario { get; set; }
        public String Senha { get; set; }
        public Boolean  Credencial { get; set; }

       
        public Usuario GetLogin(String Nome, String Login, String Senha)
        {
            Conect conexao = new Conect();
            SqlConnection conn = new SqlConnection(conexao.sql);
            SqlDataReader reader;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Sp_AutenticaAdm", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //passa os parametros com valor
            cmd.Parameters.AddWithValue("@NomeCompleto", Nome);
            cmd.Parameters.AddWithValue("@LoginUsuario", Login);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Parameters.AddWithValue("@Credencial", Credencial);

            //atribui o resultado da query para o leitor
            reader = cmd.ExecuteReader();

            //verifica se há linhas no leitor
            if (reader.HasRows)
            {
                //faz a leitura da linha
                reader.Read();
               
                IdUsuario = reader.GetInt32(0);
                NomeCompleto = reader.GetString(1);
                LoginUsuario = reader.GetString(2);
                Senha = reader.GetString(3);
                Credencial = reader.GetBoolean(4);

            }

            reader.Close();
            return this;
        }
    }
}
         