namespace LinqArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 9, 2, 12};

            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            double average = arr.Average();
            int count = arr.Count();
            int countGreaterThan4 = arr.Count(x => x > 4);

            var filtered = arr.Where(x => x > 4).ToArray();
            var doubled = arr.Select(x => x * 2).ToArray();
            var sorted = arr.OrderBy(x => x).ToArray();
            var sortedDesc = arr.OrderByDescending(x => x).ToArray();
            bool any = arr.Any(x => x > 10);
            bool all = arr.All(x => x > 0);
            int first = arr.First(x => x > 4);
        }
    }
}
