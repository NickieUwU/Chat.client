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
using System.IO;

namespace Chat.client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string con_string = @"Data Source=DESKTOP-LKC2C9H\TEW_SQLEXPRESS;Initial Catalog=Chat;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
            MakeLogFile();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MakeLogFile()
        {
            File.Create("chatlog.txt");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //temp login
            ChatRoom cr = new();
            cr.Show();
            this.Close();
        }
    }
}
