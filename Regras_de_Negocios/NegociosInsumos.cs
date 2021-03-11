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
   public class NegociosInsumos
    {
       Conect conect = new Conect();

       public String Insere_Insumo (Insumos insumos)
       {
           try
           {
               conect.LimpaParametros();
               conect.AddParametros("@IdInsumo", insumos.IdInsumo);
               conect.AddParametros("@NomeInsumo", insumos.NomeInsumo);
               conect.AddParametros("@Quantidade", insumos.Quantidade);
               conect.AddParametros("@QtdMinima", insumos.QtdMinima);
               conect.AddParametros("@QtdMaxima", insumos.QtdMaxima);
               String IdInsumo = conect.ExecutaManipulacao (CommandType.StoredProcedure, "Sp_InsereInsumo").ToString();
               conect.FecharConexao();
               return IdInsumo;
           }
           catch (Exception ex)
           {
               return ("ERRO, Detalhe :" + ex.Message);
           }
       }
       public String Altera_Insumo (Insumos insumos)
       {
           try
           {
               conect.LimpaParametros();
               conect.AddParametros("@IdInsumo", insumos.IdInsumo);
               conect.AddParametros("@NomeInsumo", insumos.NomeInsumo);
               conect.AddParametros("@Quantidade", insumos.Quantidade);
               conect.AddParametros("@QtdMinima", insumos.QtdMinima);
               conect.AddParametros("@QtdMaxima", insumos.QtdMaxima);
               String IdInsumo = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraInsumo").ToString();
               conect.FecharConexao();
               return IdInsumo;
           }
           catch (Exception ex)
           {
               return ("ERRO, Detalhe :" + ex.Message);
           }
       }
       public String Exclui_Insumo (Insumos insumos)
       {
           try
           {
               conect.LimpaParametros();
               conect.AddParametros("@IdInsumo", insumos.IdInsumo);
               String IdInsumo = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaInsumo").ToString();
               conect.FecharConexao();
               return IdInsumo;
           }
           catch (Exception ex)
           {
               return ("ERRO, Detalhe : " + ex.Message);
           }
       }
     
       public Insumo_Colecao  ConsultaInsumoPorNome(String NomeInsumo)
       {
           try
           {
               Insumo_Colecao colecao = new Insumo_Colecao();
               conect.LimpaParametros();
               conect.AddParametros("@NomeInsumo", NomeInsumo);
               DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaInsumoNome");
               foreach (DataRow linha in dt.Rows)
               {
                   Insumos insumos = new Insumos();
                   insumos.IdInsumo  = Convert.ToInt64(linha["IdInsumo"]);
                   insumos.NomeInsumo  = Convert.ToString(linha["NomeInsumo"]);
                   insumos.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                   insumos.QtdMinima = Convert.ToInt32(linha["QtdMinima"]);
                   insumos.QtdMaxima = Convert.ToInt32(linha["QtdMaxima"]);
                   colecao.Add(insumos);
                   conect.FecharConexao();
                }
               return colecao;
           }
           catch (Exception ex)
           {
               throw new Exception("Não Foi Possível Consultar Este Insumo pelo Nome Informado. Detalhe:" + ex.Message);
           }
       }
       public Insumo_Colecao ConsultaInsumoId(Int64 idinsumo)
       {
           try
           {
               Insumo_Colecao colecao = new Insumo_Colecao();
               conect.LimpaParametros();
               conect.AddParametros("@IdInsumo", idinsumo);
               DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaInsumoId");
               foreach (DataRow linha in dt.Rows)
               {
                   Insumos insumos = new Insumos();
                   insumos.IdInsumo = Convert.ToInt64(linha["IdInsumo"]);
                   insumos.NomeInsumo = Convert.ToString(linha["NomeInsumo"]);
                   insumos.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                   insumos.QtdMinima = Convert.ToInt32(linha["QtdMinima"]);
                   insumos.QtdMaxima = Convert.ToInt32(linha["QtdMaxima"]);
                   colecao.Add(insumos);
                   conect.FecharConexao();
                }
               return colecao;
           }
           catch (Exception ex)
           {
               throw new Exception("Não Foi Possível Consultar Este Insumo pelo Código Informado. Detalhe:" + ex.Message);
           }
       }
    }
}
