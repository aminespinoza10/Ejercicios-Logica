using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace Proyecto_Euler.Ejercicios
{
    /// <summary>
    /// Interaction logic for Palindromos.xaml
    /// </summary>
    public partial class Palindromos : Window
    {
        public Palindromos()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            string receivedValue = txtAnswer.Text;
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            firstList = PopulateFirstList(receivedValue);
            secondList = PopulateSecondList(receivedValue);

            var a = firstList.SequenceEqual(secondList);

            if (a)
            {
                MessageBox.Show("Tienes un palíndromo!");
                txtAnswer.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Sigue intentando");
                txtAnswer.Text = string.Empty;
            }
        }

        private List<int> PopulateFirstList(string receivedString)
        {
            List<int> firstList = new List<int>();

            foreach (char item in txtAnswer.Text)
            {
                string newCharacter = item.ToString();
                firstList.Add(Convert.ToInt32(newCharacter));
            }

            firstList.Reverse();
            return firstList;
        }

        private List<int> PopulateSecondList(string receivedString)
        {
            List<int> secondList = new List<int>();

            foreach (char item in txtAnswer.Text)
            {
                string newCharacter = item.ToString();
                secondList.Add(Convert.ToInt32(newCharacter));
            }

            return secondList;
        }
    }
}
