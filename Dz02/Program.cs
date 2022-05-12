/* Задача 3: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число = ");
string strNum = Console.ReadLine();
if (strNum.Length  > 2)
    Console.WriteLine($"{strNum} -> {strNum[2]}");
else
    Console.WriteLine($"{strNum} -> Третьей цифры нет");
System.Console.ReadKey();


