using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class CustosGeral
    {
        public Int32 IdDiaria { get; set; }
        public String  LocalAcomodado { get; set; }
        public Int32 diasAcomodado { get; set; }
        public Decimal ValorAcomodacao { get; set; }
        public Decimal  Valor_Total { get; set; }
        //
        public Int32 IdInsumo{ get; set; }
        public String NomeInsumo { get; set; }
        public Decimal  ValorInsumo { get; set; }
        //
        public Int32 IdMedicamento { get; set; }
        public String  NomeMedicamento { get; set; }
        public Decimal  ValorMedicamento { get; set; }
        //
        public Int32 IdExame { get; set; }
        public String  NomeExame { get; set; }
        public Decimal  ValorExame { get; set; }
    }
}
