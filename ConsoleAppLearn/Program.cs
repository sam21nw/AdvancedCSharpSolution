int[] list = [3, 1, 5, 8, 9, 12, 7];

List<List<int>> list1 = [];
Console.WriteLine(list1);

foreach (int item in ExtensionMethods.SquareBlock(ExtensionMethods.FilterBlock(list, 3))) {
    Console.WriteLine(item);
}

Console.WriteLine("-------------------");
Stuff<string>.Method("oops");

static class ExtensionMethods
{

    public static IEnumerable<int> SquareBlock(this IEnumerable<int> source)
    {
        foreach (int i in source) {
            yield return i * i;
        }
    }
    public static IEnumerable<int> FilterBlock(this IEnumerable<int> block, int num)
    {
        foreach (int item in block) {
            if (item % num == 0) {
                yield return item;
            }
        }
    }
}

static class Stuff<T>
{
    static readonly Func<T, Type> _action = Method; 
    public static Type? Method(T str)
    {
        return str?.GetType();
    }
    public static Func<T, Type> GetAction()
    {
        return _action;
    }
}