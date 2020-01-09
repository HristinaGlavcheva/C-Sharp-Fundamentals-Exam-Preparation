using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int countInputs = int.Parse(Console.ReadLine());
            int count = 0;
            string validationPattern = @"U\$(?<username>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}\d+)P@\$";

            for (int i = 0; i < countInputs; i++)
            {
                string input = Console.ReadLine();
                Match validReg = Regex.Match(input, validationPattern);

                if (validReg.Success)
                {
                    count++;
                    string username = validReg.Groups["username"].Value;
                    string password = validReg.Groups["password"].Value;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
