using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente listado = new Cliente();
            Cliente lista = new Cliente();
            Empleado todas = new Empleado();
            Console.WriteLine("Hola, Bienvenido al Supermercado\n");
            while (true)
            {
                Console.WriteLine("\nSi desea crear los productos del supermercado presione a\n");
                Console.WriteLine("Si desea crear a las personas del supermercado presione b\n");
                Console.WriteLine("Si desea ver el listado de productos presione c\n");
                Console.WriteLine("Si desea ver el listado de las personas presione d\n");
                Console.WriteLine("Si desea realizar una compra presione e\n");
                Console.WriteLine("Si desea relacionar a los empleados del supermercado presione f\n");
                Console.WriteLine("Si desea ver las compras echas en este supermercado presione g\n");
                Console.WriteLine("Si desea terminar presione h\n");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "a")
                {
                    Console.WriteLine("\nDiga el nombre del producto\n ");
                    string a = Console.ReadLine();
                    Console.WriteLine("\nDiga la marca del producto\n ");
                    string b = Console.ReadLine();
                    Console.WriteLine("\nDiga el precio del producto\n ");
                    string C = Console.ReadLine();
                    int c = Convert.ToInt32(C);
                    Console.WriteLine("\nDiga el stock del producto\n ");
                    string D = Console.ReadLine();
                    int d = Convert.ToInt32(D);
                    Producto p1 = new Producto(a, b, c, d);
                    listado.CrearProducto(p1);
                }

                else if (respuesta.ToLower() == "b")
                {
                    Console.WriteLine("\nDiga el nombre de la persona\n ");
                    string aa = Console.ReadLine();
                    Console.WriteLine("\nDiga el apellido de la persona\n ");
                    string bb = Console.ReadLine();
                    Console.WriteLine("\nDiga el rut de la persona (sin puntos ni guion)\n ");
                    string CC = Console.ReadLine();
                    int cc = Convert.ToInt32(CC);
                    Console.WriteLine("\nDiga la edad de la persona\n ");
                    string DD = Console.ReadLine().ToLower();
                    int dd = Convert.ToInt32(DD);
                    Console.WriteLine("\nDiga la fecha de nacimiento de la persona (03051999)\n ");
                    string EE = Console.ReadLine();
                    int ee = Convert.ToInt32(EE);
                    Console.WriteLine("\nDiga la nacionalidad de la persona\n ");
                    string ff = Console.ReadLine();
                    Console.WriteLine("\nDiga el genero de la persona\n ");
                    string gg = Console.ReadLine().ToLower();
                    Console.WriteLine("\nDiga el rol de la persona (cliente,jefe,cajero(a),auxiliar,supervisor(a),reponedor(a),gerente,guardias\n ");
                    string hh = Console.ReadLine().ToLower();
                    Console.WriteLine("\nDiga el sueldo de la persona (si es cliente ponga 0)\n ");
                    string II = Console.ReadLine();
                    int ii = Convert.ToInt32(II);
                    Persona pp1 = new Persona(aa, bb, cc, dd, ee, ff, gg, hh, ii);
                    todas.CrearPersonas(pp1);
                }

                else if (respuesta.ToLower() == "c")
                {
                    Console.WriteLine("\nEl listado de productos es el siguiente: \n");
                    listado.VerCarro();
                }

                else if (respuesta.ToLower() == "d")
                {
                    Console.WriteLine("\nEl listado de las personas es el siguiente: \n");
                    todas.VerPersonas();
                }

                else if (respuesta.ToLower() == "e")
                {
                    // Console.WriteLine("\nIngrese el nombre del cliente que desea comprar\n");
                    // string nom = Console.ReadLine();
                    // Persona pp = new Persona(nom);
                    while (true)
                    {
                        Console.WriteLine("\nIngrese el nombre del producto que desea comprar\n");
                        string A = Console.ReadLine();
                        Console.WriteLine("\nIngrese la marca del producto que desea comprar\n");
                        string B = Console.ReadLine();
                        Console.WriteLine("\nIngrese la cantidad de producto que desea comprar\n");
                        string C = Console.ReadLine();
                        int CC = Convert.ToInt32(C);
                        Producto p = new Producto(A, B, 0, CC);
                        listado.ComprarProductos(p);
                        Console.WriteLine("Desea seguir comprando?\n");
                        string opcion = Console.ReadLine();
                        if (opcion.ToLower() == "no") { break; }
                        else { }
                    }
                }
                else if (respuesta.ToLower() == "f")
                {
                    todas.Interaccion();
                }
                else if (respuesta.ToLower() == "g")
                {
                    Console.WriteLine("\nLa lista de las compras de hoy es la siguiente: \n");
                    listado.VerCompra();
                }
                else if (respuesta.ToLower() == "h")
                {
                    Console.WriteLine("\nEl programa ha finalizado, que tenga un buen día\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nEse comando no existe\n");
                }
            }
            Console.ReadLine();
        }
    }
}
