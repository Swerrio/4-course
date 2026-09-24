using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Switches
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // поворот ручки переключателя на 20 градусов при каждом клике
        private void Switch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Canvas board = (Canvas)sender;
            Grid handle = (Grid)board.Children[2];
            RotateTransform turn = (RotateTransform)handle.RenderTransform;

            DoubleAnimation rotate = new DoubleAnimation(turn.Angle + 20,
                TimeSpan.FromSeconds(0.4));
            turn.BeginAnimation(RotateTransform.AngleProperty, rotate);
        }

        // увеличение переключателя под курсором
        private void Switch_MouseEnter(object sender, MouseEventArgs e)
        {
            Zoom((Canvas)sender, 1.6);
        }

        private void Switch_MouseLeave(object sender, MouseEventArgs e)
        {
            Zoom((Canvas)sender, 1.0);
        }

        private void Zoom(Canvas board, double value)
        {
            ScaleTransform zoom = (ScaleTransform)board.RenderTransform;
            DoubleAnimation change = new DoubleAnimation(value, TimeSpan.FromSeconds(0.3));
            zoom.BeginAnimation(ScaleTransform.ScaleXProperty, change);
            zoom.BeginAnimation(ScaleTransform.ScaleYProperty, change);
        }
    }
}
