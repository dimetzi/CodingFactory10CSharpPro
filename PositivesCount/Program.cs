namespace PositivesCount
{   
    /// <summary>
    /// Μετράει το πλήθος των θετικών αριθμών που εισάγει
    /// ο χρήστης μέχρι να εισάγει το 0.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Parakalw eisagete enan arithmo:");

            while (int.TryParse(Console.ReadLine(), out int num) && num != 0)
            {
                if (num > 0) count++;
                Console.WriteLine("Parakalw eisagete enan arithmo:");
            }
            Console.WriteLine($"Plithos thetikwn arithmwn: {count}");
        }
    }
}
