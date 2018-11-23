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

namespace WpfCalc
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        bool newButton;
        double savedValue;
        char myOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();
            if(textResult.Text == "0" || newButton == true)
            {
                textResult.Text = number;
                newButton = false;
            }
            else
            {
                textResult.Text = textResult.Text + number;
            }

        }

        private void BtnOp_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(textResult.Text);
            myOperator = btn.Content.ToString()[0];
            newButton = true;
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (textResult.Text.Contains(".") == false)
                textResult.Text += ".";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (myOperator == '+')
                textResult.Text = (savedValue + double.Parse(textResult.Text)).ToString();
            else if (myOperator == '-')
                textResult.Text = (savedValue - double.Parse(textResult.Text)).ToString();
            else if (myOperator == '×')
                textResult.Text = (savedValue * double.Parse(textResult.Text)).ToString();
            else if (myOperator == '÷')
                textResult.Text = (savedValue / double.Parse(textResult.Text)).ToString();
        }
    }
}
