using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_classlib
{
    public class ArrayHelper
    {
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] reversed = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }
    }
}
