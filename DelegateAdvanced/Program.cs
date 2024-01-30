int[] arr = [1, 2, 3, 4, 5, 6];

Func<int, bool> predicate = IsMod3;

IEnumerable<int>? filteredList = Filter(arr, predicate);

foreach (int item in filteredList) {
    Console.WriteLine(item);
}

static IEnumerable<int> Filter(IEnumerable<int> arr, Func<int, bool> predicate)
{
    List<int> list = [];
    foreach (var item in arr) {
        if (predicate(item)) {
            list.Add(item);
        }
    }
    return list;
}

static bool IsMod3(int num)
{
    return num % 3 == 0;
}

//delegate bool IntPredicate(int number);