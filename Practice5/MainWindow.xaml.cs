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
using Triad;

namespace Practice5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {/*Triads.Compare(firstTriad, secondTriad);*/
        Triads firstTriad = new Triads();
        Triads secondTriad = new Triads();
        public MainWindow()
        {
            InitializeComponent();
            firstTriadBox.Text = firstTriad.First.ToString() + " " + firstTriad.Second.ToString() + " " + firstTriad.Third.ToString();
            secondTriadBox.Text = secondTriad.First.ToString() + " " + secondTriad.Second.ToString() + " " + secondTriad.Third.ToString();

        }

        private void FirstTriadIncrease(object sender, RoutedEventArgs e)
        {
            firstTriad.IncreaseTriadValuesTo10();
            firstTriadBox.Text = firstTriad.First.ToString() + " " + firstTriad.Second.ToString() + " " + firstTriad.Third.ToString();
        }

        private void SecondTriadIncrease(object sender, RoutedEventArgs e)
        {
            secondTriad.IncreaseTriadValuesTo10();
            secondTriadBox.Text = secondTriad.First.ToString() + " " + secondTriad.Second.ToString() + " " + secondTriad.Third.ToString();
        }

        private void CompareButton(object sender, RoutedEventArgs e)
        {
            if (firstTriad > secondTriad) MessageBox.Show("Значения первой триады больше значению второй");
            else MessageBox.Show("Некоторые значения первой триады меньше значений второй триады");
        }
    }
}
