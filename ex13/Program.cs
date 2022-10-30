// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int numberN = new Random().Next(0, 9999999);
Console.WriteLine($"Ввод числа {numberN}");
int result = 0;

if (numberN < 100)
{
    Console.WriteLine("Третьей цифры в числе нет");
}
else
{
    while (numberN >= 1000) numberN /= 10;
    result = numberN % 10;
    Console.WriteLine($"Третья цифра в числе {result}");
}