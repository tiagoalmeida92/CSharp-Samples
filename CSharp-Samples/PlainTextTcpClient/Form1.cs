using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlainTextTcpClient
{
    public partial class Form1 : Form
    {
        PlainTextTcpClient client = new PlainTextTcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_button_click(object sender, EventArgs e)
        {
            //var separatorIdx = ip_tbox.Text.IndexOf(':');
            //var ip = ip_tbox.Text.Substring(0, separatorIdx);
            //var port = ip_tbox.Text.Substring(separatorIdx + 1);
            var res = client.Transfer(IPAddress.Loopback, 8888);
//            var res = client.Transfer(IPAddress.Parse(ip), Convert.ToInt16(port));

            result_tbox.Text = res;

        }
        
    }
}
