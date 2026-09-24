using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace TriggerEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Left.Text = "Открыт первый документ";
            Right.Text = "Открыт второй документ";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Left.Clear();
            Right.Clear();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
