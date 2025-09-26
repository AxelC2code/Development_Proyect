using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problemas_Debate_2
{
    public partial class Form1 : Form
    {
        private TextBox textBoxActivo;

        public Form1()
        {
            InitializeComponent();
        }
        // controla la entrada por teclado
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //si no es un dígito ni una tecla de control
            {
                e.Handled = true; //ignorar el carácter
            }
        }
        private void txtInput_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // controla la entrada por botones desde eventos
        private void Numero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBoxActivo != null)
            {
                textBoxActivo.Text += btn.Text;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (textBoxActivo != null && !textBoxActivo.Text.Contains("."))
            {
                textBoxActivo.Text += ".";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(txtInput_1.Text);
            //lista.SubItems.Add(txtInput.Text);

            lsvHistorial.Items.Add(lista);

            //item.SubItems.Add((Math.Sqrt(double.Parse(txtInput.Text))).ToString());
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int primerValor = int.Parse(txtInput_1.Text);
            int segundoValor = int.Parse(txtInput_2.Text);
            int resultado = primerValor + segundoValor;
            lblSign.Text = "+";
        }

    }
}
