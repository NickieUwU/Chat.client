using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chat.server
{
    public static class Log
    {
        public static void Login(string message)
        {
            File.AppendAllText("chatlog.txt", DateTime.Now.ToString() + "|LOGIN|" + message + "\r\n");
        }

        public static void Message(string message)
        {
            File.AppendAllText("chatlog.txt", DateTime.Now.ToString() + "|MESSAGE|" + message + "\r\n");
        }
    }
}
