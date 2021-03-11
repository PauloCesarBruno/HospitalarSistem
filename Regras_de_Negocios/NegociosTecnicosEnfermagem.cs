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
    public class NegociosTecnicosEnfermagem
    {
        Conect conect = new Conect();

        public String Insere_Tecico(TecnicoEnfermagem  TecEnfermagem)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdTecnico", TecEnfermagem.IdTecnico);
                conect.AddParametros("@NomeTecnico", TecEnfermagem.NomeTecnico);
                conect.AddParametros("@Endereco", TecEnfermagem.Endereco);
                conect.AddParametros("@COREN", TecEnfermagem.COREN);
                conect.AddParametros("@CPF", TecEnfermagem.CPF);
                conect.AddParametros("@RG", TecEnfermagem.RG);
                conect.AddParametros("@Telefone", TecEnfermagem.Telefone);
                conect.AddParametros("@Celular", TecEnfermagem.Celular);
                conect.AddParametros("@Email", TecEnfermagem.Email);
                String IdTecnico = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereTecnico").ToString();
                conect.FecharConexao();
                return IdTecnico;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String Altera_Tecico(TecnicoEnfermagem TecEnfermagem)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdTecnico", TecEnfermagem.IdTecnico);
                conect.AddParametros("@NomeTecnico", TecEnfermagem.NomeTecnico);
                conect.AddParametros("@Endereco", TecEnfermagem.Endereco);
                conect.AddParametros("@COREN", TecEnfermagem.COREN);
                conect.AddParametros("@CPF", TecEnfermagem.CPF);
                conect.AddParametros("@RG", TecEnfermagem.RG);
                conect.AddParametros("@Telefone", TecEnfermagem.Telefone);
                conect.AddParametros("@Celular", TecEnfermagem.Celular);
                conect.AddParametros("@Email", TecEnfermagem.Email);
                String IdTecnico = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraTecnico").ToString();
                conect.FecharConexao();
                return IdTecnico;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public String Exclui_Tecico(TecnicoEnfermagem TecEnfermagem)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdTecnico", TecEnfermagem.IdTecnico);
                String IdTecnico = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaTecnico").ToString();
                conect.FecharConexao();
                return IdTecnico;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }

        public TecnicoEnfermagemColecao  ConsultaTecnicoNome(String TecNome)
        {
            try
            {
                TecnicoEnfermagemColecao colecao = new TecnicoEnfermagemColecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeTecnico", TecNome);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaTecnicoNome");
                foreach (DataRow linha in dt.Rows)
                {
                    TecnicoEnfermagem Tecnfermagem = new TecnicoEnfermagem();
                    Tecnfermagem.IdTecnico = Convert.ToInt32(linha["IdTecnico"]);
                    Tecnfermagem.NomeTecnico = Convert.ToString(linha["NomeTecnico"]);
                    Tecnfermagem.Endereco = Convert.ToString(linha["Endereco"]);
                    Tecnfermagem.COREN = Convert.ToString(linha["COREN"]);
                    Tecnfermagem.CPF = Convert.ToString(linha["CPF"]);
                    Tecnfermagem.RG = Convert.ToString(linha["RG"]);
                    Tecnfermagem.Telefone = Convert.ToString(linha["Telefone"]);
                    Tecnfermagem.Celular = Convert.ToString(linha["Celular"]);
                    Tecnfermagem.Email = Convert.ToString(linha["Email"]);
                    colecao.Add(Tecnfermagem);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Tecnico(a) pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }

        public TecnicoEnfermagemColecao ConsultaTecnicoId(Int32 TecId)
        {
            try
            {
                TecnicoEnfermagemColecao colecao = new TecnicoEnfermagemColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdTecnico", TecId);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaTecnicoID");
                foreach (DataRow linha in dt.Rows)
                {
                    TecnicoEnfermagem Tecnfermagem = new TecnicoEnfermagem();
                    Tecnfermagem.IdTecnico = Convert.ToInt32(linha["IdTecnico"]);
                    Tecnfermagem.NomeTecnico = Convert.ToString(linha["NomeTecnico"]);
                    Tecnfermagem.Endereco = Convert.ToString(linha["Endereco"]);
                    Tecnfermagem.COREN = Convert.ToString(linha["COREN"]);
                    Tecnfermagem.CPF = Convert.ToString(linha["CPF"]);
                    Tecnfermagem.RG = Convert.ToString(linha["RG"]);
                    Tecnfermagem.Telefone = Convert.ToString(linha["Telefone"]);
                    Tecnfermagem.Celular = Convert.ToString(linha["Celular"]);
                    Tecnfermagem.Email = Convert.ToString(linha["Email"]);
                    colecao.Add(Tecnfermagem);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Tecnico(a) pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}
