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
    public class Negocios_Outros_Funcionarios
    {
        Conect conect = new Conect();

        public String InsereOutrosFuncionarios(Outros_Funcionarios outros_funcionarios )
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdFuncionario", outros_funcionarios.IdFuncionario);
                conect.AddParametros("@NomeFuncionario", outros_funcionarios.NomeFuncionario);
                conect.AddParametros("@Cargo", outros_funcionarios.Cargo);
                conect.AddParametros("@Admissao", outros_funcionarios.Admissao);
                conect.AddParametros("@CPTS", outros_funcionarios.CPTS);
                conect.AddParametros("@CPF", outros_funcionarios.CPF);
                conect.AddParametros("@RG", outros_funcionarios.RG);
                conect.AddParametros("@Endereco", outros_funcionarios.Endereco);
                conect.AddParametros("@Telefone", outros_funcionarios.Telefone);
                conect.AddParametros("@Celular", outros_funcionarios.Celular);
                conect.AddParametros("@Email", outros_funcionarios.Email);
                conect.AddParametros("@Observacoes", outros_funcionarios.Observacoes);
                String IdFuncionario = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereOutrosFuncionarios").ToString();
                conect.FecharConexao();
                return IdFuncionario;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String ExcluirOutrosFuncionarios(Outros_Funcionarios outros_funcionarios)
        {
            try
            {
                conect.AddParametros("@IdFuncionario", outros_funcionarios .IdFuncionario);
                String IdFuncionario = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaOutrosFuncionarios").ToString();
                conect.FecharConexao();
                return IdFuncionario;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }

        public String AlteraOutrosFuncionarios(Outros_Funcionarios outros_funcionarios)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdFuncionario", outros_funcionarios.IdFuncionario);
                conect.AddParametros("@NomeFuncionario", outros_funcionarios.NomeFuncionario);
                conect.AddParametros("@Cargo", outros_funcionarios.Cargo);
                conect.AddParametros("@Admissao", outros_funcionarios.Admissao);
                conect.AddParametros("@CPTS", outros_funcionarios.CPTS);
                conect.AddParametros("@CPF", outros_funcionarios.CPF);
                conect.AddParametros("@RG", outros_funcionarios.RG);
                conect.AddParametros("@Endereco", outros_funcionarios.Endereco);
                conect.AddParametros("@Telefone", outros_funcionarios.Telefone);
                conect.AddParametros("@Celular", outros_funcionarios.Celular);
                conect.AddParametros("@Email", outros_funcionarios.Email);
                conect.AddParametros("@Observacoes", outros_funcionarios.Observacoes);
                String IdFuncionario = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraOutrosFuncionarios").ToString();
                conect.FecharConexao();
                return IdFuncionario;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public Outros_FuncionariosColecao ConsultaOutrosFuncionariosNome (String nomefuncionario)
        {
            try
            {
                Outros_FuncionariosColecao colecao = new Outros_FuncionariosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeFuncionario", nomefuncionario);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaOutrosFuncionariosNome");
                 foreach (DataRow linha in dt.Rows)
                {
                   Outros_Funcionarios outros_funcionarios = new Outros_Funcionarios ();
                   outros_funcionarios.IdFuncionario  = Convert.ToInt32(linha["IdFuncionario"]);
                   outros_funcionarios.NomeFuncionario  = Convert.ToString(linha["NomeFuncionario"]);
                   outros_funcionarios.Cargo   = Convert.ToString(linha["Cargo"]);
                   outros_funcionarios.Admissao   = Convert.ToDateTime (linha["Admissao"]);
                   outros_funcionarios.CPTS   = Convert.ToString  (linha["CPTS"]);
                   outros_funcionarios.CPF = Convert.ToString  (linha["CPF"]);
                   outros_funcionarios.RG = Convert.ToString (linha["RG"]);
                   outros_funcionarios.Endereco = Convert.ToString (linha["Endereco"]);
                   outros_funcionarios.Telefone = Convert.ToString (linha["Telefone"]);
                   outros_funcionarios.Celular = Convert.ToString (linha["Celular"]);
                   outros_funcionarios.Email = Convert.ToString (linha["Email"]);
                   outros_funcionarios.Observacoes = Convert.ToString (linha["Observacoes"]);
                   colecao.Add(outros_funcionarios);
                   conect.FecharConexao();
                }

                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Funcionário pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public Outros_FuncionariosColecao ConsultaOutrosFuncionariosId (Int32 IdFuncionario)
        {
            try
            {
                Outros_FuncionariosColecao colecao = new Outros_FuncionariosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdFuncionario", IdFuncionario);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaOutrosFuncionariosId");
                foreach (DataRow linha in dt.Rows)
                {
                    Outros_Funcionarios outros_funcionarios = new Outros_Funcionarios();
                    outros_funcionarios.IdFuncionario = Convert.ToInt32(linha["IdFuncionario"]);
                    outros_funcionarios.NomeFuncionario = Convert.ToString(linha["NomeFuncionario"]);
                    outros_funcionarios.Cargo = Convert.ToString(linha["Cargo"]);
                    outros_funcionarios.Admissao = Convert.ToDateTime(linha["Admissao"]);
                    outros_funcionarios.CPTS = Convert.ToString(linha["CPTS"]);
                    outros_funcionarios.CPF = Convert.ToString(linha["CPF"]);
                    outros_funcionarios.RG = Convert.ToString(linha["RG"]);
                    outros_funcionarios.Endereco = Convert.ToString(linha["Endereco"]);
                    outros_funcionarios.Telefone = Convert.ToString(linha["Telefone"]);
                    outros_funcionarios.Celular = Convert.ToString(linha["Celular"]);
                    outros_funcionarios.Email = Convert.ToString(linha["Email"]);
                    outros_funcionarios.Observacoes = Convert.ToString(linha["Observacoes"]);
                    colecao.Add(outros_funcionarios);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Funcionário pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
           
       
    }
}
