
List<int> list = [1, 2, 3, 4, 25, 6, 7, 8, 9];

var sum = list.MyAggregate(0, (a, i) => a + i);
var max = list.MyAggregate(0, (a, i) => i > a ? i : a);

Console.WriteLine(max);