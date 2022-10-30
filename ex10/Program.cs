int NumberN = new Random().Next(100,999);
Console.WriteLine($"Ввод трёхзначного числа {NumberN}");
int result = (NumberN%100)/10;
Console.WriteLine (result);