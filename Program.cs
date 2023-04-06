Console.Clear();
Console.WriteLine("Задача 2: \n  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. \n" );

Console.WriteLine("Введите 1-е число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
    {
        Console.WriteLine($"число {num1} - большее!, число {num2} - меньшее!");
    }
else if (num2 > num1) 
    {
        Console.WriteLine($"число {num2} - большее!, число {num1} - меньшее!");
    }


System.Console.WriteLine("\n\nЗадача 4: \n  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. \n" );

Console.WriteLine("Введите 1-е число: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int num3 = int.Parse(Console.ReadLine());
int max = num1;

if (max < num2)
    {
        max = num2;
    }
if (max < num3) 
    {
        max = num3;
    }
Console.WriteLine($"максимальное число - {max}");

System.Console.WriteLine("\n\nЗадача 6: \n  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). \n" );

Console.WriteLine("Введите число: ");
num1 = int.Parse(Console.ReadLine());

if (num1 % 2 == 0)
    {
        Console.WriteLine($"число {num1} - четное");
    }
else 
    {
        Console.WriteLine($"число {num1} - нечетное");
    }

System.Console.WriteLine("\n\nЗадача 8: \n  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. \n" );

Console.Write("Введите число: ");
num1 = int.Parse(Console.ReadLine());

if (num1 % 2 == 0)
    {
        for (int i = 2; i <= num1; i += 2)
        Console.WriteLine(i);
    }
else 
    {
        for (int i = 2; i < num1; i += 2)
        Console.WriteLine(i);
    }