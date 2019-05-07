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
    public class NegociosConsultaPacientesAcompanhantes
    {
        Conect conect = new Conect();
        public ConsultaPacienteAcompanhanteColecao ConsultaNome(String nome)
        {
            try
            {
                ConsultaPacienteAcompanhanteColecao colecao = new ConsultaPacienteAcompanhanteColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", nome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteAcompanhanteNome");
                 foreach (DataRow linha in dt.Rows)
                {
                    ConsultaPacienteAcompanhante obj = new ConsultaPacienteAcompanhante();
                    obj.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    obj.Nome = Convert.ToString(linha["Nome"]);
                    obj.NomeAcompanhante = Convert.ToString(linha["NomeAcompanhante"]);
                    obj.RGAcompanhante = Convert.ToString(linha["RGAcompanhante"]);
                    obj.EnderecoAcompanhante = Convert.ToString(linha["EnderecoAcompanhante"]);
                    obj.TelefoneAcompanhante = Convert.ToString(linha["TelefoneAcompanhante"]);
                    obj.CelularAcompanhante = Convert.ToString(linha["CeluarAcompanhante"]);
                    obj.EmailAcompanhante = Convert.ToString(linha["EmailAcompanhante"]);
                    colecao.Add(obj);
                    conect.FecharConexao();
                }

                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Paciente X Acompanhante pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public ConsultaPacienteAcompanhanteColecao ConsultaId(Int64 Id)
        {
            try
            {
                ConsultaPacienteAcompanhanteColecao colecao = new ConsultaPacienteAcompanhanteColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdPaciente", Id);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteAcompanhante");
                foreach (DataRow linha in dt.Rows)
                {
                    ConsultaPacienteAcompanhante obj = new ConsultaPacienteAcompanhante();
                    obj.IdPaciente = Convert.ToInt64(linha["IdPaciente"]);
                    obj.Nome = Convert.ToString(linha["Nome"]);
                    obj.NomeAcompanhante = Convert.ToString(linha["NomeAcompanhante"]);
                    obj.RGAcompanhante = Convert.ToString(linha["RGAcompanhante"]);
                    obj.EnderecoAcompanhante = Convert.ToString(linha["EnderecoAcompanhante"]);
                    obj.TelefoneAcompanhante = Convert.ToString(linha["TelefoneAcompanhante"]);
                    obj.CelularAcompanhante = Convert.ToString(linha["CeluarAcompanhante"]);
                    obj.EmailAcompanhante = Convert.ToString(linha["EmailAcompanhante"]);
                    colecao.Add(obj);
                    conect.FecharConexao();
                }

                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Paciente X Acompanhante pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
