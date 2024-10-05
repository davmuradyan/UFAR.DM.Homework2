using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.DM.Homework2 {
    public static class InsertionSort {
        private static int i = 1;
        public static int Sort(ref int[] array) {
            if (i == array.Length)
            {
                i = 0;
                return 0;
            }

            int j = i-1;
            int key = array[i];
            while (j >= 0 && array[j] > key)
            {
                array[j+1] = array[j];
                j--;
            }
            array[j+1] = key;
            i++;
            return Sort(ref array);
        }
    }
}
