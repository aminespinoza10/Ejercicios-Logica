using System.Windows;

namespace Proyecto_Euler.Ejercicios
{
    /// <summary>
    /// Interaction logic for Factoriales.xaml
    /// </summary>
    public partial class Factoriales : Window
    {
        public Factoriales()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            BuscarFactoriales(600851475143);
        }

        private void BuscarFactoriales(long evaluatedNumber)
        {
            long k = 2;
            while (k * k <= evaluatedNumber)
            {
                if (evaluatedNumber % k == 0)
                {
                    evaluatedNumber /= k;
                }
                else
                {
                    ++k;
                }
            }

            txtAnswer.Text = evaluatedNumber.ToString();
        }
    }
}
