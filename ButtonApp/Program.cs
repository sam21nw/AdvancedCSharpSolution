
Func<int, bool> predicate = IsMod3;

bool IsMod3(int arg)
{
    return arg % 3 == 0;
}

IEnumerable<int> Filter(IEnumerable<int> source, Func<int, bool> predicate)
{
    List<int> result = [];

    foreach (var item in result)
    {
        if (predicate(item))
        {
            result.Add(item);
        }
    }
    return result;
}