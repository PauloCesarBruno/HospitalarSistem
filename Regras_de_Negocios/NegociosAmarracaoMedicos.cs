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
    public class NegociosAmarracaoMedicos
    {
        Conect conect = new Conect();
        public AmarraExclusaoMedicoColecao  Consulta(String ProcMedico)
        {
            try
            {
                AmarraExclusaoMedicoColecao colecao = new AmarraExclusaoMedicoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", ProcMedico);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraExclusaoMedico");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraExclusaoMedico Amarra = new AmarraExclusaoMedico();
                    Amarra.Nome = Convert.ToString(linha["Nome"]);
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Nome do(a) Médico(a) pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
