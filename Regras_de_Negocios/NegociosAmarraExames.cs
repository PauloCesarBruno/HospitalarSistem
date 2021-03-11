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
    public class NegociosAmarraExames
    {
        Conect conect = new Conect();
        public AmarraExclusaoExamesColecao ConsultaNome(String ExameNome)
        {
            try
            {
                AmarraExclusaoExamesColecao colecao = new AmarraExclusaoExamesColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeExame", ExameNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraExclusaoExames");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraExlusaoExames Amarra = new AmarraExlusaoExames();
                    Amarra.NomeExame = Convert.ToString(linha["NomeExame"]);
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Nome do Exame pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
