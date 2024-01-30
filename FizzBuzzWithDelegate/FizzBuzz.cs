namespace Delegates;
public class FizzBuzz
{
    //public delegate void FizzBuzzOutput(string output);

    public static void RunAction(Action<string> output, int from, int count)
    {
        string[] returnList = ["1", "Buzz", "Fizz", "FizzBuzz"];
        foreach (int i in Enumerable.Range(from, count)) {
            returnList[0] = i.ToString();
            Console.WriteLine(returnList[(2 * Convert.ToInt32(i % 3 == 0)) + Convert.ToInt32(i % 5 == 0)]);
        }
    }
}

//Action<List<string>> print = Print;
//FizzBuzz(Print, 1, 100);

////List<string> list = [string.Empty, "Buzz", "Fizz", "FizzBuzz"];

////print(list);

//static void FizzBuzz(Action<List<string>> output, int from, int count)
//{
//    string[] returnList = [string.Empty, "Buzz", "Fizz", "FizzBuzz"];
//    List<string> list = new List<string>();
//    string result = string.Empty;
//    foreach (int i in Enumerable.Range(from, count)) {
//        returnList[0] = $"{i}";
//        //Console.WriteLine(returnList[(2 * Convert.ToInt32(i % 3 == 0)) + Convert.ToInt32(i % 5 == 0)]);
//        result = returnList[(2 * Convert.ToInt32(i % 3 == 0)) + Convert.ToInt32(i % 5 == 0)];
//        list.Add(result);
//    }
//    output(list);
//}

//static void Print(List<string> list)
//{
//    foreach (string item in list) {
//        Console.WriteLine(item);
//    }
//}