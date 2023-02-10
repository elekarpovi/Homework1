Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    System.Console.WriteLine($"{a} большее, {b} меньшее");
}
else
{
    System.Console.WriteLine($"{b} большее, {a} меньшее" );
}