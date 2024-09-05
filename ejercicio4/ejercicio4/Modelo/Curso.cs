using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.Modelo
{
    class Curso
    {
        private int Codigo;
        private string Nombre;
        private string Profesor;
        private string Materia;

        public void SetCodigo(int cod)
        {
            Codigo = cod; 
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetProfesor(string prof)
        {
            Profesor=prof;
        }
        public string GetProfesor()
        {
            return Profesor;
        }
        public void SetMateria(string mat)
        {
            Materia = mat;
        }
        public string GetMateria()
        {
            return Materia;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Codigo: "+Codigo);
            Console.WriteLine("Nombre del Curso: "+Nombre);
            Console.WriteLine("Profesor/ra: "+Profesor);
            Console.WriteLine("Materia que dicta: "+Materia);
        }
    }
}
