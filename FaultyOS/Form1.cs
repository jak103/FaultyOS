using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FaultyOS
{
    public partial class Form1 : Form
    {
        private string processName;

        private System.Timers.Timer timer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();

            timer.Elapsed += Timer_Elapsed;
            timer.Interval = (double)killRateBox.Value;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!string.IsNullOrEmpty(processName))
            {
                Process[] processes = Process.GetProcessesByName(processName);
                if (processes.Length > 0)
                {
                    Random rand = new Random();

                    int index = rand.Next(0, processes.Length);

                    PrintText("Killing process: " + processes[index].Id);
                    processes[index].Kill();
                }
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string[] command = commandBox.Text.Split(' ');

            timer.Stop();

            Process p1 = new Process();
            p1.StartInfo.FileName = command[0];

            if (command.Length > 1)
            {
                p1.StartInfo.Arguments = command[1];
            }

            p1.Start();
            processName = p1.ProcessName;
            PrintText(string.Format("Running process: {0}", p1.ProcessName));

            timer.Start();

        }

        private delegate void StringDelegate(string text);

        private void PrintText(string text)
        {
            if (checkBox1.Enabled)
            {
                if (outputBox.InvokeRequired)
                {
                    outputBox.Invoke(new StringDelegate(PrintText), new object[] { text });
                }
                else
                {
                    outputBox.AppendText(text + "\r\n");
                }
            }
        }

        private void killRateBox_ValueChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = (double)killRateBox.Value;
            timer.Start();
        }


    }
}