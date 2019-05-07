using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Conexao_SQLServer;
using Objeto_de_Transferencia;

namespace Regras_de_Negocios
{
    public class NegociosUsuarios
    {
        Conect conect = new Conect();
     
        public String IserirUsuario (Usuario usuario)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdUsuario", usuario.IdUsuario);
                conect.AddParametros("@NomeCompleto", usuario.NomeCompleto);
                conect.AddParametros("@LoginUsuario", usuario.LoginUsuario);
                conect.AddParametros("@Senha", usuario.Senha);
                conect.AddParametros("@Credencial", usuario.Credencial);
                String IdUsuario = conect.ExecutaManipulacao  (CommandType.StoredProcedure, "Sp_InsereUsuario"). ToString();
                conect.FecharConexao();
                return IdUsuario;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        
        public String ExcluirUsuario(Usuario usuario)
        {
            try
            {
                conect.AddParametros ("@IdUsuario", usuario .IdUsuario);
                String IdUsuario = conect.ExecutaManipulacao (CommandType.StoredProcedure, "Sp_DeletaUsuario").ToString();
                conect.FecharConexao();
                return IdUsuario;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }

        public String AlterarUsuario(Usuario usuario)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdUsuario", usuario.IdUsuario);
                conect.AddParametros("@NomeCompleto", usuario.NomeCompleto);
                conect.AddParametros("@LoginUsuario", usuario.LoginUsuario);
                conect.AddParametros("@Senha", usuario.Senha);
                String IdUsuario = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraUsuario").ToString();
                conect.FecharConexao();
                return IdUsuario;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public UsuarioColecao ConsultaUsuarioPorNome(String nomeusuario)
        {
            try
            {
                UsuarioColecao colecao = new UsuarioColecao();
                conect.LimpaParametros();
                conect.AddParametros  ("@NomeCompleto", nomeusuario);
                DataTable dt = conect.ExecutaConsulta (CommandType.StoredProcedure, "Sp_ConsultaUsuarioNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(linha["IdUsuario"]);
                    usuario.NomeCompleto = Convert.ToString(linha["NomeCompleto"]);
                    usuario.LoginUsuario  = Convert.ToString(linha["LoginUsuario"]);
                    usuario.Senha  = Convert.ToString(linha["Senha"]);
                    usuario.Credencial  = Convert.ToBoolean (linha["Credencial"]);
                    colecao.Add(usuario);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Usuario pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
              
        public UsuarioColecao ConsultaUsuarioPorId(Int32 IdUsuario)
        {
            try
            {
                UsuarioColecao colecao = new UsuarioColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdUsuario", IdUsuario);

                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaUsuarioId");
                foreach (DataRow linha in dt.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(linha["IdUsuario"]);
                    usuario.NomeCompleto = Convert.ToString(linha["NomeCompleto"]);
                    usuario.LoginUsuario = Convert.ToString(linha["LoginUsuario"]);
                    usuario.Senha = Convert.ToString(linha["Senha"]);
                    usuario.Credencial = Convert.ToBoolean(linha["Credencial"]);
                    colecao.Add(usuario);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Usuário pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}