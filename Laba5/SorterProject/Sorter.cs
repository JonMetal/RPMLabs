using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sorter
    {

        private static void Swap(ref int value1, ref int value2)
        {
            var temp = value1;
            value1 = value2;
            value2 = temp;
        }

        private static int GetNextStep(int s)
        {
            s = s * 1000 / 1247;
            return s;
        }

        public static int[] CombSort(int[] array)
        {
            var arrayLength = array.Length;
            var currentStep = arrayLength - 1;

            while (currentStep >= 1)
            {
                for (int i = 0; i + currentStep < array.Length; i++)
                {
                    if (array[i] > array[i + currentStep])
                    {
                        Swap(ref array[i], ref array[i + currentStep]);
                    }
                }

                currentStep = GetNextStep(currentStep);
            }

            return array;
        }

        public static int[] ShillSort(int[] array, int len)
        {
            for (int qw = len / 2; qw > 0; qw /= 2)
            {
                for (int i = qw; i < len; i++)
                {
                    var e = array[i];
                    var k = i;
                    while (k >= qw && array[k - qw] > e)
                    {
                        array[k] = array[k - qw];
                        k -= qw;
                    }
                    array[k] = e;
                }
            }
            return array;
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j + 1] < array[j])
                        {
                            Swap(ref array[j + 1], ref array[j]);
                        }
                    }
                }
            }
            return array;
        }

        public static string Print(int[] array)
        {
            return string.Join(" ", array);
        }
    }
}
