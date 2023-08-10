using galnet_prototype.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using NAudio.Wave;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using Timer = System.Threading.Timer;

namespace galnet_prototype
{
    public partial class Form1 : Form
    {
        enum StatusByte
        {
            AVAILABLE = 0x01,
            AWAY = 0x02,
            BUSY = 0x03,
            OFFLINE = 0x04
        }

        ClientWebSocket ws;
        public static RawSourceWaveStream galnetA = new RawSourceWaveStream(Properties.Resources.GalNet_LOOPA, new WaveFormat(44100, 2));
        public static RawSourceWaveStream galnetB = new RawSourceWaveStream(Properties.Resources.GalNet_LOOPB, new WaveFormat(44100, 2));
        public static RawSourceWaveStream galnetC = new RawSourceWaveStream(Properties.Resources.GalNet_LOOPC, new WaveFormat(44100, 2));
        private WaveOutEvent galnetADevice;
        private WaveOutEvent galnetBDevice;
        private WaveOutEvent galnetCDevice;
        public bool isResizing = false;

        public bool connected = false;

        Process proc = Process.GetCurrentProcess();
        public Form1()
        {
            InitializeComponent();
            statusBox.DrawMode = DrawMode.OwnerDrawFixed;
            statusBox.DrawItem += statusBox_DrawItem;
            statusBox.Region = new Region(new Rectangle(3, 3, statusBox.Width - 3, statusBox.Height - 7));
            banner.Controls.Add(logo);
            banner.Controls.Add(galaxy);
            Timer timer1 = new Timer(updateRamUsage, "vovo   we do the    car", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

            galnetADevice = new WaveOutEvent();
            galnetADevice.Init(galnetA);
            galnetBDevice = new WaveOutEvent();
            galnetBDevice.Init(galnetB);
            galnetCDevice = new WaveOutEvent();
            galnetCDevice.Init(galnetC);

            galnetADevice.Play();
        }

        void statusBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // clear bg
            e.DrawBackground();
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.Bounds);

            int hgt = e.Bounds.Height - 2 * 4;
            Rectangle irect = new Rectangle(
                e.Bounds.X + 4,
                e.Bounds.Y + 4,
                8, 8);
            Rectangle srect = new Rectangle(
                e.Bounds.X + 16,
                e.Bounds.Y,
                128, 16);
            ComboBox cbo = sender as ComboBox;
            string itxt = (string)cbo.Items[e.Index];
            if (itxt == "Available")
            {
                e.Graphics.DrawImage(Resources.online, irect);
                e.Graphics.DrawString("Available", cbo.Font, new SolidBrush(Color.White), srect);
            }
            else if (itxt == "Away")
            {
                e.Graphics.DrawImage(Resources.away, irect);
                e.Graphics.DrawString("Away", cbo.Font, new SolidBrush(Color.White), srect);
            }
            else if (itxt == "Busy")
            {
                e.Graphics.DrawImage(Resources.busy, irect);
                e.Graphics.DrawString("Busy", cbo.Font, new SolidBrush(Color.White), srect);
            }
            else if (itxt == "Invisible")
            {
                e.Graphics.DrawImage(Resources.offline, irect);
                e.Graphics.DrawString("Invisible", cbo.Font, new SolidBrush(Color.White), srect);
            }
        }

        async void Connect(string uri)
        {
            ws = new ClientWebSocket();
            // connect to websocket (no auth yet)
            try
            {
                await ws.ConnectAsync(new Uri(uri), CancellationToken.None);
            } catch (Exception e)
            {
                toolStripStatusLabel2.Text = "Server status: Disconnected";
                MessageBox.Show(e.Message, "Failed to connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            byte[] buf = new byte[1056];

            if (ws.State == WebSocketState.Open)
            {
                toolStripStatusLabel2.Text = "Server status: Connected";
                taskbarIcon.Text = "GalaxyNet Client - Connected";
                connected = true;
            }
            while (ws.State == WebSocketState.Open)
            {
                // recieve websocket message
                var result = await ws.ReceiveAsync(buf, CancellationToken.None);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    if (ws.State != WebSocketState.Closed) await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
                    toolStripStatusLabel2.Text = "Server status: Disconnected";
                    taskbarIcon.Text = "GalaxyNet Client - Disconnected";
                    connected = false;
                }
            }
        }
        async void SignIn()
        {
            if (connected)
            {
                //
                // send inital user connection packet
                /* 0x22 - start byte
                 * inital status byte (0x01-0x04)
                 * username length - 1 byte
                 * username - x bytes
                 * password length - 1 byte
                 * password - x bytes
                 */
                /*switch (statusBox.Text)
                {
                    case "Available":
                        await ws.SendAsync({ 0x22, StatusByte.AVAILABLE}, WebSocketMessageType.Text, true, CancellationToken.None);
                        break;
                    case "Away":
                        await ws.SendAsync({ 0x22, StatusByte.AWAY}, WebSocketMessageType.Text, true, CancellationToken.None);
                        break;
                    case "Busy":
                        await ws.SendAsync({ 0x22, StatusByte.BUSY}, WebSocketMessageType.Text, true, CancellationToken.None);
                        break;
                    case "Invisible":
                        await ws.SendAsync({ 0x22, StatusByte.OFFLINE}, WebSocketMessageType.Text, true, CancellationToken.None);
                        break;
                }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Server status: Connecting..";
            taskbarIcon.Text = "GalaxyNet Client - Connecting..";
            taskbarIcon.BalloonTipIcon = ToolTipIcon.Info;
            taskbarIcon.BalloonTipTitle = "GalaxyNet Client";
            taskbarIcon.BalloonTipText = "Connecting to server..";
            taskbarIcon.ShowBalloonTip(200);
            Connect("ws://localhost:4672/ws");
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                Font italicText = new Font(
                    username.Font.FontFamily,
                    ((float)username.Font.Size),
                    FontStyle.Italic,
                    GraphicsUnit.Point
                );
                username.Font = italicText;
            }
            else
            {
                Font regularTxt = new Font(
                    username.Font.FontFamily,
                    ((float)username.Font.Size),
                    FontStyle.Regular,
                    GraphicsUnit.Point
                );
                username.Font = regularTxt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Font italicText = new Font(
                    textBox1.Font.FontFamily,
                    ((float)textBox1.Font.Size),
                    FontStyle.Italic,
                    GraphicsUnit.Point
                );
                textBox1.Font = italicText;
            }
            else
            {
                Font regularTxt = new Font(
                    textBox1.Font.FontFamily,
                    ((float)textBox1.Font.Size),
                    FontStyle.Regular,
                    GraphicsUnit.Point
                );
                textBox1.Font = regularTxt;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        void updateRamUsage(object state)
        {
            toolStripStatusLabel1.Text = "RAM usage: " + (proc.PrivateMemorySize64/1000000).ToString() + " MB";
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}