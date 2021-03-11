using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class Prontuario
    {
        public DateTime Data { get; set; }
        public Int64 IdPaciente { get; set; }
        public String NomePaciente { get; set; }
        public String ProntuarioPaciente { get; set; }
    }
}
