using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio03
{
    class Cliente
    {
        public List<Producto> MisProductos = new List<Producto>();
        Producto z = new Producto("Nombre", "Marca", 0, 0);
        public bool CrearProducto(Producto producto)
        {
            MisProductos.Add(z);
            int contador = 0;
            foreach (Producto i in MisProductos)
            {
                if (i.Nombreprod == producto.Nombreprod && i.Marca == producto.Marca)
                {
                    contador += 1;

                }
                else
                {
                    contador = contador + 0;
                }
            }
            if (contador == 0)
            {
                MisProductos.Remove(z);
                Console.WriteLine("\nEl producto fue añadido con exito\n");
                MisProductos.Add(producto);
                return true;
            }
            else
            {
                MisProductos.Remove(z);
                Console.WriteLine("\nEl producto ya existe\n");
                return false;
            }
        }
        List<Producto> Compra = new List<Producto>();
        int SumaPrecios = 0;
       // List<Persona> PorRol = new List<Persona>();
        List<Boletas> Bole = new List<Boletas>();
        public void ComprarProductos(Producto compra)
        {

            foreach (Producto i in MisProductos)
            {

                if (i.Nombreprod == compra.Nombreprod)
                {
                    if (i.Marca == compra.Marca)
                    {
                        i.Stock -= compra.Stock;
                        if (i.Stock < 0)
                        {
                            Console.WriteLine("\nNo puede comprar esa cantidad de ese producto\n");
                            i.Stock += compra.Stock;
                        }
                        else
                        {
                            Compra.Add(compra);
                            SumaPrecios += (compra.Stock * i.Precio);
                            compra.Precio += (compra.Stock * i.Precio);
                            Console.WriteLine("\nEl producto ha sido agregado al carro\n");

                        }
                    }
                    // else
                    //{ Console.WriteLine("No existe esa marca de ese producto"); }

                }
                else if (i.Precio != compra.Precio)
                { }
                else if (i.Stock == compra.Stock || i.Stock != compra.Stock)
                { }
                else
                {

                    Console.WriteLine("\nEse producto no se encuentra disponible\n");
                }

            }


        }
        public void VerCarro()
        {
            foreach (Producto i in MisProductos)
            {
                Console.WriteLine(i.InformacionProducto());
            }
        }

        // int b = 0;
        public void VerCompra()
        {

            foreach (Producto i in Compra)
            {
                Console.WriteLine(i.InformacionProducto());
                
            }
            Console.WriteLine("\nLa suma total vendida hoy es de: $"+SumaPrecios);
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "en-CH"};

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("La hora registrada es la siguente:");
                Console.WriteLine("{0}: {1}", cultureName,
                                  localDate.ToString(culture));
            }

        }
    }
}
