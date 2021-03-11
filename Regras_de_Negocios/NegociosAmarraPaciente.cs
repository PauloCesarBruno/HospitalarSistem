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
    public class NegociosAmarraPaciente
    {
        Conect conect = new Conect();
        public AmarraExclusaoPacienteColecao ConsultaNome(String PacienteNome)
        {
            try
            {
                AmarraExclusaoPacienteColecao colecao = new AmarraExclusaoPacienteColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", PacienteNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraExclusaoPaciente");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraExclusaoPaciente Amarra = new AmarraExclusaoPaciente();
                    Amarra.IdPaciente  = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.Nome = Convert.ToString(linha["Nome"]);
                    Amarra.IdMedico  = Convert.ToInt32 (linha["IdMedico"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível efetuar consulta pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
