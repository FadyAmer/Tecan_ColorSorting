using System;
using System.Linq;
using ColorSorting_API.Common.Sorting;
using ColorSorting_Services.Common.Sorting;
using NUnit.Framework;

namespace ColorSorting_Test.Common.Sorting
{
    [TestFixture]
    public class QuickSortTests
    {
        private IQuickSort _quickSort;
        [SetUp]
        public void Setup()
        {
            _quickSort = new QuickSort();
        }

        [TestCase]
        public void Sort_StringArrayWithDuplicateData_ReturnSortedArray()
        {
            //Arrange
            var unSortedArrays = new string[] { "5N", "2N", "1N", "12N", "3N", "5N" };
            //Act
            _quickSort.Sort(unSortedArrays);
            //Assert
            Assert.AreEqual(unSortedArrays, unSortedArrays.OrderBy(m => m));
        }

        [TestCase]
        public void Sort_StringArrayWithNoDuplicateData_ReturnSortedArray()
        {
            //Arrange
            var unSortedArrays = new string[] { "1N", "2N", "12N", "5N", "3N", "6N" };
            //Act
            _quickSort.Sort(unSortedArrays);
            //Assert
            Assert.AreEqual(unSortedArrays, unSortedArrays.OrderBy(m => m));
        }

        [TestCase]
        public void Sort_EmptyArray_ThrowsArgumentException()
        {
            //Arrange
            string[] unSortedArrays = null;
            //Act
            var ex = Assert.Throws<ArgumentNullException>(() => _quickSort.Sort(unSortedArrays));
            //Assert 
            Assert.That(ex.Message, Is.EqualTo("Value cannot be null."));
        }
    }
}
