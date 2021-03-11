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
    public class NegociosProntuario
    {
        Conect conect = new Conect();

        public String Insere_Prontuario(Prontuario prontuario)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@Data", prontuario.Data);
                conect.AddParametros("@IdPaciente", prontuario.IdPaciente);
                conect.AddParametros("@NomePaciente", prontuario.NomePaciente);
                conect.AddParametros("@ProntuarioPaciente", prontuario.ProntuarioPaciente);
                String Data = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereProntuario").ToString();
                conect.FecharConexao();
                return Data;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Altera_Prontuario(Prontuario  prontuario)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@Data", prontuario.Data);
                conect.AddParametros("@IdPaciente", prontuario.IdPaciente);
                conect.AddParametros("@NomePaciente", prontuario.NomePaciente);
                conect.AddParametros("@ProntuarioPaciente", prontuario.ProntuarioPaciente);
                String Data = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraProntuario").ToString();
                conect.FecharConexao();
                return Data;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Exclui_Prontuario(Prontuario  prontuario)
        {
            try
            {
                conect.AddParametros("@IdPaciente", prontuario.IdPaciente);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaProntuario").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }
        public ProntuarioColecao  ConsultaProntuarioPorNome(String nomeProntuario)
        {
            try
            {
                ProntuarioColecao colecao = new ProntuarioColecao();
                conect.AddParametros("@NomePaciente", nomeProntuario);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaProntuarioNome");
                foreach (DataRow linha in dt.Rows)
                {
                   Prontuario prontuario = new Prontuario();
                   prontuario.Data = Convert.ToDateTime (linha["Data"]);
                   prontuario.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                   prontuario.NomePaciente = Convert.ToString (linha["NomePaciente"]);
                   prontuario.ProntuarioPaciente = Convert.ToString(linha["ProntuarioPaciente"]);
                   colecao.Add(prontuario);
                   conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Prontuario pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public ProntuarioColecao  ConsultaProntuarioPorId(Int64 IdProntuario)
        {
            try
            {
                ProntuarioColecao colecao = new ProntuarioColecao();
                conect.AddParametros("@IdPaciente", IdProntuario);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaProntuarioId");
                foreach (DataRow linha in dt.Rows)
                {
                    Prontuario prontuario = new Prontuario();
                    prontuario.Data = Convert.ToDateTime(linha["Data"]);
                    prontuario.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    prontuario.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    prontuario.ProntuarioPaciente = Convert.ToString(linha["ProntuarioPaciente"]);
                    colecao.Add(prontuario);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Prontuario pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
