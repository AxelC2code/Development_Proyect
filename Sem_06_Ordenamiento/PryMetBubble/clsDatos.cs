using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryMetBubble
{
    internal class clsDatos
    {
        public int Codigo { get; set; }
        public int Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

        public clsDatos(int codigo, int nombre, int precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

    }
}
