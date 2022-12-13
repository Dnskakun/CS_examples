Console.Write("Введите имя поьлзователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура, это же Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
