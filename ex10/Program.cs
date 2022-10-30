//напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int NumberN = new Random().Next(100, 999);
Console.WriteLine($"Ввод трёхзначного числа {NumberN}");
int result = (NumberN % 100) / 10;
Console.WriteLine(result);