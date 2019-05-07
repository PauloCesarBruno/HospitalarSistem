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
    public class NegociosLocalAcomodacao
    {
        Conect conect = new Conect();

        public String InsereLocalAcomodacao(LocalAcomodacao Lacomodacao)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdDiaria", Lacomodacao.IdDiaria);
                conect.AddParametros("@LocalAcomodado", Lacomodacao.LocalAcomodado);
                conect.AddParametros("@diasAcomodado", Lacomodacao.diasAcomodado);
                conect.AddParametros("@ValorAcomodacao", Lacomodacao.ValorAcomodacao);
                String IdDiaria = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereDiariaValor").ToString();
                conect.FecharConexao();
                return IdDiaria;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String AlteraLocalAcomodacao(LocalAcomodacao Lacomodacao)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdDiaria", Lacomodacao.IdDiaria);
                conect.AddParametros("@LocalAcomodado", Lacomodacao.LocalAcomodado);
                conect.AddParametros("@diasAcomodado", Lacomodacao.diasAcomodado);
                conect.AddParametros("@ValorAcomodacao", Lacomodacao.ValorAcomodacao);
                String IdDiaria = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraDiariaValor").ToString();
                conect.FecharConexao();
                return IdDiaria;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String ExcluiLocalAcomodacao(LocalAcomodacao Lacomodacao)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdDiaria", Lacomodacao.IdDiaria);
                String IdDiaria = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaDiariaValor").ToString();
                conect.FecharConexao();
                return IdDiaria;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public LocalAcomodacaoColecao  ConsultaLocalAcomodacaoNome(String LacomodNome)
        {
            try
            {
                LocalAcomodacaoColecao colecao = new LocalAcomodacaoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@LocalAcomodado", LacomodNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaDiariaValorLocal");
                foreach (DataRow linha in dt.Rows)
                {
                    LocalAcomodacao Lacomodacao = new LocalAcomodacao();
                    Lacomodacao.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    Lacomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    Lacomodacao.diasAcomodado = Convert.ToInt32(linha["diasAcomodado"]);
                    Lacomodacao.ValorAcomodacao = Convert.ToDecimal(linha["ValorAcomodacao"]);
                    colecao.Add(Lacomodacao);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Local de Acomodação pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public LocalAcomodacaoColecao ConsultaLocalAcomodacaoId(Int32 LacomodId)
        {
            try
            {
                LocalAcomodacaoColecao colecao = new LocalAcomodacaoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdDiaria", LacomodId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaDiariaValorId");
                foreach (DataRow linha in dt.Rows)
                {
                    LocalAcomodacao Lacomodacao = new LocalAcomodacao();
                    Lacomodacao.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    Lacomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    Lacomodacao.diasAcomodado = Convert.ToInt32(linha["diasAcomodado"]);
                    Lacomodacao.ValorAcomodacao = Convert.ToDecimal(linha["ValorAcomodacao"]);
                    colecao.Add(Lacomodacao);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Local de Acomodação pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
