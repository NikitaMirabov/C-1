Console.WriteLine("Как тебя зовут, солнце?");
string username = Console.ReadLine()!;

if(username.ToLower() == "никита")
{
    Console.WriteLine("Привет, красавчик, у тебя все получится!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write(", а где Никита?(");
}