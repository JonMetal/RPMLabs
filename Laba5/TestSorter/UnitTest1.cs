

using ConsoleApp1;

namespace TestSorter
{
    public class UnitTest1
    {
        [Fact]
        public void SorterOnCombSort()
        {
            int[] arr = { 2, 4, 1, 5, 3 };
            Sorter sorter = new();
            Sorter.CombSort(arr);
            int[] arrCorrect = { 1, 2, 3, 4, 5 };
            Assert.Equal(arr, arrCorrect);
        }

        [Fact]
        public void SorterOnShillSort()
        {
            int[] arr = { 2, 4, 1, 5, 3 };
            Sorter.ShillSort(arr, arr.Length);
            int[] arrCorrect = { 1, 2, 3, 4, 5 };
            Assert.Equal(arr, arrCorrect);
        }

        [Fact]
        public void SorterOnBubbleSort()
        {
            int[] arr = { 2, 4, 1, 5, 3 };
            Sorter.BubbleSort(arr);
            int[] arrCorrect = { 1, 2, 3, 4, 5 };
            Assert.Equal(arr, arrCorrect);
        }

        [Fact]
        public void SorterOnPrint()
        {
            int[] arr = { 2, 4, 1, 5, 3 };
            Sorter.CombSort(arr);
            string correct = "1 2 3 4 5";
            string test = Sorter.Print(arr);
            Assert.Equal(correct, test);
        }
    }
}