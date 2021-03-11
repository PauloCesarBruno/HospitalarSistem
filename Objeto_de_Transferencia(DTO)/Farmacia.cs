using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class Farmacia
    {
        public Int64  IdMedicamento { get; set; }
        public String NomeMedicamento { get; set; }
        public Int32 Quantidade { get; set; }
        public Int32 QtdMinima { get; set; }
        public Int32 QtdMaxima { get; set; }
        
    }
}
