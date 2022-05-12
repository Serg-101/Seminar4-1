/* Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число = ");
string strNum = Console.ReadLine();
if (strNum.Length  == 3)
{
    Console.WriteLine($"Вторая цифра этого числа = {strNum[1]}");
}
else
{
    System.Console.WriteLine("Не корректный ввод!");
}
System.Console.ReadKey();
