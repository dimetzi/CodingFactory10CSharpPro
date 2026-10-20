namespace ifUseCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string? firstName = "John";

            if (age >= 18)
            {
                Console.WriteLine("Enhlikos");
            }
            else
            {
                Console.WriteLine("Anhlikos");
            }

            // Ternary operator for contidional assignment
            var status = age >= 18 ? "Enhlikos" : "Anhlikos";
            Console.WriteLine($"Status: {status}");

            // Null-coalescing operator for default value assignment
            var name = firstName ?? "Unknown"; // (firstname is null) ? "Unknown" : firstName;

            // Null-coalescing assignment operator for safe member access
            var nameLength = firstName?.Length ?? 0; // (firstname is null) ? 0 : firstName.Length;
        }
    }
}
