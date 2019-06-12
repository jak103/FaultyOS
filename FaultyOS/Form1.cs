using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace FaultyOS
{
    public partial class Form1 : Form
    {
        private List<Process> processes = new List<Process>();
        
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
            lock (processes)
            {
                if (processes.Count > 0)
                {
                    List<Process> children = new List<Process>();
                    foreach (Process p in processes)
                    {
                        List<Process> temp = GetChildProcesses(p);
                        children.AddRange(temp);                        
                    }

                    processes.AddRange(children);

                    Random rand = new Random();

                    int index = rand.Next(0, processes.Count);

                    Process deadProcess = processes[index];

                    processes.RemoveAt(index);
                    if (!deadProcess.HasExited)
                    {
                        PrintText("Killing process: " + deadProcess.ProcessName + " (" + deadProcess.Id + ")");
                        deadProcess.Kill();
                    }
                }
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string[] command = commandBox.Text.Split(' ');

            lock (processes)
            {
                timer.Stop();
                Process p1 = new Process();
                p1.StartInfo.FileName = command[0];

                if (command.Length > 1)
                {
                    p1.StartInfo.Arguments = command[1];
                }

                p1.Start();

                processes.Add(p1);
                PrintText(string.Format("Running process: {0}", p1.ProcessName));

                timer.Start();
            }
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            lock (processes)
            {
                timer.Stop();
                foreach (Process p in processes)
                {
                    p.Kill();
                }

                processes.Clear();

            } 
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

        
        public List<Process> GetChildProcesses(Process process)
        {
            List<Process> children = new List<Process>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher(String.Format("Select * From Win32_Process Where ParentProcessID={0}", process.Id));

            foreach (ManagementObject mo in mos.Get())
            {
                children.Add(Process.GetProcessById(Convert.ToInt32(mo["ProcessID"])));
            }

            return children;
        }

        private void killRateBox_ValueChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = (double)killRateBox.Value;
            timer.Start();
        }
    }
}