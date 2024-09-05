using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio1.Modelo;

/*Una biblioteca digital ofrece una amplia variedad de libros a sus usuarios registrados. Los 
usuarios pueden buscar libros, leer descripciones, ver la disponibilidad y, si están registrados, 
pueden pedir prestados los libros. Los libros pueden estar disponibles en formato digital o físico. 
Cada vez que un usuario pide prestado un libro, se registra la fecha de préstamo y la fecha de 
devolución prevista. Además, la biblioteca tiene un sistema para enviar recordatorios a los 
usuarios cuando se acerca la fecha de devolución de un libro.
*/


namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario();

            usuario1.SetNombre("Escalante Fabiola");
            usuario1.SetTelefono("3838-473445");
            usuario1.SetRegistrado(true);
            usuario1.MostrarInfo();
            Console.WriteLine("--------------------------------------------------------------");
            Libro libro1 = new Libro();
            libro1.SetDisponi( true);
            libro1.SetNombre("Cuentos de Campo");
            libro1.SetAutor("Horacio Quiroga");
            libro1.SetEditorial("Planeta");
            libro1.SetCodigo(298);
            libro1.SetFechaPrestamo("20/07/2024");
            libro1.SetFechaDevo("20/08/2024");
            libro1.SetFormato("Digital y Fisico ");
            libro1.MostrarInfo();
            Console.ReadKey();

        }
    }
}
