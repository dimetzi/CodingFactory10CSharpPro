using System.Globalization;

namespace PrintingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12_334_555;
            double dNum = 100.12345678901234567890;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Int-Num = {0, -10}, Double-num = {1, -20:N2}", num, dNum);
            Console.WriteLine($"Int-Num = {num, -10}, Double-num = {dNum, -20:N2}");
        }
    }
}
