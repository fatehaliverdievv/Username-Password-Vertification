using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork29_11.Models
{
    internal class User
    {
        private string _name;
        private string _password;

        public string Name
        {
            get { return _name; }
            set
            {
                if (usernamevalidator(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong username ");
                }
            }
        }
        public User(string name , string password)
        {
            Name = name;
            Password = password;
        }
        public string Password
        {
            get { return _password; }
            set 
            {
                if (passwordvalidator(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("wrong password");
                }
            }
        }
        public bool usernamevalidator(string name)
        {
              
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool passwordvalidator(string surname)
        {
            bool result = false;
            if (surname.Length > 8)
            {
                bool result1 = false;
                bool result2 = false;
                bool result3 = false;
                for (int i = 0; i < surname.Length; i++)
                {
                    if (char.IsDigit(surname[i]))
                    {
                        result1 = true;
                    }
                    if (char.IsUpper(surname[i]))
                    {
                        result2 = true;
                    }
                    if (char.IsLower(surname[i]))
                    {
                        result3 = true;
                    }
                }
                if(result1==true && result2==true && result3 == true)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}
