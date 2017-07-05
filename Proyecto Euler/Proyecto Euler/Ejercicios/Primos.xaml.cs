using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_Euler.Ejercicios
{
    public partial class Primos : Window
    {
        List<int> primesList = new List<int>();
        public Primos()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            GetPrimes();
        }

        private void GetPrimes()
        {
            for (int i = 1; i < 2000000; i++)
            {
                if (isPrime(i))
                {
                    primesList.Add(i);
                }
            }
            GetSumOfPrimes();
        }

        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            //si un primo tiene una raiz cuadrada no es primo
            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private void GetSumOfPrimes()
        {
            int finalSum = 0;

            foreach (int item in primesList)
            {
                finalSum += item;
            }

            txtAnswer.Text = finalSum.ToString();
        }
    }
}
