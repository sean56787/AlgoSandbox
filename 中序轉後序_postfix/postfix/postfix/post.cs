using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postfix
{
    internal class post
    {
        public static int Priority(char c)
        {
            return c switch
            {
                '*' or '/' => 2,
                '+' or '-' => 1,
                _ => 0,
            };
        }
        public static bool IsDigit(char c)
        {
            return char.IsDigit(c);
        }
        public static bool IsOpts(char c)
        {
            return ("+-*/").Contains(c);
        }
        public static string InfixToPostfix(string input)
        {
            List<string> output = new();
            Stack<char> opts = new();
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var c in tokens)
            {
                if (double.TryParse(c, out _))
                {
                    output.Add(c);
                }
                else if (c == "(")
                {
                    opts.Push('(');
                }
                else if (c == ")")
                {
                    while (opts.Count > 0 && opts.Peek() != '(')
                        output.Add(opts.Pop().ToString());
                    if (opts.Count > 0 && opts.Peek() == '(')
                        opts.Pop();
                }
                else if (c.Length == 1 && IsOpts(c[0]))
                {
                    while (opts.Count > 0 && post.Priority(opts.Peek()) >= post.Priority(c[0]))
                        output.Add(opts.Pop().ToString());
                    opts.Push(c[0]);
                }
            }

            while (opts.Count > 0)
                output.Add(opts.Pop().ToString());

            return string.Join(" ", output);
        }

        public static void Calculate(Stack<double> oprds, char c)
        {
            double a = oprds.Pop();
            double b = oprds.Pop();

            double res = c switch
            {
                '*' => b * a,
                '/' => b / a,
                '+' => b + a,
                '-' => b - a,
                _ => throw new Exception("error opt"),
            };
            oprds.Push(res);
        }

        public static double Anser(string input)
        {
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<double> oprds = new();

            foreach (var c in tokens)
            {
                if (c == " ") continue;

                if (post.IsDigit(c[0]))
                {
                    oprds.Push(c[0] - '0');
                }
                else if (post.IsOpts(c[0]))
                {
                    Calculate(oprds, c[0]);
                }

            }

            return oprds.Peek();
        }
    }
}
