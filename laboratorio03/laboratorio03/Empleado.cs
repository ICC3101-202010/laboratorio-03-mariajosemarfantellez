using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio03
{
    class Empleado : Cliente
    {
        public List<Persona> MisPersonas = new List<Persona> ();
        Persona k = new Persona("Nombre", "Apellido", 0, 0, 0, "Nacionalidad", "Genero", "Rol", 0, "Horario");

        List<string> lista = new List<string>();
        List<string> cajeros = new List<string>();
        public bool CrearPersonas(Persona persona)
        {
            MisPersonas.Add(k);
            int contador = 0;
            foreach (Persona i in MisPersonas)
            {
                if (i.Nombre == persona.Nombre && i.Apellido == persona.Apellido && i.RUT == persona.RUT)
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
                MisPersonas.Remove(k);
                Console.WriteLine("\nLa Persona fue añadida con exito\n");
                MisPersonas.Add(persona);
                return true;
            }
            else
            {
                MisPersonas.Remove(k);
                Console.WriteLine("\nEsa persona ya está registrada\n");
                return false;
            }
        }
        public void VerPersonas()
        {
            foreach (Persona i in MisPersonas)
            {
                Console.WriteLine(i.InformacionPersonas());
            }
        }
        List<Persona> RolSinCliente = new List<Persona>();
        string Alegato;
        public void Interaccion()
        {
            Console.WriteLine("Diga el rut de quien desea controlar (de algún jefe o cliente)\n");
            string rutt = Console.ReadLine();
            int Rutt = Convert.ToInt32(rutt);
            foreach (Persona i in MisPersonas)
            {
                if (i.RUT == Rutt)
                {
                    if (i.Rol.ToLower() == "cliente")
                    {
                        Console.WriteLine("Desea alegar sobre algo?\n");
                        string alegato = Console.ReadLine();
                        if (alegato.ToLower() == "si")
                        {
                            Console.WriteLine("Diga su alegato\n");
                            Alegato = Console.ReadLine();
                            Console.WriteLine("\nSu alegato será analizado, muchas gracias\n");
                        }
                        else { }
                        Console.WriteLine("Desea preguntar por algún producto?\n");
                        string por = Console.ReadLine();
                        if (por.ToLower() == "si")
                        {
                            Console.WriteLine("Diga el nombre del producto que busca\n");
                            string n = Console.ReadLine();
                            foreach (Product ko in MisProductos)
                            {
                                Console.WriteLine("HH");
                                if (ko.Nombreprod.ToLower() == n.ToLower())
                                {
                                    Console.WriteLine(ko.InformacionProducto());
                                }
                                else { Console.WriteLine("Ese producto no se encuentra disponible\n"); }
                            }
                        }
                        else { }
                    }
                    else
                    {
                        if (i.Rol.ToLower() == "jefe")
                        {
                            Console.WriteLine("Desea modificar el sueldo de alguien?\n");
                            string opp = Console.ReadLine();
                            if (opp.ToLower() == "si")
                            {
                                Console.WriteLine("Cual es el RUT de quien desea modificar el sueldo?\n");
                                string rt = Console.ReadLine();
                                int RT = Convert.ToInt32(rt);

                                foreach (Persona k in MisPersonas)
                                {
                                    if (k.RUT == RT)
                                    {
                                        Console.WriteLine("Cual es el nuevo sueldo?\n");
                                        string nuevosueldo = Console.ReadLine();
                                        int NuevoSueldo = Convert.ToInt32(nuevosueldo);
                                        k.Sueldo = NuevoSueldo;
                                    }
                                    else { }
                                }
                            }
                            else { }
                            Console.WriteLine("Desea cambiar algun puesto de trabajo?\n");
                            string op = Console.ReadLine();
                            if (op.ToLower() == "si")
                            {
                                Console.WriteLine("Diga el rut de quien desea cambiar el cargo\n");
                                string mu = Console.ReadLine();
                                int Mu = Convert.ToInt32(mu);
                                foreach (Persona a in MisPersonas)
                                {
                                    if (a.RUT == Mu)
                                    {
                                        Console.WriteLine("Cual es el nuevo cargo?\n");
                                        string cargo = Console.ReadLine();
                                        a.Rol = cargo;
                                    }
                                    else { }
                                }
                            }
                            else { }
                            Console.WriteLine("\nDesea cambiar algún horario de trabajo?\n");
                            string po = Console.ReadLine();
                            if (po.ToLower() == "si")
                            {
                                Console.WriteLine("\nDiga el rut de quien desea cambiar el horario\n");
                                string hor = Console.ReadLine();
                                int Hor = Convert.ToInt32(hor);
                                foreach (Persona o in MisPersonas)
                                {
                                    if (o.RUT == Hor)
                                    {
                                        Console.WriteLine("\nDiga el nuevo horario\n");
                                        string hora = Console.ReadLine();
                                        o.Horario = hora;
                                    }
                                    else { }
                                }
                            }
                            else { }
                        }
                        else { }
                    }
                }
                else { Console.WriteLine("Esa persona no existe"); }
            }
        }
        public void NomBol()
        {
            int es = 0;
        foreach (Persona p in MisPersonas)
            {
                if (p.Rol.ToLower() == "cliente")
                {
                    lista.Add(p.Nombre);
                    es++;
                }
                else { }
            }
            Random rnd = new Random();
            int num = rnd.Next(0, es);
            Console.WriteLine(lista[num]);
        }
        public void NomPol()
        {
            int esa = 0;
            foreach (Persona q in MisPersonas)
            {
                if (q.Rol.ToLower() == "cajera" || q.Rol.ToLower() == "cajero")
                {
                    cajeros.Add(q.Nombre);
                }
                else { }
            }
            Random rnds = new Random();
            int nume = rnds.Next(0, esa);
            Console.WriteLine(cajeros[nume]);
        }

    }
}
