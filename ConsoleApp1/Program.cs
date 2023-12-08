using System.Text;

namespace WordNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type A 4 Digit Number");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Numbers.WordNums(numbers));
        }
    }
}
