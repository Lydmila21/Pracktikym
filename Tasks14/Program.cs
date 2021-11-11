// Найти третью цифру числа, или сказать что ее нет.
int x;
Console.WriteLine( "Введите число :");
x = Convert.ToInt32(Console.ReadLine());
if (x % 10)
{   
     (Console.WriteLine("Искомое число"));
}
else
{
    Console.WriteLine("Число является меньше требуемоего");
}