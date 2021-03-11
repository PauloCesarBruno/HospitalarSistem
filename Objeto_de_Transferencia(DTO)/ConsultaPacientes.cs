using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class ConsultaPacientes
    {
        public Int64 IdPaciente { get; set; }
        public String Nome { get; set; }
        public DateTime  DataNascimento { get; set; }
        public String  Sexo { get; set; }
        public String CPF { get; set; }
        public String RG { get; set; }
        public String  Endereco { get; set; }
        public String  Telefone { get; set; }
        public String Celular { get; set; }
        public String Plano { get; set; }
        public String  Categoria { get; set; }
        public DateTime  Internacao { get; set; }
    }
}
