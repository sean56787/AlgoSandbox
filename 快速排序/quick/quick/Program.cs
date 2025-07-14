public class Program
{
    static void sort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int pivot = arr[(left + right) / 2];
        int index = partition(arr, left, right, pivot);
        sort(arr, left, index - 1);
        sort(arr, index, right);
    }

    static int partition(int[] arr, int left, int right,int pivot)
    {
        while(left <= right)
        {
            while (arr[left] < pivot) left++;
            while (arr[right] > pivot) right--;

            if (left <= right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
        }
        return left;
    }
    static void Main(string[] args)
    {
        int[] arr = { 100, 5, 4, 3, 2, 1, -1, -99 };
        sort(arr, 0, arr.Length-1);
        Console.WriteLine(string.Join(" ", arr));
    }
}