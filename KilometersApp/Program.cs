namespace KilometersApp
{
    /// <summary>
    /// Reads a distance in kilometers from the console and converts it
    /// to meters, centimeters and miles, then prints the result,
    /// formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Δήλωση και αρχικοποίηση μεταβλητών
            const double METERS_PER_KM  = 1000.0;
            const double CM_PER_KM      = 100_000.0;
            const double MILES_PER_KM   = 0.621371;

            double kilometers = 0.0;
            double meters = 0.0;
            double centimeters = 0.0;
            double miles = 0.0;

            // Εισαγωγή δεδομένων από τον χρήστη, data binding και validation.

            Console.WriteLine("Eisagete thn apostash se xiliometra");
            if (!double.TryParse(Console.ReadLine(), out kilometers) || kilometers <0)
            {
                Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος δεκαδικός αριθμός.");
                return;
            }


            // Μετατροπη/ Υπολογισμοί
            meters = kilometers * METERS_PER_KM;
            centimeters = kilometers * CM_PER_KM;
            miles = kilometers * MILES_PER_KM;

            // Εκτύπωση αποτελεσμάτων
            Console.WriteLine($"{"Απόσταση σε μέτρα:",-30} {meters:N2}");
            Console.WriteLine($"{"Απόσταση σε εκατοστόμετρα:",-30} {centimeters:N2}");
            Console.WriteLine($"{"Απόσταση σε μίλια:",-30} {miles:N2}");
        }
    }
}
