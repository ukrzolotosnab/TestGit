//Разработать программу, которая выводит на экран линию из символов.
//Число символов, какой использовать символ, и какая будет линия — вертикальная, или горизонтальная — указывает пользователь.


while (true)
{
    Console.Clear();
    Console.WriteLine("Enter line type: 1--Vertical, 2--Horizontal");
    int.TryParse(Console.ReadLine(), out int lineType);
    if (lineType < 1 || lineType > 2)
    {
        //Дублирование этого кода естественно неверно, но пока мы не знаем функции, то оставим так
        Console.WriteLine("Incorrect input\nPress any key to continue");
        Console.ReadKey();
        continue;
    }
    Console.WriteLine("Enter line length");
    int.TryParse(Console.ReadLine(), out int length);
    if (length <= 0)
    {
        Console.WriteLine("Incorrect input\nPress any key to continue");
        Console.ReadKey();
        continue;
    }
    Console.WriteLine("Enter symbol");
    bool hasValue = char.TryParse(Console.ReadLine(), out char symbol);
    if (!hasValue || char.IsWhiteSpace(symbol))
    {
        Console.WriteLine("Incorrect input\nPress any key to continue");
        Console.ReadKey();
        continue;
    }
    Console.Clear();
    if (lineType == 1)
        for (int i = 0; i < length; i++)
            Console.WriteLine(symbol);
    else
        for (int j = 0; j < length; j++)
            Console.Write(symbol);
    Console.WriteLine("Press Enter to continue, or any key for exit");
    var key = Console.ReadKey();
    if(key.Key != ConsoleKey.Enter)
        break;
}









