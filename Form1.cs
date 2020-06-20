using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDoSer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextLabel.Text = Text;
           
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            long threads;
            if (pingSwitch.Checked)
            {
                threads = pingThreads.Value;
                for (long i = threads; i > 0; i--)
                {

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
    }
}
