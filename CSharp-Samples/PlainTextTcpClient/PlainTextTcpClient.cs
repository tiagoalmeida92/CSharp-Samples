using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainTextTcpClient
{
    class PlainTextTcpClient
    {
       

        public String Transfer(IPAddress ip, short port)
        {
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            StreamReader input = new StreamReader(client.GetStream());
            StringBuilder sb = new StringBuilder();
            String line;
            while ((line = input.ReadLine()) != null && line != string.Empty)
                sb.AppendLine(line);
            input.Close();
            return sb.ToString();
        }

    }
}
