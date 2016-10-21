using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace Login_regex
{
    class NewUser
    {
        string login;
        string password;
        string email;
        DateTime db;

        private bool logCheck(string str)
        {
            Regex Upletters = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{4,20}$");
            Match m = Upletters.Match(str);
            if (m.Success)
                return true;
            return false;
        }
        private bool emailCheck(string str)
        {
            Regex email = new Regex(@"[a-z0-9]{2,}\@[a-z0-9]+\.[a-z]{2,3}");
            Match m = email.Match(str);
            if (m.Success)
                return true;
            return false;
        }
        private bool dateCheck(string str)
        {
            Regex date = new Regex(@"^[0-9]{1,2}\.?\,?\\?\/?[0-9]{1,2}\.?\,?\\?\/?[0-9]{4}$");
            db = DateTime.Parse(str);
            Match m = date.Match(str);
            if (m.Success)
                return true;
            return false;
        }
        public void Registration()
        {
            for (;;)
            {
                Console.Clear();
                Console.WriteLine("Login:");
                login = Console.ReadLine();
                if (logCheck(login) == false)
                {
                    Console.WriteLine("Минимум: 1 заглавная буква, 1 цифра, 1 спец-символ");
                    Thread.Sleep(2000);
                }

                else
                    break;
            }
            for (;;)
            {
                Console.Clear();
                Console.WriteLine(login);
                Console.WriteLine("Passowrd:");
                password = Console.ReadLine();
                if (logCheck(password) == false)
                {
                    Console.WriteLine("Минимум: 1 заглавная буква, 1 цифра, 1 спец-символ");
                    Thread.Sleep(2000);
                }

                else
                    break;
            }
            for (;;)
            {
                Console.Clear();
                Console.WriteLine(login);
                Console.WriteLine("Passowrd:      ");
                Console.WriteLine("Email:");
                email = Console.ReadLine();
                if (emailCheck(email) == false)
                {
                    Console.WriteLine("Вы ввели некорректный е-мейл");
                    Thread.Sleep(2000);
                }

                else
                    break;
            }
            string date;
            for (;;)
            {
                Console.Clear();
                Console.WriteLine(login);
                Console.WriteLine("Passowrd:      ");
                Console.WriteLine("Email:");
                Console.WriteLine(email);
                Console.WriteLine("Date of birth:");
                date = Console.ReadLine();
                if (dateCheck(date) == false)
                {
                    Console.WriteLine("Вы ввели некорректную дату");
                    Thread.Sleep(2000);
                }
                else
                    db = DateTime.Parse(date);
                break;
            }
        }
        public void Print()
        {
            Console.WriteLine(login);
            Console.WriteLine(password);
            Console.WriteLine(email);
            Console.WriteLine(db);
        }
    }
}
