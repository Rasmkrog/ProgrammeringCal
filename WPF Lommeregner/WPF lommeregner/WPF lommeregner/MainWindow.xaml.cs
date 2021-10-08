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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_lommeregner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber = double.Parse(Tal1.Text);
            double secondNumber = double.Parse(Tal2.Text);

            double resultat = firstNumber + secondNumber;
            Resultat.Text = Convert.ToString(resultat);


        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber = double.Parse(Tal1.Text);
            double secondNumber = double.Parse(Tal2.Text);

            double resultat = firstNumber - secondNumber;
            Resultat.Text = Convert.ToString(resultat);

        }

        private void Gange_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber = double.Parse(Tal1.Text);
            double secondNumber = double.Parse(Tal2.Text);

            double resultat = firstNumber * secondNumber;
            Resultat.Text = Convert.ToString(resultat);

        }

        private void Divider_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber = double.Parse(Tal1.Text);
            double secondNumber = double.Parse(Tal2.Text);

            if (secondNumber != 0)
            {
                double resultat = firstNumber / secondNumber;
                Resultat.Text = Convert.ToString(resultat);
            }
            else
            {
                Resultat.Text = "Error";
            }
        }
    }
}

