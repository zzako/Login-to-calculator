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
using System.Windows.Shapes;

namespace Login_to_calculator
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double f = Convert.ToDouble(TextBox1.Text);
                double c;
                c = (f - 32) * 5 / 9;
                AnswerL.Content = c.ToString() + "C";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double c = Convert.ToDouble(TextBox1.Text);
                double f;
                f = c * 1.8 + 32;
                AnswerL.Content = f.ToString() + "F";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
    
}
