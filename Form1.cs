using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Pilatus_Snap_WinFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void setthreshold_Click(object sender, EventArgs e)
        {
            // initialize IP address of Pilatus 200K and its port
            String server = ipAddress_textBox.Text;
            String portString = portNumber_textBox.Text;
            Int32 port = Int32.Parse(portString);

            // create new session with Pilatus 200K
            TcpClient session_Pilatus = new TcpClient(server, port);

            // initialize stream
            NetworkStream stream = session_Pilatus.GetStream();

            // set number of images
            String setthresholdString = setthresholdCmd_textBox.Text + "\n";
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(setthresholdString);
            stream.Write(data, 0, data.Length);
            // Buffer to store the response bytes.
            data = new Byte[256];
            // String to store the response ASCII representation.
            String responseData_setthreshold = String.Empty;
            // Read Pilatus's response
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData_setthreshold = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            pilatusResponse_richTextBox.Text = responseData_setthreshold;
            Thread.Sleep(250);

            // Close everything
            stream.Flush();
            stream.Close();
            session_Pilatus.Close();
        }

        private void takeImage_Click(object sender, EventArgs e)
        {
            // initialize IP address of Pilatus 200K and its port
            String server = ipAddress_textBox.Text;
            String portString = portNumber_textBox.Text;
            Int32 port = Int32.Parse(portString);

            // create new session with Pilatus 200K
            TcpClient session_Pilatus = new TcpClient(server, port);

            // initialize stream
            NetworkStream stream = session_Pilatus.GetStream();

            // set number of images
            String niString = "ni " + ni_textBox.Text + "\n";
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(niString);
            stream.Write(data, 0, data.Length);
            // Buffer to store the response bytes.
            data = new Byte[256];
            // String to store the response ASCII representation.
            String responseData_ni = String.Empty;
            // Read Pilatus's response
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData_ni = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            // set exposure time
            String exptString = "expt " + expt_textBox.Text + "\n";
            data = System.Text.Encoding.ASCII.GetBytes(exptString);
            stream.Write(data, 0, data.Length);
            // Read Pilatus's response
            data = new Byte[256];
            // String to store the response ASCII representation.
            String responseData_expt = String.Empty;
            bytes = stream.Read(data, 0, data.Length);
            responseData_expt = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            // set exposure period
            String exppString = "expp " + expp_textBox.Text + "\n";
            data = System.Text.Encoding.ASCII.GetBytes(exppString);
            stream.Write(data, 0, data.Length);
            // Read Pilatus's response
            data = new Byte[256];
            // String to store the response ASCII representation.
            String responseData_expp = String.Empty;
            // Read Pilatus's response
            bytes = stream.Read(data, 0, data.Length);
            responseData_expp = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            // take image, do exposure
            String expoString = "expo " + imageName_textBox.Text + ".tif" + "\n";
            data = System.Text.Encoding.ASCII.GetBytes(expoString);
            stream.Write(data, 0, data.Length);
            // Read Pilatus's response
            data = new Byte[256];
            // String to store the response ASCII representation.
            String responseData_expo = String.Empty;
            // Read Pilatus's response
            bytes = stream.Read(data, 0, data.Length);
            responseData_expo = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            pilatusResponse_richTextBox.Text = responseData_ni + responseData_expt + responseData_expp + responseData_expo;

            Int32 niNumber = Int32.Parse(ni_textBox.Text);
            float niFloatNumber = Convert.ToSingle(niNumber);
            float exppFloatNumber = float.Parse(expp_textBox.Text);
            float wait_in_ms_FloatNumber = niFloatNumber * exppFloatNumber * 1000 + 1000;
            Int32 wait_in_ms = Convert.ToInt32(wait_in_ms_FloatNumber);
            Thread.Sleep(wait_in_ms);

            // Close everything
            stream.Flush();
            stream.Close();
            session_Pilatus.Close();
        }
    }
}
