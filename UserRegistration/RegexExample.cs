using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// UC1 - Validating the First Name
    /// UC2 - Validating the Last Name
    /// </summary>
    class RegexExample
    {
        string pattern = "^[A-Z][a-z]{2,}$";
        public void ValidatingFirstName()
        {
            Console.WriteLine("Validating the First Name");
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the First Name");
            string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void ValidatingLastName()
        {
            Console.WriteLine("Validating the Last Name");
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the Last Name");
            string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
