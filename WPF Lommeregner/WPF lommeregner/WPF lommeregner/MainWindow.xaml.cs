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
using System.Windows.Diagnostics;

namespace WPF_lommeregner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string Text;
        Calulator Cal = new Calulator();
        // Calcutor Actions
        private void ButtonNubmer1_Click(object sender, RoutedEventArgs e) // OFF Button
        {
            string ExitMessage = "Do you want to close this window?";
            MessageBoxResult MessageBoxAnswer = MessageBox.Show(ExitMessage, "My App", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            switch (MessageBoxAnswer)
            {
                case MessageBoxResult.Yes:
                    System.Environment.Exit(0);
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void ButtonNubmer26_Click(object sender, RoutedEventArgs e) // AC
        {
            OutputLabel.Content = Cal.Clear();
        }

        private void ButtonNubmer21_Click(object sender, RoutedEventArgs e) // C
        {
            OutputLabel.Content = Cal.RemoveCharacter();
        }

        private void ButtonNubmer3_Click(object sender, RoutedEventArgs e) // Pause
        {

        }

        // Numbers  -----------------------------------------------------------------------------------------
        private void ButtonNubmer27_Click(object sender, RoutedEventArgs e) // 0
        {
            OutputLabel.Content = Cal.Add("0");
        }

        private void ButtonNubmer22_Click(object sender, RoutedEventArgs e) // 1
        {
            OutputLabel.Content = Cal.Add("1");
        }

        private void ButtonNubmer23_Click(object sender, RoutedEventArgs e) // 2
        {
            OutputLabel.Content = Cal.Add("2");
        }

        private void ButtonNubmer24_Click(object sender, RoutedEventArgs e) // 3
        {
            OutputLabel.Content = Cal.Add("3");
        }

        private void ButtonNubmer17_Click(object sender, RoutedEventArgs e) // 4
        {
            OutputLabel.Content = Cal.Add("4");
        }

        private void ButtonNubmer18_Click(object sender, RoutedEventArgs e) // 5
        {
            OutputLabel.Content = Cal.Add("5");
        }

        private void ButtonNubmer19_Click(object sender, RoutedEventArgs e) // 6
        {
            OutputLabel.Content = Cal.Add("6");
        }

        private void ButtonNubmer12_Click(object sender, RoutedEventArgs e) // 7
        {
            OutputLabel.Content = Cal.Add("7");
        }

        private void ButtonNubmer13_Click(object sender, RoutedEventArgs e) // 8
        {
            OutputLabel.Content = Cal.Add("8");
        }

        private void ButtonNubmer14_Click(object sender, RoutedEventArgs e) // 9
        {
            OutputLabel.Content = Cal.Add("9");
        }



        // Operators  ------------------------------------------------------------------------- 
        private void ButtonNubmer2_Click(object sender, RoutedEventArgs e) // KvadratRod
        {

        }

        private void ButtonNubmer9_Click(object sender, RoutedEventArgs e) // %
        {
            OutputLabel.Content = Cal.Add("%");
        }

        private void ButtonNubmer10_Click(object sender, RoutedEventArgs e) // /
        {
            OutputLabel.Content = Cal.Add("/");
        }

        private void ButtonNubmer15_Click(object sender, RoutedEventArgs e) // X
        {

        }

        private void ButtonNubmer16_Click(object sender, RoutedEventArgs e) // +/-
        {

        }

        private void ButtonNubmer20_Click(object sender, RoutedEventArgs e) // -
        {

        }

        private void ButtonNubmer25_Click(object sender, RoutedEventArgs e) // +
        {

        }

        private void ButtonNubmer28_Click(object sender, RoutedEventArgs e) // .
        {

        }

        private void ButtonNubmer29_Click(object sender, RoutedEventArgs e) // =
        {
            OutputLabel.Content = Cal.CalculatEqution();
        }

        // Random ----------------------------------------------------------------------
        private void ButtonNubmer11_Click(object sender, RoutedEventArgs e) // M/EX
        {

        }
        private void ButtonNubmer4_Click(object sender, RoutedEventArgs e) // Tax-
        {

        }

        private void ButtonNubmer5_Click(object sender, RoutedEventArgs e) // tax +
        {

        }

        private void ButtonNubmer6_Click(object sender, RoutedEventArgs e) // MRC
        {

        }

        private void ButtonNubmer7_Click(object sender, RoutedEventArgs e) // M-
        {

        }

        private void ButtonNubmer8_Click(object sender, RoutedEventArgs e) // M+
        {

        }

    }
    public class Calulator
    {
        private string EqutionIndex;
        private bool isNumeric;
        private int n;
        public string Add(string Text)
        {
            isNumeric = int.TryParse(Text, out n);
            if (isNumeric == true)
            {
                EqutionIndex += Text;
            }
            return EqutionIndex;
        }
        public string Clear()
        {
            return EqutionIndex = "";
        }
        
        public string RemoveCharacter()
        {
            return EqutionIndex = EqutionIndex.Remove(EqutionIndex.Length - 1); 
        }

        public string CalculatEqution()
        {
            return EqutionIndex;
        }
        
    } 
}

