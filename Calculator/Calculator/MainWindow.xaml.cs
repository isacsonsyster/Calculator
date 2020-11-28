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

namespace Calculator
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button knapp)
            {
                switch (knapp.Content)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case ",":
                    case "+": 
                    case "-":
                    case "x":
                    case "/":
                    
                        FieldForNumbers.Text += knapp.Content;
                        break;
                    case "=":
                   
                        CalculateNumbers();
                        break;

                    case "%":
                        procentage(); 
                        break;

                    case "AC":
                        FieldForNumbers.Text = String.Empty; //clear the field and reset the calculation
                        break;

                    default:
                        break;

                }
                         
               }
            }

        /* The method calculates the addition, subtraction, multiplication and divison, and then write the answer. 
         */
             private void CalculateNumbers()
              {
            var numArray = FieldForNumbers.Text.Split('+', '-', 'x', '/');

            var num1 = Convert.ToDouble(numArray[0]);
            var num2 = Convert.ToDouble(numArray[1]);

            if (FieldForNumbers.Text.Contains('+'))
            {
                var result = num1 + num2;
                FieldForNumbers.Text = result.ToString();
                
            }

            else if (FieldForNumbers.Text.Contains('-'))
            {
                var result = num1 - num2;
                FieldForNumbers.Text = result.ToString();
            }

            else if (FieldForNumbers.Text.Contains('x'))
            {
                var result = num1 * num2;
                FieldForNumbers.Text = result.ToString();
            }

            else if (FieldForNumbers.Text.Contains('/'))
            {
                var result = num1/num2;
                FieldForNumbers.Text = result.ToString();
            }

        }
        /* The method calculate 1 percentage of the number the player has written, and write the percentage out
         */
        private void procentage()
        {
            var percent = FieldForNumbers.Text.Split('%');
            var number = Convert.ToDouble(percent[0]);

            var result = number / 100;
            FieldForNumbers.Text = result.ToString();


        }
    }
    }

