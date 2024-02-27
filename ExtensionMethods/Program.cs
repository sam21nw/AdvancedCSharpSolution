
List<int> list1 = [1, 2, 3, 4, 25];
List<int> list2 = [6, 7, 8, 9];
List<int> list3 = [6, 7, 8, 11, 7];

var set = new HashSet<int>(list3);

foreach (var item in set)
{
    Console.WriteLine(item);
}

Action? whoa = () => { Console.WriteLine(""); };