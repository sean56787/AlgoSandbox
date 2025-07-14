using selection.SelectionSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] input = { 7, 8, 6, 9, 1, 4, 0, 2, 3, 15, 999, -1 };
        SelectionSort ss = new SelectionSort();

        string anser = ss.sort(input);
        Console.WriteLine(anser);
    }
}