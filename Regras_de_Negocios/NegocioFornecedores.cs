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
    public class NegocioFornecedores
    {
        Conect conect = new Conect();

        public String Insere_Fornecedor(Fornecedores fornecedores)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdFornecedor", fornecedores.IdFornecedor);
                conect.AddParametros("@Nome", fornecedores.Nome);
                conect.AddParametros("@CNPJ", fornecedores.CNPJ);
                conect.AddParametros("@InscricaoEstadual", fornecedores.InscricaoEstadual);
                conect.AddParametros("@InscricaoMunicipal", fornecedores.InscricaoMunicipal);
                conect.AddParametros("@Endereco", fornecedores.Endereco);
                conect.AddParametros("@Telefone1", fornecedores.Telefone1);
                conect.AddParametros("@Telefone2", fornecedores.Telefone2);
                conect.AddParametros("@Email", fornecedores.Email);
                conect.AddParametros("@Contato", fornecedores.Contato);
                String IdFornrcedor = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereFornecedor").ToString();
                conect.FecharConexao();
                return IdFornrcedor;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public String Exclui_Fornecedor(Fornecedores fornecedores)
        {
            try
            {
                conect.AddParametros("@IdFornecedor", fornecedores.IdFornecedor);
                String IdFornecedor = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_DeletaFornecedor").ToString();
                conect.FecharConexao();
                return IdFornecedor;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe : " + ex.Message);
            }
        }
        public String Altera_Fornecedor(Fornecedores fornecedores)
        {
            try
            {
                conect.LimpaParametros();
                conect.AddParametros("@IdFornecedor", fornecedores.IdFornecedor);
                conect.AddParametros("@Nome", fornecedores.Nome);
                conect.AddParametros("@CNPJ", fornecedores.CNPJ);
                conect.AddParametros("@InscricaoEstadual", fornecedores.InscricaoEstadual);
                conect.AddParametros("@InscricaoMunicipal", fornecedores.InscricaoMunicipal);
                conect.AddParametros("@Endereco", fornecedores.Endereco);
                conect.AddParametros("@Telefone1", fornecedores.Telefone1);
                conect.AddParametros("@Telefone2", fornecedores.Telefone2);
                conect.AddParametros("@Email", fornecedores.Email);
                conect.AddParametros("@Contato", fornecedores.Contato);
                String IdFornrcedor = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraFornecedor").ToString();
                conect.FecharConexao();
                return IdFornrcedor;
            }
            catch (Exception ex)
            {
                return ("ERRO, Detalhe :" + ex.Message);
            }
        }
        public FornecedoresColecao ConsultaFornecedorPorNome(String nomefornecedor)
        {
            try
            {
                FornecedoresColecao colecao = new FornecedoresColecao();
                conect.LimpaParametros();
                conect.AddParametros("@Nome", nomefornecedor);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaFornecedorNome");
                foreach (DataRow linha in dt.Rows)
                {
                    Fornecedores fornrcedores = new Fornecedores();
                    fornrcedores.IdFornecedor = Convert.ToInt32(linha["IdFornecedor"]);
                    fornrcedores.Nome = Convert.ToString(linha["Nome"]);
                    fornrcedores.CNPJ = Convert.ToString(linha["CNPJ"]);
                    fornrcedores.InscricaoEstadual = Convert.ToString(linha["InscricaoEstadual"]);
                    fornrcedores.InscricaoMunicipal = Convert.ToString(linha["InscricaoMunicipal"]);
                    fornrcedores.Endereco = Convert.ToString(linha["Endereco"]);
                    fornrcedores.Telefone1  = Convert.ToString(linha["Telefone1"]);
                    fornrcedores.Telefone2 = Convert.ToString(linha["Telefone2"]);
                    fornrcedores.Email = Convert.ToString(linha["Email"]);
                    fornrcedores.Contato = Convert.ToString(linha["Contato"]);
                    colecao.Add(fornrcedores);
                    conect.FecharConexao();
                }

                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Fornecedor pelo Nome Informado. Detalhe:" + ex.Message);
            }
        }
        public FornecedoresColecao ConsultaFornecedorPorId(Int32 idFornecedor)
        {
            try
            {
                FornecedoresColecao colecao = new FornecedoresColecao();
                conect.LimpaParametros();
                conect.AddParametros("@IdFornecedor", idFornecedor);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaFornecedorId");
                foreach (DataRow linha in dt.Rows)
                {
                    Fornecedores fornrcedores = new Fornecedores();
                    fornrcedores.IdFornecedor = Convert.ToInt32(linha["IdFornecedor"]);
                    fornrcedores.Nome = Convert.ToString(linha["Nome"]);
                    fornrcedores.CNPJ = Convert.ToString(linha["CNPJ"]);
                    fornrcedores.InscricaoEstadual = Convert.ToString(linha["InscricaoEstadual"]);
                    fornrcedores.InscricaoMunicipal = Convert.ToString(linha["InscricaoMunicipal"]);
                    fornrcedores.Endereco = Convert.ToString(linha["Endereco"]);
                    fornrcedores.Telefone1 = Convert.ToString(linha["Telefone1"]);
                    fornrcedores.Telefone2 = Convert.ToString(linha["Telefone2"]);
                    fornrcedores.Email = Convert.ToString(linha["Email"]);
                    fornrcedores.Contato = Convert.ToString(linha["Contato"]);
                    colecao.Add(fornrcedores);
                    conect.FecharConexao();
                }
                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Consultar Fornecedor pelo Código Informado. Detalhe:" + ex.Message);
            }
        }
    }
}