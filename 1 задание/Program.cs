int a,b,c,max=0;
Console.WriteLine("Введите первое число: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
c = int.Parse(Console.ReadLine());
if (a>b)
{
    max = a;
}
else if (a<b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("максимальное из чисел - "+max);
Console.ReadKey();