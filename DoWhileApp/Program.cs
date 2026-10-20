using System.Runtime.InteropServices;

namespace DoWhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numberOfDigits = 0;
            int tmp = 0;

            Console.WriteLine("Parakalw eisagete enan arithmo:");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Parakalw eisagete enan egkuro arithmo.");
                return;
            }

            tmp = num;
            do
            {
                tmp /= 10;
                numberOfDigits++;
            } while (tmp != 0);

            Console.WriteLine($"O arithmos {num} exei {numberOfDigits} pshfia.");
        }
    }
}
