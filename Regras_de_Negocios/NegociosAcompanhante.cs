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
    public class NegociosAcompanhante
    {
        Conect conect = new Conect();

        public String Insere_Acompanhante(Acompanhante acompanhante)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdAcompanhante", acompanhante.IdAcompanhante);
                conect.AddParametros("@Nome", acompanhante.Nome);
                conect.AddParametros("@Endereco", acompanhante.Endereco);
                conect.AddParametros("@Telefone", acompanhante.Telefone);
                conect.AddParametros("@Celular", acompanhante.Celular);
                conect.AddParametros("@Email", acompanhante.Email);
                String IdAcompanhante = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereAcompanhante").ToString();
                return IdAcompanhante;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Altera_Acompanhante(Acompanhante acompanhante)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdAcompanhante", acompanhante.IdAcompanhante);
                conect.AddParametros("@Nome", acompanhante.Nome);
                conect.AddParametros("@Endereco", acompanhante.Endereco);
                conect.AddParametros("@Telefone", acompanhante.Telefone);
                conect.AddParametros("@Celular", acompanhante.Celular);
                conect.AddParametros("@Email", acompanhante.Email);
                String IdAcompanhante = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraAcompanhante").ToString();
                return IdAcompanhante;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public AcompanhanteColecao ConsultaAcompanhanteNome(String nomeacompanhante)
        {
            try
            {
                AcompanhanteColecao colecao = new AcompanhanteColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", nomeacompanhante);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaAcompanhanteNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Acompanhante acompanhante = new Acompanhante();
                    acompanhante.IdAcompanhante = Convert.ToInt32(linha["IdAcompanhante"]);
                    acompanhante.Nome = Convert.ToString(linha["Nome"]);
                    acompanhante.Endereco = Convert.ToString(linha["Endereco"]);
                    acompanhante.Telefone = Convert.ToString(linha["Telefone"]);
                    acompanhante.Celular = Convert.ToString(linha["Celular"]);
                    acompanhante.Email = Convert.ToString(linha["Email"]);
                    colecao.Add(acompanhante);
                }

                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Acompanhante pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public AcompanhanteColecao ConsultaAcompanhanteId(Int32 Idacompanhante)
        {
            try
            {
                AcompanhanteColecao colecao = new AcompanhanteColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdAcompanhante", Idacompanhante);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaAcompanhanteId");
                foreach (DataRow linha in dt.Rows)
                {
                    Acompanhante acompanhante = new Acompanhante();
                    acompanhante.IdAcompanhante = Convert.ToInt32(linha["IdAcompanhante"]);
                    acompanhante.Nome = Convert.ToString(linha["Nome"]);
                    acompanhante.Endereco = Convert.ToString(linha["Endereco"]);
                    acompanhante.Telefone = Convert.ToString(linha["Telefone"]);
                    acompanhante.Celular = Convert.ToString(linha["Celular"]);
                    acompanhante.Email = Convert.ToString(linha["Email"]);
                    colecao.Add(acompanhante);
                }

                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Acompanhante pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}