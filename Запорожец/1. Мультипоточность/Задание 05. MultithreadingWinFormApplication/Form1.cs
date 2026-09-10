using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingWinFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(DrawRectangle));
            thread2 = new Thread(new ThreadStart(DrawEllipse));
            thread3 = new Thread(new ThreadStart(RandomNumber));
        }

        Thread thread1;
        Thread thread2;
        Thread thread3;

        private void DrawRectangle()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(4);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }

        private void DrawEllipse()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(4);
                    g.DrawEllipse(Pens.Yellow, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }

        private void RandomNumber()
        {
            try
            {
                Random rnd = new Random();

                Parallel.For(0, 500, i =>
                {
                    RandomNumberTextBox.Invoke((MethodInvoker)delegate ()
                    {
                        RandomNumberTextBox.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void StartThreadingButton_Click(object sender, EventArgs e)
        {
            try
            {
                thread1.Start();
                thread2.Start();
                thread3.Start();
            }
            catch (Exception ex) { }
        }

        private void FirstMethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                thread1.Start();
            }
            catch (Exception ex) { }
        }

        private void SecondMethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                thread2.Start();
            }
            catch (Exception ex) { }
        }

        private void ThirdMethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                thread3.Start();
            }
            catch (Exception ex) { }
        }

        private void StopThreadButton_Click(object sender, EventArgs e)
        {
            try
            {
                thread1.Abort();
                thread2.Abort();
                thread3.Abort();
            }
            catch (Exception ex) { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                thread1.Abort();
                thread2.Abort();
                thread3.Abort();
            }
            catch (Exception ex) { }
        }
    }
}
