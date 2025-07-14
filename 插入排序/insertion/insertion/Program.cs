public class Program
{
    public static string sort(int[] input)
    {
        
        int n = input.Length;
        for(int i = 1; i < n; i++)
        {
            int index = input[i];
            int j = i - 1;
            while (j >= 0 && index < input[j])
            {
                input[j + 1] = input[j];
                j--;
            }
            input[j+1] = index;
        }

        return String.Join(" ", input);
    }

    public void Swap(int[] arr, int a, int b)
    {

    }
    public static void Main(string[] arg)
    {
        int[] arr = { 1,-1,2,-10,9,12,5,4,3,100 };
        string anser = sort(arr);
        Console.WriteLine(anser);
    }
}