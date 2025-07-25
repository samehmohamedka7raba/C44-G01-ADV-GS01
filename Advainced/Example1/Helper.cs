using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advainced.Example1
{
    internal static class Helper
    {
        #region swap

        public static void SWAP(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void SWAP(ref decimal x, ref decimal y)
        {
            decimal temp = x;
            x = y;
            y = temp;
        }

        public static void SWAP(ref Point x, ref Point y)
        {
            Point temp = x;
            x = y;
            y = temp;
        }
        #endregion


        #region SWAP - GENRIC
        public static void SWAP<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion






    }
}