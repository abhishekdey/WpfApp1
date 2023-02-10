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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Registration : Window
    {

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TextBox textBox = var sender as TextBox;
            //txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            //txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            //txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }

        private void OnClick3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // TextBox textBox = sender as TextBox;
            MessageBox.Show("TextBox_TextChanged_1, world!");
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("TextBox_TextChanged_2, world!");
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("TextBox_TextChanged_3, world!");
        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }
    }
}
