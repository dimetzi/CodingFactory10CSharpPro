namespace FormatExceptionApp
{
    /// <summary>
    /// Διαβάζει ενα string απο την κονσόλα
    /// και προσπαθεί να το μετατρέψει σε ακεραιο αριθμό με Parse
    /// και θα ελεγξει με try-catch για FormatException.
    /// 
    /// Στη C# δεν υπαρχουν checked kai unchecked exceptions,
    /// οπότε δεν είναι υποχρεωτικό να χρησιμοποιήσουμε try-catch.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Parakalw eisagete enan arithmo:");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"O arithmos einai: {num}");
                    if (num == 0) break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
