namespace p1.func.pre
{
    public class pre
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
        public static void PopAndCombine(Stack<string> oprs, Stack<char> opts)
        {
            try
            {
                string a = oprs.Pop();
                string b = oprs.Pop();
                char opt = opts.Pop();
                oprs.Push(opt + " " + a + " " + b);
                return;
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static bool IsOpts(char c)
        {
            return ("+-*/").Contains(c);
        }
        public static string InfixToPrefix(string input)
        {
            Stack<string> operands = new();
            Stack<char> opts = new();

            for(int i = input.Length-1; i >= 0; i--)
            {
                char c = input[i];
                if (c == ' ') continue;
                if (pre.IsDigit(c))
                {
                    operands.Push(c.ToString());
                }
                else if(c == ')')
                {
                    opts.Push(c);
                }
                else if (c == '(')
                {
                    while (operands.Count > 0 && opts.Peek() != ')')
                        pre.PopAndCombine(operands, opts);
                    if (operands.Count > 0)
                        opts.Pop();
                }
                else if (IsOpts(c))
                {
                    while (opts.Count > 0 && pre.Priority(opts.Peek()) > pre.Priority(c))
                        pre.PopAndCombine(operands, opts);
                    opts.Push(c);
                }
            }

            while (opts.Count > 0)
                PopAndCombine(operands, opts);

            return operands.Peek();
        }

        public static void Calculate(Stack<double> oprds, char c)
        {
            double a = oprds.Pop();
            double b = oprds.Pop();

            double res =  c switch
            {
                '*' => a * b,
                '/' => a / b,
                '+' => a + b,
                '-' => a - b,
                _ => throw new Exception("error opt"),
            };

            oprds.Push(res);
        }

        public static double Anser(string input)
        {
            Stack<double> oprds = new();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];
                if (c == ' ') continue;

                if (pre.IsDigit(c))
                {
                    oprds.Push(c - '0');
                }
                else if (pre.IsOpts(c))
                {
                    Calculate(oprds, c);
                }

            }

            return oprds.Pop();
        }
    }
}