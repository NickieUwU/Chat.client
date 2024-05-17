using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;

namespace Chat.server
{
    public static class ServerConnect
    {
        static async Task connect(string input)
        {
            using(ClientWebSocket client = new ClientWebSocket())
            {
                Uri uri = new("\"ws://localhost:8080/ws/\"");
                await client.ConnectAsync(uri, CancellationToken.None);
            }
        }
    }
}
