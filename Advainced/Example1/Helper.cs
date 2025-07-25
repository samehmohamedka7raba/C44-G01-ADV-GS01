using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advainced.Example1
{
    internal static class Helper<T> , IComparable<T>
    {
        #region swap v1

        //public static void SWAP(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void SWAP(ref decimal x, ref decimal y)
        //{
        //    decimal temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void SWAP(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion


        #region SWAP - GENRIC v1
        public static void SWAP(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion


        #region linear search v2
        //public static int linearSearch(int[] arr, int value)
        //{
        //    if (arr is not null && arr.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }

        //    }
        //    return -1;
        //}

        #endregion


        #region linear search -Generic
        //public static int linearSearch(T[] arr, T value)
        //{
        //    if (arr is not null && arr.Length > 0)
        //   {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }

        //    }
        //    return -1;
        //}

        #endregion


        #region Bubble sort
        //public static void BubbleSort(int[] arr)
        //{
        //    if (arr is not null && arr.Length > 0)
        //    {
        //        for(int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1; j++)
        //            {
        //                if (arr[j] > arr[j +1])
        //                    Helper<int>.SWAP(ref arr[j], ref arr[j +1]);
        //            }
        //        }
        //    }
        //}




        #region  Bubble sort generic

        public static void BubbleSort(T[] arr)
        {
            if (arr is not null && arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[j].CompareTo( arr[j + 1]) > 0)
                            Helper<T>.SWAP(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }



        #endregion












        #endregion











    }
}