using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio4.Modelo;

/*. Una universidad desea crear un sistema para la gestión de cursos y estudiantes. Cada curso 
tiene un código, nombre, profesor y la materia que dicta. Los estudiantes tienen un nombre, 
número de matrícula y el año de cursado. El sistema debe permitir la inscripción y des 
inscripción de estudiantes en cursos, así como la visualización de la lista de estudiantes por 
curso. Identifica los objetos, atributos y métodos necesarios para implementar este sistema.*/

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            estudiante1.SetNombre("Flores Lujan ");
            estudiante1.SetNumMatricula(4560);
            estudiante1.SetAnCursado("3° 2°");
            estudiante1.MostrarInfo();
            Console.WriteLine("----------------------------------------------------------------------");
            Curso curso1=new Curso();
            curso1.SetCodigo(4560);
            curso1.SetNombre("3° II° division");
            curso1.SetProfesor("Prof.Vera Ramon ");
            curso1.SetMateria("TIC");
            curso1.MostrarInfo();
            Console.ReadKey(); 
        }
    }
}
