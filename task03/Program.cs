// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

// int flag = 0;

// if (num1 == num2 * num2) flag = 1;
// else if (num2 == num1 * num1) flag = 1;

// if (flag == 1)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
if ((num1 == num2 * num2) || (num2 == num1 * num1))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}