// Дано число. Проверить, кратно ли оно 7 и 23.

Double x;
x = Convert.ToInt32(Console.ReadLine( "Введите число "));

if (x%7==0 & x/23==0)
{
    Console.WriteLine("Значение кратно 7 и 23");
}
else 
{
    Console.WriteLine(" Значение не кратно");
}