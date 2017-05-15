using System;
using System.Windows;

namespace Proyecto_Euler.Ejercicios
{
    /// <summary>
    /// Interaction logic for PitagorasTriple.xaml
    /// </summary>
    public partial class PitagorasTriple : Window
    {
        public PitagorasTriple()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            EvaluateExpression();
        }

        private void EvaluateExpression()
        {
            const int desiredNumber = 1000;
            int a;

            for (a = 1; a <= desiredNumber / 3; a++)
            {
                int b;
                for (b = a + 1; b <= desiredNumber / 2; b++)
                {
                    int c = desiredNumber - a - b;
                    if (a * a + b * b == c * c)
                    {
                        txtAnswer.Text = String.Format("{0}, {1}, {2}", a, b, c);
                    }
                }
            }
        }
    }
}
