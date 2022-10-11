using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDaper
{
    public class Ver
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

        public static Resultado Ve(Ver alumno)
        {
            Resultado resultado = new Resultado(); 

            try
            {
                using (SqlConnection context = new SqlConnection(Conexion.GetConexion()))
                {
                    var query = context.Execute($"AlumnoAdd '{alumno.Nombre}', '{alumno.AP_Paterno}','{alumno.AP_Materno}','{alumno.FechaNac}','{alumno.Matricula}','{alumno.Sexo}','{alumno.Email}',{alumno.Id_semestre}");

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
        public static Resultado GetAll()
        {
            Resultado resultado = new Resultado();

            try
            {
                using (SqlConnection context = new SqlConnection(Conexion.GetConexion()))
                {
                    //var sql = "AlumnoGetAll";
                    var lst = context.Query<Alumno>("AlumnoGetAll").ToList(); //Dapper

                    resultado.Objetos = new List<object>();
                    foreach (var obj in lst)
                    {
                        Ver alumno = new Ver();

                        alumno.Id_alumno = obj.Id_alumno;
                        alumno.Nombre = obj.Nombre;
                        alumno.AP_Paterno = obj.AP_Paterno;
                        alumno.AP_Materno = obj.AP_Materno;
                        alumno.FechaNac = obj.FechaNac;
                        alumno.Matricula = obj.Matricula;
                        alumno.Sexo = obj.Sexo;
                        alumno.Email = obj.Email;
                        alumno.Id_semestre = obj.Id_semestre;

                        resultado.Objetos.Add(alumno);
                    }
                    resultado.Mensaje = "Correcto";
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
