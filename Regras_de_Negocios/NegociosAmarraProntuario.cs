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
    public class NegociosAmarraProntuario
    {
        Conect conect = new Conect();
        public AmarraProntuarioColecao ConsultaNome(String ProntuarioNome)
        {
            try
            {
                AmarraProntuarioColecao colecao = new AmarraProntuarioColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomePaciente", ProntuarioNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraProntuario");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraProntuario Amarra = new AmarraProntuario();
                    Amarra.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.Nome = Convert.ToString(linha["Nome"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Prontuárioe pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
            public AmarraProntuarioColecao  ConsultaId(Int64  ProntuarioId)
        {
            try
            {
                AmarraProntuarioColecao colecao = new AmarraProntuarioColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", ProntuarioId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraProntuarioId");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraProntuario Amarra = new AmarraProntuario();
                    Amarra.NomePaciente   = Convert.ToString  (linha["NomePaciente"]);
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.Nome = Convert.ToString(linha["Nome"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Prontuárioe pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
