using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MenuToolbarStatus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // цвет фона окна
        private void WhiteItem_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }

        private void BlueItem_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.LightBlue;
        }

        private void GreenItem_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.LightGreen;
        }

        private void AboutItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: студент группы ИСП-4-27\n" +
                            "Лабораторная работа №3", "О разработчике");
        }

        private void CloseItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // подсказка в строке состояния
        private void Hint_MouseEnter(object sender, MouseEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            if (element != null && element.Tag != null)
            {
                StatusText.Text = element.Tag.ToString();
            }
        }

        private void Hint_MouseLeave(object sender, MouseEventArgs e)
        {
            StatusText.Text = "Готово";
        }
    }
}
