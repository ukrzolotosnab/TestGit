//Грузовой самолет должен пролететь с грузом из пункта А в пункт С через пункт В. Емкость бака для топлива у самолета — 300 литров.
//    Потребление топлива на 1 км в зависимости от веса груза у самолета следующее: ¦ до 500 кг — 1 литров / км; ¦ до 1000 кг — 4 литров / км; 
//¦ до 1500 кг — 7 литров / км; ¦ до 2000 кг — 9 литров / км; ¦ более 2000 кг — самолет не поднимает.
//    Пользователь вводит расстояние между пунктами А и В, и расстояние между пунктами В и С, а также вес груза. 
//    Программа должна рассчитать какое минимальное количество топлива необходимо для дозаправки самолету в пункте В, чтобы долететь из пункта А в пункт С.
//    В случае невозможности преодолеть любое из расстояний — программа должна вывести сообщение о невозможности полета по введенному маршруту.

//Console.WriteLine("Enter distance from A to B:");
//double.TryParse(Console.ReadLine(), out double distanceAB);
//Console.WriteLine("Enter distence from B to C:");
//double.TryParse(Console.ReadLine(), out double distanceBC);
//Console.WriteLine("Enter weight of goods:");
//double.TryParse(Console.ReadLine(), out double weight);

//const int tank = 300;
//int fuelConsumption;
//if (weight < 500) fuelConsumption = 1;
//else if (weight < 1000) fuelConsumption = 4;
//else if (weight < 1500) fuelConsumption = 7;
//else if (weight < 2000) fuelConsumption = 9;
//else fuelConsumption = -1;
//if (fuelConsumption == -1)
//    Console.WriteLine("Can't carry this weight");
//else
//{
//    double fuelAB = distanceAB * fuelConsumption;
//    double fuelBC = distanceBC * fuelConsumption;
//    if (fuelAB > tank || fuelBC > tank)
//        Console.WriteLine("Insufficient fuel");
//    else
//    {
//        double refuel = fuelAB + fuelBC - tank;
//        Console.WriteLine(refuel <= 0 ? "Don't need to refuel" : $"You need to refuel {refuel} liters");
//    }
//}


//Зарплата менеджера составляет 200$ + процент от продаж, продажи до 500$ - 3%, от 500 до 1000 – 5%, свыше 1000 – 8%.
//Пользователь вводит с клавиатуры уровень продаж для трех менеджеров. 
//Определить их зарплату, определить лучшего менеджера, начислить ему премию 200$, вывести итоги на экран.
//Console.WriteLine("Write first level of sales:");
//double.TryParse(Console.ReadLine(), out double sales1);
//Console.WriteLine("Write second level of sales:");
//double.TryParse(Console.ReadLine(), out double sales2);
//Console.WriteLine("Write thirth level of sales:");
//double.TryParse(Console.ReadLine(), out double sales3);

//const int salary = 200;
//const int bonus = 200;
//double percent1, percent2, percent3;
//percent1 = sales1 < 500 ? 3 : sales1 < 1000 ? 5 : 8;
//percent2 = sales2 < 500 ? 3 : sales2 < 1000 ? 5 : 8;
//percent3 = sales3 < 500 ? 3 : sales3 < 1000 ? 5 : 8;
//double total1 = sales1 * percent1 / 100 + salary;
//double total2 = sales2 * percent2 / 100 + salary;
//double total3 = sales3 * percent3 / 100 + salary;
//if (total1 > total2 && total1 > total3) total1 += bonus;
//else if (total2 > total1 && total2 > total3) total2 += bonus;
//else total3 += bonus;
//Console.WriteLine($"First manager revenue: {total1 + bonus}$");
//Console.WriteLine($"Second manager revenue: {total2 + bonus}$");
//Console.WriteLine($"Third manager revenue: {total3 + bonus}$");







//Разработать программу, которая выводит на экран линию из символов.
//Число символов, какой использовать символ, и какая будет линия — вертикальная, или горизонтальная — указывает пользователь.
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}
Console.WriteLine("Enter line type: 1--Vertical, 2--Horizontal");
int.TryParse(Console.ReadLine(), out int lineType);
Console.WriteLine("Enter line length");
int.TryParse(Console.ReadLine(), out int length);
Console.WriteLine("Enter symbol");
char.TryParse(Console.ReadLine(), out char symbol);
if(lineType == 1)
{
    for (int i = 0; i < length; i++) Console.WriteLine(symbol);
}
else if (lineType == 2)
{
    for (int j = 0; j < length; j++) Console.Write(symbol);
        
}
else Console.WriteLine("Incorrect action");


    
    



//var i = 0;

//for (Console.WriteLine("Начало выполнения цикла"); i < 10; Console.WriteLine($"i = {i}"))
//{
//    i++;
//}
