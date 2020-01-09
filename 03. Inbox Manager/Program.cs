using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split("->");
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (command[0] != "Statistics")
            {
                string username = command[1];

                if (command[0] == "Add")
                {
                    if (!users.ContainsKey(username))
                    {
                        users[username] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                }
                else if(command[0] == "Send")
                {
                    string email = command[2];
                    users[username].Add(email);
                }
                else if(command[0] == "Delete")
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                    else
                    {
                        users.Remove(username);
                    }
                }

                command = Console.ReadLine()
                .Split("->");
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var kvp in users.OrderByDescending(u => u.Value.Count).ThenBy(u => u.Key))
            {
                Console.WriteLine(kvp.Key);

                List<string> emails = kvp.Value;

                foreach (var email in emails)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}
