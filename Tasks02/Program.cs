double a, b;
string s = Console.ReadLine();
string y = Console.ReadLine();
a = Convert.ToInt32(s);
b = Convert.ToInt32(y); 

if  (a == b*b)
{ 
    
    string result = "a * b  равно b";
    Console.WriteLine( result );

} 

else 
{
    result = ("a * b не равно b");
    Console.WriteLine(result("a * b не равно b"));
}

/* Почему результат не может быть присвоен? что можно
вместо него использовать? Как еще обозначить значение результата?
*/
