int[] numbers = [3, 2, 1, 5, 12, 17, 8];

IntPredicate predicate = IsMod3;
predicate += IsMod5;
IEnumerable<int> filteredList = Filter(numbers, predicate);

static bool IsMod3(int num)
{
    return num % 3 == 0;
}
static bool IsMod5(int num)
{
    return num % 5 == 0;
}
static void DisplayToConsole(IEnumerable<int> list)
{
    foreach (var item in list) {
        Console.WriteLine(item);
    }
}
static void DisplayEach(int num)
{
    Console.WriteLine(num);
}

static IEnumerable<int> Filter(IEnumerable<int> arr, IntPredicate predicate)
{
    List<int> list = [];
    DisplayEachDel displayEach = DisplayEach;

    foreach (var item in arr) {
        displayEach(item);
        if (predicate(item)) {
            list.Add(item);
        }
    }
    return list;
}

delegate bool IntPredicate(int number);
delegate void DisplayDel(IEnumerable<int> list);
delegate void DisplayEachDel(int num);
