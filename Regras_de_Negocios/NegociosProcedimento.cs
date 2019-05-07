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
    public class NegociosProcedimento
    {
        Conect conect = new Conect();

        public String InsereProcedimento(Procedimento procedimento)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdProcedimento", procedimento.IdProcedimento);
                conect.AddParametros("@ProcedimentoInternacao", procedimento.ProcedimentoInternacao);
                String IdProcedimento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereProcedimento").ToString();
                conect.FecharConexao();
                return IdProcedimento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String AlteraProcedimento(Procedimento procedimento)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdProcedimento", procedimento.IdProcedimento);
                conect.AddParametros("@ProcedimentoInternacao", procedimento.ProcedimentoInternacao);
                String IdProcedimento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraProcedimento").ToString();
                conect.FecharConexao();
                return IdProcedimento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String ExcluiProcedimento(Procedimento procedimento)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdProcedimento", procedimento.IdProcedimento);
                String IdProcedimento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaProcedimento").ToString();
                conect.FecharConexao();
                return IdProcedimento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public ProcedimentoColecao  ConsultaProcedimentoNome(String ProcNome)
        {
            try
            {
                ProcedimentoColecao colecao = new ProcedimentoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@ProcedimentoInternacao", ProcNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaProcedimentoNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Procedimento procedimento = new Procedimento();
                    procedimento.IdProcedimento = Convert.ToInt32(linha["IdProcedimento"]);
                    procedimento.ProcedimentoInternacao = Convert.ToString(linha["ProcedimentoInternacao"]);
                    colecao.Add(procedimento);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Procedimento pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public ProcedimentoColecao ConsultaProcedimentoId(Int32 ProcId)
        {
            try
            {
                ProcedimentoColecao colecao = new ProcedimentoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdProcedimento", ProcId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaProcedimentoId");
                foreach (DataRow linha in dt.Rows)
                {
                    Procedimento procedimento = new Procedimento();
                    procedimento.IdProcedimento = Convert.ToInt32(linha["IdProcedimento"]);
                    procedimento.ProcedimentoInternacao = Convert.ToString(linha["ProcedimentoInternacao"]);
                    colecao.Add(procedimento);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Procedimento pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
