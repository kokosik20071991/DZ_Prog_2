Console.Clear();
Console.WriteLine();
int Day = new Random().Next(1, 8);
Console.WriteLine();
Console.WriteLine($"Дано число: {Day}");
if (Day==6|| Day==7) Console.WriteLine("Это Выходной!!!");
else
 Console.WriteLine("Рабочий!");