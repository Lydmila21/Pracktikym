// Вывести вторую цифру трехзначного числаю
int x;
Console.WriteLine("Введите трехзначное число");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x % 100 /10);
