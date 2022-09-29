using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ColorSorting_API.BitmapHelper
{
    public interface IBitmapHelper
    {
        Bitmap ImageSourceToBitmap(ImageSource ImgSrs);
        BitmapImage BitmapToImageSource(Bitmap bitmap);
    }
}
