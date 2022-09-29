using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSorting_API.ColorSort
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public interface IColorSort_Service
    {
        Bitmap LoadColors(int width, int height);
        void SortBitmapColor(Bitmap bmp);
    }
}
