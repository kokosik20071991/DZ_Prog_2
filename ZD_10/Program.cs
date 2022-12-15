int a;
Console.Write("Введите трехзначное число: ");
int.TryParse(Console.ReadLine()!, out a);
System.Console.WriteLine(); 

System.Console.WriteLine($"Второй цифрой числа {a} является {a / 10 % 10} ");

System.Console.WriteLine(); 
