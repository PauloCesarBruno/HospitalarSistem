using System;
using System.Data;

namespace Objeto_de_Transferencia
{
   public  class Fornecedores
    {
       public Int32 IdFornecedor { get; set; }
       public String Nome { get; set; }
       public String CNPJ { get; set; }
       public String InscricaoEstadual { get; set; }
       public String InscricaoMunicipal { get; set; }
       public String Endereco { get; set; }
       public String Telefone1 { get; set; }
       public String Telefone2 { get; set; }
       public String Email { get; set; }
       public String Contato { get; set; }
    }
}
