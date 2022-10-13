/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/*
Console.Write("Input int number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input int number b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"The maximum number - 'a' ({a}). The number 'b' is less ({b})");
}
else
{
    Console.WriteLine($"The maximum number - 'b' ({b}). The number 'a' is less ({a})");
}
*/


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */

/*
Console.Write("Input int number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input int number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input int number c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    if (a>c)
    {
        Console.Write($"The maximum number - 'a' ({a})");
    }
    else 
    {
        Console.Write($"The maximum number - 'c' ({c})");
    }
}
else
{
    if (b>c)
    {
        Console.Write($"The maximum number - 'b' ({b})");
    }
    else 
    {
        Console.Write($"The maximum number - 'c' ({c})");
    }
}
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет  */

/*
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;
if (result == 1)
{
    Console.Write($"Число {num} является нечетным");
}
else
{
    Console.Write($"Число {num} является четным");
}
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8  */


Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int result = 2; result <= num; result = result +2)
{
    Console.WriteLine(result);
}
