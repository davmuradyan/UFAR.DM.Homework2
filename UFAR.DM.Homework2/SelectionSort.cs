using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.DM.Homework2 {
    internal static class SelectionSort {
        private static int i = 0;
        public static int Sort(ref int[] array) {
            if(array.Length == i+1) {
                i = 0;
                return 0;
            }

            int iMin = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[iMin] > array[j])
                {
                    iMin = j;
                }
            }

            int tmp = array[i];
            array[i] = array[iMin];
            array[iMin] = tmp;

            i++;
            return Sort(ref array);
        }
    }
}