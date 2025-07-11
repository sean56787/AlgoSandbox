using p1.func.pre;

namespace p1.entry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "1 + 2 * ( 3 - 4 ) / 5";
            string prefix = pre.InfixToPrefix(input);
            double res1 = pre.Anser(prefix);
            Console.WriteLine("infix: " + input);
            Console.WriteLine("prefix: " + prefix);
            Console.WriteLine("res: " + res1 + "\n");

            string input2 = "(1 + 2) * (3 + 4)";
            string prefix2 = pre.InfixToPrefix(input2);
            double res2 = pre.Anser(prefix2);
            Console.WriteLine("infix: " + input2);
            Console.WriteLine("prefix: " + prefix2);
            Console.WriteLine("res: " + res2 + "\n");

            string input3 = "5 + ((1 + 2) * 4) - 3";
            string prefix3 = pre.InfixToPrefix(input3);
            double res3 = pre.Anser(prefix3);
            Console.WriteLine("infix: " + input3);
            Console.WriteLine("prefix: " + prefix3);
            Console.WriteLine("res: " + res3 + "\n");
        }
    }

}

