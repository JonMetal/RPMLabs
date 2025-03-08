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
        private int[] arr;
        public int Index;

        private Sorter(int[] arr, int ind)
        {
            this.arr = arr;
            Index = ind;
        }

        private void Swap(ref int value1, ref int value2)
        {
            var temp = value1;
            value1 = value2;
            value2 = temp;
        }

        private static int GetNextStep(int s)
        {
            s = s * 1000 / 1247;
            return s > 1 ? s : 1;
        }

        private static int[] CombSort(int[] arr)
        {
            var arrLength = arr.Length;
            var currentStep = arrLength - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < arr.Length; i++)
                {
                    if (arr[i] > arr[i + currentStep])
                    {
                        int a = arr[i];
                        arr[i] = arr[i + currentStep];
                        arr[i + currentStep] = a;

                    }
                }

                currentStep = GetNextStep(currentStep);
            }

            return arr;
        }

        public int[] ShillSort(int[] arr, int size, string arrName)
        {
            for (int qw = size / 2; qw > 0; qw /= 2)
            {
                for (int i = qw; i < size; i++)
                {
                    var e = arr[i];
                    var k = i;
                    while (k >= qw && arr[k - qw] > e)
                    {
                        arr[k] = arr[k - qw];
                        k -= qw;
                    }
                    arr[k] = e;
                }
            }
            return arr;
        }

        private static int[] BubbleSort(int[] mass)
        {
            int temp;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int k = 0; k < mass.Length - 1; k++)
                {
                    for (int j = 0; j < mass.Length - i - 1; j++)
                    {
                        if (mass[j + 1] > mass[j])
                        {
                            temp = mas[j + 1];
                            mass[j + 1] = mas[j];
                            mass[j] = temp;
                        }
                    }
                }
            }
            return mass;
        }

        private static string Print(int[] mass)
        {
            StringBuilder result = "";
            foreach (int i in mass)
            {
                result.Append(Convert.ToString(i) + " ");
            }
            return result;
        }
    }
}
