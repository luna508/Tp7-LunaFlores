using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.Modelo
{
    class Pasajero
    {
        private string Nombre;
        private int NumerodePasaporte;
        private string Nacionalidad;



        public void SetNombre(string nom)
        {
            Nombre= nom;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNumerodePasaporte(int pas)
        {
            NumerodePasaporte = pas;
        }
        public int GetNumerodePasaporte()
        {
            return NumerodePasaporte;
        }

        public void SetNacionalidad(string nac)
        {
            Nacionalidad= nac;
        }
        public string GetNacionalidad()
        {
            return Nacionalidad;
        }


        public void MostarInfo()
        {
            Console.WriteLine("Nombre del Pasajero/a: "+Nombre);
            Console.WriteLine("Numero de pasaporte es :"+NumerodePasaporte);
            Console.WriteLine("Su Nacionalidad es : "+Nacionalidad);
        }

    }
}
