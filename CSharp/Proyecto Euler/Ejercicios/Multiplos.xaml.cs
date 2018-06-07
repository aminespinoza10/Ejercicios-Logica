using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace Proyecto_Euler.Ejercicios
{
    /// <summary>
    /// Interaction logic for Multiplos.xaml
    /// </summary>
    public partial class Multiplos : Window
    {
        List<int> multiples = new List<int>();

        public Multiplos()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            IsNumberDivisble();
            txtAnswer.Text = GetFinalSum();
        }

        private void IsNumberDivisble()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    multiples.Add(i);
                }
                if (i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }
        }

        private string GetFinalSum()
        {
            List<int> finalCleanList = multiples.Distinct().ToList();
            int finalNumber = 0;

            foreach (int item in finalCleanList)
            {
                finalNumber += item;
            }

            return finalNumber.ToString();
        }
    }
}
