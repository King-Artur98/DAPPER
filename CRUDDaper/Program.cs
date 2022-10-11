using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDaper
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int option;

            Console.WriteLine("***** ELEGIR OPCION *****");
            Console.WriteLine("1. Agregar Alumno.");
            Console.WriteLine("2. Quitar Alumno.");
            Console.WriteLine("3. Actualizar Alumno.");
            Console.WriteLine("4. Listado.");
            Console.WriteLine("5. Listado Por ID.");
            Console.Write("Seleccione una opción (1 - 5): ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Add();
                     void Add()
                    {
                        Alumno alumno = new Alumno();


                        Console.WriteLine("Ingrese el nombre del Alumno");
                        alumno.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el Apellido Paterno del Alumno");
                        alumno.AP_Paterno = Console.ReadLine();

                        Console.WriteLine("Ingrese el Apellido Materno del Alumno");
                        alumno.AP_Materno = Console.ReadLine();

                        Console.WriteLine("Ingrese la Fecha de Nacimiento del Alumno");
                        alumno.FechaNac = Console.ReadLine();

                        Console.WriteLine("Ingrese la Matricula del Alumno");
                        alumno.Matricula = Console.ReadLine();

                        Console.WriteLine("Ingrese el sexo del Alumno");
                        alumno.Sexo = Console.ReadLine();

                        Console.WriteLine("Ingrese el email del Alumno");
                        alumno.Email = Console.ReadLine();

                        Console.WriteLine("Ingrese el ID del semestre del Alumno");
                        alumno.Id_semestre = byte.Parse(Console.ReadLine());

                        Resultado resultado = Alumno.Add(alumno);

                        if (resultado.Mensaje == "Correcto")
                        {
                            Console.WriteLine("Alumno registrado con exito");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ocurrio un error en el registro");
                            Console.ReadKey();
                        }

                    }
                    break;

                case 2:

                    Del();
                    void Del()
                    {

                        BorrarA alumno = new BorrarA();

                        Console.WriteLine("Ingrese el ID  del Alumno");
                        alumno.Id_alumno = byte.Parse(Console.ReadLine());

                        Resultado resultado = BorrarA.Del(alumno);

                        if (resultado.Mensaje == "Correcto")
                        {
                            Console.WriteLine("Alumno borrado con exito");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ocurrio un error en la eliminacion");
                            Console.ReadKey();
                        }

                    }


                    break;

                case 3:

                    Act();

                    void Act()
                    {
                        AlumnoUpdate alumno = new AlumnoUpdate();

                        Console.WriteLine("Ingrese el ID  del Alumno a cambiar");
                        alumno.Id_alumno = byte.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nombre del Alumno");
                        alumno.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el Apellido Paterno del Alumno");
                        alumno.AP_Paterno = Console.ReadLine();

                        Console.WriteLine("Ingrese el Apellido Materno del Alumno");
                        alumno.AP_Materno = Console.ReadLine();

                        Console.WriteLine("Ingrese la Fecha de Nacimiento del Alumno");
                        alumno.FechaNac = Console.ReadLine();

                        Console.WriteLine("Ingrese la Matricula del Alumno");
                        alumno.Matricula = Console.ReadLine();

                        Console.WriteLine("Ingrese el sexo del Alumno");
                        alumno.Sexo = Console.ReadLine();

                        Console.WriteLine("Ingrese el email del Alumno");
                        alumno.Email = Console.ReadLine();

                        Console.WriteLine("Ingrese el ID del semestre del Alumno");
                        alumno.Id_semestre = byte.Parse(Console.ReadLine());

                        Resultado resultado = AlumnoUpdate.Act(alumno);

                        if (resultado.Mensaje == "Correcto")
                        {
                            Console.WriteLine("Alumno actualizado con exito");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ocurrio un error en la actializacion");
                            Console.ReadKey();
                        }

                    }

                    break;

                case 4:

                    GetAll();
                    
                    void GetAll()
                    {

                        Resultado resultado = Ver.GetAll();


                        
                        if (resultado.Mensaje == "Correcto")
                        {
                            foreach (Ver alumno in resultado.Objetos)
                            {
                                Console.WriteLine("***********************************************************************************************");
                                Console.WriteLine("Id_Alumno:  " + alumno.Id_alumno);
                                Console.WriteLine("Nombre:  " + alumno.Nombre);
                                Console.WriteLine("Apellido Paterno: " + alumno.AP_Paterno);
                                Console.WriteLine("Apellido Materno: " + alumno.AP_Materno);
                                Console.WriteLine("Fecha de nacimiento: " + alumno.FechaNac);
                                Console.WriteLine("Matricula: " + alumno.Matricula);
                                Console.WriteLine("Genero: " + alumno.Sexo);
                                Console.WriteLine("Email: " + alumno.Email);
                                Console.WriteLine("Semestre: " + alumno.Id_semestre);
                                Console.WriteLine("***********************************************************************************************" );
                                Console.ReadKey();
                            }
                        }

                        else
                                {
                            Console.WriteLine("Ocurrio un error en la consulta");
                            Console.ReadKey();
                        }
                    }

                    break;

                case 5:
                    GetAllB();

                    void GetAllB()
                    {
                        VerP alumnoo = new VerP();
                        Console.WriteLine("Ingrese el ID  del Alumno a cambiar");
                        alumnoo.Id_alumno = byte.Parse(Console.ReadLine());

                        Resultado resultado = VerP.GetAllB(alumnoo);



                        if (resultado.Mensaje == "Correcto")
                        {
                            

                            foreach (VerP alumno in resultado.Objetos)
                            {
                                Console.WriteLine("***********************************************************************************************");
                                Console.WriteLine("Id_Alumno:  " + alumno.Id_alumno);
                                Console.WriteLine("Nombre:  " + alumno.Nombre);
                                Console.WriteLine("Apellido Paterno: " + alumno.AP_Paterno);
                                Console.WriteLine("Apellido Materno: " + alumno.AP_Materno);
                                Console.WriteLine("Fecha de nacimiento: " + alumno.FechaNac);
                                Console.WriteLine("Matricula: " + alumno.Matricula);
                                Console.WriteLine("Genero: " + alumno.Sexo);
                                Console.WriteLine("Email: " + alumno.Email);
                                Console.WriteLine("Semestre: " + alumno.Id_semestre);
                                Console.WriteLine("***********************************************************************************************");
                                Console.ReadKey();
                            
                            }
                        }

                        else
                        {
                            Console.WriteLine("Ocurrio un error en la consulta");
                            Console.ReadKey();
                        }
                    }



                    break;

                case 5:
                    GetAllB();

                    void GetAllB()
                    {
                        VerP alumnoo = new VerP();
                        Console.WriteLine("Ingrese el ID  del Alumno a cambiar");
                        alumnoo.Id_alumno = byte.Parse(Console.ReadLine());

                        Resultado resultado = VerP.GetAllB(alumnoo);



                        if (resultado.Mensaje == "Correcto")
                        {
                            

                            foreach (VerP alumno in resultado.Objetos)
                            {
                                Console.WriteLine("***********************************************************************************************");
                                Console.WriteLine("Id_Alumno:  " + alumno.Id_alumno);
                                Console.WriteLine("Nombre:  " + alumno.Nombre);
                                Console.WriteLine("Apellido Paterno: " + alumno.AP_Paterno);
                                Console.WriteLine("Apellido Materno: " + alumno.AP_Materno);
                                Console.WriteLine("Fecha de nacimiento: " + alumno.FechaNac);
                                Console.WriteLine("Matricula: " + alumno.Matricula);
                                Console.WriteLine("Genero: " + alumno.Sexo);
                                Console.WriteLine("Email: " + alumno.Email);
                                Console.WriteLine("Semestre: " + alumno.Id_semestre);
                                Console.WriteLine("***********************************************************************************************");
                                Console.ReadKey();
                            
                            }
                        }

                        else
                        {
                            Console.WriteLine("Ocurrio un error en la consulta");
                            Console.ReadKey();
                        }
                    }



                    break;





            }
    }
 }
}
