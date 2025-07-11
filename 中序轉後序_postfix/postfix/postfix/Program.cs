using postfix;

namespace entry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "1 + 2 * ( 3 - 4 ) / 5";
            string post = postfix.post.InfixToPostfix(input);
            double res1 = postfix.post.Anser(post);
            Console.WriteLine("infix: " + input);
            Console.WriteLine("postfix: " + post);
            Console.WriteLine("res: " + res1 + "\n");
        }
    }
}
