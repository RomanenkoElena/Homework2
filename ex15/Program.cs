// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int numberN = new Random().Next(0, 9);
Console.WriteLine($"Ввод цифры {numberN}");

if (numberN > 0 && numberN < 8) 
{
    if (numberN == 6 || numberN == 7)
    {
        Console.WriteLine("Этот день выходной");
    } 
    else 
    {
        Console.WriteLine("Этот день не является выходным");
    }
} 
else 
{
    Console.WriteLine("Такого дня недели нет");
}