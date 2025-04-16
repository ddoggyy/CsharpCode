namespace CS0409
{
    internal class Program
    {
    class Test
        {
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++) output += i;
                return output;
            }

            public int Multiply(int min, int max)
            {
                int output = 1;
                for (int i = min; i <= max; i++) output *= i;
                return output;
            }

            public static int Abs(int input)
            {
                if (input < 0) return -input;
                else return input;
            }

            public static double Abs(double input)
            {
                if (input < 0) return -input;
                else return input;
            }

            public static long Abs(long input)
            {
                if (input < 0) return -input;
                else return input;
            }
        }

        
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));
            Console.WriteLine(test.Multiply(1, 10));

            Console.WriteLine(Test.Abs(52));
            Console.WriteLine(Test.Abs(-273));

            Console.WriteLine(Test.Abs(52.273));
            Console.WriteLine(Test.Abs(-32.103));

            Console.WriteLine(Test.Abs(21474836470));
            Console.WriteLine(Test.Abs(-21474836470));

        }
    }
}
