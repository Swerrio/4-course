using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackgroundWorkerApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime startDate = DateTime.Now;

        private int randNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(startDate);
            string sTime = "  ..." + ts.Minutes.ToString("00") +
                ":" + ts.Seconds.ToString("00") +
                ":" + ts.Milliseconds.ToString("000");
            toolStripStatusLabelTime.Text = sTime;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(e.Argument);

                for (int i = 0; i < count; i++)
                {
                    System.Threading.Thread.Sleep(100);
                    backgroundWorker.ReportProgress((i * 100) / (count - 1));

                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.Value = e.ProgressPercentage;
            ContainerTextBox.AppendText(randNumber().ToString() + " ");
            toolStripStatusLabel.Text = "Обработка... " + e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Задача была отменена");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("В ходе выполнения возникла ошибка: " + (e.Error as Exception).ToString());
            }
            else
            {
                timer.Stop();
                toolStripStatusLabel.Text = "Обработка завершена";
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                return;
            }

            int count;

            if (!int.TryParse(CountNumber.Text, out count) || count < 2)
            {
                MessageBox.Show("Введите количество символов (целое число больше 1)");
                return;
            }

            ContainerTextBox.Clear();
            toolStripProgressBar.Value = 0;
            startDate = DateTime.Now;
            backgroundWorker.RunWorkerAsync(count);
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            timer.Stop();
        }
    }
}
