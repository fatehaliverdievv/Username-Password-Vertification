using classwork29_11.Models;
using System;

namespace classwork29_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("fateh" , "saLam3123");
            Console.WriteLine("Username : " + user.Name + "\n" + "Password : " + user.Password); ;
        }
    }
}
