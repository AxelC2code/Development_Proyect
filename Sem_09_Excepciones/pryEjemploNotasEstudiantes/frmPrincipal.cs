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
namespace pryEjemploNotasEstudiantes
{
    public partial class Form1 : Form
    {
        // Vector fijo para almacenar estudiantes
        private clsEstudiante[] estudiantes = new clsEstudiante[50];
        private int contadorEstudiantes = 0;
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // Inicializar columnas del DataGridView
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que no se exceda el límite del vector
                if (contadorEstudiantes >= 2)
                {
                    //throw new Exception("Límite de 50 estudiantes alcanzado.");
                    throw new InvalidOperationException("Límite de 2 estudiantes alcanzado.");
                }
                // Convertir entradas a números (puede fallar si no son numéricas)
                int id = int.Parse(txtID.Text);
                double nota = double.Parse(txtNota.Text);
                // Validar que la nota esté entre 0 y 20
                if (nota < 0 || nota > 20)
                {
                    throw new Exception("La nota debe estar entre 0 y 20.");
                }
                // Crear nuevo estudiante y agregar al vector
                clsEstudiante nuevoEstudiante = new clsEstudiante
                {
                    ID = id,
                    Nota = nota
                };
                estudiantes[contadorEstudiantes] = nuevoEstudiante;
                contadorEstudiantes++;
                // Actualizar el DataGridView con los datos del vector
                ActualizarDataGridView();
                // Mostrar resultado
                lblResultado.Text = "Resultado: Estudiante registrado con ID " + id + " y nota " + nota;
                MessageBox.Show("Registro exitoso.", "Éxito");
                //txtID.Clear();
                //txtNota.Clear();
                //MessageBox.Show("Campos limpiados. Listo para el siguiente registro.", "Finally Ejecutado");

            }
            catch (FormatException)
            {
                // Captura error si la entrada no es numérica
                lblResultado.Text = "Error: Debes ingresar valores numéricos válidos.";
                MessageBox.Show("Entrada no válida. Usa solo números.", "Error de Formato");
            }

            catch (InvalidOperationException ex)
            {
                // Captura el error de límite de estudiantes.
                lblResultado.Text = "Error de Límite: " + ex.Message;
                MessageBox.Show("Límite de estudiantes alcanzado: " + ex.Message, "Error de Capacidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                // Captura el error de rango de nota. Los datos en txtID y txtNota NO se borran.
                lblResultado.Text = "Error de Rango: " + ex.Message;
                MessageBox.Show("La nota está fuera del rango permitido: " + ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Captura si accidentalmente se excede el límite del array 'estudiantes' si no lo controlaste bien antes.
                lblResultado.Text = "Error interno: El índice del array fue excedido. " + ex.Message;
                MessageBox.Show("Error interno: " + ex.Message, "Error de Array", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception exa)
            {
                // Captura cualquier otra excepción (incluyendo la lanzada con 'throw')
                lblResultado.Text = "Error: " + exa.Message;
                MessageBox.Show("Ocurrió un error: " + exa.Message, "Error General");
            }

            finally
            {
                // Siempre se ejecuta para limpiar los campos
                txtID.Clear();
                txtNota.Clear();
                MessageBox.Show("Campos limpiados. Listo para el siguiente registro.", "Finally Ejecutado");
            }
        }
        // Método para llenar el DataGridView con los datos del vector
        private void ActualizarDataGridView()
        {
            dgvEstudiantes.Rows.Clear(); // Limpiar filas existentes
            for (int i = 0; i < contadorEstudiantes; i++)
            {
                // Agregar una fila por cada estudiante en el vector
                dgvEstudiantes.Rows.Add(estudiantes[i].ID, estudiantes[i].Nota);
            }
        }
        // Método para configurar las columnas del DataGridView
        private void ConfigurarDataGridView()
        {
            dgvEstudiantes.Columns.Add("ID", "ID Estudiante");
            dgvEstudiantes.Columns.Add("Nota", "Nota");
            dgvEstudiantes.ReadOnly = true; // Solo lectura
        }
    }
}