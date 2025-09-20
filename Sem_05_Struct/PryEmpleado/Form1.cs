using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double comision = Convert.ToDouble(txtComision.Text);

            clsEmpleado Empleado1 = new clsEmpleado(salario, comision);

            double incremento = Convert.ToDouble(txtIncremento.Text);
            Empleado1.CambiarSalario(Empleado1, incremento);

            txtResultado.Text = Empleado1.ToString();
        }
    }
}
