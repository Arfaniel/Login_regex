using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;


namespace Login_regex
{
    class Program
    {
        public static bool logCheck(string str)
        {
            Regex Upletters = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{4,20}$");
            Match m = Upletters.Match(str);
            if (m.Success)
                return true;
            return false;
        }

        public static bool emailCheck(string str)
        {
            Regex email = new Regex(@"[a-z0-9]{2,}\@[a-z0-9]+\.[a-z]{2,3}");
            Match m = email.Match(str);
            if (m.Success)
                return true;
            return false;
        }

        public static bool dateCheck(string str)
        {
            DateTime DB = new DateTime();
            Regex date = new Regex(@"[0-9]{1,2}\.?\,?\\?[0-9]{1,2}\.?\,?\\?[0-9]{4}");
            Match m = date.Match(str);
            if (m.Success)
                return true;
            return false;
        }

        static void Main(string[] args)
        {

            string login, password, email, date;
            date = "10,10.2158423";
            Console.WriteLine(dateCheck(date));
            //for (;;)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Login:");
            //    login = Console.ReadLine();
            //    if (logCheck(login) == false)
            //    {
            //        Console.WriteLine("Минимум: 1 заглавная буква, 1 цифра, 1 спец-символ");
            //        Thread.Sleep(2000);
            //    }
                    
            //    else
            //        break;
            //}
            //for (;;)
            //{
            //    Console.Clear();
            //    Console.WriteLine(login);
            //    Console.WriteLine("Passowrd:");
            //    password = Console.ReadLine();
            //    if (logCheck(password) == false)
            //    {
            //        Console.WriteLine("Минимум: 1 заглавная буква, 1 цифра, 1 спец-символ");
            //        Thread.Sleep(2000);
            //    }
                    
            //    else
            //        break;
            //}
            //for (;;)
            //{
            //    Console.Clear();
            //    Console.WriteLine(login);
            //    Console.WriteLine("Passowrd:      ");
            //    Console.WriteLine("Email:");
            //    email = Console.ReadLine();
            //    if (emailCheck(email) == false)
            //    {
            //        Console.WriteLine("Вы ввели некорректный е-мейл");
            //        Thread.Sleep(2000);
            //    }
                    
            //    else
            //        break;
            //}
            //for (;;)
            //{
            //    Console.Clear();
            //    Console.WriteLine(login);
            //    Console.WriteLine("Passowrd:      ");
            //    Console.WriteLine(login);
            //    email = Console.ReadLine();
            //    if (emailCheck(email) == false)
            //    {
            //        Console.WriteLine("Вы ввели некорректную дату");
            //        Thread.Sleep(2000);
            //    }

            //    else
            //        break;
            //}
        }
    }
}
