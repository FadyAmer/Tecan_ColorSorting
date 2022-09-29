using ColorSorting_API.BitmapHelper;
using ColorSorting_API.ColorSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorSorting_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBitmapHelper _bitmapHelper;
        private readonly IColorSort_Service _colorSort_Service;
        public MainWindow(IBitmapHelper bitmapHelper, IColorSort_Service colorSort_Service) : base()
         {
            InitializeComponent();

            _bitmapHelper = bitmapHelper;
            _colorSort_Service = colorSort_Service;
        }
        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {

            var width = color_Image.Width;
            var height = color_Image.Height;

            color_Image.Source = _bitmapHelper.BitmapToImageSource(_colorSort_Service.LoadColors((int)color_Image.Width, (int)color_Image.Height));
        }


        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            if (color_Image.Source == null)
            {
                MessageBoxResult result = MessageBox.Show("There's no colors to sort, Please click on the other button first!");
            }
            else
            {
                var imageSourceToBitmap = _bitmapHelper.ImageSourceToBitmap(color_Image.Source);
                _colorSort_Service.SortBitmapColor(imageSourceToBitmap);
                color_Image.Source = _bitmapHelper.BitmapToImageSource(imageSourceToBitmap);
            }
        }
    }
}
