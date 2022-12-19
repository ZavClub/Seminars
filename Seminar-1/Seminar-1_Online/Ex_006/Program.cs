Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if (username?.ToLower() == "alex")
{
    Console.WriteLine("Привет Лёха!!!");
}
else
{
    Console.Write($"Hello, {username}!");
    //Console.WriteLine(username);
}