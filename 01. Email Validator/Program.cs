using System;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine()
                .Split();

            while (command[0] != "Complete")
            {
                if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else if (command[1] == "Lower")
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }
                else if(command[0] == "GetDomain")
                {
                    int count = int.Parse(command[1]);
                    string domain = input.Substring(input.Length - 3);
                    Console.WriteLine(domain);
                }
                else if (command[0] == "GetUsername")
                {
                    if (input.Contains('@'))
                    {
                        int index = input.LastIndexOf('@');
                        string username = input.Substring(0, index);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The email {input} doesn't contain the @ symbol.");
                    }
                }
                else if (command[0] == "Replace")
                {
                    string charToReplace = command[1];
                    input = input.Replace(charToReplace, "-");
                    Console.WriteLine(input);
                }
                else if (command[0] == "Encrypt")
                {
                    foreach (var character in input)
                    {
                        int ascii = character;
                        Console.Write(ascii + " ");
                    }
                }

                command = Console.ReadLine()
                .Split();
            }

        }
    }
}
