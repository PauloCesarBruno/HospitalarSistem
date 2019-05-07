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
    public class NegociosDiaria
    {
        Conect conect = new Conect();

        public String Insere_Diaria(Diaria diaria)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdDiaria", diaria.IdDiaria);
                conect.AddParametros("@LocalAcomodado", diaria.LocalAcomodado);
                conect.AddParametros("@diasAcomodado", diaria.diasAcomodado);
                conect.AddParametros("@ValorAcomodacao", diaria.ValorAcomodacao);
                String IdDiaria = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereDiariaValor").ToString();
                return IdDiaria;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String Altera_Diaria(Diaria diaria)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdDiaria", diaria.IdDiaria);
                conect.AddParametros("@LocalAcomodado", diaria.LocalAcomodado);
                conect.AddParametros("@diasAcomodado", diaria.diasAcomodado);
                conect.AddParametros("@ValorAcomodacao", diaria.ValorAcomodacao);
                String IdDiaria = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraDiariaValor").ToString();
                return IdDiaria;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Exclui_Diaria(Diaria diaria)
        {
            try
            {
                conect.AddParametros("@IdDiaria", diaria.IdDiaria);
                String IdDiaria = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaDiariaValor").ToString();
                return IdDiaria;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }

        public DiariaColecao ConsultaDiariaValorLocal (String DiariaLocal)
        {
            try
            {
                DiariaColecao colecao = new DiariaColecao();
                conect.LimpaParametros();
                conect.AddParametros("@LocalAcomodado", DiariaLocal);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaDiariaValorLocal");
                foreach (DataRow linha in dt.Rows)
                {
                    Diaria diaria = new Diaria();
                    diaria.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    diaria.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    diaria.diasAcomodado = Convert.ToInt32(linha["diasAcomodado"]);
                    diaria.ValorAcomodacao = Convert.ToDecimal(linha["ValorAcomodacao"]);                   
                    colecao.Add(diaria);
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar pelo local Informado. Detalhe:" + ex.Message);
            }
        }

        public DiariaColecao ConsultaDiariaValorId(Int32 idDiaria)
        {
            try
            {
                DiariaColecao colecao = new DiariaColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdDiaria", idDiaria);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaDiariaValorId");
                foreach (DataRow linha in dt.Rows)
                {
                    Diaria diaria = new Diaria();
                    diaria.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    diaria.LocalAcomodado = Convert.ToString(linha["LocalAcomodado"]);
                    diaria.diasAcomodado = Convert.ToInt32(linha["diasAcomodado"]);
                    diaria.ValorAcomodacao = Convert.ToDecimal(linha["ValorAcomodacao"]);
                    colecao.Add(diaria);
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Acomodação pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
