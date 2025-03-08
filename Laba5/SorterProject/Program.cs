using ConsoleApp1;

namespace SorterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 1, 5, 3 };
            Sorter sorter = new();
            Sorter.CombSort(arr);
            Console.WriteLine(Sorter.Print(arr));
        }
    }
}
