using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace RoadSigns
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // по нажатию открывается исходный SVG-файл знака
        private void Sign_Click(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string file = "Signs\\" + element.Tag + ".svg";

            if (System.IO.File.Exists(file))
            {
                System.Diagnostics.Process.Start(file);
            }
        }
    }
}
