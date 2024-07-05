using Nest;
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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        //decimal roundedResult = Math.Round(Result, 2);
        char op;
        public MainWindow()
        {
            InitializeComponent();
            Zero.Click += Zero_Click;
            One.Click += One_Click;
            Two.Click += Two_Click;
            Three.Click += Three_Click;
            Four.Click += Four_Click;
            Five.Click += Five_Click;
            Six.Click += Six_Click;
            Seven.Click += Seven_Click;
            Eight.Click += Eight_Click;
            Nine.Click += Nine_Click;
            Plus.Click += Plus_Click;
            Less.Click += Less_Click;
            Devide.Click += Devide_Click;
            Multiply.Click += Multiply_Click;
            Rest_of.Click += Resto_of_Click;
            Dot.Click += Dot_Click;
            Exe.Click += Exe_Click;
            Clear.Click += Clear_Click;

        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "0";
            }
            else
            {
                Displaybox.Text += "0";
            }
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "1";
            }
            else
            {
                Displaybox.Text += "1";
            }
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "2";
            }
            else
            {
                Displaybox.Text += "2";
            }
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "3";
            }
            else
            {
                Displaybox.Text += "3";
            }
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "4";
            }
            else
            {
                Displaybox.Text += "4";
            }
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "5";
            }
            else
            {
                Displaybox.Text += "5";
            }
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "6";
            }
            else
            {
                Displaybox.Text += "6";
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "7";
            }
            else
            {
                Displaybox.Text += "7";
            }
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "8";
            }
            else
            {
                Displaybox.Text += "8";
            }
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (Displaybox.Text == "0")
            {
                Displaybox.Text = "9";
            }
            else
            {
                Displaybox.Text += "9";
            }
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(Displaybox.Text);
            op = '+';
            Displaybox.Clear();

        }
        private void Less_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(Displaybox.Text);
            Displaybox.Clear();
            op = '-';
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(Displaybox.Text);
            Displaybox.Clear();
            op = '*';
        }
        private void Devide_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(Displaybox.Text);
            Displaybox.Clear();
            op = '/';
        }
        private void Resto_of_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = decimal.Parse(Displaybox.Text);
            Displaybox.Clear();
            op = '%';
        }
        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (!Displaybox.Text.Contains("0"))
            {
                Displaybox.Text = Displaybox.Text += ",";
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Displaybox.Clear();
        }

        private void Exe_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case '+':
                    valueSecond = decimal.Parse(Displaybox.Text);
                    Result = valueFirst + valueSecond;
                    Displaybox.Text = Result.ToString();
                    break;
                case '-':
                    valueSecond = decimal.Parse(Displaybox.Text);
                    Result = valueFirst - valueSecond;
                    Displaybox.Text = Result.ToString();
                    break;
                case '*':
                    valueSecond = decimal.Parse(Displaybox.Text);
                    Result = valueFirst * valueSecond;
                    Displaybox.Text = Result.ToString();
                    break;
                case '/':
                    valueSecond = decimal.Parse(Displaybox.Text);
                    Result = valueFirst / valueSecond;
                    Displaybox.Text = Result.ToString();
                    break;
                case '%':
                    valueSecond = decimal.Parse(Displaybox.Text);
                    Result = valueFirst % valueSecond;
                    Displaybox.Text = Result.ToString();
                    break;
                default: 
                    Result = valueFirst;
                    break;
            }
        }
    }
}
