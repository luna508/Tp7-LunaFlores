using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.Modelo
{
    class Estudiante
    {
        private string Nombre;
        private int NumMatricula;
        private string AnCursado;

      
        public void SetNombre(string nom)
        {
            Nombre = nom;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNumMatricula(int matri)
        {
            NumMatricula = matri;
        }
        public int GetNumMatricula()
        {
            return NumMatricula;
        }
        public void SetAnCursado(string cursad)
        {
            AnCursado = cursad;
        }
        public string GetAnCursado()
        {
            return AnCursado;
        }


        public void MostrarInfo()
        {
            Console.WriteLine("Nombre del Estudiante: "+Nombre);
            Console.WriteLine("N° de Matricula del Estudiante: "+NumMatricula);
            Console.WriteLine("Año  en el que Cursa: "+AnCursado);
        }

    }
}
