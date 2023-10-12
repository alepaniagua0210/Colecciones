HashSet<int> evenNumbers = new HashSet<int>();  
HashSet<int> oddNumbers = new HashSet<int>();

for (int i = 0; i < 5; i++) 
{
    evenNumbers.Add(i * 2);
    oddNumbers.Add((i * 2) + 1);
}

Display("Even numbers ", evenNumbers);

void Display(string tittle, HashSet<int> numbers)
{
    Console.WriteLine(tittle);

    foreach (var item in numbers)
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine();
}

//evenNumbers.Add(8);

Display("Even numbers ", oddNumbers);


HashSet<int> numbers = new HashSet<int>(evenNumbers);

numbers.UnionWith(oddNumbers);

Display("All numbers ", numbers);