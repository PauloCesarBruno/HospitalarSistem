using System;
using System.Data;

namespace Objeto_de_Transferencia
{
    public class PacienteEntrada
    {
        public Int64 IdPaciente { get; set; }
        public Int32 IdMedico { get; set; }
        public Int32 IdProcedimento { get; set; }
        public Int32 IdDiaria { get; set; }
        public Int64 IdInsumo { get; set; }
        public Int64 IdMedicamento{ get; set; }
        public Int64  IdExame { get; set; }
        public String Nome { get; set; }
        public DateTime  DataNascimento { get; set; }
        public String Sexo { get; set; }
        public String CPF { get; set; }
        public String  RG { get; set; }
        public String  Endereco { get; set; }
        public String  Telefone { get; set; }
        public String  Celular { get; set; }
        public String  Plano { get; set; }
        public String  Categoria { get; set; }
        public DateTime  Internacao { get; set; }
        public String  NomeAcompanhante { get; set; }
        public String RGAcompanhante { get; set; }
        public String EnderecoAcompanhante { get; set; }
        public String TelefoneAcompanhante { get; set; }
        public String  CeluarAcompanhante { get; set; }
        public String EmailAcompanhante { get; set; }
        public Int32 DiasInternados { get; set; }
        public Int32  Leito { get; set; }
        public Int32 Quarto { get; set; }
        public DateTime  Alta { get; set; }
        public String  ObsAlta { get; set; }
    }
}
