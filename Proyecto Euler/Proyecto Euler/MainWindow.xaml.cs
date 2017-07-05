using Proyecto_Euler.Ejercicios;
using System.Windows;

namespace Proyecto_Euler
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMultiplos_Click(object sender, RoutedEventArgs e)
        {
            Multiplos newMultiplos = new Multiplos();
            newMultiplos.Show();
        }

        private void btnFactoriales_Click(object sender, RoutedEventArgs e)
        {
            Factoriales newFactoriales = new Factoriales();
            newFactoriales.Show();
        }

        private void btnTernasPitagoras_Click(object sender, RoutedEventArgs e)
        {
            PitagorasTriple newPitagoras = new PitagorasTriple();
            newPitagoras.Show();
        }

        private void btnPalindromos_Click(object sender, RoutedEventArgs e)
        {
            Palindromos newPalindromos = new Palindromos();
            newPalindromos.Show();
        }

        private void btnPrimos_Click(object sender, RoutedEventArgs e)
        {
            Primos newPrimos = new Primos();
            newPrimos.Show();
        }
    }
}
