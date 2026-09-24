using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace GraphicsEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // цвет кисти
        private void ColorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (InkArea == null)
            {
                return;
            }

            Color color = Colors.Black;
            if (ColorBox.SelectedIndex == 1) color = Colors.Red;
            if (ColorBox.SelectedIndex == 2) color = Colors.Green;
            if (ColorBox.SelectedIndex == 3) color = Colors.Blue;

            InkArea.DefaultDrawingAttributes.Color = color;
        }

        // размер кисти
        private void SizeSlider_ValueChanged(object sender,
            RoutedPropertyChangedEventArgs<double> e)
        {
            if (InkArea == null)
            {
                return;
            }

            InkArea.DefaultDrawingAttributes.Width = SizeSlider.Value;
            InkArea.DefaultDrawingAttributes.Height = SizeSlider.Value;
            SizeText.Text = ((int)SizeSlider.Value).ToString();
        }

        // режим работы
        private void Mode_Checked(object sender, RoutedEventArgs e)
        {
            if (InkArea == null)
            {
                return;
            }

            if (DrawMode.IsChecked == true)
            {
                InkArea.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (SelectMode.IsChecked == true)
            {
                InkArea.EditingMode = InkCanvasEditingMode.Select;
            }
            else
            {
                InkArea.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
        }
    }
}
