using ColorSorting_API.BitmapHelper;
using NUnit.Framework;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

namespace ColorSorting_Test.BitmapHelper
{
    [TestFixture]
    public class BitmapHelperTests
    {
        private IBitmapHelper _bitmapHelper;
        [SetUp]
        public void Setup()
        {
            _bitmapHelper = new ColorSorting_Services.BitmapHelper.BitmapHelper();
        }
        [TestCase]
        public void ImageSourceToBitmap_GivenImageSource_ReturnsBitmap()
        {
            //Arrange
            //System.Windows.Media.ImageSource ImgSrs = new ;
            ////Act
            //_bitmapHelper.ImageSourceToBitmap(ImgSrs);
            ////Assert
            //Assert.AreEqual(unSortedArrays, unSortedArrays.OrderBy(m => m));
        }
        [TestCase]
        public void ImageSourceToBitmap_GivenBitmap_ReturnsImageSource()
        {
            //Arrange
           
            //var bitmapSource =  BitmapSource.Create(10, 10, 10.5, 10.5, null,null, null, 10);
            //var width = bitmapSource.PixelWidth;
            //var height = bitmapSource.PixelHeight;
            //var stride = width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);
            //var memoryBlockPointer = Marshal.AllocHGlobal(height * stride);
            //Bitmap bitmap = new Bitmap(width, height, stride, System.Drawing.Imaging.PixelFormat.Format32bppPArgb, memoryBlockPointer); ;
            ////Act
            //var reult = _bitmapHelper.BitmapToImageSource(bitmap);
            ////Assert
            //Assert.That(reult, Is.TypeOf<System.Windows.Media.ImageSource>());
        }
    }
}
