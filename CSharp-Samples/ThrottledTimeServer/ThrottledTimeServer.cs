using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ThrottledTimeServer
{
    class ThrottledTimeServer
    {
        private readonly int _maxConnections;
        //private int _currentConnections = 0;
        private readonly object _lock = new object();
        TcpListener socket = new TcpListener(IPAddress.Loopback, 8888);

        public ThrottledTimeServer(int maxConnections)
        {
            _maxConnections = maxConnections;
        }

        public void Start()
        {
            socket.Start();
            socket.BeginAcceptSocket(Callback, null);
            Console.WriteLine(":: Server Started press key to end... ::");
            Console.ReadKey();
        }

        private void Callback(IAsyncResult ar)
        {
            TcpClient client = socket.EndAcceptTcpClient(ar);
            socket.BeginAcceptSocket(Callback, null);
            StreamWriter stream = new StreamWriter(client.GetStream());
            var res = DateTime.Now.ToString();
            stream.WriteLine(res);
            stream.Close();
        }
    }
}
