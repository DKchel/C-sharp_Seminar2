


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine($"Число {num} кратно 7 и 23");
}
else if ((num % 7 == 0) && (num % 23 != 0))
{
    Console.WriteLine($"Число {num} кратно 7, но не кратно 23");
}
else if ((num % 7 != 0) && (num % 23 == 0))
{
    Console.WriteLine($"Число {num} кратно 23, но не кратно 7");
}
else
{
    Console.WriteLine($"Число {num} не кратно 7 и не кратно 23");
}