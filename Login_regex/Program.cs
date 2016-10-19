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
            Regex letters = new Regex(@"[A-Z][a-z][0-9][\W]+");

            Match m = letters.Match(str);
            if (m.Success)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            string temp = "atael01D!";
            Console.WriteLine(logCheck(temp));
        }
    }
}
