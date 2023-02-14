int a;
Console.WriteLine("Введите число: ");
a = int.Parse(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("Число чётное.");
}
else 
{
    Console.WriteLine("Число нечётное.");
}
Console.ReadKey();