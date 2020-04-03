using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio03
{
    class Cliente
    {
        protected List<Producto> MisProductos = new List<Producto>();
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

            // foreach (Persona l in MisPersonas)
            //{
            //  if (l.Rol.ToLower() == "cliente")
            // {
            //   Random rnd = new Random();
            //  PorRol.Add(MisPersonas[rnd.Next()]);
            // Console.WriteLine(PorRol);
            // }
            // else if (l.Rol.ToLower() == "cajero" || l.Rol == "cajera")
            // {
            //    //b = random nombre de la cajera o cajero
            // }
            // }

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
            //foreach (Persona j in PorRol)
            //{
            //  Console.WriteLine("Esta es la compra de ", PorRol[b]);
            //b++;
            foreach (Producto i in Compra)
            {
                Console.WriteLine(i.InformacionProducto());

            }
            Console.WriteLine("\nLa suma total vendida hoy es de $"+SumaPrecios);
            //Console.WriteLine("Lo atendio el cajero b");
            //}
        }
    }
}
