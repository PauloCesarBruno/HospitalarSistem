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
    public class NegociosAmarracaoMedicamentos
    {
        Conect conect = new Conect();
        public AmarraExclusaoMedicamentosColecao  ConsultaNome(String medicamentoNome)
        {
            try
            {
                AmarraExclusaoMedicamentosColecao colecao = new AmarraExclusaoMedicamentosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeMedicamento", medicamentoNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraExclusaoMedicamento");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraExclusaoMedicamentos Amarra = new AmarraExclusaoMedicamentos();
                    Amarra.NomeMedicamento = Convert.ToString(linha["NomeMedicamento"]);
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Nome do Medicamento pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
