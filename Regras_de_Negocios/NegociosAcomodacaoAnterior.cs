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
    public class NegociosAcomodacaoAnterior
    {
        Conect conect = new Conect();

        public String Insere_AcomodacaoAnterior(acomodacaoAnterior  acomodAnt)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", acomodAnt.IdPaciente);
                conect.AddParametros("@NomePaciente", acomodAnt.NomePaciente);
                conect.AddParametros("@Data", acomodAnt.Data);
                conect.AddParametros("@IdDiaria", acomodAnt.IdDiaria);
                conect.AddParametros("@LocalAcomodado", acomodAnt.LocalAcomodado);
                conect.AddParametros("@diasAcomodado", acomodAnt.diasAcomodado);
                conect.AddParametros("@ValorAcomodacao", acomodAnt.ValorAcomodacao);
                conect.AddParametros("@Valor_Total", acomodAnt.Valor_Total);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereAcomodacaoAnterior").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Deleta_AcomodacaoAnterior(acomodacaoAnterior acomod)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", acomod.IdPaciente);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaAcomodacaoAnteriorId").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public AcomodacaoAnteriorColecao  ConsultaAcomodacaoAnteriorNome(String consultaAcomodacao)
        {
            try
            {
                AcomodacaoAnteriorColecao colecao = new AcomodacaoAnteriorColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomePaciente", consultaAcomodacao);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaAcomodacaoAnterior");
                foreach (DataRow linha in dt.Rows)
                {
                    acomodacaoAnterior acomodacao = new acomodacaoAnterior();
                    acomodacao.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    acomodacao.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    acomodacao.Data = Convert.ToDateTime(linha["Data"]);
                    acomodacao.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    acomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    acomodacao.diasAcomodado = Convert.ToInt32(linha["diasAcomodado"]);
                    acomodacao.ValorAcomodacao = Convert.ToDecimal(linha["ValorAcomodacao"]);
                    acomodacao.Valor_Total = Convert.ToDecimal(linha["Valor_Total"]);
                    colecao.Add(acomodacao);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Custos pelo Nome de Paciente Informado. Detalhe:" + ex.Message);
            }
        }

        public AcomodacaoAnteriorColecao ConsultaAcomodacaoAnteriorId(Int64 consultaAcomodacaoId)
        {
            try
            {
                AcomodacaoAnteriorColecao colecao = new AcomodacaoAnteriorColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", consultaAcomodacaoId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaAcomodacaoAnteriorId");
                foreach (DataRow linha in dt.Rows)
                {
                    acomodacaoAnterior acomodacao = new acomodacaoAnterior();
                    acomodacao.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    acomodacao.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    acomodacao.Data = Convert.ToDateTime(linha["Data"]);
                    acomodacao.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    acomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    acomodacao.diasAcomodado = Convert.ToInt32(linha["diasAcomodado"]);
                    acomodacao.ValorAcomodacao = Convert.ToDecimal(linha["ValorAcomodacao"]);
                    acomodacao.Valor_Total = Convert.ToDecimal(linha["Valor_Total"]);
                    colecao.Add(acomodacao);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Custos pelo Código de Paciente Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
