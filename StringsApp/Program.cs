namespace StringsApp
{   
    /// <summary>
    /// Strings are immutable and are intered.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str1 = "Hello";
            string? str2 = "Hello";
            string? str3 = new string("Hello");

            Console.WriteLine(str1[0]);
            Console.WriteLine(str2[0]);
            Console.WriteLine(str3[0]);

            //String equality
            Console.WriteLine(str1 == str2); //True == is overloaded for strings
            Console.WriteLine(str1.Equals(str2)); //True, with Equals method

            //Reference equality
            Console.WriteLine(object.ReferenceEquals(str1, str2)); //True because of string interning
            Console.WriteLine(object.ReferenceEquals(str1, str3)); //False, different objects

            //Compare strings
            Console.WriteLine(string.Compare(str1, str2));  // 0, because they are equal
            Console.WriteLine(str1.CompareTo(str2));        // 0, because they are equal
            int resultEqualsIsIgnoreCase = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase) ? 0 : -1; // 0, because they are equal ignoring case

            //concatenation
            string str4 = str1 + " World"; //Concatenation
            string str5 = string.Concat(str1, " World"); //Concatenation

            // toUpper and toLower
            string str6 = str1.ToUpper(); //HELLO
            string str7 = str1.ToLower(); //hello

            Console.WriteLine(str1.ToUpper() == str2.ToUpper()); //Normalized comparison, True
            
            //Substring
            string str8 = str1.Substring(1, 3); // "ell"
            string str9 = str1.Substring(1);    // "ello"

            //C# 8.0 introduced ranges and indices
            // which can be used to extract substrings in a more concise way
            string? sunStr = str1[..2];
            string? endStr = str1[2..];
            string? midStr = str1[1..4];

            //Trim
            string str10 = "   Hello World   ";
            string? trimmedStr = str10.Trim(); // "Hello World"

            string? str11 = "   %Hello World #  ";

            char[] charsToTrim = { ' ', '$', '%', '#' };
            string? trimmedStr2 = str11.Trim(charsToTrim); // "Hello World"
        }
    }
}
