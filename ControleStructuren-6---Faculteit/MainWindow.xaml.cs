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

namespace ControleStructuren_6___Faculteit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int number;
            bool isSucceeded = int.TryParse(numberTextBox.Text, out number);
            if (!isSucceeded)
            {
                return;
            }

            long faculty = 1;
            for (int i = 2; i <= number; i++)
            {
                faculty *= i;
            }
            /*
            for (int i = number; i >= 2; i--)
            {
                faculty *= i;
            }
            */

            resultTextBox.Text = faculty.ToString(); // resultTextBox.Text = Convert.ToString(faculty);
            numberTextBox.Focus();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Text = string.Empty;
            resultTextBox.Text = string.Empty;
            numberTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
