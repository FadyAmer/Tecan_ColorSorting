using ColorSorting_API.ColorSort;
using ColorSorting_API.Common.Sorting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ColorSorting_Services.ColorSort
{
    public class ColorSort_Service : IColorSort_Service
    {
        private readonly IQuickSort _sorter;

        public ColorSort_Service(IQuickSort sorter)
        {
            _sorter = sorter;
        }

        public Bitmap LoadColors(int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Random random = new Random();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    var color = String.Format("#{0:X6}", random.Next(0x1000000));
                    bmp.SetPixel(i, j, ColorTranslator.FromHtml(color));
                }
            }
            return bmp;
        }

        public void SortBitmapColor(Bitmap bmp)
        {
            string[] row = new string[bmp.Width];
            for (int i = 0; i < bmp.Height; i++)
            {
                GetSingleRowFromBitmap(bmp, i, row);
                _sorter.Sort(row);//sortedArray
                RefillWithSortedRow(bmp, i, row);
            }

        }

        private void GetSingleRowFromBitmap(Bitmap bmp, int index, string[] row)
        {
            for (int j = 0; j < bmp.Width; j++)
            {
                row[j] = ColorTranslator.ToHtml(bmp.GetPixel(j, index));
            }
        }

        private void RefillWithSortedRow(Bitmap bmp, int index, string[] row)
        {
            for (int j = 0; j < bmp.Width; j++)
            {
                bmp.SetPixel(j, index, ColorTranslator.FromHtml(row[j]));
            }
        }
    }
}
