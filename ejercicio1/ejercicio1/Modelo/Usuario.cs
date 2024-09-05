using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Modelo
{
    class Usuario
    {
        private string Nombre;
        private string Telefono;
        private bool Registrado;

        public void SetNombre(string nom) 
        {
            Nombre = nom;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetTelefono(string Tel) 
        {
            Telefono = Tel;
        }
        public string GetTelofono()
        {
            return Telefono;
        }

        public void SetRegistrado(bool res)
        {
            Registrado = res;
        }
        public bool GetRegistrado()
        {
            return Registrado;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nombre del Usuario: "+Nombre);
            Console.WriteLine("Telefono: "+Telefono);
            Console.WriteLine("Esta Registrado: "+ Registrado);
        }

    }
}
