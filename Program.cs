// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.Write("Введите вторе число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} больше, чем {num2}");
// }
// else if (num2 > num1)
// {
//     Console.WriteLine($"{num2} больше, чем {num1}");
// }
// else
// {
//     Console.WriteLine($"{num1} и {num2} равны");
// }

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine());

// int max = num1;

// if (num2 > max)
// {
// max = num2;
// }

// if (num3 > max)
// {
// max = num3;
// }
// Console.WriteLine($"Максимальное число: {max}");

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

        
// Console.Write("Введите число: ");

// int num = int.Parse(Console.ReadLine());

// if (num % 2 == 0)  // Проверяем, если остаток равен 0, то число является четным.
// {
// Console.WriteLine($"{num} - четное число.");
// }
// else
// {
// Console.WriteLine($"{num} - нечетное число.");
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число N: ");
            
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
            
if (i % 2 == 0) // Проверяем, чётное число или нет.
{
Console.WriteLine($"Чётные числа: {i}");
}
       