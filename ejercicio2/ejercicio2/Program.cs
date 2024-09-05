using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio2.Modelo; 
/*Una compañía aérea desea implementar un sistema de gestión de vuelos. Los vuelos tienen un 
número, una fecha de salida, un destino y un precio. Los pasajeros tienen un nombre, número 
de pasaporte y nacionalidad. Se requiere un programa que permita gestionar los vuelos, 
incluyendo la adición y eliminación de vuelos, así como la gestión de los pasajeros en cada 
vuelo. Identifica los posibles objetos, atributos y métodos necesarios para implementar este 
sistema.*/

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vuelos Vuelo1 = new Vuelos();
            Vuelo1.SetNumerodeVuelo(52);
            Vuelo1.SetFechadeSalida("23/09/2024");
            Vuelo1.SetDestino("Bs.As");
            Vuelo1.SetPrecio("$12,980.50");
            Vuelo1.MostrarInfo();
            Console.WriteLine("-------------------------------------------------------------------------");
            Pasajero Pasajero1 = new Pasajero();
            Pasajero1.SetNombre("Flores Luna Guadalupe");
            Pasajero1.SetNumerodePasaporte(567);
            Pasajero1.SetNacionalidad("Argentina");
            Pasajero1.MostarInfo();

            Console.ReadKey();

        }
    }
}
