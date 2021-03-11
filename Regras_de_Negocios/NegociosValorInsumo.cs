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
    public class NegociosValorInsumo
    {
        Conect conect = new Conect();

        public String InsereCustoInsumo (InsumoCusto  insumoscusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdInsumo", insumoscusto.IdInsumo);
                conect.AddParametros("@NomeInsumo", insumoscusto.NomeInsumo);
                conect .AddParametros ("@ValorInsumo", insumoscusto.ValorInsumo );
                String IdInsumo = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereCustoInsumo").ToString();
                conect.FecharConexao();
                return IdInsumo;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String AlteraCustoInsumo(InsumoCusto insumoscusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdInsumo", insumoscusto.IdInsumo);
                conect.AddParametros("@NomeInsumo", insumoscusto.NomeInsumo);
                conect.AddParametros("@ValorInsumo", insumoscusto.ValorInsumo);
                String IdInsumo = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraCustoInsumo").ToString();
                conect.FecharConexao();
                return IdInsumo;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String ExcluiCustoInsumo(InsumoCusto insumoscusto)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdInsumo", insumoscusto.IdInsumo);
                String IdInsumo = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaCustoInsumo").ToString();
                conect.FecharConexao();
                return IdInsumo;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public InsumoCustoColecao ConsultaCustoInsumoNome (String InsumoNome)
        {
            try
            {
                InsumoCustoColecao colecao = new InsumoCustoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeInsumo", InsumoNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustoInsumoNome");
                foreach (DataRow linha in dt.Rows)
                {
                    InsumoCusto Icusto = new InsumoCusto();
                    Icusto.IdInsumo  = Convert.ToInt32(linha["IdInsumo"]);
                    Icusto.NomeInsumo  = Convert.ToString(linha["NomeInsumo"]);
                    Icusto.ValorInsumo = Convert.ToDecimal(linha["ValorInsumo"]);
                    colecao.Add(Icusto);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Insumo pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public InsumoCustoColecao ConsultaCustoInsumoId(Int64 IdInsumo)
        {
            try
            {
                InsumoCustoColecao colecao = new InsumoCustoColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdInsumo", IdInsumo);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCustoInsumoId");
                foreach (DataRow linha in dt.Rows)
                {
                    InsumoCusto Icusto = new InsumoCusto();
                    Icusto.IdInsumo = Convert.ToInt32(linha["IdInsumo"]);
                    Icusto.NomeInsumo = Convert.ToString(linha["NomeInsumo"]);
                    Icusto.ValorInsumo = Convert.ToDecimal(linha["ValorInsumo"]);
                    colecao.Add(Icusto);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Insumo pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
