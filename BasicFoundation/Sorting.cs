using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFoundation
{
    public class Sorting
    {
        //Bubblesorting
        public static void BubbleSort(int[] array)
        {

            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    SwapNumbers(array, i, i + 1);
                }
            }
        }
        public static void SelectionSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int higestnumber = 0;
                for (int j = 1; j < i; j++)
                {
                    SwapNumbers(array, higestnumber, j);
                }
            }
        }
        public static void SwapNumbers(int[] array, int i, int j)
        {
            if (i == j)
            { return; }
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

        }
    }
}
