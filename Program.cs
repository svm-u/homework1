/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("больше {0}", a);
else if (a < b)
    Console.WriteLine("больше {0}", b);
else if (a == b)
    Console.WriteLine("числа равны");
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Max(a, Math.Max(b,c)));
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2==0)
    Console.WriteLine("четное");
else
    Console.WriteLine("нечетное");
*/

/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= num; i+=2)
    Console.Write(i + " ");
*/