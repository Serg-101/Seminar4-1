/* Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите номер дня недели = ");
int dayOfWeek = int.Parse(Console.ReadLine());
if (Enumerable.Range(1, 7).Contains(dayOfWeek)) // check if is in range
    if (dayOfWeek > 5)
        Console.WriteLine($"{dayOfWeek} -> да, это выходной день!");
    else
        Console.WriteLine($"{dayOfWeek} -> нет, это будний день.");
else
    System.Console.WriteLine("Не корректный ввод!");
System.Console.ReadKey();