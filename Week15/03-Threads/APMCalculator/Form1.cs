using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APMCalculator
{
    public partial class Form1 : Form
    {
        double result;
        Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch.Start();

            Thread thread = new Thread(APMCalculate);
            thread.IsBackground = true;
            thread.Start();
        }


        volatile int count = 0;
        
        private void btnClick_Click(object sender, EventArgs e)
        {
            Object locker = new Object();

            lock (locker)
            {
                count++;
            }
        }

        public void APMCalculate()
        {
            Object obj = new Object();
            while (true)
            {
                lock (obj)
                {
                    result = count / stopwatch.Elapsed.TotalMinutes;
                }

                Thread.Sleep(1500);

                BeginInvoke((Action)delegate ()
                {
                    ResultCalc();
                });
            }
        }

        public void ResultCalc()
        {
            labelTxt.Text = result.ToString();
        }
    }
}
