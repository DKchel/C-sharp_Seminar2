// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);

int digit1 = num / 100;
int digit3 = num % 10;

int result = digit1 * 10 + digit3;

Console.WriteLine(num);
Console.WriteLine(result);
