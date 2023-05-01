Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.Write("Yes, it's Masha");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}