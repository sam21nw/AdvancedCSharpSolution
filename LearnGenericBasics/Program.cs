using ExtensionMethods;

IEnumerable<int> numbers = Enumerable.Range(1, 100);
IEnumerable<int> w = MyExtensions.MyWhere(numbers, n => n % 2 == 0);

List<Person> people =
[
    new Person("Ruby", "Jake", 32),
    new Person("Fizz", "Rock", 27),
    new Person("Magog", "Truth", 45),
];

IEnumerable<string?> fNames = MyExtensions.MyMap(people, p => p.FirstName);

//foreach (int n in w)
//    Console.WriteLine(n);

//foreach (string? n in fNames) {
//    Console.WriteLine(n);
//}

//Console.WriteLine(f);

//int f = MyExtensions.MyFirst(numbers, n => n % 2 == 0);
//Console.WriteLine(f);

int count = MyExtensions.MyCount(numbers, n => n % 2 == 0);
Console.WriteLine(count);
Console.ReadLine();

//IEnumerator<int> enumerator = numbers.GetEnumerator();
//enumerator.MoveNext();
//Console.WriteLine(enumerator.Current);

class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public Person(string fName, string lName, int age)
    {
        FirstName = fName;
        LastName = lName;
        Age = age;
    }
}