// Найти кубы чисел от 1 до N
/*Console.WriteLine("Введите число ");
int N=Convert.ToInt32(Console.ReadLine());
int [] arr ={1, N};


for( int i = 0; i<N; i++ )
{
    int sum = arr(i)*arr(i)*arr(i);
    Console.WriteLine(sum);
}
Вторая часть кода подсмотренна и немного отредактированна.
 В оригенале был указанн размер массива, моя попытка
  откоррктировать не совсем удалась. Не понимаю почему не 
  выводит весь размер, а только начало и конец...
*/

Console.WriteLine("Введите желаемую длинну массива от 1 до ");
int N= Convert.ToInt32(Console.ReadLine());
int[] arr = {1, N};

for(int i = 0; i < arr.Length;i++)
{
    int sum = arr[i] *arr[i] * arr[i];

    Console.WriteLine($"куб числа {arr[i]} = {sum}");
}
