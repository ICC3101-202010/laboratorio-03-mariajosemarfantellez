using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio03
{
    class Boletas
    {
        private string nombres;
        private string marcas;
        private int cantidad;
        private int sumatotal;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Marcas { get => marcas; set => marcas = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int SumaTotal { get => sumatotal; set => sumatotal = value; }

        public Boletas(string Nombres, string Marcas, int Cantidad, int SumaTotal)
        {
            this.Nombres = Nombres;
            this.Marcas = Marcas;
            this.Cantidad = Cantidad;
            this.SumaTotal = SumaTotal;
        }
    }
}
