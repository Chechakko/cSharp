Console.Write("Введитя имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Masha")
{
    Console.Write("Yes, it's Masha");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}