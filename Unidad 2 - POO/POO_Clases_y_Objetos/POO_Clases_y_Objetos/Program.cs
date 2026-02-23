using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO_Clases_y_Objetos
{
   class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];
          for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();

                Console.WriteLine($"Ingrese los datos del artículo {i + 1}:");
                Console.WriteLine("Codigo del artículo (3 dígitos no correlativos):");
                articulos[i].codigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio del artículo:");
                articulos[i].precioArticulo = float.Parse(Console.ReadLine());
                Console.WriteLine("Código de marca (1 a 10):");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }

          Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta:");

            // 1. Lectura anticipada (fuera del while)
            Console.WriteLine("Ingrese el código del Cliente (0 para salir):");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                // 2. Procesar la venta
                Console.WriteLine("Codigo Artículo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.CantidadVendida = int.Parse(Console.ReadLine());

              

                // 3. Lectura repetida 
                // Tienes que volver a pedir el cliente para saber si sigues o sales.
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Ingrese el código del Cliente (0 para salir):");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
            // Fin del programa
        }
    }
}
