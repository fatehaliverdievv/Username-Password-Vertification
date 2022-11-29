using classwork29_11.Models;
using System;

namespace classwork29_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your username : ");
                string username = Console.ReadLine();
                Console.Write("Enter your password : ");
                string password = Console.ReadLine();
                User user = new User(username,password);
                if (user.usernamevalidator(username) && user.passwordvalidator(password))
                {
                    Console.WriteLine("User created. ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Please try again!!!");
                }
            }
        }
    }
}
