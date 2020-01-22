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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long num1 = 0;

        long num2 = 0;

        string operation = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = (num1 * 10) + 1;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 4;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10);
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = 0;
            }
            else
            {
                num2 = 0;
            }

            txtDisplay.Text = "0";

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 / 10);
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 / 10);
                txtDisplay.Text = num2.ToString();
            }
        }
    }
}
