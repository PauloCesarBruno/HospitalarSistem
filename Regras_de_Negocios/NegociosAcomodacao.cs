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
    public class NegociosAcomodacao
    {
        Conect conect = new Conect();

        public String Insere_Acomodacao(Acomodacao acomod)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", acomod.IdPaciente);
                conect.AddParametros("@NomePaciente", acomod.NomePaciente);
                conect.AddParametros("@Data", acomod.Data);
                conect.AddParametros("@diasAcomodado", acomod.diasAcomodado);
                conect.AddParametros("@IdDiaria", acomod.IdDiaria);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereAcomodacao").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String Deleta_Acomodacao(Acomodacao acomod)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", acomod.IdPaciente);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaAcomodacao").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public AcomodacaoColecao ConsultaAcomodacaoNome(String consultaAcomodacao)
        {
            try
            {
                AcomodacaoColecao colecao = new AcomodacaoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", consultaAcomodacao);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaAcomodacao");
                foreach (DataRow linha in dt.Rows)
                {
                    Acomodacao acomodacao = new Acomodacao();
                    acomodacao.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    acomodacao.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    acomodacao.Data = Convert.ToDateTime(linha["Data"]);
                    acomodacao.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    acomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    acomodacao.Leito = Convert.ToString(linha["Leito"]);
                    acomodacao.Quarto = Convert.ToString(linha["Quarto"]);
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
                throw new Exception("Não Foi Possível Consultar Acomodação pelo Nome de Paciente Informado. Detalhe:" + ex.Message);
            }
        }

        public AcomodacaoColecao ConsultaAcomodacaoId(Int64 consultaAcomodacaoId)
        {
            try
            {
                AcomodacaoColecao colecao = new AcomodacaoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", consultaAcomodacaoId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaAcomodacaoIdPaciente");
                foreach (DataRow linha in dt.Rows)
                {
                    Acomodacao acomodacao = new Acomodacao();
                    acomodacao.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    acomodacao.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    acomodacao.Data = Convert.ToDateTime(linha["Data"]);
                    acomodacao.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    acomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    acomodacao.Leito = Convert.ToString(linha["Leito"]);
                    acomodacao.Quarto = Convert.ToString(linha["Quarto"]);
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
                throw new Exception("Não Foi Possível Consultar Acomodação pelo Código de Paciente Informado. Detalhe:" + ex.Message);
            }
        }
    }
}