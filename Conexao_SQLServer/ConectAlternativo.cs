using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
//
using Conexao_SQLServer.Properties;

namespace Conexao_SQLServer
{
    public class ConectAlternativo
    {
        public string sql = (Settings.Default.String);

        public ConectAlternativo() // Construtor da Classe
        {
            // Nada Necessário.
        }
    }
}