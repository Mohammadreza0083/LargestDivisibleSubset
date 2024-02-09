namespace LargestDivisibleSubset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your array lenght :");
            int InputLenght = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[InputLenght];
            for (int i = 0; i < InputLenght; i++)
            {
                Console.WriteLine("Enter your num : ");
                input[i]= Convert.ToInt32(Console.ReadLine());
            }
            IList<int> result = LargestDivisibleSubset.LargestDivisibleSub(input);
            Console.WriteLine("Largest Divisible Subset: [" + string.Join(", ", result) + "]");
        }
    }
}
