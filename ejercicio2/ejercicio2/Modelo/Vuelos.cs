using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.Modelo
{
    class Vuelos
    {
        private int NumerodeVuelo;
        private string FechadeSalida;
        private string Destino;
        private string Precio;

        public void SetNumerodeVuelo(int vuelo)
        {
            NumerodeVuelo = vuelo;
        }

        public int GetNumerodeVuelo()
        {
            return NumerodeVuelo;
        }

        public void SetFechadeSalida( string salida)
        {
            FechadeSalida = salida;
        }
        public string GetFechadeSalida()
        {
            return FechadeSalida;
        }

        public void SetDestino(string des)
        {
            Destino= des;
        }
        public string GetDestino()
        {
            return Destino;
        }
        public void SetPrecio(string pre)
        {
            Precio = pre;
        }
        public string GetPrecio()
        {
            return Precio;
        }

            

        public  void MostrarInfo()
        {
            Console.WriteLine("Numero de Vuelo es : " + NumerodeVuelo );
            Console.WriteLine("Fecha de salida de su vuelo es el dia: "+ FechadeSalida);
            Console.WriteLine("El destino de vuelo es a: "+Destino);
            Console.WriteLine("El precio de su vuelo es : "+Precio);
            
        }

  
    }
}
