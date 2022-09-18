int max;
int number1;
int number2;
int number3;

Console.WriteLine("Введите первое число");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
number3 = Convert.ToInt32(Console.ReadLine());

max = number1;
if (max < number2) max = number2;
if (max < number3) max = number3;

Console.WriteLine("Максимальное число: " + max);