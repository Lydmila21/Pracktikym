// Показать числа от  -N до N.

Console.WriteLine(" Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Числовой отрезок от -N до N");
int index = -N;
while (index < N)
{
    Console.WriteLine(index++ );
    
}

