List<int> intList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16];

Func<int, bool> predicate = n => n % 3 == 0;

IEnumerable<int> ListMod3 = Filter(intList, predicate);

foreach (int item in ListMod3) {
    Console.WriteLine(item);
}

static IEnumerable<T> Filter<T>(List<T> source, Func<T, bool> predicate)
{
    foreach (T item in source) {
        if (predicate(item)) {
            yield return item;
        }
    }
}