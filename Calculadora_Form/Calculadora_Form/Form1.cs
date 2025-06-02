using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Calculadora_Form
{
    public partial class Form1 : Form
    {
        // Variables para almacenar los valores y la operación
        private double primerNumero = 0;
        private string operacion = "";
        private bool nuevaOperacion = true; // Indica si se debe borrar la pantalla para un nuevo número

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0"; // Inicializa la pantalla en 0
        }

        // --- Eventos para los botones de números y punto decimal ---
        private void Numero_Click(object sender, EventArgs e)
        {
            // Castea el sender (el botón que disparó el evento) a un objeto Button
            Button boton = (Button)sender;

            // Si es una nueva operación o la pantalla muestra "0", reemplaza el contenido
            if (nuevaOperacion || txtDisplay.Text == "0")
            {
                txtDisplay.Text = boton.Text;
                nuevaOperacion = false;
            }
            else // Si no, agrega el número al final
            {
                // Evita múltiples puntos decimales
                if (boton.Text == "." && txtDisplay.Text.Contains("."))
                {
                    return;
                }
                txtDisplay.Text += boton.Text;
            }
        }

        private void Operacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            // Si ya hay un número en pantalla y no es una nueva operación
            if (!nuevaOperacion)
            {
                // Si ya había una operación pendiente, calcula el resultado antes de la nueva
                if (!string.IsNullOrEmpty(operacion))
                {
                    btnEquals_Click_1(sender, e); // Llama al evento de "=" para resolver la operación anterior
                }

                primerNumero = double.Parse(txtDisplay.Text); // Guarda el número actual
                operacion = boton.Text; // Guarda la nueva operación
                nuevaOperacion = true; // Indica que el siguiente número debe ser "nuevo"
            }
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operacion)) // Solo si hay una operación pendiente
            {
                double segundoNumero = double.Parse(txtDisplay.Text);
                double resultado = 0;

                switch (operacion)
                {
                    case "+":
                        resultado = primerNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primerNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primerNumero * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0) // Evita división por cero
                        {
                            resultado = primerNumero / segundoNumero;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnClear_Click_1(sender, e); // Limpia la calculadora
                            return;
                        }
                        break;
                }

                txtDisplay.Text = resultado.ToString(); // Muestra el resultado
                primerNumero = resultado; // El resultado se convierte en el primer número para futuras operaciones
                operacion = ""; // Limpia la operación
                nuevaOperacion = true; // El siguiente número debe ser "nuevo"
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            primerNumero = 0;
            operacion = "";
            nuevaOperacion = true;
        }
    }
}