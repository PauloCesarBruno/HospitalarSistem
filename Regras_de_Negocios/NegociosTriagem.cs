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
    public class NegociosTriagem
    {
        Conect conect = new Conect();
        public Triagem_Colecao  ConsultaTriagemPorNome(String nomeTriagem)
        {
            try
            {
                Triagem_Colecao colecao = new Triagem_Colecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", nomeTriagem);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaTriagemNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Triagem triagem = new Triagem();
                    triagem.Codigo = Convert.ToInt64(linha["Codigo"]);
                    triagem.Nome = Convert.ToString(linha["Nome"]);
                    triagem.Data = Convert.ToString(linha["Data"]);
                    triagem.Sexo = Convert.ToString(linha["Sexo"]);
                    triagem.DiaHora = Convert.ToDateTime(linha["DiaHora"]);
                    triagem.Pbaixa = Convert.ToBoolean(linha["Pbaixa"]);
                    triagem.Pmedia = Convert.ToBoolean(linha["Pmedia"]);
                    triagem.Palta = Convert.ToBoolean(linha["Palta"]);
                    colecao.Add(triagem);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Registro pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public Triagem_Colecao ConsultaTriagemPorId(Int64 IdTriagem)
        {
            try
            {
                Triagem_Colecao colecao = new Triagem_Colecao();
                conect.LimpaParametros();
                conect.AddParametros("@Codigo", IdTriagem );
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaTriagemId");
                foreach (DataRow linha in dt.Rows)
                {
                    Triagem triagem = new Triagem();
                    triagem.Codigo = Convert.ToInt64(linha["Codigo"]);
                    triagem.Nome = Convert.ToString(linha["Nome"]);
                    triagem.Data = Convert.ToString(linha["Data"]);
                    triagem.Sexo = Convert.ToString(linha["Sexo"]);
                    triagem.DiaHora = Convert.ToDateTime(linha["DiaHora"]);
                    triagem.Pbaixa = Convert.ToBoolean(linha["Pbaixa"]);
                    triagem.Pmedia = Convert.ToBoolean(linha["Pmedia"]);
                    triagem.Palta = Convert.ToBoolean(linha["Palta"]);
                    colecao.Add(triagem);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Registro pelo Codigo Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
