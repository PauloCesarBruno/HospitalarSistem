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
    public class NegociosCustoGeral
    {
        Conect conect = new Conect();

        public CustoGeralColecao ConsultaPacienteCustosNome(String CGeral)
        {
            try
            {
                CustoGeralColecao colecao = new CustoGeralColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", CGeral );
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteCustosNome");
                foreach (DataRow linha in dt.Rows)
                {
                    CustoGeral geral = new CustoGeral();
                    geral.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    geral.Nome = Convert.ToString(linha["Nome"]);
                    geral.IdDiaria  = Convert.ToInt32(linha["IdDiaria"]);
                    geral.LocalAcomodado  = Convert.ToString (linha["LocalAcomodado"]);
                    geral.diasAcomodado = Convert.ToInt32(linha["diasAcomodado"]);
                    geral.ValorAcomodacao = Convert.ToDecimal(linha["ValorAcomodacao"]);
                    geral.Valor_Total = Convert.ToDecimal(linha["Valor_Total"]);
                    geral.IdInsumo  = Convert.ToInt32 (linha["IdInsumo"]);
                    geral.NomeInsumo = Convert.ToString (linha["NomeInsumo"]);
                    geral.ValorInsumo   = Convert.ToDecimal(linha["ValorInsumo"]);
                    geral.IdMedicamento = Convert.ToInt32(linha["IdMedicamento"]);
                    geral.NomeMedicamento  = Convert.ToString (linha["NomeMedicamento"]);
                    geral.ValorMedicamento = Convert.ToDecimal(linha["ValorMedicamento"]);
                    geral.IdExame  = Convert.ToInt32 (linha["IdExame"]);
                    geral.NomeExame  = Convert.ToString (linha["NomeExame"]);
                    geral.ValorExame  = Convert.ToDecimal(linha["ValorExame"]);
                    
                    colecao.Add(geral);
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
