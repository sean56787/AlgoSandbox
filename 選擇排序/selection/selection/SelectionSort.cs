using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection.SelectionSort
{
    internal class SelectionSort
    {
        public string sort(int[] input)
        {
            int n = input.Length;
            for(int i = 0; i < n; i++)
            {
                var min = i; //假設目前的是最小值
                for(int j = i; j < n; j++)
                {
                    if (input[j] < input[min]) //遇到最小的紀錄起來
                        min = j;
                }
                if(i!=min) // 最後與最小交換
                    Swap(input, i, min);
            }

            return String.Join(" ", input);
        }
        public void Swap(int[] arr,int a,int b)
        {
            int tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }
    }
}
