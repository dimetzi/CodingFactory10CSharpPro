namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            // Swap by value
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            Swap(a, b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");
            // Now swap by reference
            SwapRef(ref a, ref b);
            Console.WriteLine($"After swap (by reference): a = {a}, b = {b}");
        }
        //Pass by value - does not swap the values of a and b in the calling method
        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //Pass by reference
        public static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static (int, int) SwapWithTuple(int a, int b)
        {
            return (b, a);
        }
    }
}