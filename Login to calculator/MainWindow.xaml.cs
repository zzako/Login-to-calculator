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

namespace Login_to_calculator
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "user";
            string password = "user123";
            string inputName = TextBox1.Text;
            string inputPassword = TextBox2.Text;
            Window window = new Window();
            if (inputName == name && inputPassword == password)
            {
                MainWindow mainwindow = new MainWindow();
                mainwindow.Hide();
                Window1 window1 = new Window1();
                window1.Show();

                
            }
            else if (inputName != name || inputPassword != password)
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
    }
}
