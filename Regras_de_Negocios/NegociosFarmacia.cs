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
    public class NegociosFarmacia
    {
        Conect conect = new Conect();

        public String Insere_Farmacia(Farmacia farmacia)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdMedicamento", farmacia.IdMedicamento);
                conect.AddParametros("@NomeMedicamento", farmacia.NomeMedicamento);
                conect.AddParametros("@Quantidade", farmacia.Quantidade);
                conect.AddParametros("@QtdMinima", farmacia.QtdMinima);
                conect.AddParametros("@QtdMaxima", farmacia.QtdMaxima);
                String IdMedicamento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereMedicamento").ToString();
                conect.FecharConexao();
                return IdMedicamento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Exclui_Farmacia(Farmacia farmacia)
        {
            try
            {
                conect.AddParametros("@IdMedicamento", farmacia.IdMedicamento);
                String IdMedicamento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaMedicamento").ToString();
                conect.FecharConexao();
                return IdMedicamento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }
        public String Altera_Farmacia(Farmacia farmacia)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdMedicamento", farmacia.IdMedicamento);
                conect.AddParametros("@NomeMedicamento", farmacia.NomeMedicamento);
                conect.AddParametros("@Quantidade", farmacia.Quantidade);
                conect.AddParametros("@QtdMinima", farmacia.QtdMinima);
                conect.AddParametros("@QtdMaxima", farmacia.QtdMaxima);
                String IdMedicamento = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraMedicamento").ToString();
                conect.FecharConexao();
                return IdMedicamento;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public Farmacia_Colecao ConsultaFarmaciaPorNome(String nomefarmacia)
        {
            try
            {
                Farmacia_Colecao colecao = new Farmacia_Colecao();
                conect.LimpaParametros();
                conect.AddParametros("@NomeMedicamento", nomefarmacia);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaMedicamentoNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Farmacia farmacia = new Farmacia();
                    farmacia.IdMedicamento = Convert.ToInt64(linha["IdMedicamento"]);
                    farmacia.NomeMedicamento = Convert.ToString(linha["NomeMedicamento"]);
                    farmacia.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    farmacia.QtdMinima = Convert.ToInt32(linha["QtdMinima"]);
                    farmacia.QtdMaxima = Convert.ToInt32(linha["QtdMaxima"]);
                    colecao.Add(farmacia);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Medicamento pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public Farmacia_Colecao ConsultaFarmaciaPorId(Int64 idfarmacia)
        {
            try
            {
                Farmacia_Colecao colecao = new Farmacia_Colecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdMedicamento", idfarmacia);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaMedicamentoId");
                foreach (DataRow linha in dt.Rows)
                {
                    Farmacia farmacia = new Farmacia();
                    farmacia.IdMedicamento = Convert.ToInt64(linha["IdMedicamento"]);
                    farmacia.NomeMedicamento = Convert.ToString(linha["NomeMedicamento"]);
                    farmacia.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    farmacia.QtdMinima = Convert.ToInt32(linha["QtdMinima"]);
                    farmacia.QtdMaxima = Convert.ToInt32(linha["QtdMaxima"]);
                    colecao.Add(farmacia);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Medicamento pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}