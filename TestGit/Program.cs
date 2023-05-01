﻿//Грузовой самолет должен пролететь с грузом из пункта А в пункт С через пункт В. Емкость бака для топлива у самолета — 300 литров.
//    Потребление топлива на 1 км в зависимости от веса груза у самолета следующее: ¦ до 500 кг — 1 литров / км; ¦ до 1000 кг — 4 литров / км; 
//¦ до 1500 кг — 7 литров / км; ¦ до 2000 кг — 9 литров / км; ¦ более 2000 кг — самолет не поднимает.
//    Пользователь вводит расстояние между пунктами А и В, и расстояние между пунктами В и С, а также вес груза. 
//    Программа должна рассчитать какое минимальное количество топлива необходимо для дозаправки самолету в пункте В, чтобы долететь из пункта А в пункт С.
//    В случае невозможности преодолеть любое из расстояний — программа должна вывести сообщение о невозможности полета по введенному маршруту.

Console.WriteLine("Enter distance from A to B:");
double.TryParse(Console.ReadLine(), out double dis1);
Console.WriteLine("Enter distence from B to C:");
double.TryParse(Console.ReadLine(), out double dis2);
Console.WriteLine("Enter weight og goods:");
double.TryParse(Console.ReadLine(), out double goods);

if (goods <= 500 && dis1 <= 300)
{
    double refueling = 300.0 - dis1;
    Console.WriteLine($"You need have {refueling} liters of fuel");
}
else
    Console.WriteLine("It's not possible to fly this route");
