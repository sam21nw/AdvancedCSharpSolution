
var oops = new FizzBuzz(new ConsoleFizzOutput());
oops.Run(6, 100);

class ConsoleFizzOutput : IFizzOutput
{
    public void Write(string output)
    {
        Console.WriteLine(output);
    }
}

interface IFizzOutput
{
    void Write(string output);
}

class FizzBuzz
{
    private readonly IFizzOutput _output;
    public FizzBuzz(IFizzOutput output)
    {
        _output = output;
    }
    public void Run(int from, int count)
    {
        for (int i = from;i < from + count;i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                _output.Write("FizzBuzz");
            } else if (i % 3 == 0)
            {
                _output.Write("Fizz");
            } else if (i % 5 == 0)
            {
                _output.Write("Buzz");
            } else
            {
                _output.Write(i.ToString());
            }
        }
    }
}