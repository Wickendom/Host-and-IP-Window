using System.Net.Sockets;
using System.Net;


namespace Host_and_IP_Window
{


    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            //sets the label value for the host name to the local machines name
            hostNameValue.Text = System.Environment.GetEnvironmentVariable("COMPUTERNAME");
            InitTimer();
            GetIPAddress();
            TopMost = true; // set the window to always be on top
            MoveWindow();
        }

        //Connect to a UDP port to get the required IP address
        //Connecting to UDP means we can get an accurate IP if you are using multiple network adapters
        private string GetIPAddress()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0);
            socket.Connect("8.8.8.8", 65530);
            IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
            string ipAddress = endPoint.Address.ToString();
            UpdateIPText(ipAddress);
            return ipAddress;
        }

        private void UpdateIPText(string ipAddress)
        {
            IPValue.Text = ipAddress;
        }

        //set the window to be in the top right corner slightly below the top of the screen
        private void MoveWindow()
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Width, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetIPAddress();
        }

        private void InitTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 300000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetIPAddress();
        }
    }


}