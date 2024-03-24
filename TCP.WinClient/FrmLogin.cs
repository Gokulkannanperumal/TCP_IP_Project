using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPObj;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TCP.WinClient
{
    public partial class FrmLogin : Form
    {
       public TcpClient client=null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void XmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the server's IP address and port toconnect
                string serverIp = "192.168.1.4";
                int port = 12345;

                // Create a TCP/IP socket for client
                client = new TcpClient(serverIp, port);


                loginObj login = new loginObj() { username = TxtUname.Text, password = TxtPass.Text };

                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();


                // Serialize the Person object to a byte array
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, login);

                // Receive a response from the server
                byte[] responseData = new byte[1024];
                int bytesRead = stream.Read(responseData, 0, responseData.Length);
                string response = System.Text.Encoding.ASCII.GetString(responseData, 0, bytesRead);

                if (response == "Valid")
                {
                    FrmMain main = new FrmMain();
                    main.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Enter Correct Username and Password");

                client.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
   

}
