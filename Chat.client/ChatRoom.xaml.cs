using Chat.server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chat.client
{
    /// <summary>
    /// Interakční logika pro ChatRoom.xaml
    /// </summary>
    public partial class ChatRoom : Window
    {
        public ChatRoom()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string messageToSend = txtNewMsg.Text;
            if (!string.IsNullOrEmpty(messageToSend))
            {

            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await ServerConnect.connect();
        }
    }
}
