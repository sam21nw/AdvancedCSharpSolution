namespace Delegates;
public class FizzBuzz
{
    public delegate void FizzBuzzOutput(string output);
    public static void Run(FizzBuzzOutput output, int from, int count)
    {
        string[] returnList = ["1", "Buzz", "Fizz", "FizzBuzz"];
        foreach (int i in Enumerable.Range(from, count)) {
            returnList[0] = i.ToString();
            Console.WriteLine(returnList[(2 * Convert.ToInt32(i % 3 == 0)) + Convert.ToInt32(i % 5 == 0)]);
        }
    }
}

