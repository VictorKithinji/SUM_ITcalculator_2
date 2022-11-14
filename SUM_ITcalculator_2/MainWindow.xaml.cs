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

namespace SUM_ITcalculator_2
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
            if(previewOperationsPlane.Text == "Preview") { previewOperationsPlane.Clear(); }
            
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "1";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "1";
            }
            else
            {
                InputPlane.Text = "1";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "1";
            }
            
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (previewOperationsPlane.Text == "Preview") { previewOperationsPlane.Clear(); }

            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "2";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "2";
            }
            else
            {
                InputPlane.Text = "2";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "2";
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {if (previewOperationsPlane.Text == "Preview")
            {
                previewOperationsPlane.Clear();
            }
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "3";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "3";
            }
            else
            {
                InputPlane.Text = "3";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "3";
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {if (previewOperationsPlane.Text == "Preview")
            {
                previewOperationsPlane.Clear();
            }
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "4";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "4";
            }
            else
            {
                InputPlane.Text = "4";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "4";
            }
        }


        private void Btn5_Click(object sender, RoutedEventArgs e)
        {if (previewOperationsPlane.Text == "Preview")
            {
                previewOperationsPlane.Clear();
            }
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "5";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "5";
            }
            else
            {
                InputPlane.Text = "5";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "5";
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {if (previewOperationsPlane.Text == "Preview")
            {
                previewOperationsPlane.Clear();
            }
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "6";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "6";
            }
            else
            {
                InputPlane.Text = "6";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "6";
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {if (previewOperationsPlane.Text == "Preview")
            {
                previewOperationsPlane.Clear();
            }
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "7";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "7";
            }
            else
            {
                InputPlane.Text = "7";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "7";
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {if (previewOperationsPlane.Text == "Preview")
            {
                previewOperationsPlane.Clear();
            }
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "8";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "8";
            }
            else
            {
                InputPlane.Text = "8";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "8";
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {if (previewOperationsPlane.Text == "Preview")
            {
                previewOperationsPlane.Clear();
            }
            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "9";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "9";
            }
            else
            {
                InputPlane.Text = "9";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "9";
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (previewOperationsPlane.Text == "Preview") { previewOperationsPlane.Clear(); }

            if (InputPlane.Text != "0")
            {
                InputPlane.Text += "0";
                previewOperationsPlane.Text = previewOperationsPlane.Text += "0";
            }
            else
            {
                InputPlane.Text = "0";
            }
        }

        private void DPbtn_Click(object sender, RoutedEventArgs e)
        {
            if (previewOperationsPlane.Text == "Preview") 
            { 
                previewOperationsPlane.Clear();
                if(InputPlane.Text == "0") { previewOperationsPlane.Text = "0"; }
            }
            if (InputPlane.Text.Contains("."))
            {
                ResponsePlane.Text = "Syntax Error";
            }
            else
            {
                InputPlane.Text += ".";
                previewOperationsPlane.Text = previewOperationsPlane.Text += ".";
            }
        }

        private void ACbtn_Click(object sender, RoutedEventArgs e)
        {
            ResponsePlane.Text="0";
            InputPlane.Text="0";
            previewOperationsPlane.Text="Preview";

        }
    }
}
