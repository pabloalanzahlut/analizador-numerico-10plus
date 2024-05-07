using System;  // Librería necesaria para usar la clase Console y otras utilidades básicas
using System.Windows.Forms;  // Librería necesaria para trabajar con formularios de Windows

namespace WindowsFormsApp1
{
    public partial class Form1 : Form  // Declaración de la clase Form1 que hereda de Form
    {
        public Form1()  // Constructor de la clase Form1
        {
            InitializeComponent();  // Método generado automáticamente para inicializar componentes
        }

        private void button1_Click(object sender, EventArgs e)  // Evento Click del botón button1
        {
            // Obtener el texto ingresado por el usuario en el TextBox
            string entrada = textBox1.Text;  // Acceder al texto del cuadro de texto textBox1

            try
            {
                double n = double.Parse(entrada);  // Convertir la entrada de string a double
                MessageBox.Show("Número ingresado: " + n);  // Mostrar un mensaje con el número ingresado

                if (n > 10)  // Verificar si el número ingresado es mayor que 10
                    MessageBox.Show("Es mayor a 10");  // Mostrar un mensaje si es mayor que 10
                else
                    MessageBox.Show("No es mayor a 10");  // Mostrar un mensaje si no es mayor que 10
            }
            catch (FormatException)
            {
                MessageBox.Show("La entrada no es un número válido.");  // Manejar una excepción si la entrada no es válida
            }
        }
    }
}
