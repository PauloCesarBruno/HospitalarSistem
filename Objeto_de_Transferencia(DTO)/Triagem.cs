using System;
using System.Data;


namespace Objeto_de_Transferencia
{
    public class Triagem
    {
        public Int64 Codigo { get; set; }
        public String Nome { get; set; }
        public String Data { get; set; }
        public String Sexo { get; set; }
        public DateTime DiaHora { get; set; }
        public Boolean Pbaixa { get; set; }
        public Boolean Pmedia { get; set; }
        public Boolean Palta { get; set; }
    }
}
