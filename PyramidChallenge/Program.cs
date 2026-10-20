namespace PyramidChallenge
{
    /// <summary>
    /// Ο χρήστης εισαγε το υψος της πυραμιδας
    /// και το προγραμμα εμφανιζει την πυραμιδα με αστερακια
    /// Για παραδειγμα, αν ο χρηστης εισαγει 5, η εξοδος θα ειναι :
    ///     *
    ///    ***
    ///   *****
    ///  *******
    /// **********
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the pyramid: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
