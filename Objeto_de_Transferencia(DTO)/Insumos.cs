using System;
using System.Data;


namespace Objeto_de_Transferencia
{
   public class Insumos
    {
       public Int64 IdInsumo { get; set; }
       public String NomeInsumo { get; set; }
       public Int32 Quantidade { get; set; }
       public Int32 QtdMinima { get; set; }
       public Int32 QtdMaxima { get; set; }
    }
}
