
    
/*int[] Array;
Array = ar(1, N);
N = Console.ReadLine("Введите окончание отрезка");
index=0;
if (index< ar)
{
    Console.WriteLine((index%2==0),"Вывести все четные числа");
    index++;
}*/

int N;
Console.WriteLine("Введите число N");
N = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index < N)
{
    if  (index % 2 == 0)
    { 
      
        Console.WriteLine(index);            
        index++;
    }
   
}