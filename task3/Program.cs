Console.Clear();

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    System.Console.WriteLine($"{a} является четным числом");
}

else
{
    System.Console.WriteLine($"{a} не является четным числом");
}
