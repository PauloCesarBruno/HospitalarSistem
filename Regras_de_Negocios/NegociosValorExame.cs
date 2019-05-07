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
    public class NegociosValorExame
    {
        Conect conect = new Conect();

        public String InsereCustoExame (Exames examesCusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdExame", examesCusto.IdExame);
                conect.AddParametros("@NomeExame", examesCusto.NomeExame);
                conect.AddParametros("@ValorExame", examesCusto.ValorExame);
                String IdExame = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereCustoExame").ToString();
                conect.FecharConexao();
                return IdExame;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String AlteraCustoExame(Exames examesCusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdExame", examesCusto.IdExame);
                conect.AddParametros("@NomeExame", examesCusto.NomeExame);
                conect.AddParametros("@ValorExame", examesCusto.ValorExame);
                String IdExame = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraCustoExame").ToString();
                conect.FecharConexao();
                return IdExame;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String ExcluiCustoExame(Exames examesCusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdExame", examesCusto.IdExame);
                String IdExame = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaCustoExame").ToString();
                conect.FecharConexao();
                return IdExame;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public ExamesColecao ConsultaCustoExameNome (String exameNome)
        {
            try
            {
                ExamesColecao colecao = new ExamesColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeExame", exameNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustoExameNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Exames Ecusto = new Exames();
                    Ecusto.IdExame = Convert.ToInt32(linha["IdExame"]);
                    Ecusto.NomeExame = Convert.ToString(linha["NomeExame"]);
                    Ecusto.ValorExame = Convert.ToDecimal(linha["ValorExame"]);
                    colecao.Add(Ecusto);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Exame pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public ExamesColecao ConsultaCustoExameId(Int32 IdExame)
        {
            try
            {
                ExamesColecao colecao = new ExamesColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdExame", IdExame);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustoExameId");
                foreach (DataRow linha in dt.Rows)
                {
                    Exames Ecusto = new Exames();
                    Ecusto.IdExame = Convert.ToInt32(linha["IdExame"]);
                    Ecusto.NomeExame = Convert.ToString(linha["NomeExame"]);
                    Ecusto.ValorExame = Convert.ToDecimal(linha["ValorExame"]);
                    colecao.Add(Ecusto);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Exame pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
