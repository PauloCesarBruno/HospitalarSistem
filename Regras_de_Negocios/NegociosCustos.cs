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
    public class NegociosCustos
    {
        Conect conect = new Conect();

        public String Insere_Custos(Custos custos)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", custos.IdPaciente);
                conect.AddParametros("@NomePaciente", custos.NomePaciente);
                conect.AddParametros("Data", custos.Data);
                conect.AddParametros("@Responsavel", custos.Responsavel);
                conect.AddParametros("@IdInsumo", custos.IdInsumo);
                conect.AddParametros("@IdMedicamento", custos.IdMedicamento);
                conect.AddParametros("@IdExame", custos.IdExame);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereCustos").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Exclui_Custos(Custos custos)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@NomePaciente", custos.NomePaciente);
                String NomePaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaCustos").ToString();
                conect.FecharConexao();
                return NomePaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public CustosColecao ConsultaCustosNome(String consultaCustos)
        {
            try
            {
                CustosColecao colecao = new CustosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", consultaCustos);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustos");
                foreach (DataRow linha in dt.Rows)
                {
                    Custos custos = new Custos();
                    custos.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    custos.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    custos.Data = Convert.ToDateTime(linha["Data"]);
                    custos.Responsavel = Convert.ToString(linha["Responsavel"]);
                    custos.IdInsumo = Convert.ToInt32(linha["IdInsumo"]);
                    custos.NomeInsumo = Convert.ToString(linha["NomeInsumo"]);
                    custos.ValorInsumo = Convert.ToDecimal(linha["ValorInsumo"]);
                    custos.IdMedicamento = Convert.ToInt32(linha["IdMedicamento"]);
                    custos.NomeMedicamento = Convert.ToString(linha["NomeMedicamento"]);
                    custos.ValorMedicamento = Convert.ToDecimal(linha["ValorMedicamento"]);
                    custos.IdExame = Convert.ToInt32(linha["IdExame"]);
                    custos.NomeExame = Convert.ToString(linha["NomeExame"]);
                    custos.ValorExame = Convert.ToDecimal(linha["ValorExame"]);
                    colecao.Add(custos);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Custos pelo Nome de Paciênte Informado. Detalhe:" + ex.Message);
            }
        }
        public CustosColecao ConsultaCustosId(Int64 consultaCustosId)
        {
            try
            {
                CustosColecao colecao = new CustosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", consultaCustosId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustosId");
                foreach (DataRow linha in dt.Rows)
                {
                    Custos custos = new Custos();
                    custos.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    custos.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    custos.Data = Convert.ToDateTime(linha["Data"]);
                    custos.Responsavel = Convert.ToString(linha["Responsavel"]);
                    custos.IdInsumo = Convert.ToInt32(linha["IdInsumo"]);
                    custos.NomeInsumo = Convert.ToString(linha["NomeInsumo"]);
                    custos.ValorInsumo = Convert.ToDecimal(linha["ValorInsumo"]);
                    custos.IdMedicamento = Convert.ToInt32(linha["IdMedicamento"]);
                    custos.NomeMedicamento = Convert.ToString(linha["NomeMedicamento"]);
                    custos.ValorMedicamento = Convert.ToDecimal(linha["ValorMedicamento"]);
                    custos.IdExame = Convert.ToInt32(linha["IdExame"]);
                    custos.NomeExame = Convert.ToString(linha["NomeExame"]);
                    custos.ValorExame = Convert.ToDecimal(linha["ValorExame"]);
                    colecao.Add(custos);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Custos pelo Codigo de Paciênte Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
