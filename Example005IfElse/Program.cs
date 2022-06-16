Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лили")
{
    Console.WriteLine("После стольких лет? Всегда...");
}
else
{
   Console.Write("Да здавствует ");
   Console.Write(username);
}