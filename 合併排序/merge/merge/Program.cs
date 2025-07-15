
public class Program 
{
    static void Main(string[] args)
    {
        int[] arr = { 6, 5, 4, 3, 2, 1,100,9,-2,-101 };
        sort(arr, 0, arr.Length - 1);
        Console.WriteLine(string.Join(" ", arr));
    }

    static void sort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int mid = (left + right) / 2;
        sort(arr, left, mid);
        sort(arr, mid + 1, right);
        merge(arr, left, mid, right);
    }

    static void merge(int[] arr, int left, int mid, int right)
    {
        int[] tmp = new int[right - left + 1];
        int i = left; //左指標
        int j = mid + 1; //右指標
        int k = 0; //新陣列指標

        while(i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                tmp[k++] = arr[i++];
            else
                tmp[k++] = arr[j++];
        }

        while (i <= mid)
        {
            tmp[k++] = arr[i++];
        }

        while(j <= right)
        {
            tmp[k++] = arr[j++];
        }

        for(int z = 0; z < tmp.Length; z++) //複製回原陣列
        {
            arr[left + z] = tmp[z];
        }
    }
}
