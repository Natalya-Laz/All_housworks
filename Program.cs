// в трёхзначном числе показывает вторую цифру этого числа
int num = new Random ().Next(100,1000);
int a = num/10;
int b = a%10;

Console.WriteLine($"Выбранное число:{num}");

Console.WriteLine($"Второе число {a%10}");