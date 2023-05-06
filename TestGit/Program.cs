//Грузовой самолет должен пролететь с грузом из пункта А в пункт С через пункт В. Емкость бака для топлива у самолета — 300 литров.
//    Потребление топлива на 1 км в зависимости от веса груза у самолета следующее: ¦ до 500 кг — 1 литров / км; ¦ до 1000 кг — 4 литров / км; 
//¦ до 1500 кг — 7 литров / км; ¦ до 2000 кг — 9 литров / км; ¦ более 2000 кг — самолет не поднимает.
//    Пользователь вводит расстояние между пунктами А и В, и расстояние между пунктами В и С, а также вес груза. 
//    Программа должна рассчитать какое минимальное количество топлива необходимо для дозаправки самолету в пункте В, чтобы долететь из пункта А в пункт С.
//    В случае невозможности преодолеть любое из расстояний — программа должна вывести сообщение о невозможности полета по введенному маршруту.

Console.WriteLine("Enter distance from A to B:");
double.TryParse(Console.ReadLine(), out double distanceAB);
Console.WriteLine("Enter distence from B to C:");
double.TryParse(Console.ReadLine(), out double distanceBC);
Console.WriteLine("Enter weight of goods:");
double.TryParse(Console.ReadLine(), out double weight);

const int tank = 300;
int fuelConsumption;
if (weight < 500) fuelConsumption = 1;
else if (weight < 1000) fuelConsumption = 4;
else if (weight < 1500) fuelConsumption = 7;
else if (weight < 2000)  fuelConsumption = 9; 
else fuelConsumption = -1;
if (fuelConsumption == -1)
    Console.WriteLine("Can't carry this weight");
else
{
    double fuelAB = distanceAB * fuelConsumption;
    double fuelBC = distanceBC * fuelConsumption;
    if (fuelAB > tank || fuelBC > tank)
        Console.WriteLine("Insufficient fuel");    
    else
    {
        double refuel = fuelAB + fuelBC - tank;
        Console.WriteLine(refuel <= 0 ? "Don't need refuel" : $"You need to refuel {refuel} liters");
    }
} 

