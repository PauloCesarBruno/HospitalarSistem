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
    public class NegociosMedicos
    {
        Conect conect = new Conect();

        public String Insere_Medico(Medicos medicos)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdMedico", medicos.IdMedico);
                conect.AddParametros("@Nome", medicos.Nome);
                conect.AddParametros("@Endereco", medicos.Endereco);
                conect.AddParametros("@CRM", medicos.CRM);
                conect.AddParametros("@CPF", medicos.CPF);
                conect.AddParametros("@RG", medicos.RG);
                conect.AddParametros("@Especialidade", medicos.Especialidade);
                conect.AddParametros("@Telefone", medicos.Telefone);
                conect.AddParametros("@Celular", medicos.Celular);
                conect.AddParametros("@Email", medicos.Email);
                String IdMedico = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereMedico").ToString();
                conect.FecharConexao();
                return IdMedico;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Altera_Medico(Medicos medicos)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdMedico", medicos.IdMedico);
                conect.AddParametros("@Nome", medicos.Nome);
                conect.AddParametros("@Endereco", medicos.Endereco);
                conect.AddParametros("@CRM", medicos.CRM);
                conect.AddParametros("@CPF", medicos.CPF);
                conect.AddParametros("@RG", medicos.RG);
                conect.AddParametros("@Especialidade", medicos.Especialidade);
                conect.AddParametros("@Telefone", medicos.Telefone);
                conect.AddParametros("@Celular", medicos.Celular);
                conect.AddParametros("@Email", medicos.Email);
                String IdMedico = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraMedico").ToString();
                conect.FecharConexao();
                return IdMedico;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Exclui_Medico(Medicos medicos)
        {
            try
            {
                conect.AddParametros("@IdMedico", medicos.IdMedico);
                String IdMedico = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaMedico").ToString();
                conect.FecharConexao();
                return IdMedico;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }

        public MedicosColecao ConsultaMedicoPorNome(String nomemedico)
        {
            try
            {
                MedicosColecao colecao = new MedicosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", nomemedico);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaMedicoNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Medicos medicos = new Medicos();
                    medicos.IdMedico = Convert.ToInt32(linha["IdMedico"]);
                    medicos.Nome = Convert.ToString(linha["Nome"]);
                    medicos.Endereco = Convert.ToString(linha["Endereco"]);
                    medicos.CRM = Convert.ToString(linha["CRM"]);
                    medicos.CPF = Convert.ToString(linha["CPF"]);
                    medicos.RG = Convert.ToString(linha["RG"]);
                    medicos.Especialidade = Convert.ToString(linha["Especialidade"]);
                    medicos.Telefone = Convert.ToString(linha["Telefone"]);
                    medicos.Celular = Convert.ToString(linha["Celular"]);
                    medicos.Email = Convert.ToString(linha["EMail"]);
                    colecao.Add(medicos);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Medico pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public MedicosColecao ConsultaMedicoPorId(Int32 nomemedico)
        {
            try
            {
                MedicosColecao colecao = new MedicosColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdMedico", nomemedico);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaMedicoId");
                foreach (DataRow linha in dt.Rows)
                {
                    Medicos medicos = new Medicos();
                    medicos.IdMedico = Convert.ToInt32(linha["IdMedico"]);
                    medicos.Nome = Convert.ToString(linha["Nome"]);
                    medicos.Endereco = Convert.ToString(linha["Endereco"]);
                    medicos.CRM = Convert.ToString(linha["CRM"]);
                    medicos.CPF = Convert.ToString(linha["CPF"]);
                    medicos.RG = Convert.ToString(linha["RG"]);
                    medicos.Especialidade = Convert.ToString(linha["Especialidade"]);
                    medicos.Telefone = Convert.ToString(linha["Telefone"]);
                    medicos.Celular = Convert.ToString(linha["Celular"]);
                    medicos.Email = Convert.ToString(linha["EMail"]);
                    colecao.Add(medicos);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Medico pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}