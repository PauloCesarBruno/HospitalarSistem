using System;
using System.Data;


namespace Objeto_de_Transferencia
{
    public class Acomodacao
    {
        public Int64 IdPaciente { get; set; }
        public String  NomePaciente { get; set; }
        public DateTime  Data { get; set; }
        public Int32 IdDiaria { get; set; }
        public String  LocalAcomodado { get; set; }
        public String Leito { get; set; }
        public String  Quarto { get; set; }
        public Int32 diasAcomodado { get; set; }
        public Decimal  ValorAcomodacao { get; set; }
        public Decimal Valor_Total { get; set; }
    }
}
