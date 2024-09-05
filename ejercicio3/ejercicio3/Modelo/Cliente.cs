using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.Modelo
{
    class Cliente
    {
        private string Nombre;
        private string DirecciondeEnvio;
        private string CorreoElectronico;

        public void SetNombre(string nom)
        {
            Nombre = nom ;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetDirecciondeEnvio(string envio)
        {
            DirecciondeEnvio= envio;
        }
        public string GetDirecciondeEnvio()
        {
            return DirecciondeEnvio;
        }

        public void SetCorreoElectronico(string correo)
        {
            CorreoElectronico= correo;
        }
        public string GetCorreoElectronico()
        {
            return CorreoElectronico;
        }


        public void MostrarInfo()
        {
            Console.WriteLine("Nombre del Cliente/a: "+Nombre);
            Console.WriteLine("Direccion de Envio: "+DirecciondeEnvio);
            Console.WriteLine("Direccion de Correo Electronico: "+ CorreoElectronico);
        }

    }
}
