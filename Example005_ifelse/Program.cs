﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "Marie")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}