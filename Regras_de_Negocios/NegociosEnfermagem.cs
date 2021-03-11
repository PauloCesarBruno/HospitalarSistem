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
    public class NegociosEnfermagem
    {
        Conect conect = new Conect();

        public String Insere_Enfermagem(Enfermagem enfermagem)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdEnfermeiro", enfermagem.IdEnfermeiro);
                conect.AddParametros("@NomeEnfermeiro", enfermagem.NomeEnfermeiro);
                conect.AddParametros("@Endereco", enfermagem.Endereco);
                conect.AddParametros("@COREN", enfermagem.COREN);
                conect.AddParametros("@CPF", enfermagem.CPF);
                conect.AddParametros("@RG", enfermagem.RG);
                conect.AddParametros("@Telefone", enfermagem.Telefone);
                conect.AddParametros("@Celular", enfermagem.Celular);
                conect.AddParametros("@Email", enfermagem.Email);
                String IdEnfermeiro = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereEnfermagem").ToString();
                conect.FecharConexao();
                return IdEnfermeiro;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String Altera_Enfermagem(Enfermagem enfermagem)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdEnfermeiro", enfermagem.IdEnfermeiro);
                conect.AddParametros("@NomeEnfermeiro", enfermagem.NomeEnfermeiro);
                conect.AddParametros("@Endereco", enfermagem.Endereco);
                conect.AddParametros("@COREN", enfermagem.COREN);
                conect.AddParametros("@CPF", enfermagem.CPF);
                conect.AddParametros("@RG", enfermagem.RG);
                conect.AddParametros("@Telefone", enfermagem.Telefone);
                conect.AddParametros("@Celular", enfermagem.Celular);
                conect.AddParametros("@Email", enfermagem.Email);
                String IdEnfermeiro = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraEnfermagem").ToString();
                conect.FecharConexao();
                return IdEnfermeiro;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String Exclui_Enfermagem(Enfermagem enfermagem)
        {
            try
            {
                conect.AddParametros("@IdEnfermeiro", enfermagem.IdEnfermeiro);
                String IdEnfermeiro = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaEnfermagem").ToString();
                conect.FecharConexao();
                return IdEnfermeiro;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }

        public EnfermagemColecao ConsultaEnfermagemNome(String EnfNome)
        {
            try
            {
                EnfermagemColecao colecao = new EnfermagemColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeEnfermeiro", EnfNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaEnfermagemNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Enfermagem enfermagem = new Enfermagem();
                    enfermagem.IdEnfermeiro = Convert.ToInt32(linha["IdEnfermeiro"]);
                    enfermagem.NomeEnfermeiro = Convert.ToString(linha["NomeEnfermeiro"]);
                    enfermagem.Endereco = Convert.ToString(linha["Endereco"]);
                    enfermagem.COREN = Convert.ToString(linha["COREN"]);
                    enfermagem.CPF = Convert.ToString(linha["CPF"]);
                    enfermagem.RG = Convert.ToString(linha["RG"]);
                    enfermagem.Telefone = Convert.ToString(linha["Telefone"]);
                    enfermagem.Celular = Convert.ToString(linha["Celular"]);
                    enfermagem.Email = Convert.ToString(linha["Email"]);
                    colecao.Add(enfermagem);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Enfermeiro(a) pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public EnfermagemColecao ConsultaEnfermagemId(Int32 EnfId)
        {
            try
            {
                EnfermagemColecao colecao = new EnfermagemColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdEnfermeiro", EnfId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaEnfermagemId");
                foreach (DataRow linha in dt.Rows)
                {
                    Enfermagem enfermagem = new Enfermagem();
                    enfermagem.IdEnfermeiro = Convert.ToInt32(linha["IdEnfermeiro"]);
                    enfermagem.NomeEnfermeiro = Convert.ToString(linha["NomeEnfermeiro"]);
                    enfermagem.Endereco = Convert.ToString(linha["Endereco"]);
                    enfermagem.COREN = Convert.ToString(linha["COREN"]);
                    enfermagem.CPF = Convert.ToString(linha["CPF"]);
                    enfermagem.RG = Convert.ToString(linha["RG"]);
                    enfermagem.Telefone = Convert.ToString(linha["Telefone"]);
                    enfermagem.Celular = Convert.ToString(linha["Celular"]);
                    enfermagem.Email = Convert.ToString(linha["Email"]);
                    colecao.Add(enfermagem);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Enfermeiro(a) pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}