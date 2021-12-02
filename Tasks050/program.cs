// Загадано число, необходимо угадать его с 7 попыток

int j= 7; //Колличество попыток!
Random rnd = new Random();


Console.WriteLine("Угадайте число: ");
int namber = Convert.ToInt32(Console.ReadLine()); 
int i;
for( i= rnd.Next(1, 100);i <= j;++ i)
{
    if ( i < namber)
     Console.WriteLine( "Недолет! Попробуй еще))");
     
    if(i > namber)  
    Console.WriteLine("Перелет! Попробуй еще))");
    if (i == namber)
    {
        Console.WriteLine("Победа, Вы угадали!!!");
    } 
    
}  

if( i > j)
{
    Console.WriteLine("Попытки закончились! Повезет в следующий раз!");
}
