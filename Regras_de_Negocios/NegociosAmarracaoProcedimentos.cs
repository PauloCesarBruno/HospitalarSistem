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
    public class NegociosAmarracaoProcedimentos
    {
        Conect conect = new Conect();
        public AmarraExclusaoProcedimentoColecao  Consulta(String ProcNome)
        {
            try
            {
                AmarraExclusaoProcedimentoColecao colecao = new AmarraExclusaoProcedimentoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@ProcedimentoInternacao", ProcNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraExclusaoProcedimento");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraExclusaoProcedimento Amarra = new AmarraExclusaoProcedimento();
                    Amarra.ProcedimentoInternacao = Convert.ToString(linha["ProcedimentoInternacao"]);
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.Nome = Convert.ToString(linha["Nome"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Nome do Procedimento pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
