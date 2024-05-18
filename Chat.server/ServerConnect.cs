using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;
using System.Windows.Forms;

namespace Chat.server
{
    public static class ServerConnect
    {
        public static async Task connect(string input)
        {
            using(ClientWebSocket client = new ClientWebSocket())
            {
                try
                {
                    Uri uri = new Uri("ws://localhost:8080/ws/");
                    await client.ConnectAsync(uri, CancellationToken.None);
                    byte[] bytesToSend = Encoding.UTF8.GetBytes(input);
                    await client.SendAsync(new ArraySegment<byte>(bytesToSend), WebSocketMessageType.Text, true, CancellationToken.None);
                    byte[] bytesReceived = new byte[1024];
                    WebSocketReceiveResult result = await client.ReceiveAsync(new ArraySegment<byte>(bytesReceived), CancellationToken.None);
                    string receivedMessage = Encoding.UTF8.GetString(bytesReceived, 0, result.Count);
                    MessageBox.Show($"Message: {receivedMessage}");
                    await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
                }
                catch (WebSocketException ex)
                {
                    MessageBox.Show($"WebSocket error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
