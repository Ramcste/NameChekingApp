using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NameChecking
{
    class Program
    {
        static void Main(string[] args)
        {

            //string pattern = @"^(\w+)\s*$";

            //string pattern = @"^\d{11}$";

            string pattern = @"^((([A-Z].)*)+[A-Z][a-z]+||([A-Z][a-z]+\s[A-Z].[A-Z][a-z]+))$";

            string input = Console.ReadLine();

            bool isValid = input != null && Regex.IsMatch(input, pattern);

            if (isValid)
            {
                Console.WriteLine("Accepted: {0}", input);
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("invalid");
                Console.ReadLine();
            }

        }
    }
}
