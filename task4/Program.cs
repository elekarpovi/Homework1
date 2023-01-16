Console.Clear();

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N>0)
{
    int i = 2;
while (i <= N)
{
    System.Console.WriteLine($"{i}");
    i=i+2;
}
}
else 
{
    int i = 0;
    while (i >= N)
    {
       System.Console.WriteLine($"{i}");
    i=i-2; 
    }
}