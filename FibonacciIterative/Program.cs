namespace FibonacciIterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Fibonacci(10) = {Fibonacci(10)}");
        }

        public static int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            int a = 0, b = 1, c = 1;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        public static int FibonacciWithArray(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;

            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }

        public static int FibonacciRecursive(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
