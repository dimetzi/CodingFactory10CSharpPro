using System.Text;

namespace NumberRead
{   
    /// <summary>
    /// Safe Reading float, double from console input.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            float floatnum = 0F;
            double doubleNum = 0D;

            Console.WriteLine("Εισάγεται δύο δεκαδικούς αριθμούς");

            if (!float.TryParse(Console.ReadLine(), out floatnum))
            {
                Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος δεκαδικός αριθμός.");
                return;
            }


            if (!double.TryParse(Console.ReadLine(), out doubleNum))
            {
                Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος δεκαδικός αριθμός.");
                return;
            }

            Console.WriteLine($"Ο δεκαδικός αριθμός float είναι: {floatnum, -10:N2}");
            Console.WriteLine($"Ο δεκαδικός αριθμός double είναι: {doubleNum, -10:N2}");
        }
    }
}
