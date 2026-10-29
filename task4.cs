/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Введите команду: добавить, поиск, показать или выход");
            string command = Console.ReadLine().ToLower();

            if (command == "выход")
            {
                break;
            }

            if (command == "добавить")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                Console.Write("Введите номер телефона: ");
                string phone = Console.ReadLine();

                contacts[name] = phone;
            }
            else if (command == "поиск")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                if (contacts.ContainsKey(name))
                {
                    Console.WriteLine(contacts[name]);
                }
                else
                {
                    Console.WriteLine("Контакт не найден");
                }
            }
            else if (command == "показать")
            {
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine(contact.Key + ": " + contact.Value);
                }
            }
            else
            {
                Console.WriteLine("Неизвестная команда");
            }
        }
    }
}
*/