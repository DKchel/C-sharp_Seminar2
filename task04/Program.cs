Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine($"Число {num2} кратно числу {num1}");
}
else
{
    Console.WriteLine($"Число {num2} не кратно числу {num1}");
    // Console.Write($"Остаток от деления числа {num1} на число {num2} равен: ");  - мой вариант
    // Console.Write(num1 % num2); - мой вариант
    Console.WriteLine($"Остаток от деления числа {num1} на число {num2} равен: {num1 % num2}");
}