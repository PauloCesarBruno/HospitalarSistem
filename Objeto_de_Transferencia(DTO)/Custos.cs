using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class Custos
    {       
        public Int64 IdPaciente { get; set; }
        public String  NomePaciente{ get; set; }
        public DateTime  Data { get; set; }
        public String  Responsavel { get; set; }
        public Int32 IdInsumo { get; set; }
        public String NomeInsumo { get; set; }
        public Decimal ValorInsumo { get; set; }
        public Int32  IdMedicamento { get; set; }
        public String  NomeMedicamento { get; set; }
        public Decimal  ValorMedicamento { get; set; }
        public Int32  IdExame { get; set; }
        public String  NomeExame { get; set; }
        public Decimal  ValorExame { get; set; }
    }
}
