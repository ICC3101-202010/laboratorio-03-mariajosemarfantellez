using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio03
{
    class Persona
    {
        private int rut;
        private string nombre;
        private string apellido;
        private int fechanacimiento;
        private string nacionalidad;
        private string genero;
        private int edad;
        private string rol;
        private int sueldo;
        private string horario;

        public int RUT { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int FechaNacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        public string Horario { get => horario; set => horario = value; }

        public Persona(string Nombre, string Apellido, int RUT, int Edad, int FechaNacimiento, string Nacionalidad, string Genero, string Rol, int Sueldo, string Horario)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.RUT = RUT;
            this.Edad = Edad;
            this.FechaNacimiento = FechaNacimiento;
            this.Nacionalidad = Nacionalidad;
            this.Genero = Genero;
            this.Rol = Rol;
            this.Sueldo = Sueldo;
            this.Horario = Horario;
        }
        public string InformacionPersonas()
        {
            return ("Nombre: " + Nombre + ", " + "Apellido: " + Apellido + ", " + "Rut: " + RUT + ", " + "Edad: " + Edad + ", " + "Fecha de Nacimiento: " + FechaNacimiento + ", " + "Nacionalidad: " + Nacionalidad + ", " + "Genero: " + Genero + ", " + "Rol: " + Rol + ", " + "Sueldo: $" + Sueldo + ", " + "Horario de trabajo: "+Horario );
        }
    }
}
