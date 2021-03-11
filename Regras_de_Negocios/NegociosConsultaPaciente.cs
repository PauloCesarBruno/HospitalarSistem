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
    public class NegociosConsultaPaciente
    {
        Conect conect = new Conect();

        public ConsultaPacienteColecao ConsultaPacientePorNome(String nomePaciente)
        {
            try
            {
                ConsultaPacienteColecao colecao = new ConsultaPacienteColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", nomePaciente);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteNome");
                foreach (DataRow linha in dt.Rows)
                {
                    ConsultaPacientes Cp = new ConsultaPacientes();
                    Cp.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Cp.Nome = Convert.ToString(linha["Nome"]);
                    Cp.Sexo = Convert.ToString(linha["Sexo"]);
                    Cp.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    Cp.CPF = Convert.ToString(linha["CPF"]);
                    Cp.RG = Convert.ToString(linha["RG"]);
                    Cp.Endereco = Convert.ToString(linha["Endereco"]);
                    Cp.Telefone = Convert.ToString(linha["Telefone"]);
                    Cp.Celular = Convert.ToString(linha["Celular"]);
                    Cp.Plano = Convert.ToString(linha["Plano"]);
                    Cp.Categoria = Convert.ToString(linha["Categoria"]);
                    Cp.Internacao = Convert.ToDateTime(linha["Internacao"]);
                    colecao.Add(Cp);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Paciente pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

             public ConsultaPacienteColecao  ConsultaPacientePorId(Int64 IdPaciente)
        {
            try
            {
                ConsultaPacienteColecao colecao = new ConsultaPacienteColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", IdPaciente);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteId");
                foreach (DataRow linha in dt.Rows)
                {
                    ConsultaPacientes Cp = new ConsultaPacientes();
                    Cp.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    Cp.Nome = Convert.ToString(linha["Nome"]);
                    Cp.Sexo = Convert.ToString(linha["Sexo"]);
                    Cp.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    Cp.CPF = Convert.ToString(linha["CPF"]);
                    Cp.RG = Convert.ToString(linha["RG"]);
                    Cp.Endereco = Convert.ToString(linha["Endereco"]);
                    Cp.Telefone = Convert.ToString(linha["Telefone"]);
                    Cp.Celular = Convert.ToString(linha["Celular"]);
                    Cp.Plano = Convert.ToString(linha["Plano"]);
                    Cp.Categoria = Convert.ToString(linha["Categoria"]);
                    Cp.Internacao = Convert.ToDateTime(linha["Internacao"]);
                    colecao.Add(Cp);
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
