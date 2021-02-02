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

namespace SumByVal
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            int number1 = Convert.ToInt32(number1TextBox.Text);
            int number2 = Convert.ToInt32(number2TextBox.Text);

            int sum = SumByValue(number1, number2);

            resultTextBlock.Text = Convert.ToString(sum);
        }

        private int SumByValue(int g1, int g2)
        {
            int result = g1 + g2;
            return result;
        }
    }
}
