using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort.BubbleSort
{
    internal class BubbleSort
    {
        public string sort(int[] input)
        {
            int n = input.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, j + 1);
                    }
                }
            }

            return String.Join(" ", input);
        }

        public void Swap(int[] arr, int a, int b)
        {
            int tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }
    }
}
