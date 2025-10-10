using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryDemoOrdenamiento
{
    public partial class frmPrincipal : Form
    {
        private Producto[] productosInvetario;      //arreglo de productos del inventario
        private const int MAX_PRODUCTOS = 10;       //cantidad maxima de productos en el inventario
        public frmPrincipal()
        {
            InitializeComponent();
            InicializarDatosDelInventario();


        }

        private void InicializarDatosDelInventario()
        {
            productosInvetario = new Producto[MAX_PRODUCTOS];   
            productosInvetario[0] = new Producto(1, "Teclado", 2500);
            productosInvetario[1] = new Producto(2, "Mouse", 1500);
            productosInvetario[2] = new Producto(3, "Monitor", 12500);
            productosInvetario[3] = new Producto(4, "Impresora", 8500);
            productosInvetario[4] = new Producto(5, "Parlantes", 3000);
            productosInvetario[5] = new Producto(6, "Webcam", 4000);
            productosInvetario[6] = new Producto(7, "Auriculares", 2000);
            productosInvetario[7] = new Producto(8, "Microfono", 3500);
            productosInvetario[8] = new Producto(9, "Router", 6000);
            productosInvetario[9] = new Producto(10, "Disco Externo", 7500);
        }

        public struct Producto
        {
            public int ID;
            public string Name;
            public double Price;

            public Producto(int id, string nombre, double precio)
            {
                ID = id;
                Name = nombre;
                Price = precio;
            }
        }

        private void CargarProductosEnDGV()
        {
            dgvProductos.Rows.Clear();

        }
    }
}
