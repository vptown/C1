﻿Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else 
{
    Console.WriteLine("Hello, ");
    Console.WriteLine(username);
}