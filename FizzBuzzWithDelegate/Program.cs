using System.Diagnostics;

using Delegates;

var timer = new Stopwatch();
timer.Start();

FizzBuzz.Run(FBOutput, 1, 100);

timer.Stop();

TimeSpan timeTaken = timer.Elapsed;
Console.WriteLine("Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));

static void FBOutput(string output)
{
    Console.WriteLine(output);
}

