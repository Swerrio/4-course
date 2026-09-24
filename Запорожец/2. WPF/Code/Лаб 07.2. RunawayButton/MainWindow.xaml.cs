using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace RunawayButton
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private readonly Random random = new Random();

        // кнопка смещается от курсора
        private void Runaway_MouseEnter(object sender, MouseEventArgs e)
        {
            double maxLeft = Field.ActualWidth - Runaway.ActualWidth;
            double maxTop = Field.ActualHeight - Runaway.ActualHeight;

            double left = random.NextDouble() * (maxLeft > 0 ? maxLeft : 0);
            double top = random.NextDouble() * (maxTop > 0 ? maxTop : 0);

            DoubleAnimation moveLeft = new DoubleAnimation(left, TimeSpan.FromSeconds(0.3));
            DoubleAnimation moveTop = new DoubleAnimation(top, TimeSpan.FromSeconds(0.3));

            Runaway.BeginAnimation(Canvas.LeftProperty, moveLeft);
            Runaway.BeginAnimation(Canvas.TopProperty, moveTop);
        }

        private void Runaway_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поймали!", "Убегающая кнопка");
        }
    }
}
