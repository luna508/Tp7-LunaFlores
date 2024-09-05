using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.Modelo
{
    class Pedido
    {
        private int IndenPedido;
        private string FechadePedido;
        private string Usuario;
        private float Preciototal;

        public void SetIndenPedido(int numpedi)
        {
                IndenPedido = numpedi;
        }
        public int GetIndenPedido()
        {
            return IndenPedido;
        }

        public void SetFechadePedido(string fecha )
        {
            FechadePedido= fecha;
        }
        public string GetFechadePedido()
        {
            return FechadePedido;
        }

        public void SetUsuario(string usua)
        {
            Usuario = usua;
        }
        public string GetUsuario()
        {
            return Usuario;
        }

        public void SetPreciototal(float total)
        {
            Preciototal = total;
        }
        public float GetPreciototal()
        {
            return Preciototal;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Indentificador de Pedido: "+IndenPedido);
            Console.WriteLine("Fecha de Pedido: "+FechadePedido);
            Console.WriteLine("Nombre del Usuario: "+Usuario);
            Console.WriteLine("Precio Total :$ "+Preciototal);
        }

    }
}
