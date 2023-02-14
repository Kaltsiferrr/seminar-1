int a;
Console.WriteLine("Введите число: ");
a = int.Parse(Console.ReadLine());
Console.Write("Все чётные числа до "+a+":\t");
for (int i = 1; i<a;i++)
{
    if(i%2==0)
    {
        Console.Write("\t"+i);
    }
}