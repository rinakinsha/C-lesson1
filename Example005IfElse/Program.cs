Console.Write("Введите Ваше имя: ");

string? username = Console.ReadLine();

if (!String.IsNullOrWhiteSpace(username))
{
 if (username.ToLower() == "лили")
{
    Console.WriteLine("После стольких лет? Всегда...");
}
 else
{
   Console.Write("Да здравствует ");
   Console.Write(username);
}
}
else 
{
    Console.Write("Пустая строка");
}