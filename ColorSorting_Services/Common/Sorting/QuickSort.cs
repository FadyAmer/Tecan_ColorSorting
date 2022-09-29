using ColorSorting_API.Common.Sorting;
using System;
using ColorSorting_Services.ExtensionMethod;

namespace ColorSorting_Services.Common.Sorting
{
    public class QuickSort : IQuickSort
    {
        public void Sort(string[] arr)
        {
            if (arr.IsNullOrEmpty())
            {
                throw new ArgumentNullException();
            }
            SortWithQuickSortAlgo(arr, 0, arr.Length - 1);
        }
      
        private void SortWithQuickSortAlgo(string[] arr, int left, int right)
        {
            //https://www.tutorialspoint.com/chash-program-to-perform-quick-sort-using-recursion
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    SortWithQuickSortAlgo(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    SortWithQuickSortAlgo(arr, pivot + 1, right);
                }
            }
        }

        private int Partition(string[] arr, int left, int right)
        {
            string pivot;
            pivot = arr[left];
            while (true)
            {
                while (String.Compare(arr[left], pivot) < 0)
                {
                    // str1 is less than str2
                    left++;
                }
                while (String.Compare(pivot, arr[right]) < 0)
                {
                    // str1 is less than str2
                    right--;
                }
                if (left < right && arr[left] != arr[right])
                {
                    string temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
