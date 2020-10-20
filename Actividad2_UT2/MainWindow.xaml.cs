using System;
using System.Linq;
using System.Windows;

namespace Actividad2_UT2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void comprobarValoresValidos()
        {
            float numeroValido;
            string[] operadoresValidos = new string[4] {"+","-","*","/"};
            bool operando1Valido = float.TryParse(operando1TextBox.Text, out numeroValido);
            bool operando2Valido = float.TryParse(operando2TextBox.Text, out numeroValido);
            bool operadorValido = operadoresValidos.Contains(operadorTextBox.Text);
            if (operando1Valido && operando2Valido && operadorValido) calcularButton.IsEnabled = true;
            else calcularButton.IsEnabled = false;
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            switch (operadorTextBox.Text)
            {
                case "+":
                    resultadoTextBox.Text = Convert.ToString(sumar());
                    break;
                case "-":
                    resultadoTextBox.Text = Convert.ToString(restar());
                    break;
                case "/":
                    resultadoTextBox.Text = Convert.ToString(dividir());
                    break;
                case "*":
                    resultadoTextBox.Text = Convert.ToString(multiplicar());
                    break;
            }
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
            calcularButton.IsEnabled = false;
        }

        private float sumar()
        {
            return float.Parse(operando1TextBox.Text) + float.Parse(operando2TextBox.Text);
        }
        private float restar()
        {
            return float.Parse(operando1TextBox.Text) - float.Parse(operando2TextBox.Text);
        }
        private float dividir()
        {
            return float.Parse(operando1TextBox.Text) / float.Parse(operando2TextBox.Text);
        }
        private float multiplicar()
        {
            return float.Parse(operando1TextBox.Text) * float.Parse(operando2TextBox.Text);
        }

        private void operando1TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            comprobarValoresValidos();
        }

        private void operando2TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            comprobarValoresValidos();
        }

        private void operadorTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            comprobarValoresValidos();
        }
    }
}
