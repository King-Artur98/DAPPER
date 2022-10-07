using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDaper
{
    public  class BorrarA
    {
        public int Id_alumno { get; set; }

        public string Nombre { get; set; }

        public string AP_Paterno { get; set; }

        public string AP_Materno { get; set; }

        public string FechaNac { get; set; }

        public string Matricula { get; set; }

        public string Sexo { get; set; }

        public string Email { get; set; }

        public byte Id_semestre { get; set; }

        public static Resultado Del(BorrarA alumno)
        {
            Resultado resultado = new Resultado();

            try
            {
                using (SqlConnection context = new SqlConnection(Conexion.GetConexion()))
                {
                    var query = context.Execute($"AlumnoDel {alumno.Id_alumno}");

                    if (query > 0)
                    {
                        resultado.Mensaje = "Correcto";
                    }

                }
            }
            catch (Exception ex)
            {
                resultado.Mensaje = "Error" + ex;
            }
            return resultado;
        }
    }
}
