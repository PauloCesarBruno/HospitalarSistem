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
    public class NegociosAcomodacoes
    {
        Conect conect = new Conect();

        public AcomodacoesColecao ConsultaNome(String consulta)
        {
            try
            {
                AcomodacoesColecao colecao = new AcomodacoesColecao();
                conect.LimpaParametros();
                conect.AddParametros("@LocalAcomodado", consulta);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultalLocalAcomodado");
                foreach (DataRow linha in dt.Rows)
                {
                    Acomodacoes acomodacao = new Acomodacoes();
                    acomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    acomodacao.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    acomodacao.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    acomodacao.Leito = Convert.ToInt32(linha["Leito"]);
                    acomodacao.Quarto = Convert.ToInt32(linha["Quarto"]);
                    colecao.Add(acomodacao);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Acomodação pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public AcomodacoesColecao ConsultaNomePaciente(String consultaPaciente)
        {
            try
            {
                AcomodacoesColecao colecao = new AcomodacoesColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomePaciente", consultaPaciente);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultalLocalAcomodadoPaciente");
                foreach (DataRow linha in dt.Rows)
                {
                    Acomodacoes acomodacao = new Acomodacoes();
                    acomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    acomodacao.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    acomodacao.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    acomodacao.Leito = Convert.ToInt32(linha["Leito"]);
                    acomodacao.Quarto = Convert.ToInt32(linha["Quarto"]);
                    colecao.Add(acomodacao);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Acomodação pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public AcomodacoesColecao ConsultaNomePacienteID(Int64 consultaPacienteId)
        {
            try
            {
                AcomodacoesColecao colecao = new AcomodacoesColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", consultaPacienteId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaAcomodacaoIdPaciente");
                foreach (DataRow linha in dt.Rows)
                {
                    Acomodacoes acomodacao = new Acomodacoes();
                    acomodacao.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    acomodacao.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    acomodacao.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    acomodacao.Leito = Convert.ToInt32(linha["Leito"]);
                    acomodacao.Quarto = Convert.ToInt32(linha["Quarto"]);
                    colecao.Add(acomodacao);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Acomodação pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
