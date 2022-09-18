Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (firstNumber > secondNumber) {
 max =  firstNumber; min = secondNumber;
 }
 else {
   max = secondNumber; min = firstNumber;
 }
Console.WriteLine("из чисел " + firstNumber + " и " + secondNumber + " максимальное = " + max + ", а минимальное " + min);