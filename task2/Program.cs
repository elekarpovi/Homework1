Console.Clear();

System.Console.WriteLine("Нужно ввести три числа.");
System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=a;

if (b>max) max=b;
if (c>max) max=c;

System.Console.WriteLine($"Максимальное число {max}");

