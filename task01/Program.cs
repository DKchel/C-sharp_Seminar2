int num = new Random().Next(10, 100);

int digit1 = num / 10;
int digit2 = num % 10;

int max = digit1;

if (digit2 > max)
{
    max = digit2;
}

Console.WriteLine(num);
Console.WriteLine();
Console.WriteLine(max);