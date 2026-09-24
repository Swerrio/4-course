using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ImageViewer
{
    public partial class ImageCard : UserControl
    {
        public ImageCard()
        {
            InitializeComponent();
        }

        // имя файла изображения
        public string Source
        {
            set { Picture.Source = new BitmapImage(new System.Uri(value, System.UriKind.Relative)); }
        }

        // подпись под изображением
        public string Title
        {
            set { Caption.Text = value; }
        }
    }
}
