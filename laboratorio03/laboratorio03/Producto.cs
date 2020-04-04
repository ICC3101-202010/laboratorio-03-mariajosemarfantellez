using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio03
{
    class Product
    {
        private string nombreprod;
        private string marca;
        private int precio;
        private int stock;
        public string Nombreprod { get => nombreprod; set => nombreprod = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public Product(string Nombreprod, string Marca, int Precio, int Stock)
        {
            this.Nombreprod = Nombreprod;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Stock = Stock;
        }



        List<Cliente> AgregarAlCarro = new List<Cliente>();


        public string InformacionProducto()
        {
            return ("Nombre Producto: " + Nombreprod + ", " + "Marca Producto: " + Marca + ", " + "Precio Producto: $" + Precio + ", " + "Stock Producto: " + Stock);

        }
    }
}
