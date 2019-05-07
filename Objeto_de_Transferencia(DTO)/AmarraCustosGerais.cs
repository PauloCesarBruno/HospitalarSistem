using System;
using System.Data;


namespace Objeto_de_Transferencia
{
    public class AmarraCustosGerais
    {
        public Int64 IdPaciente { get; set; }
        public String Nome { get; set; }
        public Int64 IdInsumo { get; set; }
        public Int64 IdMedicamento { get; set; }
        public Int32 IdExame { get; set; }
    }
}
