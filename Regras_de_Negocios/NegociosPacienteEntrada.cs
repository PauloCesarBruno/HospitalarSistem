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
    public class NegociosPacienteEntrada
    {
        Conect conect = new Conect();

        public String Insere_Paciente(PacienteEntrada pacienteEntrada)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", pacienteEntrada.IdPaciente);
                conect.AddParametros("@IdMedico", pacienteEntrada.IdMedico);
                conect.AddParametros("@IdProcedimento", pacienteEntrada.IdProcedimento);
                conect.AddParametros("@IdDiaria", pacienteEntrada.IdDiaria);
                conect.AddParametros("@IdInsumo", pacienteEntrada.IdInsumo);
                conect.AddParametros("@IdMedicamento", pacienteEntrada.IdMedicamento);
                conect.AddParametros("@IdExame", pacienteEntrada.IdExame);
                conect.AddParametros("@Nome", pacienteEntrada.Nome);
                conect.AddParametros("@DataNascimento", pacienteEntrada.DataNascimento);
                conect.AddParametros("@Sexo", pacienteEntrada.Sexo);
                conect.AddParametros("@CPF", pacienteEntrada.CPF);
                conect.AddParametros("@RG", pacienteEntrada.RG);
                conect.AddParametros("@Endereco", pacienteEntrada.Endereco);
                conect.AddParametros("@Telefone", pacienteEntrada.Telefone);
                conect.AddParametros("@Celular", pacienteEntrada.Celular);
                conect.AddParametros("@Plano", pacienteEntrada.Plano);
                conect.AddParametros("@Categoria", pacienteEntrada.Categoria);
                conect.AddParametros("@Internacao", pacienteEntrada.Internacao);
                conect.AddParametros("@NomeAcompanhante", pacienteEntrada.NomeAcompanhante);
                conect .AddParametros("@RGAcompanhante", pacienteEntrada .RGAcompanhante);
                conect.AddParametros("@EnderecoAcompanhante", pacienteEntrada.EnderecoAcompanhante);
                conect.AddParametros("@TelefoneAcompanhante", pacienteEntrada.TelefoneAcompanhante);
                conect.AddParametros("@CeluarAcompanhante", pacienteEntrada.CeluarAcompanhante);
                conect.AddParametros("@EmailAcompanhante", pacienteEntrada.EmailAcompanhante);
                conect.AddParametros("@DiasInternados", pacienteEntrada.DiasInternados);
                conect.AddParametros("@Leito", pacienteEntrada.Leito);
                conect.AddParametros("@Quarto", pacienteEntrada.Quarto);
                conect.AddParametros("@Alta", pacienteEntrada.Alta);
                conect.AddParametros("@ObsAlta", pacienteEntrada.ObsAlta);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InserePaciente").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Altera_Paciente(PacienteEntrada pacienteEntrada)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", pacienteEntrada.IdPaciente);
                conect.AddParametros("@IdMedico", pacienteEntrada.IdMedico);
                conect.AddParametros("@IdProcedimento", pacienteEntrada.IdProcedimento);
                conect.AddParametros("@IdDiaria", pacienteEntrada.IdDiaria);
                conect.AddParametros("@IdInsumo", pacienteEntrada.IdInsumo);
                conect.AddParametros("@IdMedicamento", pacienteEntrada.IdMedicamento);
                conect.AddParametros("@IdExame", pacienteEntrada.IdExame);
                conect.AddParametros("@Nome", pacienteEntrada.Nome);
                conect.AddParametros("@DataNascimento", pacienteEntrada.DataNascimento);
                conect.AddParametros("@Sexo", pacienteEntrada.Sexo);
                conect.AddParametros("@CPF", pacienteEntrada.CPF);
                conect.AddParametros("@RG", pacienteEntrada.RG);
                conect.AddParametros("@Endereco", pacienteEntrada.Endereco);
                conect.AddParametros("@Telefone", pacienteEntrada.Telefone);
                conect.AddParametros("@Celular", pacienteEntrada.Celular);
                conect.AddParametros("@Plano", pacienteEntrada.Plano);
                conect.AddParametros("@Categoria", pacienteEntrada.Categoria);
                conect.AddParametros("@Internacao", pacienteEntrada.Internacao);
                conect.AddParametros("@NomeAcompanhante", pacienteEntrada.NomeAcompanhante);
                conect.AddParametros("@RGAcompanhante", pacienteEntrada.RGAcompanhante);
                conect.AddParametros("@EnderecoAcompanhante", pacienteEntrada.EnderecoAcompanhante);
                conect.AddParametros("@TelefoneAcompanhante", pacienteEntrada.TelefoneAcompanhante);
                conect.AddParametros("@CeluarAcompanhante", pacienteEntrada.CeluarAcompanhante);
                conect.AddParametros("@EmailAcompanhante", pacienteEntrada.EmailAcompanhante);
                conect.AddParametros("@DiasInternados", pacienteEntrada.DiasInternados);
                conect.AddParametros("@Leito", pacienteEntrada.Leito);
                conect.AddParametros("@Quarto", pacienteEntrada.Quarto);
                conect.AddParametros("@Alta", pacienteEntrada.Alta);
                conect.AddParametros("@ObsAlta", pacienteEntrada.ObsAlta);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraPaciente").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String Excluir_Pacientes(PacienteEntrada pacienteentrada)
        {
            try
            {
                conect.AddParametros("@IdPaciente", pacienteentrada.IdPaciente);
                String IdPaciente = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaPaciente").ToString();
                conect.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }
        public PacienteEntradaColecao ConsultaPacientePorNome(String nomePaciente)
        {
            try
            {
                PacienteEntradaColecao colecao = new PacienteEntradaColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", nomePaciente);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteCompletoNome");
                foreach (DataRow linha in dt.Rows)
                {
                    PacienteEntrada pacienteEntrada = new PacienteEntrada();
                    pacienteEntrada.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    pacienteEntrada.IdMedico  = Convert.ToInt32(linha["IdMedico"]);
                    pacienteEntrada.IdProcedimento = Convert.ToInt32(linha["IdProcedimento"]);
                    pacienteEntrada.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    pacienteEntrada.IdInsumo = Convert.ToInt64(linha["IdInsumo"]);
                    pacienteEntrada.IdMedicamento  = Convert.ToInt64(linha["IdMedicamento"]);
                    pacienteEntrada.IdExame = Convert.ToInt64(linha["IdExame"]);
                    pacienteEntrada.Nome = Convert.ToString(linha["Nome"]);
                    pacienteEntrada.Sexo = Convert.ToString (linha["Sexo"]);
                    pacienteEntrada.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    pacienteEntrada.CPF = Convert.ToString(linha["CPF"]);
                    pacienteEntrada.RG = Convert.ToString(linha["RG"]);
                    pacienteEntrada.Endereco = Convert.ToString(linha["Endereco"]);
                    pacienteEntrada.Telefone = Convert.ToString(linha["Telefone"]);
                    pacienteEntrada.Celular = Convert.ToString(linha["Celular"]);
                    pacienteEntrada.Plano = Convert.ToString(linha["Plano"]);
                    pacienteEntrada.Categoria = Convert.ToString(linha["Categoria"]);
                    pacienteEntrada.Internacao = Convert.ToDateTime(linha["Internacao"]);
                    pacienteEntrada.NomeAcompanhante = Convert.ToString(linha["NomeAcompanhante"]);
                    pacienteEntrada.RGAcompanhante = Convert.ToString(linha["RGAcompanhante"]);
                    pacienteEntrada.EnderecoAcompanhante = Convert.ToString(linha["EnderecoAcompanhante"]);
                    pacienteEntrada.TelefoneAcompanhante = Convert.ToString(linha["TelefoneAcompanhante"]);
                    pacienteEntrada.CeluarAcompanhante = Convert.ToString(linha["CeluarAcompanhante"]);
                    pacienteEntrada.EmailAcompanhante = Convert.ToString(linha["EmailAcompanhante"]);
                    pacienteEntrada.DiasInternados = Convert.ToInt32(linha["DiasInternados"]);
                    pacienteEntrada.Leito = Convert.ToInt32(linha["Leito"]);
                    pacienteEntrada.Quarto = Convert.ToInt32(linha["Quarto"]);
                    pacienteEntrada.Alta = Convert.ToDateTime (linha["Alta"]);
                    pacienteEntrada.ObsAlta = Convert.ToString(linha["ObsAlta"]);
                    colecao.Add(pacienteEntrada);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Paciente pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
       
        public PacienteEntradaColecao ConsultaPacientePorId(Int64 Id)
        {
            try
            {
                PacienteEntradaColecao colecao = new PacienteEntradaColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", Id);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteCompletoId");
                foreach (DataRow linha in dt.Rows)
                {
                    PacienteEntrada pacienteEntrada = new PacienteEntrada();
                    pacienteEntrada.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    pacienteEntrada.IdMedico = Convert.ToInt32(linha["IdMedico"]);
                    pacienteEntrada.IdProcedimento = Convert.ToInt32(linha["IdProcedimento"]);
                    pacienteEntrada.IdDiaria = Convert.ToInt32(linha["IdDiaria"]);
                    pacienteEntrada.IdInsumo = Convert.ToInt64(linha["IdInsumo"]);
                    pacienteEntrada.IdMedicamento = Convert.ToInt64(linha["IdMedicamento"]);
                    pacienteEntrada.IdExame = Convert.ToInt64(linha["IdExame"]);
                    pacienteEntrada.Nome = Convert.ToString(linha["Nome"]);
                    pacienteEntrada.Sexo = Convert.ToString(linha["Sexo"]);
                    pacienteEntrada.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    pacienteEntrada.CPF = Convert.ToString(linha["CPF"]);
                    pacienteEntrada.RG = Convert.ToString(linha["RG"]);
                    pacienteEntrada.Endereco = Convert.ToString(linha["Endereco"]);
                    pacienteEntrada.Telefone = Convert.ToString(linha["Telefone"]);
                    pacienteEntrada.Celular = Convert.ToString(linha["Celular"]);
                    pacienteEntrada.Plano = Convert.ToString(linha["Plano"]);
                    pacienteEntrada.Categoria = Convert.ToString(linha["Categoria"]);
                    pacienteEntrada.Internacao = Convert.ToDateTime(linha["Internacao"]);
                    pacienteEntrada.NomeAcompanhante = Convert.ToString(linha["NomeAcompanhante"]);
                    pacienteEntrada.RGAcompanhante = Convert.ToString(linha["RGAcompanhante"]);
                    pacienteEntrada.EnderecoAcompanhante = Convert.ToString(linha["EnderecoAcompanhante"]);
                    pacienteEntrada.TelefoneAcompanhante = Convert.ToString(linha["TelefoneAcompanhante"]);
                    pacienteEntrada.CeluarAcompanhante = Convert.ToString(linha["CeluarAcompanhante"]);
                    pacienteEntrada.EmailAcompanhante = Convert.ToString(linha["EmailAcompanhante"]);
                    pacienteEntrada.DiasInternados = Convert.ToInt32(linha["DiasInternados"]);
                    pacienteEntrada.Leito = Convert.ToInt32(linha["Leito"]);
                    pacienteEntrada.Quarto = Convert.ToInt32(linha["Quarto"]);
                    pacienteEntrada.Alta = Convert.ToDateTime(linha["Alta"]);
                    pacienteEntrada.ObsAlta = Convert.ToString(linha["ObsAlta"]);
                    colecao.Add(pacienteEntrada);
                    conect.FecharConexao();
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