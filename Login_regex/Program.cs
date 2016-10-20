using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


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
            Regex email = new Regex(@"[a-z0-9]{2,}\@[a-z0-9]+\/");
            Match m = email.Match(str);
            if (m.Success)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            string email = "sataes4()l@ua.fm";
            Console.WriteLine(emailCheck(email));

            //string temp = "datael01!";
            //Console.WriteLine(logCheck(temp));
            //string login, password;
            //for(;;)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Login:");
            //    login = Console.ReadLine();
            //    if (logCheck(login) == false)
            //        Console.WriteLine("Минимум: 1 заглавная буква, 1 цифра, 1 спец-символ");
            //    else
            //        break;
            //}
            //for(;;)
            //{
            //    Console.Clear();
            //    Console.WriteLine(login);
            //    Console.WriteLine("Passowrd:");
            //    password = Console.ReadLine();
            //    if (logCheck(password)==false)
            //        Console.WriteLine("Минимум: 1 заглавная буква, 1 цифра, 1 спец-символ");
            //    else
            //        break;
            //}
                
            

        }
    }
}
