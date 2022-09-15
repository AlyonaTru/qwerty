Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алена"
    )
{
    Console.WriteLine("Ух, наконец это ты, Алена, УРА!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(username);
}