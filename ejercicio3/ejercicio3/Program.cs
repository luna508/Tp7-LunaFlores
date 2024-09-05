using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio3.Modelo;


/*Una tienda en línea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada 
producto tiene un nombre, precio, descripción y cantidad en stock. Los pedidos incluyen un 
identificador de pedido, fecha de pedido, cliente y el precio total del pedido. Los clientes tienen 
un nombre, dirección de envío y dirección de correo electrónico. Diseña un programa que 
permita agregar productos, gestionar el stock, y procesar pedidos. Identifica los objetos, 
atributos y métodos necesarios para este sistema.*/

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.SetNombre("Flores Luna ");
            cliente1.SetCorreoElectronico("luz23@gmail.com");
            cliente1.SetDirecciondeEnvio("B° San Agustin p5,c18 ");
            cliente1.MostrarInfo();
            Console.WriteLine("---------------------------------------------------------------");
            Pedido pedido1 = new Pedido();
            pedido1.SetUsuario("Flores Luna ");
            pedido1.SetIndenPedido(34);
            pedido1.SetFechadePedido("23/09/2025");
            pedido1.SetPreciototal(3450);
            pedido1.MostrarInfo();
            Console.WriteLine("---------------------------------------------------------------");
            Producto producto1 = new Producto();
            producto1.SetNombre("Salsa de Tomate/Botella");
            producto1.SetDescripcion("Rico en minerales y muy economico");
            producto1.SetPrecio(3450);
            producto1.SetStock(3);
            producto1.MostrarInfo();

            Console.ReadKey();


        }
    }
}
