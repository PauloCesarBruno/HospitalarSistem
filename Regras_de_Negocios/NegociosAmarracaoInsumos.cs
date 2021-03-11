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
    public class NegociosAmarracaoInsumos
    {
        Conect conect = new Conect();
        public AmarraExclusaoInsumosColecao  ConsultaNome(String InsumoNome)
        {
            try
            {
                AmarraExclusaoInsumosColecao colecao = new AmarraExclusaoInsumosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeInsumo", InsumoNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraExclusaoInsumos");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraExclusaoInsumos Amarra = new AmarraExclusaoInsumos();
                    Amarra.NomeInsumo = Convert.ToString(linha["NomeInsumo"]);
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    colecao.Add(Amarra);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Nome do Insumo pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
