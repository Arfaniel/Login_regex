using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;

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
        private string convertDate(string str)
        {
            string temp;
            Regex date = new Regex(@"\,");
            string target = ".";
            temp = date.Replace(str, target);
            return temp;
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
                if(isInFile(login)==true)
                {
                    Console.WriteLine("Такой пользователь уже существует");
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
                if (isInFile(email) == true)
                {
                    Console.WriteLine("Такой пользователь уже существует");
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
                {
                    date = convertDate(date);
                    db = Convert.ToDateTime(date);
                    break;
                }
           }
            toFile();
        }
        public void Print()
        {
            Console.WriteLine(login);
            Console.WriteLine(password);
            Console.WriteLine(email);
            Console.WriteLine(db.ToShortDateString());
        }
        private void toFile()
        {
            Stream st = new FileStream("users.txt", FileMode.OpenOrCreate);
            using (BinaryReader br = new BinaryReader(st))
            {
                byte[] bt = br.ReadBytes(1024);
            }
            st = new FileStream("users.txt", FileMode.Append);
            using (BinaryWriter br = new BinaryWriter(st))
            {
                br.Write(login.ToArray());
                br.Write(',');
                br.Write(password.ToArray());
                br.Write(',');
                br.Write(email.ToArray());
                br.Write(',');
                br.Write(db.ToShortDateString().ToArray());
                br.Write('\n');
            }
        }
        private bool isInFile(string check)
        {
            string textFromFile;
            using (FileStream fstream = File.OpenRead("users.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                textFromFile = System.Text.Encoding.Default.GetString(array);
            }
            string[] arrUser = textFromFile.Split('\n');
            for (int i = 0; i < arrUser.Length; i++)
            {
                string[] userFields = arrUser[i].Split(',');
                for (int j = 0; j < userFields.Length; j++)
                {
                    if (userFields[j] == check)
                        return true;
                }
            }
            return false;
        }
    }
}
