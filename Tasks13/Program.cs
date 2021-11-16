// Выяснить, кратно ли число заданному, если нет, то вывесть остаток


Console.WriteLine("Введите число для проверки ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите предпологаемое кратное");
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(a / b >= 0);
if (a / b ==0)
{
     
     Console.WriteLine("Число кратно");

}

if (a / b > 0)

{
    Console.WriteLine( " a / b =");
}
