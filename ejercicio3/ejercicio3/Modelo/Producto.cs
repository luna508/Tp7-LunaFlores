using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.Modelo
{
    class Producto
    {
        private string Nombre;
        private float Precio;
        private string Descripcion;
        private int Stock;


        public void SetNombre(string nom)
        {
            Nombre = nom;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetPrecio (float pre)
        {
            Precio = pre;
        }
        public float GetPrecio()
        {
            return Precio;
        }

        public void SetDescripcion(string des)
        {
            Descripcion = des;
        }
        public string GetDescripcion()
        {
            return Descripcion;
        }

        public void SetStock(int stock)
        {
            Stock= stock;
        }
        public int GetStock()
        {
            return Stock;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("El Nombre del Producto es: "+Nombre);
            Console.WriteLine("El precio del Producto es $: " + Precio);
            Console.WriteLine("Descrpcion de Producto: "+Descripcion);
            Console.WriteLine("La Cantidad de Stock: "+ Stock);

        }

    }
}
