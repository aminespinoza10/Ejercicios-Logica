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
    }
}
