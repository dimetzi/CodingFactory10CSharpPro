namespace ProductsVat
{   
    /// <summary>
    /// Reads a product price from the console, 
    /// calculates the VAT amount (24%) and the total price,
    /// and prints the results formatted to 2  decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
   

            //Declare and initialize variables
            const double VAT_RATE = 0.24;
            double price = 0.0;
            double vatAmount = 0.0;
            double totalPrice = 0.0;


            //Data input, data binding and validation.
            Console.WriteLine("Enter the product price:");
            if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("The value you entered is not a valid decimal number.");
                return;
            }


            //Calculate VAT and total price.
            vatAmount = price * VAT_RATE;
            totalPrice = price + vatAmount;


            //Print results.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Product Price: ${price:F2} €");
            Console.WriteLine($"VAT Amount: ${vatAmount:F2} €");
            Console.WriteLine($"Total Price: ${totalPrice:F2} €");
        }
    }
}
