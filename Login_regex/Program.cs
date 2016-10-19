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
        static void Main(string[] args)
        {
            string temp = "datael01!";
            Console.WriteLine(logCheck(temp));
        }
    }
}
