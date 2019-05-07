using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
//
using Conexao_SQLServer;
using Objeto_de_Transferencia;

namespace Regras_de_Negocios
{
    public class NegociosAmarraCustosGeral
    {
        Conect conect = new Conect();
        public AmarraCustosGeraisColecao ConsultaNome(String CustosNome)
        {
            try
            {
                AmarraCustosGeraisColecao colecao = new AmarraCustosGeraisColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", CustosNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraCustosdeUso");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraCustosGerais Amarra = new AmarraCustosGerais();
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.Nome = Convert.ToString (linha["Nome"]);
                    Amarra.IdInsumo = Convert.ToInt64 (linha["IdInsumo"]);
                    Amarra.IdMedicamento = Convert.ToInt64(linha["IdMedicamento"]);
                    Amarra.IdExame = Convert.ToInt32(linha["IdExame"]);
                    colecao.Add(Amarra);
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Paciente pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public AmarraCustosGeraisColecao ConsultaId(Int64 CustoId)
        {
            try
            {
                AmarraCustosGeraisColecao colecao = new AmarraCustosGeraisColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", CustoId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_AmarraCustodeUsoId");
                foreach (DataRow linha in dt.Rows)
                {
                    AmarraCustosGerais Amarra = new AmarraCustosGerais();
                    Amarra.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Amarra.Nome = Convert.ToString(linha["Nome"]);
                    Amarra.IdInsumo = Convert.ToInt64(linha["IdInsumo"]);
                    Amarra.IdMedicamento = Convert.ToInt64(linha["IdMedicamento"]);
                    Amarra.IdExame = Convert.ToInt32(linha["IdExame"]);
                    colecao.Add(Amarra);
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Paciente pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
