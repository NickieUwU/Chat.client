using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Net.Http;

namespace Chat.server
{
    public static class ServerConnect
    {
        public static async Task connect()
        {
            using(ClientWebSocket client = new())
            {
                try
                {
                    Uri uri = new Uri("ws://localhost:7000");
                    await client.ConnectAsync(uri,  CancellationToken.None);
                    MessageBox.Show("Client connected!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
        }
        public static async Task send(string message)
        {
            using(ClientWebSocket client = new())
            {
                try
                {
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
