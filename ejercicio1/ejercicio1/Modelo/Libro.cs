using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Modelo
{
    class Libro
    {
        private bool Disponi;
        private string Nombre;
        private string Autor;
        private int Codigo;
        private string Editorial;
        private string FechaPrestamo;
        private string FechaDevo;
        private string Formato;

        public void SetDisponi(bool dis)
        {
            Disponi = dis;
        }

        public bool GetDisponi()
        {
            return Disponi;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetAutor(string aut)
        {
            Autor = aut;
        }

        public string GetAutor()
        {
            return Autor;
        }
        public void SetCodigo(int cod)
        {
            Codigo = cod;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        public void SetEditorial(string edi)
        {
            Editorial = edi;
        }

        public string GetEditorial()
        {
            return Editorial;
        }

        public void SetFechaPrestamo(string pres)
        {
            FechaPrestamo = pres;
        }

        public string GetFechaPrestamo()
        {
            return FechaPrestamo;
        }
        public void SetFechaDevo(string devo)
        {
            FechaDevo = devo;
        }

        public string GetFechaDevo()
        {
            return FechaDevo;
        }
        public void SetFormato(string form)
        {
            Formato= form ;
        }

        public string GetFormato()
        {
            return Formato;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Disponibilidad de libro: "+Disponi);
            Console.WriteLine("Nombre del Libro: "+Nombre);
            Console.WriteLine("Autor: "+Autor);
            Console.WriteLine("Codigo de Libro: "+Codigo);
            Console.WriteLine("Fecha de Prestamo: "+FechaPrestamo);
            Console.WriteLine("Fecha de Devolucion: "+FechaDevo);
            Console.WriteLine("Digital o Fisico:  " + Formato);
        }





    }
}
