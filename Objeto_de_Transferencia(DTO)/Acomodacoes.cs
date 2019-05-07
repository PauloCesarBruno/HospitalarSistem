using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class Acomodacoes
    {
        public String  LocalAcomodado { get; set; }
        public Int64 IdPaciente { get; set; }
        public String  NomePaciente { get; set; }
        public Int32 Leito { get; set; }
        public Int32 Quarto { get; set; }
    }
}
