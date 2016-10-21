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
        
        static void Main(string[] args)
        {
            NewUser user = new NewUser();
            user.Registration();
            user.Print();
           
        }
    }
}
