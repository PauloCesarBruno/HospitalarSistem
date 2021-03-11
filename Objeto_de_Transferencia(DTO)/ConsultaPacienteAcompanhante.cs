using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class ConsultaPacienteAcompanhante
    {
        public Int64 IdPaciente { get; set; }
        public String Nome { get; set; }
        public String NomeAcompanhante { get; set; }
        public String RGAcompanhante { get; set; }
        public String EnderecoAcompanhante { get; set; }
        public String TelefoneAcompanhante { get; set; }
        public String CelularAcompanhante { get; set; }
        public String EmailAcompanhante { get; set; }
    }
}
