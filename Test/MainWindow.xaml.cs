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

namespace Test
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

        //Buttons
        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            Main_Block.Text += (sender as Button).Content;
        }

        //Operations

        double first_number = 0, second_number = 0, result = 0;
        char znak = '+';

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            Main_Block.Text = "";
        }

        private void Btn_addition_Click(object sender, RoutedEventArgs e)
        {
            first_number = Convert.ToDouble(Main_Block.Text);
            Main_Block.Text = "";
        }
        private void Btn_equaly_Click(object sender, RoutedEventArgs e)
        {
            second_number = Convert.ToDouble(Main_Block.Text);
            
            switch (znak)
            {
                case '+':
                    result = first_number + second_number;
                    break;
                case '-':
                    result = first_number - second_number;
                    break;
                case '*':
                    result = first_number * second_number;
                    break;
                case '/':
                    result = first_number / second_number;
                    break;
                case '^':
                    for (int i = 0; i < second_number; i++) 
                    {
                        result *= first_number;
                    }
                    break;
            }
            Main_Block.Text = Convert.ToString(result);
        }
    }
}
