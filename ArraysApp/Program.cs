namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;

            int[] arr2 = { 1, 2, 3, 4, 5 };

            int[] arr3;
            arr3 = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            foreach (var num in arr2)
            {
                Console.WriteLine(num);
            }

            //2D array
            int[,] arr4 = new int[2, 3];

            int[,] arr5 = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    Console.WriteLine(arr5[i, j]);
                }
            }

            //Array methods
            int[] ints = { 5, 3, 8, 1, 2 };

            Array.Sort(ints); // Sorts the array in ascending order
            Array.Reverse(ints); // Reverses the array

            int elementToFind = 3;
            int index = Array.IndexOf(ints, elementToFind); // Finds the index of the element
            if (index == -1)
            {
                Console.WriteLine($"Element {elementToFind} not found in the array.");

            }
            else
            {
                Console.WriteLine($"Element {elementToFind} found at index {index}.");
            }

            int[] copy = new int[ints.Length];
            Array.Copy(ints, copy, ints.Length); // Copies the array to another array
        }

        public static int GetMinPosition(int[] arr)
        {
            int minPosition = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minPosition)
                {
                    minPosition = i;
                }
            }
            return minPosition;
        }
        // Palindrome with while
        public static bool IsPalindromeWhile(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static bool IsPalindromeFor(int[] arr)
        {
            for (int i = 0,  j = arr.Length - 1; i < j; i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
