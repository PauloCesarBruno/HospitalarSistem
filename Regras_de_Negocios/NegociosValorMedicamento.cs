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
    public class NegociosValorMedicamento
    {
        Conect conect = new Conect();

        public String InsereCustoMedicamento (Medicamentos  medicamentocusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdMedicamento", medicamentocusto.IdMedicamento);
                conect.AddParametros("@NomeMedicamento", medicamentocusto.NomeMedicamento);
                conect.AddParametros("@ValorMedicamento", medicamentocusto.ValorMedicamento);
                String IdMedicamento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereCustoMedicamento").ToString();
                conect.FecharConexao();
                return IdMedicamento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String AlteraCustoMedicamento(Medicamentos medicamentocusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdMedicamento", medicamentocusto.IdMedicamento);
                conect.AddParametros("@NomeMedicamento", medicamentocusto.NomeMedicamento);
                conect.AddParametros("@ValorMedicamento", medicamentocusto.ValorMedicamento);
                String IdMedicamento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraCustoMedicamento").ToString();
                conect.FecharConexao();
                return IdMedicamento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String ExcluiCustoMedicamento(Medicamentos medicamentocusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdMedicamento", medicamentocusto.IdMedicamento);
                String IdMedicamento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaCustoMedicamento").ToString();
                conect.FecharConexao();
                return IdMedicamento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public MedicamentosColecao  ConsultaCustoMedicamentoNome (String medicamentoNome)
        {
            try
            {
                MedicamentosColecao colecao = new MedicamentosColecao ();
                conect.LimpaParametros();
                conect.AddParametros("@NomeMedicamento", medicamentoNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustoMedicamentoNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Medicamentos Mcusto = new Medicamentos();
                    Mcusto.IdMedicamento  = Convert.ToInt32(linha["IdMedicamento"]);
                    Mcusto.NomeMedicamento = Convert.ToString(linha["NomeMedicamento"]);
                    Mcusto.ValorMedicamento = Convert.ToDecimal(linha["ValorMedicamento"]);
                    colecao.Add(Mcusto);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Medicamento pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public MedicamentosColecao ConsultaCustoMedicamentoId(Int64 IdMedicamento)
        {
            try
            {
                MedicamentosColecao colecao = new MedicamentosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdMedicamento", IdMedicamento);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustoMedicamentoId");
                foreach (DataRow linha in dt.Rows)
                {
                    Medicamentos Mcusto = new Medicamentos();
                    Mcusto.IdMedicamento = Convert.ToInt32(linha["IdMedicamento"]);
                    Mcusto.NomeMedicamento = Convert.ToString(linha["NomeMedicamento"]);
                    Mcusto.ValorMedicamento = Convert.ToDecimal(linha["ValorMedicamento"]);
                    colecao.Add(Mcusto);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Medicamento pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
