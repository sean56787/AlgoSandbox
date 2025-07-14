using sort.BubbleSort;

namespace entry.program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] chars = { 7, 6, 5, 4, 3, 2, 1 };
            BubbleSort b = new BubbleSort();
            string anser = b.sort(chars);
            Console.WriteLine(anser);
        }
    }
}