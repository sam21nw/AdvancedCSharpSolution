
var fb = new FizzBuzz();

FizzBuzzOutput fbo = Console.WriteLine;
fbo += Console.WriteLine;

FizzBuzz.Run(Console.WriteLine, 20);

//static void ConsoleWrite(string output)
//{
//    Console.WriteLine(output);
//}

class FizzBuzz
{
    public static void Run(FizzBuzzOutput output, int n)
    {
        for (int i = 1;i < n;i++)
        {
            if (i % 3 == 0)
            {
                output.Invoke("Fizz");
            }
            if (i % 5 == 0)
            {
                output("Buzz");
            } else
            {
                output(i.ToString());
            }
        }
    }
}
public delegate void FizzBuzzOutput(string output);