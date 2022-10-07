using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDaper
{
    public class Conexion
    {
        public static string GetConexion ()
        {
            return @"Data Source=ARTURO\SQLEXPRESS;Initial Catalog=AArteagaDapper;Integrated Security=True";
        }
       
    }
}
