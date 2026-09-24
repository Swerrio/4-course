using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MultiEdit
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // поле, в котором пользователь набирает текст, становится большим
        private void Text_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["BigText"];
        }

        private void Text_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["SmallText"];
        }
    }
}
